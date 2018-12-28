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
           

            //声明参数
            continerFountainId = acontinerFountain_id;
            continerFountainNo = acontinerFountain_no;
            tcontainerTableAdapter1.Fill(dsContainerFountain1.tcontainer);
            //填充水价信息
            tcontainer_testTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_test, acontinerFountain_id);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "货柜与产品价格管理", "");
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
            //判断是否点击dgv集合中的一项
            if (dgv.CurrentRow == null)
            {
                //没有弹窗返回
                ClsMsgBox.Ts("请选择水价列表中的一行数据！");
                return;
            }
            f.fatherForm = this;
            f.prepare(EnumNED.EDIT, dsContainerFountain1, bds, tcontainer_testTableAdapter1, continerFountainId, continerFountainNo);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FrmRepairMX f = new FrmRepairMX();
            //判断是否点击dgv集合中的一项
            if (dgv.CurrentRow == null)
            {
                //没有弹窗返回
                ClsMsgBox.Ts("请选择水价列表中的一行数据！");
                return;
            }
            f.fatherForm = this;
       
            f.prepare(EnumNED.DETAIL, dsContainerFountain1, bds, tcontainer_testTableAdapter1, continerFountainId, continerFountainNo);
            f.ShowDialog();
        }
    }
}