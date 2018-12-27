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
    public partial class FrmConfigMX : Form
    {
        #region 自定义成员变量
        private EnumNED NED;
        private BindingSource bds;
        private DSedid dsedid;
        private tconfigTableAdapter tconfigTableAdapter;
        private DataGridView dgv;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        #endregion
        public FrmConfigMX()
        {
            InitializeComponent();
        }

        #region binding()
        private void binding()
        {
            this.txtdm.DataBindings.Clear();
            this.txtdm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dm", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtms.DataBindings.Clear();
            this.txtms.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "ms", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.txtnr.DataBindings.Clear();
            this.txtnr.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "nr", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion
        #region
        public void Prepare(EnumNED aNED, BindingSource aBds, DSedid aDSJckja,
              tconfigTableAdapter atconfigTableAdapter, DataGridView aDgv = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsedid = aDSJckja;
            tconfigTableAdapter = atconfigTableAdapter;
            dgv = aDgv;
            // ClsD.SetMaxLength(this, dsJckja1.troles);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 空值判断
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtdm.Text))
            {
                ClsMsgBox.Jg("代码不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtnr.Text))
            {
                ClsMsgBox.Jg("内容不可为空！");
                return;
            }
            if (string.IsNullOrEmpty(txtms.Text))
            {
                ClsMsgBox.Jg("描述不可为空！");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                tconfigTableAdapter.Update(dsedid.tconfig);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
                string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
                ClsOplog.Oplog(userRow.id.ToString(), _type, "配置管理", "配置代码：" + txtdm.Text + "配置描述：" + txtms.Text + "配置内容：" + txtnr.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存配置时遇到了错误：", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsedid.tconfig.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}