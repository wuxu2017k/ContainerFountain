#region Using

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using Gizmox.WebGUI.Common;
using Gizmox.WebGUI.Forms;
using Gizmox.WebGUI.Forms.Charts;
using DLTLib.Classes;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmYgTjtb : Form
    {

        public FrmYgTjtb()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            initChart(chartXl);
           initChart(chartGw);
            btnShow.PerformClick();
        }
        private void initChart(Chart chart)
        {
            chart.Theme = ThemeTypes.Theme1;
            // 创建X坐标轴
            AxisX x = new AxisX();
            x.Title = chart.Tag.ToString();
            chart.AxisX = x;
            // 创建Y坐标轴
            AxisY y = new AxisY();
            y.Title = "人数";
            chart.AxisY = y;
        }
        private void showChart(Chart chart, DisplayTypes chartType, ThemeTypes theme, bool isPerc)
        {
            chart.Theme = theme;
            AxisY y = chart.AxisY;
            y.Suffix = isPerc ? "%" : "";
            chart.Title = new Title("员工" + chart.Text.ToString() + "分布");
            // Create new data series for chart
            string pxzd = chart.Tag.ToString();
            string pxzdmc = pxzd + "mc";
            string cmd = string.Format(@"
SELECT {0}, {1}, count(*) AS cnt 
FROM vusers
GROUP BY {0}, {1}
ORDER BY {0}", pxzd, pxzdmc);
            DataSeries ds = ClsVisifire.DataTableToDataSeries(cmd, ClsDBCon.ConStrKj, pxzdmc, "cnt", isPerc);
            ds.Name = chart.Tag.ToString() + "tj";
            ds.RenderAs = chartType;
            ds.MarkerScale = 0.8;
            ds.ToolTipText = isPerc ? "%" : "人数";
            ds.ToolTipText += ": #YValue";
            ds.LabelEnabled = true;
            chart.Data.Clear();
            chart.Data.Add(ds);
            chart.Update();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            RadioButton rb = ClsVWG.GetCheckedRadioBtn(grpCharts);
            DisplayTypes t = (DisplayTypes)(Enum.Parse(typeof(DisplayTypes), rb.Tag.ToString()));
            RadioButton rbd = ClsVWG.GetCheckedRadioBtn(grpDataForm);
            RadioButton rbt = ClsVWG.GetCheckedRadioBtn(grpThemes);
            ThemeTypes theme = (ThemeTypes)(Enum.Parse(typeof(ThemeTypes), rbt.Tag.ToString()));
            showChart(chartXl, t, theme, string.Equals(rbd.Text, "%"));
           showChart(chartGw, t, theme, string.Equals(rbd.Text, "%"));
        }
    }
}