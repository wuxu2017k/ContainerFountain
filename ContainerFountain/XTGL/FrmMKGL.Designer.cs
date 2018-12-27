using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmMKGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMKGL));
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.mnuTrV = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewBrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dSedid1 = new ContainerFountain.Datasets.DSedid();
            this.tfuncsTableAdapter1 = new ContainerFountain.Datasets.DSedidTableAdapters.tfuncsTableAdapter();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtBz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtBm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.grpMain = new Gizmox.WebGUI.Forms.GroupBox();
            this.grpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSedid1)).BeginInit();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // trV
            // 
            this.trV.ContextMenuStrip = this.mnuTrV;
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.ExcludeFromUniqueId = false;
            this.trV.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.trV.ImageKey = "Folders.Folders.Folder_yellow_close_16.ico";
            this.trV.ImageList = this.imgLst;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.PerformLayoutEnabled = true;
            this.trV.SelectedImageKey = "Folders.Folders.Folder_yellow_open_16.ico";
            this.trV.Size = new System.Drawing.Size(254, 507);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // mnuTrV
            // 
            this.mnuTrV.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuTrV.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuTrV.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuTrV.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuTrV.ExcludeFromUniqueId = false;
            this.mnuTrV.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewBrother,
            this.mnuNewChild,
            this.mnuDel});
            this.mnuTrV.Name = "mnuTrV";
            this.mnuTrV.PerformLayoutEnabled = true;
            this.mnuTrV.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewBrother
            // 
            this.mnuNewBrother.ExcludeFromUniqueId = false;
            this.mnuNewBrother.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewBrother.Image"));
            this.mnuNewBrother.Name = "toolStripMenuItem2";
            this.mnuNewBrother.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewBrother.Size = new System.Drawing.Size(147, 20);
            this.mnuNewBrother.Text = "新增同级模块";
            this.mnuNewBrother.Click += new System.EventHandler(this.mnuNewBrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.ExcludeFromUniqueId = false;
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "toolStripMenuItem3";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(147, 20);
            this.mnuNewChild.Text = "新增下级模块";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.ExcludeFromUniqueId = false;
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "toolStripMenuItem4";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(147, 20);
            this.mnuDel.Text = "删除当前模块";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
            // 
            // imgLst
            // 
            this.imgLst.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imgLst.Images1"))});
            this.imgLst.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLst.Images.SetKeyName(0, "Folders.Folders.Folder_yellow_close_16.ico");
            this.imgLst.Images.SetKeyName(1, "Folders.Folders.Folder_yellow_open_16.ico");
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.trV);
            this.grpLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpLeft.ExcludeFromUniqueId = false;
            this.grpLeft.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpLeft.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.PerformLayoutEnabled = true;
            this.grpLeft.Size = new System.Drawing.Size(260, 527);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "模块树";
            // 
            // bds
            // 
            this.bds.DataMember = "tfuncs";
            this.bds.DataSource = this.dSedid1;
            // 
            // dSedid1
            // 
            this.dSedid1.DataSetName = "DSedid";
            this.dSedid1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tfuncsTableAdapter1
            // 
            this.tfuncsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.ExcludeFromUniqueId = false;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCancel.Image"));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(163, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.PerformLayoutEnabled = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ExcludeFromUniqueId = false;
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(62, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnSave.PerformLayoutEnabled = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Checked", this.bds, "active", true));
            this.chkActive.ExcludeFromUniqueId = false;
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkActive.Location = new System.Drawing.Point(89, 266);
            this.chkActive.Name = "chkActive";
            this.chkActive.PerformLayoutEnabled = true;
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "活动";
            // 
            // txtBz
            // 
            this.txtBz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bz", true));
            this.txtBz.ExcludeFromUniqueId = false;
            this.txtBz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBz.Location = new System.Drawing.Point(89, 218);
            this.txtBz.Name = "txtBz";
            this.txtBz.PerformLayoutEnabled = true;
            this.txtBz.Size = new System.Drawing.Size(173, 20);
            this.txtBz.TabIndex = 5;
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true));
            this.txtJb.Enabled = false;
            this.txtJb.ExcludeFromUniqueId = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJb.Location = new System.Drawing.Point(89, 178);
            this.txtJb.Name = "txtJb";
            this.txtJb.PerformLayoutEnabled = true;
            this.txtJb.Size = new System.Drawing.Size(100, 20);
            this.txtJb.TabIndex = 4;
            // 
            // txtBm
            // 
            this.txtBm.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "bm", true));
            this.txtBm.ExcludeFromUniqueId = false;
            this.txtBm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBm.Location = new System.Drawing.Point(89, 138);
            this.txtBm.Name = "txtBm";
            this.txtBm.PerformLayoutEnabled = true;
            this.txtBm.Size = new System.Drawing.Size(100, 20);
            this.txtBm.TabIndex = 3;
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true));
            this.txtMc.ExcludeFromUniqueId = false;
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMc.Location = new System.Drawing.Point(89, 98);
            this.txtMc.Name = "txtMc";
            this.txtMc.PerformLayoutEnabled = true;
            this.txtMc.Size = new System.Drawing.Size(100, 20);
            this.txtMc.TabIndex = 2;
            // 
            // txtXh
            // 
            this.txtXh.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "xh", true));
            this.txtXh.ExcludeFromUniqueId = false;
            this.txtXh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXh.Location = new System.Drawing.Point(89, 58);
            this.txtXh.Name = "txtXh";
            this.txtXh.PerformLayoutEnabled = true;
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true));
            this.lblId.ExcludeFromUniqueId = false;
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(87, 39);
            this.lblId.Name = "lblId";
            this.lblId.PerformLayoutEnabled = true;
            this.lblId.Size = new System.Drawing.Size(27, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "lblId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ExcludeFromUniqueId = false;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(48, 179);
            this.label6.Name = "label6";
            this.label6.PerformLayoutEnabled = true;
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "级别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ExcludeFromUniqueId = false;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(48, 226);
            this.label5.Name = "label5";
            this.label5.PerformLayoutEnabled = true;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ExcludeFromUniqueId = false;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(34, 142);
            this.label4.Name = "label4";
            this.label4.PerformLayoutEnabled = true;
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "编码(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ExcludeFromUniqueId = false;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 102);
            this.label3.Name = "label3";
            this.label3.PerformLayoutEnabled = true;
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "名称(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ExcludeFromUniqueId = false;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.PerformLayoutEnabled = true;
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.txtBz);
            this.grpMain.Controls.Add(this.txtJb);
            this.grpMain.Controls.Add(this.txtBm);
            this.grpMain.Controls.Add(this.txtMc);
            this.grpMain.Controls.Add(this.txtXh);
            this.grpMain.Controls.Add(this.lblId);
            this.grpMain.Controls.Add(this.label6);
            this.grpMain.Controls.Add(this.label5);
            this.grpMain.Controls.Add(this.label4);
            this.grpMain.Controls.Add(this.label3);
            this.grpMain.Controls.Add(this.label2);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpMain.ExcludeFromUniqueId = false;
            this.grpMain.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpMain.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpMain.Location = new System.Drawing.Point(260, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.PerformLayoutEnabled = true;
            this.grpMain.Size = new System.Drawing.Size(315, 527);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "模块信息";
            // 
            // FrmMKGL
            // 
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpLeft);
            this.Size = new System.Drawing.Size(575, 527);
            this.Text = "模块管理";
            this.Load += new System.EventHandler(this.FrmMKGL_Load);
            this.grpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSedid1)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private TreeView trV;
        private GroupBox grpLeft;
        private ContextMenuStrip mnuTrV;
        private ToolStripMenuItem mnuNewBrother;
        private ToolStripMenuItem mnuNewChild;
        private ToolStripMenuItem mnuDel;
        private ImageList imgLst;
        private BindingSource bds;
        private Datasets.DSedid dSedid1;
        private Datasets.DSedidTableAdapters.tfuncsTableAdapter tfuncsTableAdapter1;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkActive;
        private TextBox txtBz;
        private TextBox txtJb;
        private TextBox txtBm;
        private TextBox txtMc;
        private TextBox txtXh;
        private Label lblId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grpMain;
    }
}