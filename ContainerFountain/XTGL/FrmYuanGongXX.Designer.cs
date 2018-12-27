using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmYuanGongXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYuanGongXX));
            this.imgLst = new Gizmox.WebGUI.Forms.ImageList(this.components);
            this.cmbJgTree = new DLTLib.Controls.TreeViewComboBox.TreeViewComboBox();
            this.cmbXb = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbXl = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbGw = new Gizmox.WebGUI.Forms.ComboBox();
            this.cmbRole = new Gizmox.WebGUI.Forms.ComboBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.lblId = new Gizmox.WebGUI.Forms.Label();
            this.chkActive = new Gizmox.WebGUI.Forms.CheckBox();
            this.label9 = new Gizmox.WebGUI.Forms.Label();
            this.label8 = new Gizmox.WebGUI.Forms.Label();
            this.label7 = new Gizmox.WebGUI.Forms.Label();
            this.label6 = new Gizmox.WebGUI.Forms.Label();
            this.label5 = new Gizmox.WebGUI.Forms.Label();
            this.label4 = new Gizmox.WebGUI.Forms.Label();
            this.label3 = new Gizmox.WebGUI.Forms.Label();
            this.txtXm = new Gizmox.WebGUI.Forms.TextBox();
            this.txtXh = new Gizmox.WebGUI.Forms.TextBox();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.dtpRzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.cmbZt = new Gizmox.WebGUI.Forms.ComboBox();
            this.dtpLzrq = new Gizmox.WebGUI.Forms.DateTimePicker();
            this.txtWx = new Gizmox.WebGUI.Forms.TextBox();
            this.txtEmail = new Gizmox.WebGUI.Forms.TextBox();
            this.txtQQ = new Gizmox.WebGUI.Forms.TextBox();
            this.txtMTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtOTel = new Gizmox.WebGUI.Forms.TextBox();
            this.txtFax = new Gizmox.WebGUI.Forms.TextBox();
            this.label18 = new Gizmox.WebGUI.Forms.Label();
            this.label17 = new Gizmox.WebGUI.Forms.Label();
            this.label16 = new Gizmox.WebGUI.Forms.Label();
            this.label15 = new Gizmox.WebGUI.Forms.Label();
            this.label14 = new Gizmox.WebGUI.Forms.Label();
            this.label13 = new Gizmox.WebGUI.Forms.Label();
            this.label12 = new Gizmox.WebGUI.Forms.Label();
            this.label11 = new Gizmox.WebGUI.Forms.Label();
            this.label10 = new Gizmox.WebGUI.Forms.Label();
            this.btnSave = new Gizmox.WebGUI.Forms.Button();
            this.btnPassword = new Gizmox.WebGUI.Forms.Button();
            this.btnClose = new Gizmox.WebGUI.Forms.Button();
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
            // cmbJgTree
            // 
            this.cmbJgTree.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbJgTree.ExcludeFromUniqueId = false;
            this.cmbJgTree.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbJgTree.FormattingEnabled = true;
            this.cmbJgTree.ImageList = this.imgLst;
            this.cmbJgTree.IsNonLeafNodeSelectable = true;
            this.cmbJgTree.Location = new System.Drawing.Point(133, 80);
            this.cmbJgTree.Name = "cmbJgTree";
            this.cmbJgTree.PerformLayoutEnabled = true;
            this.cmbJgTree.Size = new System.Drawing.Size(145, 20);
            this.cmbJgTree.TabIndex = 2;
            this.cmbJgTree.TreeHeight = 200;
            this.cmbJgTree.TreeWidth = 120;
            // 
            // cmbXb
            // 
            this.cmbXb.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXb.ExcludeFromUniqueId = false;
            this.cmbXb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXb.FormattingEnabled = true;
            this.cmbXb.Location = new System.Drawing.Point(133, 215);
            this.cmbXb.Name = "cmbXb";
            this.cmbXb.PerformLayoutEnabled = true;
            this.cmbXb.Size = new System.Drawing.Size(145, 20);
            this.cmbXb.TabIndex = 6;
            // 
            // cmbXl
            // 
            this.cmbXl.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbXl.ExcludeFromUniqueId = false;
            this.cmbXl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbXl.FormattingEnabled = true;
            this.cmbXl.Location = new System.Drawing.Point(133, 308);
            this.cmbXl.Name = "cmbXl";
            this.cmbXl.PerformLayoutEnabled = true;
            this.cmbXl.Size = new System.Drawing.Size(145, 20);
            this.cmbXl.TabIndex = 9;
            // 
            // cmbGw
            // 
            this.cmbGw.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbGw.ExcludeFromUniqueId = false;
            this.cmbGw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbGw.FormattingEnabled = true;
            this.cmbGw.Location = new System.Drawing.Point(133, 277);
            this.cmbGw.Name = "cmbGw";
            this.cmbGw.PerformLayoutEnabled = true;
            this.cmbGw.Size = new System.Drawing.Size(145, 20);
            this.cmbGw.TabIndex = 8;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.ExcludeFromUniqueId = false;
            this.cmbRole.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(133, 246);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.PerformLayoutEnabled = true;
            this.cmbRole.Size = new System.Drawing.Size(145, 20);
            this.cmbRole.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.ExcludeFromUniqueId = false;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(133, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PerformLayoutEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(145, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ExcludeFromUniqueId = false;
            this.lblId.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(133, 22);
            this.lblId.Name = "lblId";
            this.lblId.PerformLayoutEnabled = true;
            this.lblId.Size = new System.Drawing.Size(35, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.ExcludeFromUniqueId = false;
            this.chkActive.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkActive.Location = new System.Drawing.Point(146, 346);
            this.chkActive.Name = "chkActive";
            this.chkActive.PerformLayoutEnabled = true;
            this.chkActive.Size = new System.Drawing.Size(48, 16);
            this.chkActive.TabIndex = 10;
            this.chkActive.Text = "活动";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ExcludeFromUniqueId = false;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(21, 115);
            this.label9.Name = "label9";
            this.label9.PerformLayoutEnabled = true;
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "姓名(*)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ExcludeFromUniqueId = false;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(21, 219);
            this.label8.Name = "label8";
            this.label8.PerformLayoutEnabled = true;
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ExcludeFromUniqueId = false;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(21, 250);
            this.label7.Name = "label7";
            this.label7.PerformLayoutEnabled = true;
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "角色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ExcludeFromUniqueId = false;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(21, 146);
            this.label6.Name = "label6";
            this.label6.PerformLayoutEnabled = true;
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "账户(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ExcludeFromUniqueId = false;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(21, 281);
            this.label5.Name = "label5";
            this.label5.PerformLayoutEnabled = true;
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "岗位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ExcludeFromUniqueId = false;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.PerformLayoutEnabled = true;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "学历";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ExcludeFromUniqueId = false;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.PerformLayoutEnabled = true;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "机构";
            // 
            // txtXm
            // 
            this.txtXm.ExcludeFromUniqueId = false;
            this.txtXm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXm.Location = new System.Drawing.Point(133, 111);
            this.txtXm.Name = "txtXm";
            this.txtXm.PerformLayoutEnabled = true;
            this.txtXm.Size = new System.Drawing.Size(100, 20);
            this.txtXm.TabIndex = 3;
            // 
            // txtXh
            // 
            this.txtXh.Enabled = false;
            this.txtXh.ExcludeFromUniqueId = false;
            this.txtXh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXh.Location = new System.Drawing.Point(133, 49);
            this.txtXh.Name = "txtXh";
            this.txtXh.PerformLayoutEnabled = true;
            this.txtXh.Size = new System.Drawing.Size(100, 20);
            this.txtXh.TabIndex = 1;
            // 
            // txtLoginName
            // 
            this.txtLoginName.ExcludeFromUniqueId = false;
            this.txtLoginName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoginName.Location = new System.Drawing.Point(133, 142);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PerformLayoutEnabled = true;
            this.txtLoginName.Size = new System.Drawing.Size(145, 20);
            this.txtLoginName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ExcludeFromUniqueId = false;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.PerformLayoutEnabled = true;
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "序号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // dtpRzrq
            // 
            this.dtpRzrq.CustomFormat = "";
            this.dtpRzrq.ExcludeFromUniqueId = false;
            this.dtpRzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpRzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpRzrq.IsEmpty = false;
            this.dtpRzrq.IsEmptyAllowed = false;
            this.dtpRzrq.Location = new System.Drawing.Point(408, 270);
            this.dtpRzrq.Name = "dtpRzrq";
            this.dtpRzrq.PerformLayoutEnabled = true;
            this.dtpRzrq.Size = new System.Drawing.Size(160, 16);
            this.dtpRzrq.TabIndex = 18;
            this.dtpRzrq.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // cmbZt
            // 
            this.cmbZt.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.cmbZt.ExcludeFromUniqueId = false;
            this.cmbZt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbZt.FormattingEnabled = true;
            this.cmbZt.Location = new System.Drawing.Point(408, 53);
            this.cmbZt.Name = "cmbZt";
            this.cmbZt.PerformLayoutEnabled = true;
            this.cmbZt.Size = new System.Drawing.Size(129, 20);
            this.cmbZt.TabIndex = 11;
            // 
            // dtpLzrq
            // 
            this.dtpLzrq.CustomFormat = "";
            this.dtpLzrq.ExcludeFromUniqueId = false;
            this.dtpLzrq.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpLzrq.Format = Gizmox.WebGUI.Forms.DateTimePickerFormat.Short;
            this.dtpLzrq.IsEmpty = false;
            this.dtpLzrq.IsEmptyAllowed = false;
            this.dtpLzrq.Location = new System.Drawing.Point(408, 302);
            this.dtpLzrq.Name = "dtpLzrq";
            this.dtpLzrq.PerformLayoutEnabled = true;
            this.dtpLzrq.Size = new System.Drawing.Size(160, 16);
            this.dtpLzrq.TabIndex = 19;
            this.dtpLzrq.Value = new System.DateTime(2018, 12, 24, 0, 0, 0, 0);
            // 
            // txtWx
            // 
            this.txtWx.ExcludeFromUniqueId = false;
            this.txtWx.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWx.Location = new System.Drawing.Point(408, 239);
            this.txtWx.Name = "txtWx";
            this.txtWx.PerformLayoutEnabled = true;
            this.txtWx.Size = new System.Drawing.Size(157, 20);
            this.txtWx.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.ExcludeFromUniqueId = false;
            this.txtEmail.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEmail.Location = new System.Drawing.Point(408, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PerformLayoutEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // txtQQ
            // 
            this.txtQQ.ExcludeFromUniqueId = false;
            this.txtQQ.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQQ.Location = new System.Drawing.Point(408, 208);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.PerformLayoutEnabled = true;
            this.txtQQ.Size = new System.Drawing.Size(157, 20);
            this.txtQQ.TabIndex = 16;
            // 
            // txtMTel
            // 
            this.txtMTel.ExcludeFromUniqueId = false;
            this.txtMTel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMTel.Location = new System.Drawing.Point(408, 115);
            this.txtMTel.Name = "txtMTel";
            this.txtMTel.PerformLayoutEnabled = true;
            this.txtMTel.Size = new System.Drawing.Size(157, 20);
            this.txtMTel.TabIndex = 13;
            // 
            // txtOTel
            // 
            this.txtOTel.ExcludeFromUniqueId = false;
            this.txtOTel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOTel.Location = new System.Drawing.Point(408, 84);
            this.txtOTel.Name = "txtOTel";
            this.txtOTel.PerformLayoutEnabled = true;
            this.txtOTel.Size = new System.Drawing.Size(157, 20);
            this.txtOTel.TabIndex = 12;
            // 
            // txtFax
            // 
            this.txtFax.ExcludeFromUniqueId = false;
            this.txtFax.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFax.Location = new System.Drawing.Point(408, 146);
            this.txtFax.Name = "txtFax";
            this.txtFax.PerformLayoutEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(157, 20);
            this.txtFax.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ExcludeFromUniqueId = false;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(315, 53);
            this.label18.Name = "label18";
            this.label18.PerformLayoutEnabled = true;
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "状态";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ExcludeFromUniqueId = false;
            this.label17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(315, 85);
            this.label17.Name = "label17";
            this.label17.PerformLayoutEnabled = true;
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "市话";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ExcludeFromUniqueId = false;
            this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(315, 117);
            this.label16.Name = "label16";
            this.label16.PerformLayoutEnabled = true;
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "手机";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ExcludeFromUniqueId = false;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(315, 309);
            this.label15.Name = "label15";
            this.label15.PerformLayoutEnabled = true;
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "离职日期";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ExcludeFromUniqueId = false;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(315, 277);
            this.label14.Name = "label14";
            this.label14.PerformLayoutEnabled = true;
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "入职日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ExcludeFromUniqueId = false;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(315, 181);
            this.label13.Name = "label13";
            this.label13.PerformLayoutEnabled = true;
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ExcludeFromUniqueId = false;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(315, 245);
            this.label12.Name = "label12";
            this.label12.PerformLayoutEnabled = true;
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "微信";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ExcludeFromUniqueId = false;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(315, 213);
            this.label11.Name = "label11";
            this.label11.PerformLayoutEnabled = true;
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "QQ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ExcludeFromUniqueId = false;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(315, 149);
            this.label10.Name = "label10";
            this.label10.PerformLayoutEnabled = true;
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fax";
            // 
            // btnSave
            // 
            this.btnSave.ExcludeFromUniqueId = false;
            this.btnSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnSave.Image"));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(203, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnSave.PerformLayoutEnabled = true;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.ExcludeFromUniqueId = false;
            this.btnPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPassword.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnPassword.Image"));
            this.btnPassword.Location = new System.Drawing.Point(21, 177);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.PerformLayoutEnabled = true;
            this.btnPassword.Size = new System.Drawing.Size(75, 23);
            this.btnPassword.TabIndex = 5;
            this.btnPassword.Text = "口令(*)";
            this.btnPassword.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnClose.ExcludeFromUniqueId = false;
            this.btnClose.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Image = new Gizmox.WebGUI.Common.Resources.IconResourceHandle(resources.GetString("btnClose.Image"));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(351, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new Gizmox.WebGUI.Forms.Padding(10, 0, 0, 0);
            this.btnClose.PerformLayoutEnabled = true;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "关闭";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmYuanGongXX
            // 
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtOTel);
            this.Controls.Add(this.txtMTel);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWx);
            this.Controls.Add(this.dtpLzrq);
            this.Controls.Add(this.cmbZt);
            this.Controls.Add(this.dtpRzrq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.txtXh);
            this.Controls.Add(this.txtXm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.cmbGw);
            this.Controls.Add(this.cmbXl);
            this.Controls.Add(this.cmbXb);
            this.Controls.Add(this.cmbJgTree);
            this.Size = new System.Drawing.Size(693, 419);
            this.Text = "员工详细信息";
            this.ResumeLayout(false);

        }


        #endregion

        private ImageList imgLst;
        private DLTLib.Controls.TreeViewComboBox.TreeViewComboBox cmbJgTree;
        private ComboBox cmbXb;
        private ComboBox cmbXl;
        private ComboBox cmbGw;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private Label lblId;
        private CheckBox chkActive;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtXm;
        private TextBox txtXh;
        private TextBox txtLoginName;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpRzrq;
        private ComboBox cmbZt;
        private DateTimePicker dtpLzrq;
        private TextBox txtWx;
        private TextBox txtEmail;
        private TextBox txtQQ;
        private TextBox txtMTel;
        private TextBox txtOTel;
        private TextBox txtFax;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnSave;
        private Button btnPassword;
        private Button btnClose;
    }
}