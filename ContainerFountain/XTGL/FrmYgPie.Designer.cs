using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmYgPie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartXl = new Gizmox.WebGUI.Forms.Charts.Chart();
            this.chartGw = new Gizmox.WebGUI.Forms.Charts.Chart();
            this.SuspendLayout();
            // 
            // chartXl
            // 
            this.chartXl.AnimationEnabled = false;
            this.chartXl.AxisX = null;
            this.chartXl.AxisY = null;
            this.chartXl.ColorSet = null;
            this.chartXl.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.chartXl.ExcludeFromUniqueId = false;
            this.chartXl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartXl.Location = new System.Drawing.Point(0, 0);
            this.chartXl.Name = "chartXl";
            this.chartXl.PerformLayoutEnabled = true;
            this.chartXl.Size = new System.Drawing.Size(329, 481);
            this.chartXl.TabIndex = 0;
            this.chartXl.Tag = "xl";
            this.chartXl.Text = "学历";
            this.chartXl.Theme = Gizmox.WebGUI.Forms.Charts.ThemeTypes.Theme1;
            this.chartXl.Title = null;
            this.chartXl.View3D = false;
            // 
            // chartGw
            // 
            this.chartGw.AnimationEnabled = false;
            this.chartGw.AxisX = null;
            this.chartGw.AxisY = null;
            this.chartGw.ColorSet = null;
            this.chartGw.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.chartGw.ExcludeFromUniqueId = false;
            this.chartGw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartGw.Location = new System.Drawing.Point(329, 0);
            this.chartGw.Name = "chartGw";
            this.chartGw.PerformLayoutEnabled = true;
            this.chartGw.Size = new System.Drawing.Size(360, 481);
            this.chartGw.TabIndex = 1;
            this.chartGw.Tag = "gw";
            this.chartGw.Text = "岗位";
            this.chartGw.Theme = Gizmox.WebGUI.Forms.Charts.ThemeTypes.Theme1;
            this.chartGw.Title = null;
            this.chartGw.View3D = false;
            // 
            // FrmYgPie
            // 
            this.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.chartGw);
            this.Controls.Add(this.chartXl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new System.Drawing.Size(689, 481);
            this.Text = "员工分布饼图";
            this.ResumeLayout(false);

        }


        #endregion

        private Gizmox.WebGUI.Forms.Charts.Chart chartXl;
        private Gizmox.WebGUI.Forms.Charts.Chart chartGw;
    }
}