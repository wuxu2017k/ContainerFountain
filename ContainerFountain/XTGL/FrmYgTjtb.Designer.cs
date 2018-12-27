using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Common;

namespace ContainerFountain.XTGL
{
    partial class FrmYgTjtb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYgTjtb));
            this.rbLine = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbBar = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbColumn = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbPie = new Gizmox.WebGUI.Forms.RadioButton();
            this.grpCharts = new Gizmox.WebGUI.Forms.GroupBox();
            this.rbPerc = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbNum = new Gizmox.WebGUI.Forms.RadioButton();
            this.grpDataForm = new Gizmox.WebGUI.Forms.GroupBox();
            this.btnShow = new Gizmox.WebGUI.Forms.Button();
            this.rbTheme3 = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbTheme2 = new Gizmox.WebGUI.Forms.RadioButton();
            this.rbTheme1 = new Gizmox.WebGUI.Forms.RadioButton();
            this.grpThemes = new Gizmox.WebGUI.Forms.GroupBox();
            this.chartXl = new Gizmox.WebGUI.Forms.Charts.Chart();
            this.chartGw = new Gizmox.WebGUI.Forms.Charts.Chart();
            this.grpCharts.SuspendLayout();
            this.grpDataForm.SuspendLayout();
            this.grpThemes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.ExcludeFromUniqueId = false;
            this.rbLine.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbLine.Location = new System.Drawing.Point(235, 45);
            this.rbLine.Name = "rbLine";
            this.rbLine.PerformLayoutEnabled = true;
            this.rbLine.Size = new System.Drawing.Size(59, 16);
            this.rbLine.TabIndex = 3;
            this.rbLine.Tag = "Line";
            this.rbLine.Text = "折线图";
            // 
            // rbBar
            // 
            this.rbBar.AutoSize = true;
            this.rbBar.ExcludeFromUniqueId = false;
            this.rbBar.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbBar.Location = new System.Drawing.Point(138, 45);
            this.rbBar.Name = "rbBar";
            this.rbBar.PerformLayoutEnabled = true;
            this.rbBar.Size = new System.Drawing.Size(83, 16);
            this.rbBar.TabIndex = 2;
            this.rbBar.Tag = "Bar";
            this.rbBar.Text = "横向柱状图";
            // 
            // rbColumn
            // 
            this.rbColumn.AutoSize = true;
            this.rbColumn.ExcludeFromUniqueId = false;
            this.rbColumn.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbColumn.Location = new System.Drawing.Point(53, 45);
            this.rbColumn.Name = "rbColumn";
            this.rbColumn.PerformLayoutEnabled = true;
            this.rbColumn.Size = new System.Drawing.Size(83, 16);
            this.rbColumn.TabIndex = 1;
            this.rbColumn.Tag = "Column";
            this.rbColumn.Text = "纵向柱状图";
            // 
            // rbPie
            // 
            this.rbPie.AutoSize = true;
            this.rbPie.ExcludeFromUniqueId = false;
            this.rbPie.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbPie.Location = new System.Drawing.Point(4, 45);
            this.rbPie.Name = "rbPie";
            this.rbPie.PerformLayoutEnabled = true;
            this.rbPie.Size = new System.Drawing.Size(47, 16);
            this.rbPie.TabIndex = 0;
            this.rbPie.Tag = "Pie";
            this.rbPie.Text = "饼图";
            // 
            // grpCharts
            // 
            this.grpCharts.Controls.Add(this.rbLine);
            this.grpCharts.Controls.Add(this.rbBar);
            this.grpCharts.Controls.Add(this.rbColumn);
            this.grpCharts.Controls.Add(this.rbPie);
            this.grpCharts.ExcludeFromUniqueId = false;
            this.grpCharts.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpCharts.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCharts.Location = new System.Drawing.Point(0, 9);
            this.grpCharts.Name = "grpCharts";
            this.grpCharts.PerformLayoutEnabled = true;
            this.grpCharts.Size = new System.Drawing.Size(299, 95);
            this.grpCharts.TabIndex = 0;
            this.grpCharts.TabStop = false;
            this.grpCharts.Text = "图表类型";
            // 
            // rbPerc
            // 
            this.rbPerc.AutoSize = true;
            this.rbPerc.ExcludeFromUniqueId = false;
            this.rbPerc.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbPerc.Location = new System.Drawing.Point(85, 45);
            this.rbPerc.Name = "rbPerc";
            this.rbPerc.PerformLayoutEnabled = true;
            this.rbPerc.Size = new System.Drawing.Size(29, 16);
            this.rbPerc.TabIndex = 1;
            this.rbPerc.Text = "%";
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.ExcludeFromUniqueId = false;
            this.rbNum.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbNum.Location = new System.Drawing.Point(14, 45);
            this.rbNum.Name = "rbNum";
            this.rbNum.PerformLayoutEnabled = true;
            this.rbNum.Size = new System.Drawing.Size(47, 16);
            this.rbNum.TabIndex = 0;
            this.rbNum.Text = "人数";
            // 
            // grpDataForm
            // 
            this.grpDataForm.Controls.Add(this.rbPerc);
            this.grpDataForm.Controls.Add(this.rbNum);
            this.grpDataForm.ExcludeFromUniqueId = false;
            this.grpDataForm.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpDataForm.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDataForm.Location = new System.Drawing.Point(299, 9);
            this.grpDataForm.Name = "grpDataForm";
            this.grpDataForm.PerformLayoutEnabled = true;
            this.grpDataForm.Size = new System.Drawing.Size(159, 95);
            this.grpDataForm.TabIndex = 1;
            this.grpDataForm.TabStop = false;
            this.grpDataForm.Text = "数据形式";
            // 
            // btnShow
            // 
            this.btnShow.ExcludeFromUniqueId = false;
            this.btnShow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShow.Image = new Gizmox.WebGUI.Common.Resources.ImageResourceHandle(resources.GetString("btnShow.Image"));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(226, 42);
            this.btnShow.Name = "btnShow";
            this.btnShow.Padding = new Gizmox.WebGUI.Forms.Padding(8, 0, 0, 0);
            this.btnShow.PerformLayoutEnabled = true;
            this.btnShow.Size = new System.Drawing.Size(98, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "刷新图表";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.TextImageRelation = Gizmox.WebGUI.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbTheme3
            // 
            this.rbTheme3.AutoSize = true;
            this.rbTheme3.ExcludeFromUniqueId = false;
            this.rbTheme3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTheme3.Location = new System.Drawing.Point(152, 45);
            this.rbTheme3.Name = "rbTheme3";
            this.rbTheme3.PerformLayoutEnabled = true;
            this.rbTheme3.Size = new System.Drawing.Size(53, 16);
            this.rbTheme3.TabIndex = 2;
            this.rbTheme3.Tag = "Theme1";
            this.rbTheme3.Text = "主题3";
            // 
            // rbTheme2
            // 
            this.rbTheme2.AutoSize = true;
            this.rbTheme2.ExcludeFromUniqueId = false;
            this.rbTheme2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTheme2.Location = new System.Drawing.Point(78, 45);
            this.rbTheme2.Name = "rbTheme2";
            this.rbTheme2.PerformLayoutEnabled = true;
            this.rbTheme2.Size = new System.Drawing.Size(53, 16);
            this.rbTheme2.TabIndex = 1;
            this.rbTheme2.Tag = "Theme1";
            this.rbTheme2.Text = "主题2";
            // 
            // rbTheme1
            // 
            this.rbTheme1.AutoSize = true;
            this.rbTheme1.ExcludeFromUniqueId = false;
            this.rbTheme1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbTheme1.Location = new System.Drawing.Point(4, 45);
            this.rbTheme1.Name = "rbTheme1";
            this.rbTheme1.PerformLayoutEnabled = true;
            this.rbTheme1.Size = new System.Drawing.Size(53, 16);
            this.rbTheme1.TabIndex = 0;
            this.rbTheme1.Tag = "Theme1";
            this.rbTheme1.Text = "主题1";
            // 
            // grpThemes
            // 
            this.grpThemes.Controls.Add(this.btnShow);
            this.grpThemes.Controls.Add(this.rbTheme3);
            this.grpThemes.Controls.Add(this.rbTheme2);
            this.grpThemes.Controls.Add(this.rbTheme1);
            this.grpThemes.ExcludeFromUniqueId = false;
            this.grpThemes.FlatStyle = Gizmox.WebGUI.Forms.FlatStyle.Flat;
            this.grpThemes.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThemes.Location = new System.Drawing.Point(458, 9);
            this.grpThemes.Name = "grpThemes";
            this.grpThemes.PerformLayoutEnabled = true;
            this.grpThemes.Size = new System.Drawing.Size(404, 95);
            this.grpThemes.TabIndex = 2;
            this.grpThemes.TabStop = false;
            this.grpThemes.Text = "主题";
            // 
            // chartXl
            // 
            this.chartXl.AnimationEnabled = false;
            this.chartXl.AxisX = null;
            this.chartXl.AxisY = null;
            this.chartXl.ColorSet = null;
            this.chartXl.ExcludeFromUniqueId = false;
            this.chartXl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartXl.Location = new System.Drawing.Point(0, 104);
            this.chartXl.Name = "chartXl";
            this.chartXl.PerformLayoutEnabled = true;
            this.chartXl.Size = new System.Drawing.Size(404, 539);
            this.chartXl.TabIndex = 0;
            this.chartXl.Tag = "xl";
            this.chartXl.Text = "学历";
            this.chartXl.Theme = Gizmox.WebGUI.Forms.Charts.ThemeTypes.Theme1;
            this.chartXl.Title = null;
            this.chartXl.View3D = false;
            // 
            // chartGw
            // 
            this.chartGw.AnimationEnabled = false;
            this.chartGw.AxisX = null;
            this.chartGw.AxisY = null;
            this.chartGw.ColorSet = null;
            this.chartGw.ExcludeFromUniqueId = false;
            this.chartGw.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chartGw.Location = new System.Drawing.Point(404, 104);
            this.chartGw.Name = "chartGw";
            this.chartGw.PerformLayoutEnabled = true;
            this.chartGw.Size = new System.Drawing.Size(458, 539);
            this.chartGw.TabIndex = 1;
            this.chartGw.Tag = "gw";
            this.chartGw.Text = "岗位";
            this.chartGw.Theme = Gizmox.WebGUI.Forms.Charts.ThemeTypes.Theme2;
            this.chartGw.Title = null;
            this.chartGw.View3D = false;
            // 
            // FrmYgTjtb
            // 
            this.Controls.Add(this.chartGw);
            this.Controls.Add(this.chartXl);
            this.Controls.Add(this.grpThemes);
            this.Controls.Add(this.grpDataForm);
            this.Controls.Add(this.grpCharts);
            this.Size = new System.Drawing.Size(862, 634);
            this.Text = "员工统计图表";
            this.grpCharts.ResumeLayout(false);
            this.grpDataForm.ResumeLayout(false);
            this.grpThemes.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private RadioButton rbLine;
        private RadioButton rbBar;
        private RadioButton rbColumn;
        private RadioButton rbPie;
        private GroupBox grpCharts;
        private RadioButton rbPerc;
        private RadioButton rbNum;
        private GroupBox grpDataForm;
        private Button btnShow;
        private RadioButton rbTheme3;
        private RadioButton rbTheme2;
        private RadioButton rbTheme1;
        private GroupBox grpThemes;
        private Gizmox.WebGUI.Forms.Charts.Chart chartXl;
        private Gizmox.WebGUI.Forms.Charts.Chart chartGw;
    }
}