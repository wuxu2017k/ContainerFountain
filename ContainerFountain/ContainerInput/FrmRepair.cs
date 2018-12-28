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

namespace ContainerFountain.ContainerInput
{
    public partial class FrmRepair : Form
    {
        private int continerFountainId;
        private string continerFountainNo;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        DSContainerFountain.tcontainer_testRow tcontainer_testRow1;
        public FrmRepair()
        {
            InitializeComponent();
        }
        public void prepare(int acontinerFountain_id, string acontinerFountain_no)
        {
           

            //��������
            continerFountainId = acontinerFountain_id;
            continerFountainNo = acontinerFountain_no;
            tcontainerTableAdapter1.Fill(dsContainerFountain1.tcontainer);
            //���ˮ����Ϣ
            tcontainer_testTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_test, acontinerFountain_id);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "�������Ʒ�۸����", "");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
          FrmRepairMX f = new FrmRepairMX();
            f.prepare(EnumNED.NEW,dsContainerFountain1,bds,tcontainer_testTableAdapter1, continerFountainId, continerFountainNo);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmRepairMX f = new FrmRepairMX();
            //�ж��Ƿ���dgv�����е�һ��
            if (dgv.CurrentRow == null)
            {
                //û�е�������
                ClsMsgBox.Ts("��ѡ��ˮ���б��е�һ�����ݣ�");
                return;
            }
            f.fatherForm = this;
            f.prepare(EnumNED.EDIT, dsContainerFountain1, bds, tcontainer_testTableAdapter1, continerFountainId, continerFountainNo);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FrmRepairMX f = new FrmRepairMX();
            //�ж��Ƿ���dgv�����е�һ��
            if (dgv.CurrentRow == null)
            {
                //û�е�������
                ClsMsgBox.Ts("��ѡ��ˮ���б��е�һ�����ݣ�");
                return;
            }
            f.fatherForm = this;
       
            f.prepare(EnumNED.DETAIL, dsContainerFountain1, bds, tcontainer_testTableAdapter1, continerFountainId, continerFountainNo);
            f.ShowDialog();
        }
    }
}