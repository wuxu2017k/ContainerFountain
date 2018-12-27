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
            //����һ�ε��� AcceptChanges ֮�󣬸���δ���ġ�
            //�þ�������Ƿ�ֹ��toptionlb�����ӻ�ɾ����¼ʱ, 
            //ִ�е������r.dm��r.mc�ĸ�ֵ���ʱ��r��Ӧ�Ķ���Ϊnull��������
            if (lbRow.RowState == DataRowState.Unchanged)
            {
                toptionxmTableAdapter1.FillByLbdm(dSedid1.toptionxm, lbRow.dm);
            }
            else
                //�˾������toptionxm���д�ǰװ��Ķ�Ӧ����ѡ������ѡ����Ŀ
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
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.EDIT, bds, dSedid1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionLBXX f = new FrmOptionLBXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, toptionlbTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            Datasets.DSedid.toptionlbRow r = (Datasets.DSedid.toptionlbRow)(((DataRowView)bds.Current).Row);
            string cmd = "SELECT * FROM toptionxm WHERE lbdm =" + ClsQ.Q1(r.dm);
            if (ClsMSSQL.Exists(cmd, ClsDBCon.ConStrKj))
            {
                ClsMsgBox.Jg("������´�����Ŀ�޷�ɾ��");
                return;
            }
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }
        #region deleting() ѡ������б���ɾ��ʱ�Ļص�����
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "ѡ�����", "������ƣ�" + dgv.Rows[a].Cells[1].Value.ToString());
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
            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.DETAIL, bdsXM, dSedid1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnNewXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.NEW, bdsXM, dSedid1, toptionxmTableAdapter1, dgvXM, lbRow.dm);
            f.ShowDialog();
        }

        private void btnEditXM_Click(object sender, EventArgs e)
        {
            //����Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            FrmOptionXMXX f = new FrmOptionXMXX();
            f.Prepare(EnumNED.EDIT, bdsXM, dSedid1, toptionxmTableAdapter1);
            f.ShowDialog();
        }

        private void btnDelXM_Click(object sender, EventArgs e)
        {
            //�б��Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bdsXM.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deletingXM);
        }

        #region deletingXM() ѡ����Ŀ�б���ɾ���Ļص�����
        private void deletingXM(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                int b = dgvXM.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "ѡ�����", dgv.Rows[a].Cells[1].Value + "����Ŀ����:" + dgvXM.Rows[b].Cells[1].Value.ToString());
                bdsXM.RemoveCurrent();
                toptionxmTableAdapter1.Update(dSedid1.toptionxm);
                ClsD.TurnDgvToBdsCurrRec(dgvXM);
            }
        }
        #endregion
    }
}