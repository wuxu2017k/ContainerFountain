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
        //��������++++++
        private EnumNED NED;
        private BindingSource bdscontainer_price;
        private DSContainerFountain dscontainerFountain1;
        private tcontainer_productpriceTableAdapter tcontainer_productpriceTableAdapter1;
        // private DataGridView dgv;
        public FrmContainerPrice fatherForm;
        //��ѯ��Ʒ�����е�����
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
                //������ֵ
                NED = aNED;
               bdscontainer_price = aBds;
                //�����б�
                fillcmds();
                //������Դ
                bindingPriceDetail();
                //������ֵ
                dscontainerFountain1 = adscontainer;
              tcontainer_productpriceTableAdapter1 = atcontainer_productpriceTableAdapter;
                // dgv = aDgv;
                //���ֵ���ȵ�����
                ClsD.SetMaxLength(this, dscontainerFountain1.tcontainer_productprice);
                //����
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
                //��ϸ
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
            //ע�⣺���õķ������ǰ���ʾ���ݷ��ڲ�ѯ�ĵڶ�������
            string cmd = "select id,product_name from tproducttype_dic";
            //��ѯ�����б������          
            ClsVWG.FillCmbBySQL(cmbContain_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region bindingPriceDetail()
        private void bindingPriceDetail()
        {
            //��id
            this.lblid.DataBindings.Clear();
            this.lblid.DataBindings.Add(new Binding("text", bdscontainer_price, "id", true, DataSourceUpdateMode.OnPropertyChanged));
          
            //��Ѻ��
            this.txtdeposit.DataBindings.Clear();
            this.txtdeposit.DataBindings.Add(new Binding("text", bdscontainer_price, "deposit", true, DataSourceUpdateMode.OnPropertyChanged));
            //�����
            this.txtrent_price.DataBindings.Clear();
            this.txtrent_price.DataBindings.Add(new Binding("text",bdscontainer_price, "rent_price",true,DataSourceUpdateMode.OnPropertyChanged));
            //�󶨻�����
            this.lblContainFountainId.DataBindings.Clear();
            this.lblContainFountainId.DataBindings.Add(new Binding("text",bdscontainer_price, "container_no",true,DataSourceUpdateMode.OnPropertyChanged));
            //�����б��������
            this.cmbContain_type.DataBindings.Clear();
            this.cmbContain_type.DataBindings.Add(new Binding("SelectedValue", bdscontainer_price, "producttype_id", true, DataSourceUpdateMode.OnPropertyChanged));
        
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //�жϿ�ѡ���Ƿ�Ϊ��
                if (cmbContain_type.SelectedIndex < 0 || string.IsNullOrEmpty(txtdeposit.Text.Trim()) || string.IsNullOrEmpty(txtrent_price.Text.Trim()))
                {
                    //��ʾ����
                    ClsMsgBox.Ts("����*���ŵ����Ϊ�������������д��");
                    return;
                }


                //Ӧ�õ�����Դ
                bdscontainer_price.EndEdit();
                //���µ����ݿ�
                tcontainer_productpriceTableAdapter1.Update(dscontainerFountain1.tcontainer_productprice);
            }
            catch (Exception ex)
            {
                //��ʾ�쳣����Ϣ
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
