using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.ContainerInput
{
    partial class FrmContainerFountain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainerFountain));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsContainerFountain1 = new ContainerFountain.ContainerInput.DSContainerFountain();
            this.tcontainerTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainerTableAdapter();
            this.tjigouTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tjigouTableAdapter();
            this.tcontainer_statusTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainer_statusTableAdapter();
            this.tcontainer_productpriceTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainer_productpriceTableAdapter();
            this.conNew = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.trV = new Gizmox.WebGUI.Forms.TreeView();
            this.grpLeft = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnproduct = new Gizmox.WebGUI.Forms.Button();
            this.grpTop = new Gizmox.WebGUI.Forms.GroupBox();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.grpFill = new Gizmox.WebGUI.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).BeginInit();
            this.grpLeft.SuspendLayout();
            this.grpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpFill.SuspendLayout();
            this.SuspendLayout();
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
            // bds
            // 
            this.bds.DataMember = "tcontainer";
            this.bds.DataSource = this.dsContainerFountain1;
            // 
            // dsContainerFountain1
            // 
            this.dsContainerFountain1.DataSetName = "DSContainerFountain";
            this.dsContainerFountain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tcontainerTableAdapter1
            // 
            this.tcontainerTableAdapter1.ClearBeforeFill = true;
            // 
            // tjigouTableAdapter1
            // 
            this.tjigouTableAdapter1.ClearBeforeFill = true;
            // 
            // tcontainer_statusTableAdapter1
            // 
            this.tcontainer_statusTableAdapter1.ClearBeforeFill = true;
            // 
            // tcontainer_productpriceTableAdapter1
            // 
            this.tcontainer_productpriceTableAdapter1.ClearBeforeFill = true;
            // 
            // conNew
            // 
            this.conNew.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.conNew.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.conNew.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.conNew.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.conNew.ExcludeFromUniqueId = false;
            this.conNew.Name = "conNew";
            this.conNew.PerformLayoutEnabled = true;
            this.conNew.Size = new System.Drawing.Size(100, 25);
            // 
            // trV
            // 
            this.trV.ContextMenuStrip = this.conNew;
            this.trV.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.trV.ExcludeFromUniqueId = false;
            this.trV.ImageKey = "Folders.Folders.Folder_yellow_close_16.ico";
            this.trV.ImageList = this.imgLst;
            this.trV.Location = new System.Drawing.Point(3, 17);
            this.trV.Name = "trV";
            this.trV.PerformLayoutEnabled = true;
            this.trV.SelectedImageKey = "Folders.Folders.Folder_yellow_open_16.ico";
            this.trV.Size = new System.Drawing.Size(182, 522);
            this.trV.TabIndex = 0;
            this.trV.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.trV_AfterSelect);
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.trV);
            this.grpLeft.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpLeft.ExcludeFromUniqueId = false;
            this.grpLeft.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.PerformLayoutEnabled = true;
            this.grpLeft.Size = new System.Drawing.Size(188, 542);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "机构树";
            // 
            // btnNew
            // 
            this.btnNew.ExcludeFromUniqueId = false;
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(13, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnNew.PerformLayoutEnabled = true;
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ExcludeFromUniqueId = false;
            this.btnEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(97, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnEdit.PerformLayoutEnabled = true;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.ExcludeFromUniqueId = false;
            this.btnDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(181, 34);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDetail.PerformLayoutEnabled = true;
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDel.ExcludeFromUniqueId = false;
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(359, 35);
            this.btnDel.Name = "btnDel";
            this.btnDel.PerformLayoutEnabled = true;
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.ExcludeFromUniqueId = false;
            this.btnproduct.Location = new System.Drawing.Point(268, 34);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.PerformLayoutEnabled = true;
            this.btnproduct.Size = new System.Drawing.Size(75, 23);
            this.btnproduct.TabIndex = 4;
            this.btnproduct.Text = "产品价格";
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.btnNew);
            this.grpTop.Controls.Add(this.btnEdit);
            this.grpTop.Controls.Add(this.btnDetail);
            this.grpTop.Controls.Add(this.btnDel);
            this.grpTop.Controls.Add(this.btnproduct);
            this.grpTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpTop.ExcludeFromUniqueId = false;
            this.grpTop.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpTop.Location = new System.Drawing.Point(188, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.PerformLayoutEnabled = true;
            this.grpTop.Size = new System.Drawing.Size(1155, 86);
            this.grpTop.TabIndex = 0;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "功能模块";
            // 
            // dgv
            // 
            this.dgv.AllowDrag = false;
            this.dgv.AllowDragTargetsPropagation = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle1.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.ExcludeFromUniqueId = false;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.Name = "dgv";
            this.dgv.PerformLayoutEnabled = true;
            this.dgv.ReadOnly = true;
            this.dgv.RenderCellPanelsAsText = false;
            this.dgv.RowTemplate.Enabled = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1149, 436);
            this.dgv.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "jgmc";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "机构";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "container_no";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "货柜编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "container_name";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "货柜名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "screen_type_name";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "屏幕类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "model_type_name";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "货柜类型";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn6.HeaderText = "详细地址";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "record_time";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn7.HeaderText = "录入时间";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // grpFill
            // 
            this.grpFill.Controls.Add(this.dgv);
            this.grpFill.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpFill.ExcludeFromUniqueId = false;
            this.grpFill.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpFill.Location = new System.Drawing.Point(188, 86);
            this.grpFill.Name = "grpFill";
            this.grpFill.PerformLayoutEnabled = true;
            this.grpFill.Size = new System.Drawing.Size(1155, 456);
            this.grpFill.TabIndex = 0;
            this.grpFill.TabStop = false;
            this.grpFill.Text = "货柜列表和状态";
            // 
            // FrmContainerFountain
            // 
            this.Controls.Add(this.grpFill);
            this.Controls.Add(this.grpTop);
            this.Controls.Add(this.grpLeft);
            this.Size = new System.Drawing.Size(1343, 542);
            this.Text = "货柜信息录入";
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).EndInit();
            this.grpLeft.ResumeLayout(false);
            this.grpTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpFill.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private ImageList imgLst;
        private BindingSource bds;
        private DSContainerFountain dsContainerFountain1;
        private DSContainerFountainTableAdapters.tcontainerTableAdapter tcontainerTableAdapter1;
        private DSContainerFountainTableAdapters.tjigouTableAdapter tjigouTableAdapter1;
        private DSContainerFountainTableAdapters.tcontainer_statusTableAdapter tcontainer_statusTableAdapter1;
        private DSContainerFountainTableAdapters.tcontainer_productpriceTableAdapter tcontainer_productpriceTableAdapter1;
        private ContextMenuStrip conNew;
        private TreeView trV;
        private GroupBox grpLeft;
        private Button btnNew;
        private Button btnEdit;
        private Button btnDetail;
        private Button btnDel;
        private Button btnproduct;
        private GroupBox grpTop;
        private DataGridView dgv;
        private GroupBox grpFill;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}