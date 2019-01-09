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

        #region showStat()���״̬��Ϣ��ʾ����
        private void showStat()
        {
            DataRow userRow = VWGContext.Current.Session["UserRow"] as DataRow;
            tssLblUser.Text = "�û���" + userRow["xm"].ToString();
            #region ��ʾ�汾�Ͱ�Ȩ��Ϣ
            //��ǰϵͳ�İ汾��
            Assembly a = Assembly.GetExecutingAssembly();//��ȡ��ǰִ�д���ĳ���
            AssemblyName an = a.GetName();//��ȡ�γ��򼯵�AssemblyName
            tssLblVer.Text = "�汾��" + an.Version.ToString();
            //VWG�İ汾��
            //VWG�汾��Gizmox.WebGUI.WGConst.Version��ȡ������10.0.5 d - 2016.01.31 04:13 PM GMT+2
            //״̬������ʾ�汾���뷢������
            String s = Gizmox.WebGUI.WGConst.Version;//��ǰ��Visual WebGui�汾
            Regex r = new Regex(" [0-9]?[0-9]+:");//ƥ��" 04:"���ָ����������ʽ��ʼ��Regex�����ʵ��
            Match m = r.Match(s);//����������ʽƥ��Ľ��
            //�Ӵ�ʵ���������ַ��������ַ�����ָ�����ַ�λ�ÿ�ʼ������ָ���ĳ���
            tssLblVWGVer.Text = "VWG:" + s.Substring(0, m.Index);
            //��Ȩ��Ϣ
            tssLblCopyRight.Text = a.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            #endregion
        }
        #endregion

        private void lblTop_Click(object sender, EventArgs e)
        {
            pnlTop.Visible = !pnlTop.Visible;
            lblTop.Text = pnlTop.Visible ? "��" : "��";
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            pnlLeft.Visible = !pnlLeft.Visible;
            splitter1.Visible = pnlLeft.Visible;
            lblLeft.Text = pnlLeft.Visible ? "<" : ">";
        }

        private void tsBtnlogout_Click(object sender, EventArgs e)
        {
            ClsMsgBox.YesNo("ȷʵҪ�˳�ϵͳ��", logout);
        }
        #region logout(object sender, EventArgs e) ѯ���Ƿ��˳���logout�ص�����
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