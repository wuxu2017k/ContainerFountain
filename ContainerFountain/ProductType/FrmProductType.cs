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
            //填充数据集dSdiscount1中tdiscount表数据
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
                //返回
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
                //返回
                return;
            }
            FrmProductTypeMX f = new FrmProductTypeMX();
            f.prepare(EnumNED.DETAIL, bds, dSproducttype1, tproducttype_dicTableAdapter1);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //点击的数据不为空
            if (dgv.SelectedRows != null)
            {
                //弹窗，调用删除的方法
                ClsMsgBox.YesNo("确定要删除吗？", deleting);
            }
        }
        private void deleting(object sender, EventArgs e)
        {

            DialogResult dr = ((Form)sender).DialogResult;
            //判断返回类型
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //移除dgv集合所选行的数据
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