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
using DLTLib.Classes;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmConfig : UserControl
    {
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;
        public FrmConfig()
        {
            InitializeComponent();
        }
        public void prepare()
        {
            tconfigTableAdapter1.Fill(dSedid1.tconfig);
            //ClsOplog.Oplog(userRow.id.ToString(), "20", "���ù���", "");
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            prepare();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmConfigMX f = new FrmConfigMX();
            f.Prepare(EnumNED.NEW, bds, dSedid1, tconfigTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmConfigMX f = new FrmConfigMX();
            f.Prepare(EnumNED.EDIT, bds, dSedid1, tconfigTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmConfigMX f = new FrmConfigMX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, tconfigTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
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
                    ClsOplog.Oplog(userRow.id.ToString(), "50", "���ù���", "����������" + dgv.Rows[a].Cells[1].Value.ToString() + "�������ݣ�" + dgv.Rows[a].Cells[2].Value.ToString());
                    bds.RemoveCurrent();
                    tconfigTableAdapter1.Update(dSedid1.tconfig);
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                catch (Exception ex)
                {
                    ClsMsgBox.Jg(ex.ToString());
                }

            }
        }
        #endregion
    }
}