using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.ContainerInput
{
    partial class FrmContainerFountainMX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainerFountainMX));
            this.bdsContainer = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.dsContainerFountain1 = new ContainerFountain.ContainerInput.DSContainerFountain();
            this.bdsContainer_status = new Gizmox.WebGUI.Forms.BindingSource(this.components);
            this.tcontainer_statusTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainer_statusTableAdapter();
            this.tcontainerTableAdapter1 = new ContainerFountain.ContainerInput.DSContainerFountainTableAdapters.tcontainerTableAdapter();
            this.tableAdapterManager1 = new ContainerFountain.Datasets.DSedidTableAdapters.TableAdapterManager();
            this.txtcontainer_no = new Gizmox.WebGUI.Forms.TextBox();
            this.lblcontainer_id = new Gizmox.WebGUI.Forms.Label();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.txtcontainer_name = new Gizmox.WebGUI.Forms.TextBox();
            this.cmbscreen_type = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbmodeltype = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtaddress = new Gizmox.WebGUI.Forms.TextBox();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.textBox1 = new Gizmox.WebGUI.Forms.TextBox();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.lblpay_parameter = new Gizmox.WebGUI.Forms.Label();
            this.grpTop = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.cmbJgTree = new ContainerFountain.TreeViewComboBox.TreeViewComboBox();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.txtsimcard = new Gizmox.WebGUI.Forms.TextBox();
            this.txtversion = new Gizmox.WebGUI.Forms.TextBox();
            this.txtcapacity = new Gizmox.WebGUI.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContainer_status)).BeginInit();
            this.grpTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdsContainer
            // 
            this.bdsContainer.DataMember = "tcontainer";
            this.bdsContainer.DataSource = this.dsContainerFountain1;
            // 
            // dsContainerFountain1
            // 
            this.dsContainerFountain1.DataSetName = "DSContainerFountain";
            this.dsContainerFountain1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsContainer_status
            // 
            this.bdsContainer_status.DataMember = "tcontainer_status";
            this.bdsContainer_status.DataSource = this.dsContainerFountain1;
            // 
            // tcontainer_statusTableAdapter1
            // 
            this.tcontainer_statusTableAdapter1.ClearBeforeFill = true;
            // 
            // tcontainerTableAdapter1
            // 
            this.tcontainerTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.tconfigTableAdapter = null;
            this.tableAdapterManager1.tfuncsTableAdapter = null;
            this.tableAdapterManager1.tjigouTableAdapter = null;
            this.tableAdapterManager1.toptionlbTableAdapter = null;
            this.tableAdapterManager1.toptionxmTableAdapter = null;
            this.tableAdapterManager1.trolefuncsTableAdapter = null;
            this.tableAdapterManager1.trolesTableAdapter = null;
            this.tableAdapterManager1.tygTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = ContainerFountain.Datasets.DSedidTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtcontainer_no
            // 
            this.txtcontainer_no.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "container_no", true));
            this.txtcontainer_no.Enabled = false;
            this.txtcontainer_no.ExcludeFromUniqueId = false;
            this.txtcontainer_no.Location = new System.Drawing.Point(100, 50);
            this.txtcontainer_no.Name = "txtcontainer_no";
            this.txtcontainer_no.PerformLayoutEnabled = true;
            this.txtcontainer_no.Size = new System.Drawing.Size(145, 21);
            this.txtcontainer_no.TabIndex = 0;
            this.txtcontainer_no.LostFocus += new System.EventHandler(this.txtWaterFountain_no_LostFocus);
            // 
            // lblcontainer_id
            // 
            this.lblcontainer_id.AutoSize = true;
            this.lblcontainer_id.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "id", true));
            this.lblcontainer_id.ExcludeFromUniqueId = false;
            this.lblcontainer_id.ForeColor = System.Drawing.Color.DarkRed;
            this.lblcontainer_id.Location = new System.Drawing.Point(97, 29);
            this.lblcontainer_id.Name = "lblcontainer_id";
            this.lblcontainer_id.PerformLayoutEnabled = true;
            this.lblcontainer_id.Size = new System.Drawing.Size(15, 13);
            this.lblcontainer_id.TabIndex = 0;
            this.lblcontainer_id.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ExcludeFromUniqueId = false;
            this.label2.Location = new System.Drawing.Point(83, 29);
            this.label2.Name = "label2";
            this.label2.PerformLayoutEnabled = true;
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ExcludeFromUniqueId = false;
            this.label8.Location = new System.Drawing.Point(16, 50);
            this.label8.Name = "label8";
            this.label8.PerformLayoutEnabled = true;
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "饮水机编号(*)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ExcludeFromUniqueId = false;
            this.label13.Location = new System.Drawing.Point(285, 53);
            this.label13.Name = "label13";
            this.label13.PerformLayoutEnabled = true;
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "设备名称(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ExcludeFromUniqueId = false;
            this.label3.Location = new System.Drawing.Point(31, 83);
            this.label3.Name = "label3";
            this.label3.PerformLayoutEnabled = true;
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "机器类型(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ExcludeFromUniqueId = false;
            this.label5.Location = new System.Drawing.Point(285, 83);
            this.label5.Name = "label5";
            this.label5.PerformLayoutEnabled = true;
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "屏幕类型(*)";
            // 
            // txtcontainer_name
            // 
            this.txtcontainer_name.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "container_name", true));
            this.txtcontainer_name.ExcludeFromUniqueId = false;
            this.txtcontainer_name.Location = new System.Drawing.Point(357, 50);
            this.txtcontainer_name.Name = "txtcontainer_name";
            this.txtcontainer_name.PerformLayoutEnabled = true;
            this.txtcontainer_name.Size = new System.Drawing.Size(118, 21);
            this.txtcontainer_name.TabIndex = 1;
            // 
            // cmbscreen_type
            // 
            this.cmbscreen_type.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbscreen_type.ExcludeFromUniqueId = false;
            this.cmbscreen_type.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbscreen_type.FormattingEnabled = true;
            this.cmbscreen_type.Location = new System.Drawing.Point(357, 81);
            this.cmbscreen_type.Name = "cmbscreen_type";
            this.cmbscreen_type.PerformLayoutEnabled = true;
            this.cmbscreen_type.Size = new System.Drawing.Size(119, 20);
            this.cmbscreen_type.TabIndex = 6;
            // 
            // cmbmodeltype
            // 
            this.cmbmodeltype.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbmodeltype.ExcludeFromUniqueId = false;
            this.cmbmodeltype.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbmodeltype.FormattingEnabled = true;
            this.cmbmodeltype.Location = new System.Drawing.Point(100, 81);
            this.cmbmodeltype.Name = "cmbmodeltype";
            this.cmbmodeltype.PerformLayoutEnabled = true;
            this.cmbmodeltype.Size = new System.Drawing.Size(171, 20);
            this.cmbmodeltype.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "address", true));
            this.txtaddress.ExcludeFromUniqueId = false;
            this.txtaddress.Location = new System.Drawing.Point(104, 192);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.PerformLayoutEnabled = true;
            this.txtaddress.Size = new System.Drawing.Size(376, 21);
            this.txtaddress.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ExcludeFromUniqueId = false;
            this.label7.Location = new System.Drawing.Point(30, 200);
            this.label7.Name = "label7";
            this.label7.PerformLayoutEnabled = true;
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "饮水机地址";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ExcludeFromUniqueId = false;
            this.textBox1.Location = new System.Drawing.Point(258, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.PerformLayoutEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(20, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ExcludeFromUniqueId = false;
            this.label9.Location = new System.Drawing.Point(287, 29);
            this.label9.Name = "label9";
            this.label9.PerformLayoutEnabled = true;
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "二维码参数";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ExcludeFromUniqueId = false;
            this.label10.Location = new System.Drawing.Point(41, 116);
            this.label10.Name = "label10";
            this.label10.PerformLayoutEnabled = true;
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "所属机构:";
            // 
            // lblpay_parameter
            // 
            this.lblpay_parameter.AutoSize = true;
            this.lblpay_parameter.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "pay_parameter", true));
            this.lblpay_parameter.ExcludeFromUniqueId = false;
            this.lblpay_parameter.ForeColor = System.Drawing.Color.DarkRed;
            this.lblpay_parameter.Location = new System.Drawing.Point(354, 29);
            this.lblpay_parameter.Name = "lblpay_parameter";
            this.lblpay_parameter.PerformLayoutEnabled = true;
            this.lblpay_parameter.Size = new System.Drawing.Size(15, 13);
            this.lblpay_parameter.TabIndex = 1;
            this.lblpay_parameter.Text = "二维码参数";
            // 
            // grpTop
            // 
            this.grpTop.Controls.Add(this.txtcapacity);
            this.grpTop.Controls.Add(this.txtversion);
            this.grpTop.Controls.Add(this.txtsimcard);
            this.grpTop.Controls.Add(this.label6);
            this.grpTop.Controls.Add(this.label4);
            this.grpTop.Controls.Add(this.label1);
            this.grpTop.Controls.Add(this.txtcontainer_no);
            this.grpTop.Controls.Add(this.cmbJgTree);
            this.grpTop.Controls.Add(this.lblcontainer_id);
            this.grpTop.Controls.Add(this.label2);
            this.grpTop.Controls.Add(this.label8);
            this.grpTop.Controls.Add(this.label13);
            this.grpTop.Controls.Add(this.label3);
            this.grpTop.Controls.Add(this.label5);
            this.grpTop.Controls.Add(this.txtcontainer_name);
            this.grpTop.Controls.Add(this.cmbscreen_type);
            this.grpTop.Controls.Add(this.cmbmodeltype);
            this.grpTop.Controls.Add(this.txtaddress);
            this.grpTop.Controls.Add(this.label7);
            this.grpTop.Controls.Add(this.textBox1);
            this.grpTop.Controls.Add(this.label9);
            this.grpTop.Controls.Add(this.label10);
            this.grpTop.Controls.Add(this.lblpay_parameter);
            this.grpTop.Dock = Gizmox.WebGUI.Forms.DockStyle.Top;
            this.grpTop.ExcludeFromUniqueId = false;
            this.grpTop.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpTop.Location = new System.Drawing.Point(0, 0);
            this.grpTop.Name = "grpTop";
            this.grpTop.PerformLayoutEnabled = true;
            this.grpTop.Size = new System.Drawing.Size(513, 253);
            this.grpTop.TabIndex = 0;
            this.grpTop.TabStop = false;
            this.grpTop.Text = "饮水机信息明细";
            // 
            // btnClose
            // 
            this.btnClose.ExcludeFromUniqueId = false;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(426, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnClose.PerformLayoutEnabled = true;
            this.btnClose.Size = new System.Drawing.Size(65, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "返回";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ExcludeFromUniqueId = false;
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(337, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnSave.PerformLayoutEnabled = true;
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.panel1.ExcludeFromUniqueId = false;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.PerformLayoutEnabled = true;
            this.panel1.Size = new System.Drawing.Size(513, 47);
            this.panel1.TabIndex = 1;
            // 
            // cmbJgTree
            // 
            this.cmbJgTree.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJgTree.ExcludeFromUniqueId = false;
            this.cmbJgTree.FormattingEnabled = true;
            this.cmbJgTree.ImageList = null;
            this.cmbJgTree.IsNonLeafNodeSelectable = false;
            this.cmbJgTree.Location = new System.Drawing.Point(100, 116);
            this.cmbJgTree.Name = "cmbJgTree";
            this.cmbJgTree.PerformLayoutEnabled = true;
            this.cmbJgTree.Size = new System.Drawing.Size(141, 21);
            this.cmbJgTree.TabIndex = 1;
            this.cmbJgTree.TreeHeight = 200;
            this.cmbJgTree.TreeWidth = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "版本号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ExcludeFromUniqueId = false;
            this.label4.Location = new System.Drawing.Point(285, 160);
            this.label4.Name = "label4";
            this.label4.PerformLayoutEnabled = true;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "货柜容量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ExcludeFromUniqueId = false;
            this.label6.Location = new System.Drawing.Point(287, 124);
            this.label6.Name = "label6";
            this.label6.PerformLayoutEnabled = true;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "sim编号";
            // 
            // txtsimcard
            // 
            this.txtsimcard.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "sim_card", true));
            this.txtsimcard.ExcludeFromUniqueId = false;
            this.txtsimcard.Location = new System.Drawing.Point(357, 121);
            this.txtsimcard.Name = "txtsimcard";
            this.txtsimcard.PerformLayoutEnabled = true;
            this.txtsimcard.Size = new System.Drawing.Size(100, 20);
            this.txtsimcard.TabIndex = 10;
            // 
            // txtversion
            // 
            this.txtversion.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "version", true));
            this.txtversion.ExcludeFromUniqueId = false;
            this.txtversion.Location = new System.Drawing.Point(104, 153);
            this.txtversion.Name = "txtversion";
            this.txtversion.PerformLayoutEnabled = true;
            this.txtversion.Size = new System.Drawing.Size(100, 20);
            this.txtversion.TabIndex = 11;
            // 
            // txtcapacity
            // 
            this.txtcapacity.DataBindings.Add(new Gizmox.WebGUI.Forms.Binding("Text", this.bdsContainer, "capacity", true));
            this.txtcapacity.ExcludeFromUniqueId = false;
            this.txtcapacity.Location = new System.Drawing.Point(357, 157);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.PerformLayoutEnabled = true;
            this.txtcapacity.Size = new System.Drawing.Size(100, 20);
            this.txtcapacity.TabIndex = 12;
            // 
            // FrmContainerFountainMX
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpTop);
            this.Size = new System.Drawing.Size(513, 300);
            this.Text = "货柜明细";
            ((System.ComponentModel.ISupportInitialize)(this.bdsContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContainerFountain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsContainer_status)).EndInit();
            this.grpTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private BindingSource bdsContainer;
        private BindingSource bdsContainer_status;
        private DSContainerFountain dsContainerFountain1;
        private DSContainerFountainTableAdapters.tcontainer_statusTableAdapter tcontainer_statusTableAdapter1;
        private DSContainerFountainTableAdapters.tcontainerTableAdapter tcontainerTableAdapter1;
        private Datasets.DSedidTableAdapters.TableAdapterManager tableAdapterManager1;
        private TextBox txtcontainer_no;
        private Label lblcontainer_id;
        private Label label2;
        private Label label8;
        private Label label13;
        private Label label3;
        private Label label5;
        private TextBox txtcontainer_name;
        private ComboBox cmbscreen_type;
        private ComboBox cmbmodeltype;
        private TextBox txtaddress;
        private Label label7;
        private TextBox textBox1;
        private Label label9;
        private Label label10;
        private Label lblpay_parameter;
        private GroupBox grpTop;
        private TreeViewComboBox.TreeViewComboBox cmbJgTree;
        private Button btnClose;
        private Button btnSave;
        private Panel panel1;
        private TextBox txtcapacity;
        private TextBox txtversion;
        private TextBox txtsimcard;
        private Label label6;
        private Label label4;
        private Label label1;
    }
}