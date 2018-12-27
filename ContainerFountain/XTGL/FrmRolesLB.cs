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
using ContainerFountain.Datasets;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmRolesLB : UserControl
    {
       DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;
        public FrmRolesLB()
        {
            InitializeComponent();
        }

        private void FrmRolesLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        #region Prepare()
        public void Prepare()
        {
            trolesTableAdapter1.Fill(dSedid1.troles);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "��ɫ����", "");
        }

        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.NEW, bds, dSedid1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.EDIT, bds,dSedid1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            Datasets.DSedid.trolesRow r = (Datasets.DSedid.trolesRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("������´�����Ŀ�޷�ɾ��");
                return;
            }
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        #region deleting() ɾ��ʱ�Ļص�����
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int a = dgv.CurrentRow.Index;
                    ClsOplog.Oplog(userRow.id.ToString(), "50", "��ɫ����", "��ɫ���ƣ�" + dgv.Rows[a].Cells[1].Value.ToString() + "��ɫȨ�ޣ� " + dgv.Rows[a].Cells[2].Value.ToString());
                    bds.RemoveCurrent();
                    trolesTableAdapter1.Update(dSedid1.troles);
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Jg(ex.ToString());
                }

            }
        }
        #endregion
        private void btnFuncs_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
                return;
            DSedid.trolesRow r = (DSedid.trolesRow)(((DataRowView)bds.Current).Row);
            if (r.qx < 1024)
            {
                ClsMsgBox.Jg("�ý�ɫΪϵͳ�������ɫ������Ҫ���ÿɷ��ʵĹ���ģ�顣");
                return;
            }
            FrmRoleFuncs f = new FrmRoleFuncs();
            f.Prepare(r.id, r.mc);
            f.ShowDialog();
        }
    }
}