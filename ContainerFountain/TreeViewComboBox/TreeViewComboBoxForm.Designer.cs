using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.TreeViewComboBox
{
    partial class TreeViewComboBoxForm
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
            this.CmbTreeView = new Gizmox.WebGUI.Forms.TreeView();
            this.treeViewComboBox1 = new DLTLib.Controls.TreeViewComboBox.TreeViewComboBox();
            this.SuspendLayout();
            // 
            // CmbTreeView
            // 
            this.CmbTreeView.Dock = Gizmox.WebGUI.Forms.DockStyle.Fill;
            this.CmbTreeView.ExcludeFromUniqueId = false;
            this.CmbTreeView.Font = new System.Drawing.Font("ËÎÌו", 9F);
            this.CmbTreeView.Location = new System.Drawing.Point(0, 0);
            this.CmbTreeView.Name = "CmbTreeView";
            this.CmbTreeView.PerformLayoutEnabled = true;
            this.CmbTreeView.Size = new System.Drawing.Size(235, 181);
            this.CmbTreeView.TabIndex = 0;
            this.CmbTreeView.AfterSelect += new Gizmox.WebGUI.Forms.TreeViewEventHandler(this.CmbTreeView_AfterSelect);
            // 
            // treeViewComboBox1
            // 
            this.treeViewComboBox1.DropDownStyle = Gizmox.WebGUI.Forms.ComboBoxStyle.DropDownList;
            this.treeViewComboBox1.ExcludeFromUniqueId = false;
            this.treeViewComboBox1.FormattingEnabled = true;
            this.treeViewComboBox1.ImageList = null;
            this.treeViewComboBox1.IsNonLeafNodeSelectable = false;
            this.treeViewComboBox1.Location = new System.Drawing.Point(173, 138);
            this.treeViewComboBox1.Name = "treeViewComboBox1";
            this.treeViewComboBox1.PerformLayoutEnabled = true;
            this.treeViewComboBox1.Size = new System.Drawing.Size(121, 21);
            this.treeViewComboBox1.TabIndex = 1;
            this.treeViewComboBox1.TreeHeight = 200;
            this.treeViewComboBox1.TreeWidth = 120;
            // 
            // TreeViewComboBoxForm
            // 
            this.Controls.Add(this.treeViewComboBox1);
            this.Controls.Add(this.CmbTreeView);
            this.Size = new System.Drawing.Size(235, 181);
            this.Text = "TreeViewComboBoxForm";
            this.ResumeLayout(false);

        }


        #endregion

        public TreeView CmbTreeView;
        private DLTLib.Controls.TreeViewComboBox.TreeViewComboBox treeViewComboBox1;
    }
}