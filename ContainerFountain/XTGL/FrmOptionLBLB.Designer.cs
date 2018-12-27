using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmOptionLBLB
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
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOptionLBLB));
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            Gizmox.WebGUI.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new Gizmox.WebGUI.Forms.DataGridViewCellStyle();
            this.bds = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dSedid1 = new ContainerFountain.Datasets.DSedid();
            this.toptionlbTableAdapter1 = new ContainerFountain.Datasets.DSedidTableAdapters.toptionlbTableAdapter();
            this.dgv = new Gizmox.WebGUI.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.mnuDgv = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNew = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEdit = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetail = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDel = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpDgv = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnDel = new Gizmox.WebGUI.Forms.Button();
            this.btnEdit = new Gizmox.WebGUI.Forms.Button();
            this.btnNew = new Gizmox.WebGUI.Forms.Button();
            this.btnDetail = new Gizmox.WebGUI.Forms.Button();
            this.pnlLB = new Gizmox.WebGUI.Forms.Panel();
            this.dgvXM = new Gizmox.WebGUI.Forms.DataGridView();
            this.mnuXM = new Gizmox.WebGUI.Forms.ContextMenuStrip(this.components);
            this.mnuNewXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuEditXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDetailXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.mnuDelXM = new Gizmox.WebGUI.Forms.ToolStripMenuItem();
            this.grpXM = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnDetailXM = new Gizmox.WebGUI.Forms.Button();
            this.btnNewXM = new Gizmox.WebGUI.Forms.Button();
            this.btnEditXM = new Gizmox.WebGUI.Forms.Button();
            this.btnDelXM = new Gizmox.WebGUI.Forms.Button();
            this.pnlXM = new Gizmox.WebGUI.Forms.Panel();
            this.toptionxmTableAdapter1 = new ContainerFountain.Datasets.DSedidTableAdapters.toptionxmTableAdapter();
            this.bdsXM = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new Gizmox.WebGUI.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSedid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.grpDgv.SuspendLayout();
            this.pnlLB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).BeginInit();
            this.grpXM.SuspendLayout();
            this.pnlXM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).BeginInit();
            this.SuspendLayout();
            // 
            // bds
            // 
            this.bds.DataMember = "toptionlb";
            this.bds.DataSource = this.dSedid1;
            // 
            // dSedid1
            // 
            this.dSedid1.DataSetName = "DSedid";
            this.dSedid1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toptionlbTableAdapter1
            // 
            this.toptionlbTableAdapter1.ClearBeforeFill = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle12.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv.ContextMenuStrip = this.mnuDgv;
            this.dgv.DataSource = this.bds;
            this.dgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgv.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv.ExcludeFromUniqueId = false;
            this.dgv.Location = new System.Drawing.Point(3, 17);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.PerformLayoutEnabled = true;
            this.dgv.ReadOnly = true;
            this.dgv.RenderCellPanelsAsText = false;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv.RowTemplate.Enabled = true;
            this.dgv.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.SelectOnRightClick = true;
            this.dgv.Size = new System.Drawing.Size(211, 535);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            this.dgv.DoubleClick += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn1.HeaderText = "代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // mnuDgv
            // 
            this.mnuDgv.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuDgv.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuDgv.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuDgv.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuDgv.ExcludeFromUniqueId = false;
            this.mnuDgv.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuDetail,
            this.mnuDel});
            this.mnuDgv.Name = "mnuDgv";
            this.mnuDgv.PerformLayoutEnabled = true;
            this.mnuDgv.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNew
            // 
            this.mnuNew.ExcludeFromUniqueId = false;
            this.mnuNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNew.Image"));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNew.Size = new System.Drawing.Size(99, 20);
            this.mnuNew.Text = "新增";
            this.mnuNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.ExcludeFromUniqueId = false;
            this.mnuEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEdit.Image"));
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEdit.Size = new System.Drawing.Size(99, 20);
            this.mnuEdit.Text = "编辑";
            this.mnuEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // mnuDetail
            // 
            this.mnuDetail.ExcludeFromUniqueId = false;
            this.mnuDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetail.Image"));
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetail.Size = new System.Drawing.Size(99, 20);
            this.mnuDetail.Text = "详细";
            this.mnuDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // mnuDel
            // 
            this.mnuDel.ExcludeFromUniqueId = false;
            this.mnuDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDel.Image"));
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDel.Size = new System.Drawing.Size(99, 20);
            this.mnuDel.Text = "删除";
            this.mnuDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grpDgv
            // 
            this.grpDgv.Controls.Add(this.dgv);
            this.grpDgv.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpDgv.ExcludeFromUniqueId = false;
            this.grpDgv.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDgv.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpDgv.Location = new System.Drawing.Point(0, 0);
            this.grpDgv.Name = "grpDgv";
            this.grpDgv.PerformLayoutEnabled = true;
            this.grpDgv.Size = new System.Drawing.Size(217, 555);
            this.grpDgv.TabIndex = 0;
            this.grpDgv.TabStop = false;
            this.grpDgv.Text = "选项类别列表";
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDel.ExcludeFromUniqueId = false;
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDel.Image"));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(15, 269);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDel.PerformLayoutEnabled = true;
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "删除";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEdit.ExcludeFromUniqueId = false;
            this.btnEdit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEdit.Image"));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(15, 177);
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
            this.btnNew.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNew.ExcludeFromUniqueId = false;
            this.btnNew.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNew.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNew.Image"));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(15, 133);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnNew.PerformLayoutEnabled = true;
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDetail.ExcludeFromUniqueId = false;
            this.btnDetail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDetail.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetail.Image"));
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(15, 226);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDetail.PerformLayoutEnabled = true;
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "详细";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // pnlLB
            // 
            this.pnlLB.Controls.Add(this.btnDel);
            this.pnlLB.Controls.Add(this.btnEdit);
            this.pnlLB.Controls.Add(this.btnNew);
            this.pnlLB.Controls.Add(this.btnDetail);
            this.pnlLB.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlLB.ExcludeFromUniqueId = false;
            this.pnlLB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlLB.Location = new System.Drawing.Point(217, 0);
            this.pnlLB.Name = "pnlLB";
            this.pnlLB.PerformLayoutEnabled = true;
            this.pnlLB.Size = new System.Drawing.Size(115, 555);
            this.pnlLB.TabIndex = 2;
            // 
            // dgvXM
            // 
            this.dgvXM.AllowUserToAddRows = false;
            this.dgvXM.AllowUserToDeleteRows = false;
            this.dgvXM.AllowUserToResizeColumns = false;
            this.dgvXM.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgvXM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXM.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgvXM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXM.Columns.AddRange(new Gizmox.WebGUI.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvXM.ContextMenuStrip = this.mnuXM;
            this.dgvXM.DataSource = this.bdsXM;
            dataGridViewCellStyle18.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.False;
            this.dgvXM.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.dgvXM.EditMode = Gizmox.WebGUI.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvXM.ExcludeFromUniqueId = false;
            this.dgvXM.Location = new System.Drawing.Point(3, 17);
            this.dgvXM.MultiSelect = false;
            this.dgvXM.Name = "dgvXM";
            this.dgvXM.PerformLayoutEnabled = true;
            this.dgvXM.ReadOnly = true;
            this.dgvXM.RenderCellPanelsAsText = false;
            dataGridViewCellStyle19.Alignment = Gizmox.WebGUI.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = Gizmox.WebGUI.Forms.DataGridViewTriState.True;
            this.dgvXM.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.FormatProvider = new System.Globalization.CultureInfo("zh-CN");
            this.dgvXM.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvXM.RowTemplate.Enabled = true;
            this.dgvXM.SelectionMode = Gizmox.WebGUI.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXM.SelectOnRightClick = true;
            this.dgvXM.Size = new System.Drawing.Size(219, 535);
            this.dgvXM.TabIndex = 0;
            // 
            // mnuXM
            // 
            this.mnuXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left)));
            this.mnuXM.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.mnuXM.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.None;
            this.mnuXM.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(1);
            this.mnuXM.ExcludeFromUniqueId = false;
            this.mnuXM.Items.AddRange(new Gizmox.WebGUI.Forms.ToolStripItem[] {
            this.mnuNewXM,
            this.mnuEditXM,
            this.mnuDetailXM,
            this.mnuDelXM});
            this.mnuXM.Name = "mnuXM";
            this.mnuXM.PerformLayoutEnabled = true;
            this.mnuXM.Size = new System.Drawing.Size(100, 25);
            // 
            // mnuNewXM
            // 
            this.mnuNewXM.ExcludeFromUniqueId = false;
            this.mnuNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuNewXM.Image"));
            this.mnuNewXM.Name = "mnuNewXM";
            this.mnuNewXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuNewXM.Size = new System.Drawing.Size(99, 20);
            this.mnuNewXM.Text = "新增";
            this.mnuNewXM.Click += new System.EventHandler(this.btnNewXM_Click);
            // 
            // mnuEditXM
            // 
            this.mnuEditXM.ExcludeFromUniqueId = false;
            this.mnuEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuEditXM.Image"));
            this.mnuEditXM.Name = "mnuEditXM";
            this.mnuEditXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuEditXM.Size = new System.Drawing.Size(99, 20);
            this.mnuEditXM.Text = "编辑";
            this.mnuEditXM.Click += new System.EventHandler(this.btnEditXM_Click);
            // 
            // mnuDetailXM
            // 
            this.mnuDetailXM.ExcludeFromUniqueId = false;
            this.mnuDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDetailXM.Image"));
            this.mnuDetailXM.Name = "mnuDetailXM";
            this.mnuDetailXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDetailXM.Size = new System.Drawing.Size(99, 20);
            this.mnuDetailXM.Text = "详细";
            this.mnuDetailXM.Click += new System.EventHandler(this.btnDetailXM_Click);
            // 
            // mnuDelXM
            // 
            this.mnuDelXM.ExcludeFromUniqueId = false;
            this.mnuDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("mnuDelXM.Image"));
            this.mnuDelXM.Name = "mnuDelXM";
            this.mnuDelXM.Padding = new Gizmox.WebGUI.Forms.Padding(0, 0, 0, 0);
            this.mnuDelXM.Size = new System.Drawing.Size(99, 20);
            this.mnuDelXM.Text = "删除";
            this.mnuDelXM.Click += new System.EventHandler(this.btnDelXM_Click);
            // 
            // grpXM
            // 
            this.grpXM.Controls.Add(this.dgvXM);
            this.grpXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.grpXM.ExcludeFromUniqueId = false;
            this.grpXM.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpXM.Location = new System.Drawing.Point(332, 0);
            this.grpXM.Name = "grpXM";
            this.grpXM.PerformLayoutEnabled = true;
            this.grpXM.Size = new System.Drawing.Size(225, 555);
            this.grpXM.TabIndex = 3;
            this.grpXM.TabStop = false;
            this.grpXM.Text = "选项项目列表";
            // 
            // btnDetailXM
            // 
            this.btnDetailXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDetailXM.ExcludeFromUniqueId = false;
            this.btnDetailXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDetailXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDetailXM.Image"));
            this.btnDetailXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailXM.Location = new System.Drawing.Point(13, 226);
            this.btnDetailXM.Name = "btnDetailXM";
            this.btnDetailXM.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDetailXM.PerformLayoutEnabled = true;
            this.btnDetailXM.Size = new System.Drawing.Size(75, 23);
            this.btnDetailXM.TabIndex = 1;
            this.btnDetailXM.Text = "详细";
            this.btnDetailXM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailXM.Click += new System.EventHandler(this.btnDetailXM_Click);
            // 
            // btnNewXM
            // 
            this.btnNewXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnNewXM.ExcludeFromUniqueId = false;
            this.btnNewXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNewXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnNewXM.Image"));
            this.btnNewXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewXM.Location = new System.Drawing.Point(13, 133);
            this.btnNewXM.Name = "btnNewXM";
            this.btnNewXM.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnNewXM.PerformLayoutEnabled = true;
            this.btnNewXM.Size = new System.Drawing.Size(75, 23);
            this.btnNewXM.TabIndex = 1;
            this.btnNewXM.Text = "新增";
            this.btnNewXM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewXM.Click += new System.EventHandler(this.btnNewXM_Click);
            // 
            // btnEditXM
            // 
            this.btnEditXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnEditXM.ExcludeFromUniqueId = false;
            this.btnEditXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnEditXM.Image"));
            this.btnEditXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditXM.Location = new System.Drawing.Point(13, 177);
            this.btnEditXM.Name = "btnEditXM";
            this.btnEditXM.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnEditXM.PerformLayoutEnabled = true;
            this.btnEditXM.Size = new System.Drawing.Size(75, 23);
            this.btnEditXM.TabIndex = 1;
            this.btnEditXM.Text = "编辑";
            this.btnEditXM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditXM.Click += new System.EventHandler(this.btnEditXM_Click);
            // 
            // btnDelXM
            // 
            this.btnDelXM.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnDelXM.ExcludeFromUniqueId = false;
            this.btnDelXM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelXM.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnDelXM.Image"));
            this.btnDelXM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelXM.Location = new System.Drawing.Point(13, 269);
            this.btnDelXM.Name = "btnDelXM";
            this.btnDelXM.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnDelXM.PerformLayoutEnabled = true;
            this.btnDelXM.Size = new System.Drawing.Size(75, 23);
            this.btnDelXM.TabIndex = 1;
            this.btnDelXM.Text = "删除";
            this.btnDelXM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelXM.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelXM.Click += new System.EventHandler(this.btnDelXM_Click);
            // 
            // pnlXM
            // 
            this.pnlXM.Controls.Add(this.btnDetailXM);
            this.pnlXM.Controls.Add(this.btnNewXM);
            this.pnlXM.Controls.Add(this.btnEditXM);
            this.pnlXM.Controls.Add(this.btnDelXM);
            this.pnlXM.Dock = Gizmox.WebGUI.Forms.DockStyle.Left;
            this.pnlXM.ExcludeFromUniqueId = false;
            this.pnlXM.Location = new System.Drawing.Point(557, 0);
            this.pnlXM.Name = "pnlXM";
            this.pnlXM.PerformLayoutEnabled = true;
            this.pnlXM.Size = new System.Drawing.Size(114, 555);
            this.pnlXM.TabIndex = 4;
            // 
            // toptionxmTableAdapter1
            // 
            this.toptionxmTableAdapter1.ClearBeforeFill = true;
            // 
            // bdsXM
            // 
            this.bdsXM.DataMember = "toptionxm";
            this.bdsXM.DataSource = this.dSedid1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn3.HeaderText = "代码";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mc";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn4.HeaderText = "名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmOptionLBLB
            // 
            this.Controls.Add(this.pnlXM);
            this.Controls.Add(this.grpXM);
            this.Controls.Add(this.pnlLB);
            this.Controls.Add(this.grpDgv);
            this.Size = new System.Drawing.Size(691, 555);
            this.Text = "选项类别列表";
            this.Load += new System.EventHandler(this.FrmOptionLBLB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSedid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.grpDgv.ResumeLayout(false);
            this.pnlLB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXM)).EndInit();
            this.grpXM.ResumeLayout(false);
            this.pnlXM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsXM)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private BindingSource bds;
        private Datasets.DSedid dSedid1;
        private Datasets.DSedidTableAdapters.toptionlbTableAdapter toptionlbTableAdapter1;
        private DataGridView dgv;
        private GroupBox grpDgv;
        private Button btnDel;
        private Button btnEdit;
        private Button btnNew;
        private Button btnDetail;
        private Panel pnlLB;
        private DataGridView dgvXM;
        private GroupBox grpXM;
        private Button btnDetailXM;
        private Button btnNewXM;
        private Button btnEditXM;
        private Button btnDelXM;
        private Panel pnlXM;
        private ContextMenuStrip mnuDgv;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuEdit;
        private ToolStripMenuItem mnuDetail;
        private ToolStripMenuItem mnuDel;
        private ContextMenuStrip mnuXM;
        private ToolStripMenuItem mnuNewXM;
        private ToolStripMenuItem mnuEditXM;
        private ToolStripMenuItem mnuDetailXM;
        private ToolStripMenuItem mnuDelXM;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Datasets.DSedidTableAdapters.toptionxmTableAdapter toptionxmTableAdapter1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private BindingSource bdsXM;
    }
}