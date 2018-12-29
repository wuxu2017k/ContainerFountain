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
using ContainerFountain.ProductType.DSproducttypeTableAdapters;
using ContainerFountain.Datasets;

#endregion

namespace ContainerFountain.ProductType
{
    public partial class FrmProductTypeMX : Form
    {
        private EnumNED NED;
        private DSproducttype dsproducttype;
        private tproducttype_dicTableAdapter tproducttype_dicTableAdapter;
        private BindingSource bds;
        DSedid.vusersRow userRows = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        public FrmProductTypeMX()
        {
            InitializeComponent();
        }

        public void prepare(EnumNED aNED, BindingSource aBds, DSproducttype adsproducttype, tproducttype_dicTableAdapter atproducttype_dicTableAdapter)
        {
            NED = aNED;
            dsproducttype = adsproducttype;
            tproducttype_dicTableAdapter = atproducttype_dicTableAdapter;
            bds = aBds;
            binding();
            if(NED==EnumNED.NEW)
            {
                bds.AddNew();
                DSproducttype.tproducttype_dicRow tmp_tproducttype_dicRow = (DSproducttype.tproducttype_dicRow)((DataRowView)bds.Current).Row;
                
            }
            if(NED==EnumNED.EDIT)
            {
                DSproducttype.tproducttype_dicRow tmp_tproducttype_dicRow = (DSproducttype.tproducttype_dicRow)((DataRowView)bds.Current).Row;
            }
            if(NED==EnumNED.DETAIL)
            {
                btnSave.Enabled = false;
                DSproducttype.tproducttype_dicRow tmp_tproducttype_dicRow = (DSproducttype.tproducttype_dicRow)((DataRowView)bds.Current).Row;
            }
        }

        #region binding
        private void binding()
        {
            //绑定产品名称
            txtproduct_name.Clear();
            txtproduct_name.DataBindings.Add(new Binding("text",bds, "product_name",true,DataSourceUpdateMode.OnPropertyChanged));
           
            //绑定产品类型
            txtproduct_type.Clear();
            txtproduct_type.DataBindings.Add(new Binding("text",bds, "product_type",true,DataSourceUpdateMode.OnPropertyChanged));
            //绑定识别标识
            txtmark.Clear();
            txtmark.DataBindings.Add(new Binding("text", bds,"mark",true,DataSourceUpdateMode.OnPropertyChanged));
            //绑定照片地址
            txtpicture_path.Clear();
            txtpicture_path.DataBindings.Add(new Binding("text",bds,"picture_path",true,DataSourceUpdateMode.OnPropertyChanged));
            //绑定单价
            txtproduct_price.Clear();
            txtproduct_price.DataBindings.Add(new Binding("text",bds,"product_price",true,DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.bds.EndEdit();
            tproducttype_dicTableAdapter.Update(dsproducttype.tproducttype_dic);
            this.DialogResult = DialogResult.OK;
            string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}