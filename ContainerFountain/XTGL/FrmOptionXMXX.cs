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
    public partial class FrmOptionXMXX : Form
    {
        #region �Զ����Ա����
        private EnumNED NED;
        private BindingSource bds;
        private DSedid dsedid;
        private toptionxmTableAdapter toptionxmTableAdapter1;
        private DataGridView dgv;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        #endregion
        public FrmOptionXMXX()
        {
            InitializeComponent();
        }

        #region Prepare()
        public void Prepare(EnumNED aNED, BindingSource aBds, DSedid aDSJckja,
           toptionxmTableAdapter atoptionxmTableAdapter1, DataGridView aDgv = null, string aLbdm = null)
        {
            bds = aBds;
            binding();
            NED = aNED;
            dsedid = aDSJckja;
            toptionxmTableAdapter1 = atoptionxmTableAdapter1;
            dgv = aDgv;
            ClsD.SetMaxLength(this, dsedid.toptionxm);
            if (NED == EnumNED.NEW)
            {
                DSedid.toptionxmRow r = (DSedid.toptionxmRow)((DataRowView)bds.AddNew()).Row;
                r.lbdm = aLbdm;
            }
            else if (NED == EnumNED.DETAIL)
            {
                this.btnSave.Visible = false;
            }
        }
        #endregion

        #region binding() �ؼ��󶨺���
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
            #region ��ֵ�ж�
            ClsD.TextBoxTrim(this);
            if (string.IsNullOrEmpty(txtDm.Text))
            {
                ClsMsgBox.Jg("���벻��Ϊ�գ�");
                return;
            }
            if (!ClsReg.AlphaNumeric.IsMatch(txtDm.Text))
            {
                ClsMsgBox.Jg("�����������ĸ�����ַ���");
                return;
            }
            if (string.IsNullOrEmpty(txtMC.Text))
            {
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
                return;
            }
            #endregion
            try
            {
                bds.EndEdit();
                toptionxmTableAdapter1.Update(dsedid.toptionxm);
                if (NED == EnumNED.NEW)
                {
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }
                this.DialogResult = DialogResult.OK;
                string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
                ClsOplog.Oplog(userRow.id.ToString(), _type, "ѡ�����", "������ƣ�" + txtMC.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("����ѡ�����ʱ�����˴���", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            dsedid.toptionxm.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}