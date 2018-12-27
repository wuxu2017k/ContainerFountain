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
using System.Data.SqlClient;
using DLTLib.Classes;
using DLTVWG.Datasets;
using ContainerFountain.Datasets;

#endregion

namespace ContainerFountain.ContainerInput
{
    public partial class FrmContainerPrice : Form
    {
        private int continerFountainId;
        private string continerFountainNo;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        DSContainerFountain.tcontainer_productpriceRow tcontainer_productprice;
        public FrmContainerPrice()
        {
            InitializeComponent();
        }
        public void prepare(int acontinerFountain_id, string acontinerFountain_no)
        {
            CreateTableAndRelation();

            //声明参数
            continerFountainId = acontinerFountain_id;
            continerFountainNo= acontinerFountain_no;
           tcontainerTableAdapter1.Fill(dsContainerFountain1.tcontainer);
            //填充水价信息
            tcontainer_productpriceTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_productprice, acontinerFountain_id);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "货柜与产品价格管理", "");
        }
        #region CreateTableAndRelation();动态创建表以及表的关系
        private void CreateTableAndRelation()
        {
            string cmd = string.Format(@"select id,product_name from tproducttype_dic");
            DataTable dcontainerType = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //向数据集dSwaterFountain1添加表
            dsContainerFountain1.Tables.Add(dcontainerType);
            DataRelation relcontainerType = new DataRelation("FK_relcontainerType", dcontainerType.Columns["id"], dsContainerFountain1.tcontainer_productprice.Columns["producttype_id"]);
            dsContainerFountain1.Relations.Add(relcontainerType);
            //dsContainerFountain1.tcontainer_productprice.producttype_idColumn.Expression = "Parent(FK_relcontainerType).product_name";

        }
        #endregion

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmContainerPriceMX f = new FrmContainerPriceMX();
            f.fatherForm = this;

            //调用模块中的方法
            f.prepare(EnumNED.NEW, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1,continerFountainId, continerFountainNo);
            //显示窗体
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //判断是否点击dgv集合中的一项
            if (dgv.CurrentRow == null)
            {
                //没有弹窗返回
                ClsMsgBox.Ts("请选择水价列表中的一行数据！");
                return;
            }
            FrmContainerPriceMX f = new FrmContainerPriceMX();
            f.fatherForm = this;

            //调用模块中的方法
            f.prepare(EnumNED.EDIT, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1, continerFountainId, continerFountainNo);
            //显示窗体
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            //判断dgv中的集合是否有数据
            if (dgv.CurrentRow == null)
            {
                //没有弹窗返回
                ClsMsgBox.Ts("请选择货柜产品列表中的一行数据！");
                return;
            }
            FrmContainerPriceMX f = new FrmContainerPriceMX();
            f.fatherForm = this;

            //调用模块中的方法
            f.prepare(EnumNED.DETAIL, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1, continerFountainId, continerFountainNo);
            //显示窗体
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //判断数据是否为空
            if (bdscontainer_price.Current != null)
            {
                //弹窗并调用删除的方法
                ClsMsgBox.YesNo("确定要删除吗？", deleting);
            }
        }
        private void deleting(object sender, EventArgs e)
        {
            //调用返回类型
            DialogResult dr = ((Form)sender).DialogResult;
            //判断返回的类型
            if (dr == DialogResult.Yes)
            {
                try
                {

                    /// ClsOplog.Oplog(userRow.id.ToString(), "50", "货柜与产品价格", "货柜编号：" + dgv.Rows[a].Cells[1].Value.ToString() + "产品名称： " + dgv.Rows[a].Cells[2].Value.ToString());
                    //删除产品价格的
                    bdscontainer_price.RemoveCurrent();
                    //对产品价格数据进行修改
                    tcontainer_productpriceTableAdapter1.Update(dsContainerFountain1.tcontainer_productprice);
                    //跳转到新的界面
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                catch (Exception ex)
                {
                    //警告框显示错误
                    ClsMsgBox.Jg(ex.ToString());
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}