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
            //填充下拉列表
            fillcmbs();
            //创建树函数
            createFuncTree();
            //对trv的数值
            if (trV.Nodes.Count > 0)
            {
                //显示所有的数据
                trV.ExpandAll();
                //显示所有的节点树
                trV.SelectedNode = trV.Nodes[0];
            }
            //动态绑定列值
            CreateTableAndRelation();
            //填充机构的信息
            tjigouTableAdapter1.Fill(dScontainerheartbeat1.tjigou);
            //填充视图
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
            //查询语句
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='modeltype'");
            //获取查询到的信息
            ClsVWG.FillCmbBySQL(cmbmodeltype, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region  fillcmbscreen_type()
        private void fillcmbscreen_type()
        {
            //查询语句
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='screen_type'");
            //获取查询到的信息
            ClsVWG.FillCmbBySQL(cmbscreen_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillcmbgprs_status()
        private void fillcmbgprs_status()
        {
            //声明一个集合
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            //给集合添加数据
            lst.Add(new ClsBhMcString("", ""));
            lst.Add(new ClsBhMcString("True", "正常"));
            lst.Add(new ClsBhMcString("False", "故障"));
            cmbgprs_status.DataSource = lst;
            cmbgprs_status.DisplayMember = "Mc";
            cmbgprs_status.ValueMember = "Bh";
        }
        #endregion

        #region fillstatus()
        private void fillstatus()
        {
            //声明一个集合
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            //给集合添加数据
            lst.Add(new ClsBhMcString("", ""));
            lst.Add(new ClsBhMcString("True", "正常"));
            lst.Add(new ClsBhMcString("False", "故障"));
            cmbstatus.DataSource = lst;
            cmbstatus.DisplayMember = "Mc";
            cmbstatus.ValueMember = "Bh";
        }
        #endregion

        #endregion

        #region createFuncTree()
        private void createFuncTree()
        {
            //sql语句
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1 in (3,4)
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            //获取表中数据的信息
            DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
            //判断角色的权限
            if (userRow.qx >= 1024)
            {
                //sql语句
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);
            }
            //获取表的信息
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //遍历表的信息
            foreach (DataRow r in dt.Rows)
            {
                //给机构赋值
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //显示树节点的信息
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        //创建新的节点
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//向trV控件添加节点
                        else
                            tp.Nodes.Add(tn);//向父节点tp中添加节点
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
            //使用指定的文本初始化 TreeNode 类的新实例。
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
                //sql语句获取代码，名称的信息
                string cmd = string.Format(@"select dm,mc from toptionxm where lbdm=@lbdm");
                //创建一个SqlParameter，第一个参数是名字，第二个参数值
                SqlParameter paramodeltype = new SqlParameter("@lbdm", "modeltype");
                //上一个表的结构再建一个表
                DataTable dtmodeltype = dScontainerheartbeat1.Tables.Add("dtmodeltype");
                //获取表的信息
                dtmodeltype = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, paramodeltype);
                //添加表的信息
                dScontainerheartbeat1.Tables.Add(dtmodeltype);
                //添加表关系
                DataRelation relmodeltype = new DataRelation("relmodeltype", dtmodeltype.Columns["dm"], dScontainerheartbeat1.vcontainerStatus.Columns["modeltype"]);
                //创建一个SqlParameter，第一个参数是名字，第二个参数值
                SqlParameter parascreen_type = new SqlParameter("@lbdm", "screen_type");
                //建立一个新的表
                DataTable dtscreen_type = dScontainerheartbeat1.Tables.Add("dtscreen_type");
                //查询表的数据
                dtscreen_type = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, parascreen_type);
                //给表添加信息
                dScontainerheartbeat1.Tables.Add(dtscreen_type);
                //添加表关系
                DataRelation relscreen_type = new DataRelation("relscreen_type", dtscreen_type.Columns["dm"], dScontainerheartbeat1.vcontainerStatus.Columns["screen_type"]);
                //数据集添加关系
                dScontainerheartbeat1.Relations.Add(relmodeltype);
                dScontainerheartbeat1.Relations.Add(relscreen_type);
                //给数据集中的信息赋值
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
            //获取其中的名称
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