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
using ContainerFountain.ContainerInput.DSContainerFountainTableAdapters;

#endregion

namespace ContainerFountain.ContainerInput
{
    public partial class FrmContainerPriceMX : Form
    {
        //声明变量++++++
        private EnumNED NED;
        private BindingSource bdscontainer_price;
        private DSContainerFountain dscontainerFountain1;
        private tcontainer_productpriceTableAdapter tcontainer_productpriceTableAdapter1;
        // private DataGridView dgv;
        public FrmContainerPrice fatherForm;
        //查询产品单价中的数据
        DSedid.vusersRow userRows = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        DSContainerFountain.tcontainer_productpriceRow tcontainer_productpriceRow;
        public FrmContainerPriceMX()
        {
            InitializeComponent();
        }

        #region prepare()
        public void prepare(EnumNED aNED, DSContainerFountain adscontainer, BindingSource aBds,
           tcontainer_productpriceTableAdapter atcontainer_productpriceTableAdapter, int acontainerFountainId, string acontainerFountain_no = null)
        {
            try
            {
                //变量赋值
                NED = aNED;
               bdscontainer_price = aBds;
                //下拉列表
                fillcmds();
                //绑定数据源
                bindingPriceDetail();
                //变量赋值
                dscontainerFountain1 = adscontainer;
              tcontainer_productpriceTableAdapter1 = atcontainer_productpriceTableAdapter;
                // dgv = aDgv;
                //最大值长度的设置
                ClsD.SetMaxLength(this, dscontainerFountain1.tcontainer_productprice);
                //新增
                if (NED == EnumNED.NEW)
                {
                    tcontainer_productpriceRow = (DSContainerFountain.tcontainer_productpriceRow)((DataRowView)bdscontainer_price.AddNew()).Row;
                    tcontainer_productpriceRow.container_id = acontainerFountainId;
                    lblContainFountainId.Text = acontainerFountain_no;
                    return;
                }
                if (NED == EnumNED.EDIT)
                {
                    //tcontainer_productpriceRow = (DSContainerFountain.tcontainer_productpriceRow)((DataRowView)bdscontainer_price.AddNew()).Row;

                }
                //详细
                if (NED == EnumNED.DETAIL)
                {
                   // tcontainer_productpriceRow = (DSContainerFountain.tcontainer_productpriceRow)((DataRowView)bdscontainer_price.AddNew()).Row;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
            }
        }

        #endregion

        #region fillcmds()
        private void fillcmds()
        {
            //注意：调用的方法总是把显示数据放在查询的第二个数。
            string cmd = "select id,product_name from tproducttype_dic";
            //查询下拉列表的数据          
            ClsVWG.FillCmbBySQL(cmbContain_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region bindingPriceDetail()
        private void bindingPriceDetail()
        {
            //绑定id
            this.lblid.DataBindings.Clear();
            this.lblid.DataBindings.Add(new Binding("text", bdscontainer_price, "id", true, DataSourceUpdateMode.OnPropertyChanged));
          
            //绑定押金
            this.txtdeposit.DataBindings.Clear();
            this.txtdeposit.DataBindings.Add(new Binding("text", bdscontainer_price, "deposit", true, DataSourceUpdateMode.OnPropertyChanged));
            //绑定租金
            this.txtrent_price.DataBindings.Clear();
            this.txtrent_price.DataBindings.Add(new Binding("text",bdscontainer_price, "rent_price",true,DataSourceUpdateMode.OnPropertyChanged));
            //绑定货柜编号
            this.lblContainFountainId.DataBindings.Clear();
            this.lblContainFountainId.DataBindings.Add(new Binding("text",bdscontainer_price, "container_no",true,DataSourceUpdateMode.OnPropertyChanged));
            //下拉列表添加类型
            this.cmbContain_type.DataBindings.Clear();
            this.cmbContain_type.DataBindings.Add(new Binding("SelectedValue", bdscontainer_price, "producttype_id", true, DataSourceUpdateMode.OnPropertyChanged));
        
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //判断可选项是否为空
                if (cmbContain_type.SelectedIndex < 0 || string.IsNullOrEmpty(txtdeposit.Text.Trim()) || string.IsNullOrEmpty(txtrent_price.Text.Trim()))
                {
                    //提示返回
                    ClsMsgBox.Ts("带（*）号的项均为必填项，请认真填写！");
                    return;
                }


                //应用到数据源
                bdscontainer_price.EndEdit();
                //更新到数据库
                tcontainer_productpriceTableAdapter1.Update(dscontainerFountain1.tcontainer_productprice);
            }
            catch (Exception ex)
            {
                //显示异常的信息
                ClsMsgBox.Cw(ex.ToString());
            }
            this.DialogResult = DialogResult.OK;
            string _type=NED==EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
