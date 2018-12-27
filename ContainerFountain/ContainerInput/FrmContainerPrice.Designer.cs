using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.ContainerInput
{
    partial class FrmContainerPrice
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainerPrice));
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.bdscontainer_price = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsContainerFountain1 = new ContainerFountain.ContainerInput.DSContainerFountain();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.grpTop = new Gizmox.WebGUI.Forms.GroupBox();
            this.tcontainer_productpriceTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainer_productpriceTableAdapter();
            this.tcontainerTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdscontainer_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.grpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowDrag = false;
            this.dgv.AllowDragTargetsPropagation = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv.DataSource = this.bdscontainer_price;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.ExcludeFromUniqueId = false;
            this.dgv.Location = new System.Drawing.Point(3, 59);
            this.dgv.Name = "dgv";
            this.dgv.PerformLayoutEnabled = true;
            this.dgv.ReadOnly = true;
            this.dgv.RenderCellPanelsAsText = false;
            this.dgv.RowTemplate.Enabled = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(598, 394);
            this.dgv.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "container_no";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "货柜编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "producttype_id";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "类型名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "deposit";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn4.HeaderText = "押金";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rent_price";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.HeaderText = "租金";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // bdscontainer_price
            // 
            this.bdscontainer_price.DataMember = "tcontainer_productprice";
            this.bdscontainer_price.DataSource = this.dsContainerFountain1;
            // 
            // dsContainerFountain1
            // 
            this.dsContainerFountain1.DataSetName = "DSContainerFountain";
            this.dsContainerFountain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.ExcludeFromUniqueId = false;
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(429, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnClose.PerformLayoutEnabled = true;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.ExcludeFromUniqueId = false;
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(313, 13);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDel.PerformLayoutEnabled = true;
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.ExcludeFromUniqueId = false;
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(234, 13);
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
            // btnEdit
            // 
            this.btnEdit.ExcludeFromUniqueId = false;
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(155, 13);
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
            // btnNew
            // 
            this.btnNew.ExcludeFromUniqueId = false;
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(76, 13);
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
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(3, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.Size = new System.Drawing.Size(598, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.dgv);
            this.grpTop.Controls.Add(this.pnlTop);
            this.grpTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.grpTop.ExcludeFromUniqueId = false;
            this.grpTop.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.PerformLayoutEnabled = true;
            this.grpTop.Size = new System.Drawing.Size(604, 456);
            this.grpTop.TabIndex = 0;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "水价列表";
            // 
            // tcontainer_productpriceTableAdapter1
            // 
            this.tcontainer_productpriceTableAdapter1.ClearBeforeFill = true;
            // 
            // tcontainerTableAdapter1
            // 
            this.tcontainerTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmContainerPrice
            // 
            this.Controls.Add(this.grpTop);
            this.Size = new System.Drawing.Size(604, 456);
            this.Text = "货柜价格表";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdscontainer_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.grpTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private DataGridView dgv;
        private Button btnClose;
        private Button btnDel;
        private Button btnDetail;
        private Button btnEdit;
        private Button btnNew;
        private Panel pnlTop;
        private GroupBox grpTop;
        private DSContainerFountain dsContainerFountain1;
        private DSContainerFountainTableAdapters.tcontainer_productpriceTableAdapter tcontainer_productpriceTableAdapter1;
        private DSContainerFountainTableAdapters.tcontainerTableAdapter tcontainerTableAdapter1;
        private BindingSource bdscontainer_price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}