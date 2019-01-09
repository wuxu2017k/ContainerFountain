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


using System.Reflection;
using System.Text.RegularExpressions;
using DLTLib.Classes;
using ContainerFountain.Datasets;
using ContainerFountain.Containerheartbeat;
using ContainerFountain.NumberQuery;


#endregion

namespace ContainerFountain
{
    public partial class FrmMain : Form
    {
        int send =0,send1=0;
       DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        FrmContainerheartbeatWarn formstatus = new FrmContainerheartbeatWarn();
        FrmNumberQueryWarn formnumber = new FrmNumberQueryWarn();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            showStat();
            Classes.ClsFuncsA funcs = new Classes.ClsFuncsA(tpMain);
            funcsTree.Prepare(funcs);

            foreach (string strTheme in VWGContext.Current.Config.Themes)
                this.cmbTheme.Items.Add(strTheme);
            this.cmbTheme.Text = VWGContext.Current.CurrentTheme;
            this.cmbTheme.SelectedIndexChanged += new System.EventHandler(this.cmbTheme_SelectedIndexChanged);
            cmbTheme.SelectedIndex = 4;
            updateWaterFountainStatus();
            initListener();
        }
        private void Listener(object sender, EventArgs e)
        {

            string cmd = string.Format(@"select count(*) from tcontainer_status where status='0' or gprs_status='0'");
            if (Convert.ToInt32(ClsMSSQL.GetValue(cmd, ClsDBCon.ConStrKj)) > 0)
            {

                formstatus.Prepare();
                formstatus.ShowDialog();
                formstatus.Closed += new EventHandler(ListenerFrm_Closed);
                timer1.Enabled = false;
            }
            string cmd1 = string.Format(@"select count(*) from vNumberQuery where type_ERR>=capacity/2");
            //string cmd1 = string.Format(@"select count(*) from vNumberQuery where datediff(s,record_time,getdate())>3600");
            if (Convert.ToInt32(ClsMSSQL.GetValue(cmd1, ClsDBCon.ConStrKj)) > 0)
            {
                formnumber.Prepare();
                formnumber.ShowDialog();
                send1 = 1;
                formnumber.Closed += new EventHandler(ListenerFrm_Closed);
            }
        }
        private void initListener()
        {
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += new EventHandler(Listener);
        }
        private void ListenerFrm_Closed(object sender, EventArgs e)
        {
            if (send == 0)
            {
                if (formstatus.DialogResult == DialogResult.No)
                {
                    timer1.Interval = 6000;
                    timer1.Enabled = true;
                }
            }
            else if (send1==1)
            {
                if (formnumber.DialogResult == DialogResult.No)
                {
                    timer1.Interval = 6000;
                    timer1.Enabled = true;
                }
            }

        }
        private void updateWaterFountainStatus()
        {
            string cmd = string.Format(@"update tcontainer_status set status='false',gprs_status='0' where datediff(s,upload_time,getdate())>(select nr from tconfig where dm='Heartbeat_timeout')");
            ClsMSSQL.ExecuteCmd(cmd, ClsDBCon.ConStrKj);
        }

        #region showStat()设计状态信息显示函数
        private void showStat()
        {
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLblUser.Text = "用户：" + userRow["xm"].ToString();
            #region 显示版本和版权信息
            //当前系统的版本号
            Assembly a = Assembly.GetExecutingAssembly();//获取当前执行代码的程序集
            AssemblyName an = a.GetName();//获取次程序集的AssemblyName
            tssLblVer.Text = "版本：" + an.Version.ToString();
            //VWG的版本号
            //VWG版本用Gizmox.WebGUI.WGConst.Version获取，形如10.0.5 d - 2016.01.31 04:13 PM GMT+2
            //状态栏仅显示版本号与发行日期
            String s = Gizmox.WebGUI.WGConst.Version;//当前的Visual WebGui版本
            Regex r = new Regex(" [0-9]?[0-9]+:");//匹配" 04:"针对指定的正则表达式初始化Regex类的新实例
            Match m = r.Match(s);//单个正则表达式匹配的结果
            //从此实例检索子字符串，子字符串从指定的字符位置开始并具有指定的长度
            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);
            //版权信息
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            #endregion
        }
        #endregion

        private void lblTop_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "∧" : "∨";
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        private void tsBtnlogout_Click(object sender, EventArgs e)
        {
            ClsMsgBox.YesNo("确实要退出系统吗？", logout);
        }
        #region logout(object sender, EventArgs e) 询问是否退出的logout回调函数
        private void logout(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                VWGContext.Current.Session.IsLoggedOn = false;
                VWGContext.Current.HttpContext.Session.Abandon();
            }
        }
        #endregion

        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {

            string ids = funcsTree.trV.SelectedNode.Name;
            funcsTree.trV.Nodes.Clear();
            Classes.ClsFuncsA funcs = new Classes.ClsFuncsA(tpMain);
            funcsTree.Prepare(funcs);
            funcsTree.trV.ExpandAll();
            TreeNode[] tns = funcsTree.trV.Nodes.Find(ids, true);
            if (tns.Length > 0)
            {
                funcsTree.trV.SelectedNode = tns[0];
            }
            else
                funcsTree.trV.SelectedNode = funcsTree.trV.Nodes[0];
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            VWGContext.Current.CurrentTheme = this.cmbTheme.Text;
        }
    }
}