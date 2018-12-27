using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmJGGL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJGGL));
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.mnuTrV = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewBrother = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuNewChild = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.imageList = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dSedid1 = new ContainerFountain.Datasets.DSedid();
            this.tjigouTableAdapter1 = new ContainerFountain.Datasets.DSedidTableAdapters.tjigouTableAdapter();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.txtLat = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLon = new Gizmox.WebGUI.Forms.TextBox();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.txtProvince = new Gizmox.WebGUI.Forms.TextBox();
            this.txtCity = new Gizmox.WebGUI.Forms.TextBox();
            this.txtDz = new Gizmox.WebGUI.Forms.TextBox();
            this.txtYb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtWzbz = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbBmlx = new Gizmox.WebGUI.Forms.ComboBox();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtJb = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFzrId = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMc = new Gizmox.WebGUI.Forms.TextBox();
            this.txtJc = new Gizmox.WebGUI.Forms.TextBox();
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
            this.trV.ImageList = this.imageList;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.PerformLayoutEnabled = true;
            this.trV.SelectedImageKey = "Folders.Folders.Folder_yellow_open_16.ico";
            this.trV.Size = new System.Drawing.Size(254, 499);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            this.trV.AfterCheck += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterCheck);
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
            this.grpLeft.Size = new System.Drawing.Size(260, 519);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "机构树";
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
            this.mnuNewBrother.Size = new System.Drawing.Size(152, 20);
            this.mnuNewBrother.Text = "新增同级机构";
            this.mnuNewBrother.Click += new System.EventHandler(this.mnuNewBrother_Click);
            // 
            // mnuNewChild
            // 
            this.mnuNewChild.ExcludeFromUniqueId = false;
            this.mnuNewChild.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewChild.Image"));
            this.mnuNewChild.Name = "toolStripMenuItem3";
            this.mnuNewChild.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewChild.Size = new System.Drawing.Size(152, 20);
            this.mnuNewChild.Text = "新增下级机构";
            this.mnuNewChild.Click += new System.EventHandler(this.mnuNewChild_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.ExcludeFromUniqueId = false;
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "toolStripMenuItem4";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(152, 20);
            this.mnuDel.Text = "删除当前机构";
            this.mnuDel.Click += new System.EventHandler(this.mnuDel_Click);
            // 
            // imageList
            // 
            this.imageList.Images.AddRange(new Gizmox.WebGUI.Common.Resources.ResourceHandle[] {
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList.Images")),
            new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("imageList.Images1"))});
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.Images.SetKeyName(0, "Folders.Folders.Folder_yellow_close_16.ico");
            this.imageList.Images.SetKeyName(1, "Folders.Folders.Folder_yellow_open_16.ico");
            // 
            // bds
            // 
            this.bds.DataMember = "tjigou";
            this.bds.DataSource = this.dSedid1;
            // 
            // dSedid1
            // 
            this.dSedid1.DataSetName = "DSedid";
            this.dSedid1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tjigouTableAdapter1
            // 
            this.tjigouTableAdapter1.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ExcludeFromUniqueId = false;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(225, 210);
            this.label13.Name = "label13";
            this.label13.PerformLayoutEnabled = true;
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "纬度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ExcludeFromUniqueId = false;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(225, 182);
            this.label12.Name = "label12";
            this.label12.PerformLayoutEnabled = true;
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "经度";
            // 
            // txtLat
            // 
            this.txtLat.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "latitude", true));
            this.txtLat.ExcludeFromUniqueId = false;
            this.txtLat.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLat.Location = new System.Drawing.Point(266, 206);
            this.txtLat.Name = "txtLat";
            this.txtLat.PerformLayoutEnabled = true;
            this.txtLat.Size = new System.Drawing.Size(109, 20);
            this.txtLat.TabIndex = 5;
            // 
            // txtLon
            // 
            this.txtLon.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "longitude", true));
            this.txtLon.ExcludeFromUniqueId = false;
            this.txtLon.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLon.Location = new System.Drawing.Point(266, 179);
            this.txtLon.Name = "txtLon";
            this.txtLon.PerformLayoutEnabled = true;
            this.txtLon.Size = new System.Drawing.Size(109, 20);
            this.txtLon.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ExcludeFromUniqueId = false;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(30, 210);
            this.label11.Name = "label11";
            this.label11.PerformLayoutEnabled = true;
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "省份";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ExcludeFromUniqueId = false;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(225, 76);
            this.label10.Name = "label10";
            this.label10.PerformLayoutEnabled = true;
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "城市";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ExcludeFromUniqueId = false;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(225, 103);
            this.label9.Name = "label9";
            this.label9.PerformLayoutEnabled = true;
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "地址";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ExcludeFromUniqueId = false;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(201, 157);
            this.label8.Name = "label8";
            this.label8.PerformLayoutEnabled = true;
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "位置标志";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ExcludeFromUniqueId = false;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(225, 130);
            this.label7.Name = "label7";
            this.label7.PerformLayoutEnabled = true;
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "邮编";
            // 
            // txtProvince
            // 
            this.txtProvince.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "province", true));
            this.txtProvince.ExcludeFromUniqueId = false;
            this.txtProvince.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProvince.Location = new System.Drawing.Point(71, 206);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.PerformLayoutEnabled = true;
            this.txtProvince.Size = new System.Drawing.Size(110, 20);
            this.txtProvince.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "city", true));
            this.txtCity.ExcludeFromUniqueId = false;
            this.txtCity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCity.Location = new System.Drawing.Point(266, 72);
            this.txtCity.Name = "txtCity";
            this.txtCity.PerformLayoutEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(110, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtDz
            // 
            this.txtDz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "dz", true));
            this.txtDz.ExcludeFromUniqueId = false;
            this.txtDz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDz.Location = new System.Drawing.Point(266, 98);
            this.txtDz.Name = "txtDz";
            this.txtDz.PerformLayoutEnabled = true;
            this.txtDz.Size = new System.Drawing.Size(140, 20);
            this.txtDz.TabIndex = 8;
            // 
            // txtYb
            // 
            this.txtYb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "yb", true));
            this.txtYb.ExcludeFromUniqueId = false;
            this.txtYb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYb.Location = new System.Drawing.Point(266, 124);
            this.txtYb.Name = "txtYb";
            this.txtYb.PerformLayoutEnabled = true;
            this.txtYb.Size = new System.Drawing.Size(110, 20);
            this.txtYb.TabIndex = 9;
            // 
            // txtWzbz
            // 
            this.txtWzbz.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "wzbz", true));
            this.txtWzbz.ExcludeFromUniqueId = false;
            this.txtWzbz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWzbz.Location = new System.Drawing.Point(266, 150);
            this.txtWzbz.Name = "txtWzbz";
            this.txtWzbz.PerformLayoutEnabled = true;
            this.txtWzbz.Size = new System.Drawing.Size(110, 20);
            this.txtWzbz.TabIndex = 10;
            // 
            // cmbBmlx
            // 
            this.cmbBmlx.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("SelectedValue", this.bds, "bmlx", true));
            this.cmbBmlx.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbBmlx.ExcludeFromUniqueId = false;
            this.cmbBmlx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBmlx.FormattingEnabled = true;
            this.cmbBmlx.Location = new System.Drawing.Point(72, 153);
            this.cmbBmlx.Name = "cmbBmlx";
            this.cmbBmlx.PerformLayoutEnabled = true;
            this.cmbBmlx.Size = new System.Drawing.Size(109, 20);
            this.cmbBmlx.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.ExcludeFromUniqueId = false;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnCancel.Image"));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(301, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.PerformLayoutEnabled = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
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
            this.btnSave.Location = new System.Drawing.Point(216, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnSave.PerformLayoutEnabled = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
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
            this.chkActive.Location = new System.Drawing.Point(72, 241);
            this.chkActive.Name = "chkActive";
            this.chkActive.PerformLayoutEnabled = true;
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 11;
            this.chkActive.Text = "活动";
            // 
            // txtJb
            // 
            this.txtJb.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jb", true));
            this.txtJb.Enabled = false;
            this.txtJb.ExcludeFromUniqueId = false;
            this.txtJb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJb.Location = new System.Drawing.Point(72, 180);
            this.txtJb.Name = "txtJb";
            this.txtJb.PerformLayoutEnabled = true;
            this.txtJb.Size = new System.Drawing.Size(109, 20);
            this.txtJb.TabIndex = 5;
            // 
            // txtFzrId
            // 
            this.txtFzrId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "fzrid", true));
            this.txtFzrId.ExcludeFromUniqueId = false;
            this.txtFzrId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFzrId.Location = new System.Drawing.Point(72, 126);
            this.txtFzrId.Name = "txtFzrId";
            this.txtFzrId.PerformLayoutEnabled = true;
            this.txtFzrId.Size = new System.Drawing.Size(109, 20);
            this.txtFzrId.TabIndex = 3;
            // 
            // txtMc
            // 
            this.txtMc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "mc", true));
            this.txtMc.ExcludeFromUniqueId = false;
            this.txtMc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMc.Location = new System.Drawing.Point(72, 72);
            this.txtMc.Name = "txtMc";
            this.txtMc.PerformLayoutEnabled = true;
            this.txtMc.Size = new System.Drawing.Size(109, 20);
            this.txtMc.TabIndex = 1;
            // 
            // txtJc
            // 
            this.txtJc.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "jc", true));
            this.txtJc.ExcludeFromUniqueId = false;
            this.txtJc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJc.Location = new System.Drawing.Point(72, 99);
            this.txtJc.Name = "txtJc";
            this.txtJc.PerformLayoutEnabled = true;
            this.txtJc.Size = new System.Drawing.Size(109, 20);
            this.txtJc.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bds, "id", true));
            this.lblId.ExcludeFromUniqueId = false;
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(72, 39);
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
            this.label6.Location = new System.Drawing.Point(7, 158);
            this.label6.Name = "label6";
            this.label6.PerformLayoutEnabled = true;
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "部门类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ExcludeFromUniqueId = false;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(31, 184);
            this.label5.Name = "label5";
            this.label5.PerformLayoutEnabled = true;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "级别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ExcludeFromUniqueId = false;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(19, 132);
            this.label4.Name = "label4";
            this.label4.PerformLayoutEnabled = true;
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "负责人";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ExcludeFromUniqueId = false;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 80);
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
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.PerformLayoutEnabled = true;
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "简介";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.label13);
            this.grpMain.Controls.Add(this.label12);
            this.grpMain.Controls.Add(this.txtLat);
            this.grpMain.Controls.Add(this.txtLon);
            this.grpMain.Controls.Add(this.label11);
            this.grpMain.Controls.Add(this.label10);
            this.grpMain.Controls.Add(this.label9);
            this.grpMain.Controls.Add(this.label8);
            this.grpMain.Controls.Add(this.label7);
            this.grpMain.Controls.Add(this.txtProvince);
            this.grpMain.Controls.Add(this.txtCity);
            this.grpMain.Controls.Add(this.txtDz);
            this.grpMain.Controls.Add(this.txtYb);
            this.grpMain.Controls.Add(this.txtWzbz);
            this.grpMain.Controls.Add(this.cmbBmlx);
            this.grpMain.Controls.Add(this.btnCancel);
            this.grpMain.Controls.Add(this.btnSave);
            this.grpMain.Controls.Add(this.chkActive);
            this.grpMain.Controls.Add(this.txtJb);
            this.grpMain.Controls.Add(this.txtFzrId);
            this.grpMain.Controls.Add(this.txtMc);
            this.grpMain.Controls.Add(this.txtJc);
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
            this.grpMain.Size = new System.Drawing.Size(442, 519);
            this.grpMain.TabIndex = 1;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "机构信息";
            // 
            // FrmJGGL
            // 
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.grpLeft);
            this.Size = new System.Drawing.Size(702, 519);
            this.Text = "机构管理";
            this.Load += new System.EventHandler(this.FrmJGGL_Load);
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
        private ImageList imageList;
        private BindingSource bds;
        private Datasets.DSedid dSedid1;
        private Datasets.DSedidTableAdapters.tjigouTableAdapter tjigouTableAdapter1;
        private Label label13;
        private Label label12;
        private TextBox txtLat;
        private TextBox txtLon;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtProvince;
        private TextBox txtCity;
        private TextBox txtDz;
        private TextBox txtYb;
        private TextBox txtWzbz;
        private ComboBox cmbBmlx;
        private Button btnCancel;
        private Button btnSave;
        private CheckBox chkActive;
        private TextBox txtJb;
        private TextBox txtFzrId;
        private TextBox txtMc;
        private TextBox txtJc;
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