using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.ProductType
{
    partial class FrmProductType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductType));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.pnlTop = new Gizmox.WebGUI.Forms.Panel();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dSproducttype1 = new ContainerFountain.ProductType.DSproducttype();
            this.tproducttype_dicTableAdapter1 = new ContainerFountain.ProductType.DSproducttypeTableAdapters.tproducttype_dicTableAdapter();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSproducttype1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.ExcludeFromUniqueId = false;
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(313, 9);
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
            this.btnDetail.Location = new System.Drawing.Point(217, 9);
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
            this.btnEdit.Location = new System.Drawing.Point(121, 9);
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
            this.btnNew.Location = new System.Drawing.Point(25, 9);
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
            this.pnlTop.Controls.Add(this.btnDel);
            this.pnlTop.Controls.Add(this.btnDetail);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.pnlTop.ExcludeFromUniqueId = false;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.PerformLayoutEnabled = true;
            this.pnlTop.Size = new System.Drawing.Size(568, 42);
            this.pnlTop.TabIndex = 0;
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
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.ExcludeFromUniqueId = false;
            this.dgv.Location = new System.Drawing.Point(0, 42);
            this.dgv.Name = "dgv";
            this.dgv.PerformLayoutEnabled = true;
            this.dgv.ReadOnly = true;
            this.dgv.RenderCellPanelsAsText = false;
            this.dgv.RowTemplate.Enabled = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(568, 529);
            this.dgv.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "product_name";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "产品名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_type";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "产品类型";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mark";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "识别标识";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "picture_path";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "照片地址";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "product_price";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "产品单价";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // bds
            // 
            this.bds.DataMember = "tproducttype_dic";
            this.bds.DataSource = this.dSproducttype1;
            // 
            // dSproducttype1
            // 
            this.dSproducttype1.DataSetName = "DSproducttype";
            this.dSproducttype1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tproducttype_dicTableAdapter1
            // 
            this.tproducttype_dicTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmProductType
            // 
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Size = new System.Drawing.Size(568, 571);
            this.Text = "FrmProductType";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSproducttype1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Button btnDel;
        private Button btnDetail;
        private Button btnEdit;
        private Button btnNew;
        private Panel pnlTop;
        private DataGridView dgv;
        private BindingSource bds;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DSproducttype dSproducttype1;
        private DSproducttypeTableAdapters.tproducttype_dicTableAdapter tproducttype_dicTableAdapter1;
    }
}