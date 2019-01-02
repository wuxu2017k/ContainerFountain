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

namespace ContainerFountain.Containerheartbeat
{
    public partial class FrmContainerheartbeatWarn : Form
    {
        public FrmContainerheartbeatWarn()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
          
            vcontainerStatusTableAdapter1.FillByWhere(dScontainerheartbeat1.vcontainerStatus, " where status='0' or gprs_status='0'");
            //ClsOplog.Oplog(userRow.id.ToString(), "20", "货柜异常提示信息", "");
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}