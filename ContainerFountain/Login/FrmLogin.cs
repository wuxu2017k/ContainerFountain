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

        #region readCookid() 读取cookie中的值
        private void readCookie()
        {
            string cookieAccount = Context.Cookies["Account"];
            string cookiePassword = Context.Cookies["Password"];
            //判断Cookies的是否有值
            if(!string.IsNullOrWhiteSpace(cookieAccount)&& !string.IsNullOrWhiteSpace(cookiePassword))
            {
                txtLoginName.Text = cookieAccount;
                txtPassword.Text = cookiePassword;
                chkAutoSave.Checked = true;
            }

        }
        #endregion

        #region 确定按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            string a = DateTime.Now.ToString("yyyyMMddhhmmss");
            #region 账号或口令为空判断
            txtLoginName.Text = txtLoginName.Text.Trim();
            if(string.IsNullOrWhiteSpace(txtLoginName.Text))
            {
                ClsMsgBox.Jg("账户不能为空！");
                return;
            }
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ClsMsgBox.Jg("口令不能为空！");
                return;
            }
            #endregion
            vusersTableAdapter uta = new vusersTableAdapter();
            DSedid.vusersDataTable u = uta.GetDataByLoginName(txtLoginName.Text);
            DSedid.vusersRow userRow=u.Rows.Count==0? null :(DSedid.vusersRow)u.Rows[0];
            #region  账户、口令有效性判断
            if (userRow == null)
            {
                ClsMsgBox.Jg("账户不存在！");
                return;
            }
            //判断口令
            if (string.Compare(txtPassword.Text, userRow.password, false) != 0)
            {
                ClsMsgBox.Jg("口令不正确！");
                return;
            }
            //判断活动状态
            if (!userRow.active)
            {
                ClsMsgBox.Jg("此用户为非活动用户，不允许登录系统！");
                return;
            }
            #endregion
            #region 是否保存到cookie
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
            //将登录用户信息保存到Session
            VWGContext.Current.Session["userRow"] = userRow;
            this.Context.Session.IsLoggedOn = true;//允许打开实际的窗体
        }
        #endregion

    }
}