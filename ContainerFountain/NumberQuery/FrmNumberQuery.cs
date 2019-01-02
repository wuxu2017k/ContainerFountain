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

#endregion

namespace ContainerFountain.NumberQuery
{
    public partial class FrmNumberQuery : UserControl
    {
        public FrmNumberQuery()
        {
            InitializeComponent();
        }
        public void Prepare()
        {
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                //显示所有的数据
                trV.ExpandAll();
                //显示所有的节点树
                trV.SelectedNode = trV.Nodes[0];
            }
            vNumberQueryTableAdapter1.Fill(dsNumberQuery1.vNumberQuery);
        }
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

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //获取其中的名称
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                string sWhere = string.Format("where  id{0}={1}", e.Node.Tag, e.Node.Name);

               vNumberQueryTableAdapter1.FillByWhere(dsNumberQuery1.vNumberQuery, sWhere);
                
            }
            #region 填充下拉值
            string cmd = string.Format(@"select container_no from vNumberQuery where id{0}={1}", e.Node.Tag,e.Node.Name);
            ClsVWG.FillCmbBySQL(comboBox1, cmd, ClsDBCon.ConStrKj, true);
            #endregion
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sWhere = "where 1=1 ";
            if (comboBox1.SelectedIndex>=1)
                sWhere += string.Format(" and container_no='{0}'", comboBox1.SelectedValue);
            vNumberQueryTableAdapter1.FillByWhere(dsNumberQuery1.vNumberQuery, sWhere);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            vNumberQueryTableAdapter1.Fill(dsNumberQuery1.vNumberQuery);
        }
    }
}