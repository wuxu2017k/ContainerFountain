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
using ContainerFountain.Datasets.DSedidTableAdapters;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmOptionLBXX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSedid dsedid;
        private toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridView dgv;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;
        #endregion
        public FrmOptionLBXX()
        {
            InitializeComponent();
        }
        #region Prepare()
        public void Prepare(EnumNED aNED, BindingSource aBds, DSedid aDSJckja,
          toptionlbTableAdapter atoptionlbTableAdapter1, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsedid = aDSJckja;
            toptionlbTableAdapter1 = atoptionlbTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsedid.toptionlb);
            if (NED == EnumNED.NEW)
            {
                bds.AddNew();
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region binding()
        private void binding()
        {
            this.txtDm.DataBindings.Clear();
            this.txtDm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtMC.DataBindings.Clear();
            this.txtMC.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("代码不可为空！");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("代码包含非字母数字字符！");
                return;
            }
            if (string.IsNullOrEmpty(txtMC.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                toptionlbTableAdapter1.Update(dsedid.toptionlb);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
                string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
                ClsOplog.Oplog(userRow.id.ToString(), _type, "选项管理", "类别名称：" + txtMC.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存选项类别时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsedid.toptionlb.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}