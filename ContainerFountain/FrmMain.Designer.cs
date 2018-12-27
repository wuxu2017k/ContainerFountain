using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.stat = new Gizmox.WebGUI.Forms.StatusStrip();
            this.tssLblUser = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblVer = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblVWGVer = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.tssLblCopyRight = new Gizmox.WebGUI.Forms.ToolStripStatusLabel();
            this.timer1 = new Gizmox.WebGUI.Forms.Timer(this.components);
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.lblTop = new Gizmox.WebGUI.Forms.Label();
            this.tsMTools = new Gizmox.WebGUI.Forms.ToolStrip();
            this.tsBtnlogout = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.tsBtnRefresh = new Gizmox.WebGUI.Forms.ToolStripButton();
            this.pnlTitle = new Gizmox.WebGUI.Forms.Panel();
            this.pnlLeft = new Gizmox.WebGUI.Forms.Panel();
            this.splitter1 = new Gizmox.WebGUI.Forms.Splitter();
            this.lblLeft = new Gizmox.WebGUI.Forms.Label();
            this.pnlMTitle = new Gizmox.WebGUI.Forms.Panel();
            this.tpMain = new Gizmox.WebGUI.Forms.TabPage();
            this.tpHTML = new Gizmox.WebGUI.Forms.TabPage();
            this.tcMain = new Gizmox.WebGUI.Forms.TabControl();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.funcsTree = new ContainerFountain.Controls.UCFuncsTree();
            this.cmbTheme = new Gizmox.WebGUI.Forms.ComboBox();
            this.pnlTitle.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // stat
            // 
            this.stat.Dock = Gizmox.WebGUI.Forms.DockStyle.Bottom;
            this.stat.DockPadding.Left = 1;
            this.stat.DockPadding.Right = 14;
            this.stat.ExcludeFromUniqueId = false;
            this.stat.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tssLblUser,
            this.tssLblVer,
            this.tssLblVWGVer,
            this.tssLblCopyRight});
            this.stat.Location = new System.Drawing.Point(0, 428);
            this.stat.Name = "stat";
            this.stat.PerformLayoutEnabled = true;
            this.stat.Size = new System.Drawing.Size(600, 22);
            this.stat.TabIndex = 0;
            this.stat.Text = "statusStrip1";
            // 
            // tssLblUser
            // 
            this.tssLblUser.ExcludeFromUniqueId = false;
            this.tssLblUser.Font = new System.Drawing.Font("宋体", 8.25F);
            this.tssLblUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblUser.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblUser.Name = "tssLblUser";
            this.tssLblUser.Size = new System.Drawing.Size(65, 11);
            this.tssLblUser.Text = "tssLblUser";
            // 
            // tssLblVer
            // 
            this.tssLblVer.ExcludeFromUniqueId = false;
            this.tssLblVer.Font = new System.Drawing.Font("宋体", 8.25F);
            this.tssLblVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblVer.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblVer.Name = "tssLblVer";
            this.tssLblVer.Size = new System.Drawing.Size(59, 11);
            this.tssLblVer.Text = "tssLblVer";
            // 
            // tssLblVWGVer
            // 
            this.tssLblVWGVer.ExcludeFromUniqueId = false;
            this.tssLblVWGVer.Font = new System.Drawing.Font("宋体", 8.25F);
            this.tssLblVWGVer.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblVWGVer.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblVWGVer.Name = "tssLblVWGVer";
            this.tssLblVWGVer.Size = new System.Drawing.Size(77, 11);
            this.tssLblVWGVer.Text = "tssLblVWGVer";
            // 
            // tssLblCopyRight
            // 
            this.tssLblCopyRight.ExcludeFromUniqueId = false;
            this.tssLblCopyRight.Font = new System.Drawing.Font("宋体", 8.25F);
            this.tssLblCopyRight.ForeColor = System.Drawing.Color.DarkBlue;
            this.tssLblCopyRight.Margin = new Gizmox.WebGUI.Forms.Padding(0, 1, 0, 2);
            this.tssLblCopyRight.Name = "tssLblCopyRight";
            this.tssLblCopyRight.Size = new System.Drawing.Size(95, 11);
            this.tssLblCopyRight.Text = "tssLblCopyRight";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pnlTop.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlTop.BackgroundImage"));
            this.pnlTop.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.None;
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.Size = new System.Drawing.Size(600, 88);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(170)))));
            this.lblTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.lblTop.ExcludeFromUniqueId = false;
            this.lblTop.Font = new System.Drawing.Font("宋体", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.ForeColor = System.Drawing.Color.Blue;
            this.lblTop.Location = new System.Drawing.Point(0, 88);
            this.lblTop.Name = "lblTop";
            this.lblTop.PerformLayoutEnabled = true;
            this.lblTop.Size = new System.Drawing.Size(600, 13);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "∧";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.Click += new System.EventHandler(this.lblTop_Click);
            // 
            // tsMTools
            // 
            this.tsMTools.ExcludeFromUniqueId = false;
            this.tsMTools.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.tsBtnlogout,
            this.tsBtnRefresh});
            this.tsMTools.Location = new System.Drawing.Point(0, 0);
            this.tsMTools.Name = "tsMTools";
            this.tsMTools.PerformLayoutEnabled = true;
            this.tsMTools.Size = new System.Drawing.Size(200, 25);
            this.tsMTools.TabIndex = 0;
            this.tsMTools.Text = "toolStrip1";
            // 
            // tsBtnlogout
            // 
            this.tsBtnlogout.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnlogout.ExcludeFromUniqueId = false;
            this.tsBtnlogout.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("tsBtnlogout.Image"));
            this.tsBtnlogout.Name = "tsBtnlogout";
            this.tsBtnlogout.Size = new System.Drawing.Size(23, 20);
            this.tsBtnlogout.Text = "toolStripButton1";
            this.tsBtnlogout.ToolTipText = "注销";
            this.tsBtnlogout.Click += new System.EventHandler(this.tsBtnlogout_Click);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.DisplayStyle = Gizmox.WebGUI.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRefresh.ExcludeFromUniqueId = false;
            this.tsBtnRefresh.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("tsBtnRefresh.Image"));
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(23, 20);
            this.tsBtnRefresh.ToolTipText = "刷新";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Linen;
            this.pnlTitle.Controls.Add(this.tsMTools);
            this.pnlTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTitle.ExcludeFromUniqueId = false;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.PerformLayoutEnabled = true;
            this.pnlTitle.Size = new System.Drawing.Size(200, 22);
            this.pnlTitle.TabIndex = 0;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnlLeft.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.Empty);
            this.pnlLeft.Controls.Add(this.funcsTree);
            this.pnlLeft.Controls.Add(this.pnlTitle);
            this.pnlLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLeft.ExcludeFromUniqueId = false;
            this.pnlLeft.Location = new System.Drawing.Point(0, 101);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.PerformLayoutEnabled = true;
            this.pnlLeft.Size = new System.Drawing.Size(200, 327);
            this.pnlLeft.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.ExcludeFromUniqueId = false;
            this.splitter1.Location = new System.Drawing.Point(200, 101);
            this.splitter1.Name = "splitter1";
            this.splitter1.PerformLayoutEnabled = true;
            this.splitter1.Size = new System.Drawing.Size(1, 327);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(116)))), ((int)(((byte)(205)))));
            this.lblLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.lblLeft.ExcludeFromUniqueId = false;
            this.lblLeft.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLeft.ForeColor = System.Drawing.Color.Blue;
            this.lblLeft.Location = new System.Drawing.Point(201, 101);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.PerformLayoutEnabled = true;
            this.lblLeft.Size = new System.Drawing.Size(6, 327);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "<";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLeft.Click += new System.EventHandler(this.lblLeft_Click);
            // 
            // pnlMTitle
            // 
            this.pnlMTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(132)))), ((int)(((byte)(180)))));
            this.pnlMTitle.Controls.Add(this.cmbTheme);
            this.pnlMTitle.Controls.Add(this.label1);
            this.pnlMTitle.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlMTitle.ExcludeFromUniqueId = false;
            this.pnlMTitle.Location = new System.Drawing.Point(207, 101);
            this.pnlMTitle.Name = "pnlMTitle";
            this.pnlMTitle.PerformLayoutEnabled = true;
            this.pnlMTitle.Size = new System.Drawing.Size(393, 22);
            this.pnlMTitle.TabIndex = 0;
            // 
            // tpMain
            // 
            this.tpMain.AutoScroll = true;
            this.tpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(242)))));
            this.tpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpMain.ExcludeFromUniqueId = false;
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.PerformLayoutEnabled = true;
            this.tpMain.Size = new System.Drawing.Size(385, 279);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "tpMain";
            // 
            // tpHTML
            // 
            this.tpHTML.BackColor = System.Drawing.Color.PapayaWhip;
            this.tpHTML.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tpHTML.ExcludeFromUniqueId = false;
            this.tpHTML.Location = new System.Drawing.Point(4, 22);
            this.tpHTML.Name = "tpHTML";
            this.tpHTML.PerformLayoutEnabled = true;
            this.tpHTML.Size = new System.Drawing.Size(385, 279);
            this.tpHTML.TabIndex = 0;
            this.tpHTML.Text = "tpHTML";
            // 
            // tcMain
            // 
            this.tcMain.Appearance = Gizmox.WebGUI.Forms.TabAppearance.Logical;
            this.tcMain.Controls.Add(this.tpMain);
            this.tcMain.Controls.Add(this.tpHTML);
            this.tcMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.tcMain.ExcludeFromUniqueId = false;
            this.tcMain.Location = new System.Drawing.Point(207, 123);
            this.tcMain.Name = "tcMain";
            this.tcMain.PerformLayoutEnabled = true;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(393, 305);
            this.tcMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 4);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "主题";
            // 
            // funcsTree
            // 
            this.funcsTree.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.funcsTree.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.funcsTree.ExcludeFromUniqueId = false;
            this.funcsTree.Location = new System.Drawing.Point(0, 22);
            this.funcsTree.Name = "funcsTree";
            this.funcsTree.PerformLayoutEnabled = true;
            this.funcsTree.Size = new System.Drawing.Size(200, 305);
            this.funcsTree.TabIndex = 1;
            this.funcsTree.Text = "UCFuncsTree";
            // 
            // cmbTheme
            // 
            this.cmbTheme.Dock = Gizmox.WebGUI.Forms.DockStyle.Right;
            this.cmbTheme.ExcludeFromUniqueId = false;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(272, 0);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.PerformLayoutEnabled = true;
            this.cmbTheme.Size = new System.Drawing.Size(121, 21);
            this.cmbTheme.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.pnlMTitle);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.stat);
            this.Size = new System.Drawing.Size(600, 450);
            this.Text = "德鲁泰VWG平台";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.RegisteredTimers = new Gizmox.WebGUI.Forms.Timer[] {
        this.timer1};
            this.pnlTitle.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private StatusStrip stat;
        private ToolStripStatusLabel tssLblUser;
        private ToolStripStatusLabel tssLblVer;
        private ToolStripStatusLabel tssLblVWGVer;
        private ToolStripStatusLabel tssLblCopyRight;
        private Timer timer1;
        private Panel pnlTop;
        private Label lblTop;
        private ToolStrip tsMTools;
        private ToolStripButton tsBtnlogout;
        private ToolStripButton tsBtnRefresh;
        private Panel pnlTitle;
        private Panel pnlLeft;
        private Splitter splitter1;
        private Label lblLeft;
        private Panel pnlMTitle;
        private TabPage tpMain;
        private TabPage tpHTML;
        private TabControl tcMain;
        private Controls.UCFuncsTree funcsTree;
        private Label label1;
        private ComboBox cmbTheme;
    }
}