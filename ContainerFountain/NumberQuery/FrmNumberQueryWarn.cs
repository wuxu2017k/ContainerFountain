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

#endregion

namespace ContainerFountain.NumberQuery
{
    public partial class FrmNumberQueryWarn : Form
    {
        public FrmNumberQueryWarn()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            vNumberQueryTableAdapter1.FillByWhere(dsNumberQuery1.vNumberQuery, "where type_ERR>=capacity/2");
           // vNumberQueryTableAdapter1.FillByWhere(dsNumberQuery1.vNumberQuery, "where datediff(s,record_time,getdate())>3600");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}