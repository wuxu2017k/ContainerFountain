#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using DLTLib.Classes;
using ContainerFountain.Datasets.DSedidTableAdapters;
using ContainerFountain.Datasets;
using Gizmox.WebGUI.Forms.Authentication;

#endregion

namespace ContainerFountain.Login
{
    public partial class FrmLogin : LogonForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            readCookie();
        }

        #region readCookid() ��ȡcookie�е�ֵ
        private void readCookie()
        {
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //�ж�Cookies���Ƿ���ֵ
            if(!string.IsNullOrWhiteSpace(cookieAccount)&& !string.IsNullOrWhiteSpace(cookiePassword))
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }

        }
        #endregion

        #region ȷ����ť
        private void btnOK_Click(object sender, EventArgs e)
        {
            string a = DateTime.Now.ToString("yyyyMMddhhmmss");
            #region �˺Ż����Ϊ���ж�
            txtLoginName.Text = txtLoginName.Text.Trim();
            if(string.IsNullOrWhiteSpace(txtLoginName.Text))
            {
                ClsMsgBox.Jg("�˻�����Ϊ�գ�");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ClsMsgBox.Jg("�����Ϊ�գ�");
                return;
            }
            #endregion
            vusersTableAdapter uta = new vusersTableAdapter();
            DSedid.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            DSedid.vusersRow userRow=u.Rows.Count==0? null :(DSedid.vusersRow)u.Rows[0];
            #region  �˻���������Ч���ж�
            if (userRow == null)
            {
                ClsMsgBox.Jg("�˻������ڣ�");
                return;
            }
            //�жϿ���
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
                ClsMsgBox.Jg("�����ȷ��");
                return;
            }
            //�жϻ״̬
            if (!userRow.active)
            {
                ClsMsgBox.Jg("���û�Ϊ�ǻ�û����������¼ϵͳ��");
                return;
            }
            #endregion
            #region �Ƿ񱣴浽cookie
            if (chkAutoSave.Checked)
            {
                Context.Cookies["Account"] = txtLoginName.Text;
                Context.Cookies["Password"] = txtPassword.Text;
            }
            else
            {
                Context.Cookies["Account"] = "";
                Context.Cookies["Password"] = "";
            }
            #endregion
            //����¼�û���Ϣ���浽Session
            VWGContext.Current.Session["userRow"] = userRow;
            this.Context.Session.IsLoggedOn = true;//�����ʵ�ʵĴ���
        }
        #endregion

    }
}