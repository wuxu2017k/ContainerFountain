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

            //��������
            continerFountainId = acontinerFountain_id;
            continerFountainNo= acontinerFountain_no;
           tcontainerTableAdapter1.Fill(dsContainerFountain1.tcontainer);
            //���ˮ����Ϣ
            tcontainer_productpriceTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_productprice, acontinerFountain_id);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "�������Ʒ�۸����", "");
        }
        #region CreateTableAndRelation();��̬�������Լ���Ĺ�ϵ
        private void CreateTableAndRelation()
        {
            string cmd = string.Format(@"select id,product_name from tproducttype_dic");
            DataTable dcontainerType = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //�����ݼ�dSwaterFountain1��ӱ�
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

            //����ģ���еķ���
            f.prepare(EnumNED.NEW, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1,continerFountainId, continerFountainNo);
            //��ʾ����
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //�ж��Ƿ���dgv�����е�һ��
            if (dgv.CurrentRow == null)
            {
                //û�е�������
                ClsMsgBox.Ts("��ѡ��ˮ���б��е�һ�����ݣ�");
                return;
            }
            FrmContainerPriceMX f = new FrmContainerPriceMX();
            f.fatherForm = this;

            //����ģ���еķ���
            f.prepare(EnumNED.EDIT, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1, continerFountainId, continerFountainNo);
            //��ʾ����
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            //�ж�dgv�еļ����Ƿ�������
            if (dgv.CurrentRow == null)
            {
                //û�е�������
                ClsMsgBox.Ts("��ѡ������Ʒ�б��е�һ�����ݣ�");
                return;
            }
            FrmContainerPriceMX f = new FrmContainerPriceMX();
            f.fatherForm = this;

            //����ģ���еķ���
            f.prepare(EnumNED.DETAIL, dsContainerFountain1, bdscontainer_price, tcontainer_productpriceTableAdapter1, continerFountainId, continerFountainNo);
            //��ʾ����
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //�ж������Ƿ�Ϊ��
            if (bdscontainer_price.Current != null)
            {
                //����������ɾ���ķ���
                ClsMsgBox.YesNo("ȷ��Ҫɾ����", deleting);
            }
        }
        private void deleting(object sender, EventArgs e)
        {
            //���÷�������
            DialogResult dr = ((Form)sender).DialogResult;
            //�жϷ��ص�����
            if (dr == DialogResult.Yes)
            {
                try
                {

                    /// ClsOplog.Oplog(userRow.id.ToString(), "50", "�������Ʒ�۸�", "�����ţ�" + dgv.Rows[a].Cells[1].Value.ToString() + "��Ʒ���ƣ� " + dgv.Rows[a].Cells[2].Value.ToString());
                    //ɾ����Ʒ�۸��
                    bdscontainer_price.RemoveCurrent();
                    //�Բ�Ʒ�۸����ݽ����޸�
                    tcontainer_productpriceTableAdapter1.Update(dsContainerFountain1.tcontainer_productprice);
                    //��ת���µĽ���
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                catch (Exception ex)
                {
                    //�������ʾ����
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