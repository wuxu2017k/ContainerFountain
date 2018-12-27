using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new Gizmox.WebGUI.Forms.Panel();
            this.txtLoginName = new Gizmox.WebGUI.Forms.TextBox();
            this.chkAutoSave = new Gizmox.WebGUI.Forms.CheckBox();
            this.txtPassword = new Gizmox.WebGUI.Forms.TextBox();
            this.btnCancel = new Gizmox.WebGUI.Forms.Button();
            this.label1 = new Gizmox.WebGUI.Forms.Label();
            this.btnOK = new Gizmox.WebGUI.Forms.Button();
            this.label2 = new Gizmox.WebGUI.Forms.Label();
            this.pnlBG = new Gizmox.WebGUI.Forms.Panel();
            this.pnlBG.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("panel1.BackgroundImage"));
            this.panel1.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Zoom;
            this.panel1.ExcludeFromUniqueId = false;
            this.panel1.Location = new System.Drawing.Point(66, 19);
            this.panel1.Name = "panel1";
            this.panel1.PerformLayoutEnabled = true;
            this.panel1.Size = new System.Drawing.Size(118, 117);
            this.panel1.TabIndex = 0;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtLoginName.ExcludeFromUniqueId = false;
            this.txtLoginName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(126, 115);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.PerformLayoutEnabled = true;
            this.txtLoginName.Size = new System.Drawing.Size(148, 25);
            this.txtLoginName.TabIndex = 1;
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.ExcludeFromUniqueId = false;
            this.chkAutoSave.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoSave.ForeColor = System.Drawing.Color.OrangeRed;
            this.chkAutoSave.Location = new System.Drawing.Point(126, 184);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.PerformLayoutEnabled = true;
            this.chkAutoSave.Size = new System.Drawing.Size(72, 16);
            this.chkAutoSave.TabIndex = 5;
            this.chkAutoSave.Text = "自动保存";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.txtPassword.ExcludeFromUniqueId = false;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(126, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PerformLayoutEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(148, 24);
            this.txtPassword.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Cancel;
            this.btnCancel.ExcludeFromUniqueId = false;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCancel.Location = new System.Drawing.Point(214, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PerformLayoutEnabled = true;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            // 
            // label1
            // 
            this.label1.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ExcludeFromUniqueId = false;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(94, 118);
            this.label1.Name = "label1";
            this.label1.PerformLayoutEnabled = true;
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.btnOK.ExcludeFromUniqueId = false;
            this.btnOK.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnOK.Location = new System.Drawing.Point(123, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.PerformLayoutEnabled = true;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)((Gizmox.WebGUI.Forms.AnchorStyles.Left | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ExcludeFromUniqueId = false;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(94, 158);
            this.label2.Name = "label2";
            this.label2.PerformLayoutEnabled = true;
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "口令";
            // 
            // pnlBG
            // 
            this.pnlBG.Anchor = Gizmox.WebGUI.Forms.AnchorStyles.None;
            this.pnlBG.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("pnlBG.BackgroundImage"));
            this.pnlBG.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.pnlBG.Controls.Add(this.txtLoginName);
            this.pnlBG.Controls.Add(this.chkAutoSave);
            this.pnlBG.Controls.Add(this.txtPassword);
            this.pnlBG.Controls.Add(this.btnCancel);
            this.pnlBG.Controls.Add(this.label1);
            this.pnlBG.Controls.Add(this.btnOK);
            this.pnlBG.Controls.Add(this.label2);
            this.pnlBG.ExcludeFromUniqueId = false;
            this.pnlBG.Location = new System.Drawing.Point(106, 185);
            this.pnlBG.Name = "pnlBG";
            this.pnlBG.PerformLayoutEnabled = true;
            this.pnlBG.Size = new System.Drawing.Size(387, 303);
            this.pnlBG.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("$this.BackgroundImage"));
            this.BackgroundImageLayout = Gizmox.WebGUI.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlBG);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(599, 672);
            this.Text = "登录";
            this.pnlBG.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel panel1;
        private TextBox txtLoginName;
        private CheckBox chkAutoSave;
        private TextBox txtPassword;
        private Button btnCancel;
        private Label label1;
        private Button btnOK;
        private Label label2;
        private Panel pnlBG;
    }
}