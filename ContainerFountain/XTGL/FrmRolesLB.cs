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
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "角色管理", "");
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
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.EDIT, bds,dSedid1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmRolesXX f = new FrmRolesXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, trolesTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            Datasets.DSedid.trolesRow r = (Datasets.DSedid.trolesRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        #region deleting() 删除时的回调函数
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int a = dgv.CurrentRow.Index;
                    ClsOplog.Oplog(userRow.id.ToString(), "50", "角色管理", "角色名称：" + dgv.Rows[a].Cells[1].Value.ToString() + "角色权限： " + dgv.Rows[a].Cells[2].Value.ToString());
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
                ClsMsgBox.Jg("该角色为系统管理类角色，不需要设置可访问的功能模块。");
                return;
            }
            FrmRoleFuncs f = new FrmRoleFuncs();
            f.Prepare(r.id, r.mc);
            f.ShowDialog();
        }
    }
}