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

namespace ContainerFountain.ProductType
{
    public partial class FrmProductType : UserControl
    {
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        public FrmProductType()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            //������ݼ�dSdiscount1��tdiscount������
            tproducttype_dicTableAdapter1.Fill(dSproducttype1.tproducttype_dic);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmProductTypeMX f = new FrmProductTypeMX();
            f.prepare(EnumNED.NEW, bds, dSproducttype1, tproducttype_dicTableAdapter1);
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
            {
                //����
                return;
            }
            FrmProductTypeMX f = new FrmProductTypeMX();
            f.prepare(EnumNED.EDIT, bds, dSproducttype1, tproducttype_dicTableAdapter1);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (bds.Current == null)
            {
                //����
                return;
            }
            FrmProductTypeMX f = new FrmProductTypeMX();
            f.prepare(EnumNED.DETAIL, bds, dSproducttype1, tproducttype_dicTableAdapter1);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //��������ݲ�Ϊ��
            if (dgv.SelectedRows != null)
            {
                //����������ɾ���ķ���
                ClsMsgBox.YesNo("ȷ��Ҫɾ����", deleting);
            }
        }
        private void deleting(object sender, EventArgs e)
        {

            DialogResult dr = ((Form)sender).DialogResult;
            //�жϷ�������
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //�Ƴ�dgv������ѡ�е�����
                    // dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                    bds.RemoveCurrent();

                    tproducttype_dicTableAdapter1.Update(dSproducttype1.tproducttype_dic);
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}