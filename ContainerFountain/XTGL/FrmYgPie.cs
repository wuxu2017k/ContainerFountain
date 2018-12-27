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
    public partial class FrmYgPie : Form
    {
        public FrmYgPie()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
         showChart(chartXl);
         showChart(chartGw);
        }
        private void showChart(Chart chart)
        {
            chart.Theme = ThemeTypes.Theme1;
            //����X������
            AxisX x = new AxisX();
            x.Title = chart.Text;
            chart.AxisX = x;
            //����Y������
            AxisY y = new AxisY();
            y.Title = "����";
            chart.AxisY = y;
            chart.Title = new Title("Ա��" + chart.Text + "��ͼ�ֲ�");
            //Create new data series for chart
            string pxzd = chart.Tag.ToString();
            string pxzdmc = pxzd + "mc";
            string cmd = string.Format(@"
SELECT {0}, {1}, count(*) AS cnt 
FROM vusers
GROUP BY {0}, {1}
ORDER BY {0}", pxzd, pxzdmc);
            DataSeries ds = ClsVisifire.DataTableToDataSeries(cmd, ClsDBCon.ConStrKj, pxzdmc, "cnt");
            ds.Name = chart.Tag.ToString() + "tj";
            ds.RenderAs = DisplayTypes.Pie;
            ds.MarkerScale = 0.8;
            ds.ToolTipText = "����";
            ds.ToolTipText += ": #YValue";
            ds.LabelEnabled = true;
            chart.Data.Clear();
            chart.Data.Add(ds);
            chart.Update();
        }
    }
}