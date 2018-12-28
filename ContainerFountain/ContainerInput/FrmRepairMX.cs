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
using ContainerFountain.ContainerInput.DSContainerFountainTableAdapters;
using ContainerFountain.Datasets;

#endregion

namespace ContainerFountain.ContainerInput
{
    public partial class FrmRepairMX : Form
    {
        private EnumNED NED;
        private BindingSource bdtcontainer_test;
        private DSContainerFountain dscontainerFountain1;
        private tcontainer_testTableAdapter tcontainer_testTableAdapter1;
        // private DataGridView dgv;
        public FrmRepair fatherForm;
        //查询产品单价中的数据
        DSedid.vusersRow userRows = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        DSContainerFountain.tcontainer_testRow tcontainer_testRow;
        public FrmRepairMX()
        {
            InitializeComponent();
        }

        public void prepare(EnumNED aNED, DSContainerFountain adscontainer, BindingSource aBds,
      tcontainer_testTableAdapter atcontainer_testTableAdapter, int acontainerFountainId, string acontainerFountain_no = null)
        {
            try
            {
                NED = aNED;
                bdtcontainer_test = aBds;
                bindingPriceDetail();
                dscontainerFountain1 = adscontainer;
               tcontainer_testTableAdapter1 = atcontainer_testTableAdapter;
                ClsD.SetMaxLength(this, dscontainerFountain1.tcontainer_test);
                if (NED == EnumNED.NEW)
                {
                   tcontainer_testRow= (DSContainerFountain.tcontainer_testRow)((DataRowView)bdtcontainer_test.AddNew()).Row;
                    tcontainer_testRow.test_enable = false;
                    tcontainer_testRow.container_id = acontainerFountainId;
                    label2.Text = acontainerFountain_no;
                    return;
                }
                if (NED == EnumNED.EDIT)
                {

                    //tcontainer_productpriceRow = (DSContainerFountain.tcontainer_productpriceRow)((DataRowView)bdscontainer_price.AddNew()).Row;
                  //  tcontainer_testRow = (DSContainerFountain.tcontainer_testRow)((DataRowView)bdtcontainer_test.AddNew()).Row;
                   // tcontainer_testRow.test_enable = false;
                    //tcontainer_testRow.container_id = acontainerFountainId;
                    //label2.Text = acontainerFountain_no;

                }
                //详细
                if (NED == EnumNED.DETAIL)
                {
                    //tcontainer_testRow.test_enable = false;
                    //tcontainer_testRow.container_id = acontainerFountainId;
                    //label2.Text = acontainerFountain_no;
                    // tcontainer_productpriceRow = (DSContainerFountain.tcontainer_productpriceRow)((DataRowView)bdscontainer_price.AddNew()).Row;
                    btnSave.Enabled = false;
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void bindingPriceDetail()
        {


            ////绑定押金
            //this.txtdeposit.DataBindings.Clear();
            //this.txtdeposit.DataBindings.Add(new Binding("text", bdscontainer_price, "deposit", true, DataSourceUpdateMode.OnPropertyChanged));
            //this.txttest_enable.DataBindings.Clear();
            //this.txttest_enable.DataBindings.Add(new Binding("text", bdtcontainer_test, "test_enable", true, DataSourceUpdateMode.OnPropertyChanged));
            if (NED == EnumNED.EDIT)
                {
                label2.DataBindings.Clear();
                label2.DataBindings.Add(new Binding("text", bdtcontainer_test, "container_no", true, DataSourceUpdateMode.OnPropertyChanged));
            }
            //txttest_enable.Clear();
            // txttest_enable.DataBindings.Add(new Binding("text", bdtcontainer_test, "test_enable", true,DataSourceUpdateMode.OnPropertyChanged));
            checkBox1.DataBindings.Clear();
            checkBox1.DataBindings.Add(new Binding("Checked", bdtcontainer_test, "test_enable", true, DataSourceUpdateMode.OnPropertyChanged));

            this.txttest_project.DataBindings.Clear();
            this.txttest_project.DataBindings.Add(new Binding("text", bdtcontainer_test, "test_project", true, DataSourceUpdateMode.OnPropertyChanged));

            this.txttest_content.DataBindings.Clear();
            this.txttest_content.DataBindings.Add(new Binding("text", bdtcontainer_test, "test_content", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           

            //应用到数据源
            bdtcontainer_test.EndEdit();
            //更新到数据库
           tcontainer_testTableAdapter1.Update(dscontainerFountain1.tcontainer_test);
            this.DialogResult = DialogResult.OK;
            string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}