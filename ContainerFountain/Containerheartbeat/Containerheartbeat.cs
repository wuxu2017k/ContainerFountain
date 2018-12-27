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
using DLTLib.Classes;
using ContainerFountain.Datasets;
using System.Data.SqlClient;

#endregion

namespace ContainerFountain.Containerheartbeat
{
    public partial class Containerheartbeat :UserControl
    {
        public Containerheartbeat()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            if (dScontainerheartbeat1.Tables.Contains("dtmodeltype"))
            {
                dScontainerheartbeat1.Tables.Remove("dtmodeltype");
            }
            if (dScontainerheartbeat1.Tables.Contains("dtscreen_type"))
            {
                dScontainerheartbeat1.Tables.Remove("dtscreen_type");
            }
            if (dScontainerheartbeat1.Tables.Contains("relmodeltype"))
            {
                dScontainerheartbeat1.Tables.Remove("relmodeltype");
            }
            if (dScontainerheartbeat1.Tables.Contains("relscreen_type"))
            {
                dScontainerheartbeat1.Tables.Remove("relscreen_type");
            }
            //��������б�
            fillcmbs();
            //����������
            createFuncTree();
            //��trv����ֵ
            if (trV.Nodes.Count > 0)
            {
                //��ʾ���е�����
                trV.ExpandAll();
                //��ʾ���еĽڵ���
                trV.SelectedNode = trV.Nodes[0];
            }
            //��̬����ֵ
            CreateTableAndRelation();
            //����������Ϣ
            tjigouTableAdapter1.Fill(dScontainerheartbeat1.tjigou);
            //�����ͼ
            vcontainerStatusTableAdapter1.Fill(dScontainerheartbeat1.vcontainerStatus);
        }

        #region fillcmbs()
        private void fillcmbs()
        {
            fillcmbmodeltype();
            fillcmbscreen_type();
            fillcmbgprs_status();
            fillstatus();
        }

        #region  fillcmbmodeltype()
        private void fillcmbmodeltype()
        {
            //��ѯ���
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='modeltype'");
            //��ȡ��ѯ������Ϣ
            ClsVWG.FillCmbBySQL(cmbmodeltype, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region  fillcmbscreen_type()
        private void fillcmbscreen_type()
        {
            //��ѯ���
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='screen_type'");
            //��ȡ��ѯ������Ϣ
            ClsVWG.FillCmbBySQL(cmbscreen_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillcmbgprs_status()
        private void fillcmbgprs_status()
        {
            //����һ������
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            //�������������
            lst.Add(new ClsBhMcString("", ""));
            lst.Add(new ClsBhMcString("True", "����"));
            lst.Add(new ClsBhMcString("False", "����"));
            cmbgprs_status.DataSource = lst;
            cmbgprs_status.DisplayMember = "Mc";
            cmbgprs_status.ValueMember = "Bh";
        }
        #endregion

        #region fillstatus()
        private void fillstatus()
        {
            //����һ������
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            //�������������
            lst.Add(new ClsBhMcString("", ""));
            lst.Add(new ClsBhMcString("True", "����"));
            lst.Add(new ClsBhMcString("False", "����"));
            cmbstatus.DataSource = lst;
            cmbstatus.DisplayMember = "Mc";
            cmbstatus.ValueMember = "Bh";
        }
        #endregion

        #endregion

        #region createFuncTree()
        private void createFuncTree()
        {
            //sql���
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1 in (3,4)
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            //��ȡ�������ݵ���Ϣ
            DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
            //�жϽ�ɫ��Ȩ��
            if (userRow.qx >= 1024)
            {
                //sql���
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);
            }
            //��ȡ�����Ϣ
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //���������Ϣ
            foreach (DataRow r in dt.Rows)
            {
                //��������ֵ
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //��ʾ���ڵ����Ϣ
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        //�����µĽڵ�
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//��trV�ؼ���ӽڵ�
                        else
                            tp.Nodes.Add(tn);//�򸸽ڵ�tp����ӽڵ�
                        tp = tn;
                    }
                }
            }
        }

        #region createANode(DataRow r, int jb)
        private TreeNode createANode(DataRow r, int jb)
        {

            string id = "id" + jb;
            string mc = "mc" + jb;
            //string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r["jb"].ToString();
            return tn;
        }
        #endregion

        #endregion

        #region CreateTableAndRelation()
        private void CreateTableAndRelation()
        {
            try
            {
                //sql����ȡ���룬���Ƶ���Ϣ
                string cmd = string.Format(@"select dm,mc from toptionxm where lbdm=@lbdm");
                //����һ��SqlParameter����һ�����������֣��ڶ�������ֵ
                SqlParameter paramodeltype = new SqlParameter("@lbdm", "modeltype");
                //��һ����Ľṹ�ٽ�һ����
                DataTable dtmodeltype = dScontainerheartbeat1.Tables.Add("dtmodeltype");
                //��ȡ�����Ϣ
                dtmodeltype = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, paramodeltype);
                //��ӱ����Ϣ
                dScontainerheartbeat1.Tables.Add(dtmodeltype);
                //��ӱ��ϵ
                DataRelation relmodeltype = new DataRelation("relmodeltype", dtmodeltype.Columns["dm"], dScontainerheartbeat1.vcontainerStatus.Columns["modeltype"]);
                //����һ��SqlParameter����һ�����������֣��ڶ�������ֵ
                SqlParameter parascreen_type = new SqlParameter("@lbdm", "screen_type");
                //����һ���µı�
                DataTable dtscreen_type = dScontainerheartbeat1.Tables.Add("dtscreen_type");
                //��ѯ�������
                dtscreen_type = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, parascreen_type);
                //���������Ϣ
                dScontainerheartbeat1.Tables.Add(dtscreen_type);
                //��ӱ��ϵ
                DataRelation relscreen_type = new DataRelation("relscreen_type", dtscreen_type.Columns["dm"], dScontainerheartbeat1.vcontainerStatus.Columns["screen_type"]);
                //���ݼ���ӹ�ϵ
                dScontainerheartbeat1.Relations.Add(relmodeltype);
                dScontainerheartbeat1.Relations.Add(relscreen_type);
                //�����ݼ��е���Ϣ��ֵ
                dScontainerheartbeat1.vcontainerStatus.model_type_nameColumn.Expression = "Parent(relmodeltype).mc";
                dScontainerheartbeat1.vcontainerStatus.screen_type_nameColumn.Expression = "Parent(relscreen_type).mc";
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //��ȡ���е�����
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                string sWhere = string.Format("where  id{0}={1}", e.Node.Tag, e.Node.Name);

               vcontainerStatusTableAdapter1.FillByWhere(dScontainerheartbeat1.vcontainerStatus, sWhere);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sWhere = "where 1=1 ";
            if (trV.SelectedNode != null)
                sWhere += string.Format(" and id{0}={1}", trV.SelectedNode.Tag, trV.SelectedNode.Name);
            if (cmbmodeltype.SelectedIndex >= 1)
                sWhere += string.Format(" and modeltype='{0}' ", cmbmodeltype.SelectedValue);
            if (cmbscreen_type.SelectedIndex >= 1)
                sWhere += string.Format(" and screen_type='{0}'", cmbscreen_type.SelectedValue);
            if (cmbstatus.SelectedIndex >= 1)
                sWhere += string.Format(" and status='{0}'", cmbstatus.SelectedValue);
            if (cmbgprs_status.SelectedIndex >= 1)
                sWhere += string.Format(" and gprs_status='{0}'", cmbgprs_status.SelectedValue);
            if (dtpKs_upload_time.Checked)
                sWhere += string.Format(" and upload_time>='{0}'", dtpKs_upload_time.Value);
            if (dtpJs_upload_time.Checked)
                sWhere += string.Format(" and upload_time<='{0}'", dtpJs_upload_time.Value);
            vcontainerStatusTableAdapter1.FillByWhere(dScontainerheartbeat1.vcontainerStatus, sWhere);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbgprs_status.SelectedIndex = 0;
            cmbmodeltype.SelectedIndex = 0;
            cmbscreen_type.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;
            dtpJs_upload_time.Checked = false;
            dtpKs_upload_time.Checked = false;
           vcontainerStatusTableAdapter1.Fill(dScontainerheartbeat1.vcontainerStatus);
        }
    }
}