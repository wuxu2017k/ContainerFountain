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
using ContainerFountain.Datasets;
using ContainerFountain.XTGL;
using DLTLib.Classes;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmOptionLBLB : UserControl
    {
        private Datasets.DSedid.toptionlbRow lbRow;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;

        public FrmOptionLBLB()
        {
           
            InitializeComponent();
        }

        #region Prepare()
        public void Prepare()
        {
            toptionlbTableAdapter1.Fill(dSedid1.toptionlb);
        }

        #endregion
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (bds.Current == null)
            {
                lbRow = null;
                return;
            }
            lbRow = (Datasets.DSedid.toptionlbRow)(((DataRowView)bds.Current).Row);
            //自上一次调用 AcceptChanges 之后，该行未更改。
            //该句的作用是防止在toptionlb中增加或删除记录时, 
            //执行到里面的r.dm和r.mc的赋值语句时因r对应的东西为null，而报错
            if (lbRow.RowState == DataRowState.Unchanged)
            {
                toptionxmTableAdapter1.FillByLbdm(dSedid1.toptionxm, lbRow.dm);
            }
            else
                //此句是清空toptionxm表中此前装入的对应其他选项类别的选项项目
                dSedid1.toptionxm.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.NEW, bds, dSedid1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.EDIT, bds, dSedid1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            Datasets.DSedid.toptionlbRow r = (Datasets.DSedid.toptionlbRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("该类别下存在项目无法删除");
                return;
            }
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }
        #region deleting() 选项类别列表中删除时的回调函数
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "选项管理", "类别名称：" + dgv.Rows[a].Cells[1].Value.ToString());
                bds.RemoveCurrent();
                toptionlbTableAdapter1.Update(dSedid1.toptionlb);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion

        private void FrmOptionLBLB_Load(object sender, EventArgs e)
        {
            Prepare();
            dgv.IsSelectionChangeCritical = true;
        }

        private void btnDetailXM_Click(object sender, EventArgs e)
        {
            //列表表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETAIL, bdsXM, dSedid1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            //类别表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM, dSedid1, toptionxmTableAdapter1, dgvXM, lbRow.dm);
            f.ShowDialog();
        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            //类别表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dSedid1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            //列表表为空时不执行本操作
            if (bds.Current == null)
                return;
            //数据表为空时不执行本操作
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deletingXM);
        }

        #region deletingXM() 选项项目列表中删除的回调函数
        private void deletingXM(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                int b = dgvXM.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "选项管理", dgv.Rows[a].Cells[1].Value + "下项目名称:" + dgvXM.Rows[b].Cells[1].Value.ToString());
                bdsXM.RemoveCurrent();
                toptionxmTableAdapter1.Update(dSedid1.toptionxm);
                ClsD.TurnDgvToBdsCurrRec(dgvXM);
            }
        }
        #endregion
    }
}