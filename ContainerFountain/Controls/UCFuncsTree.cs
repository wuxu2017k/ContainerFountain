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

namespace ContainerFountain.Controls
{
    public partial class UCFuncsTree :UserControl
    {
        private ClsFuncs funcs;
        public UCFuncsTree()
        {
            InitializeComponent();
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //没有下级子节点的功能，才进行功能调用。
            if (!e.Node.HasNodes)
                funcs.Call(Int32.Parse(e.Node.Name), e.Node.Tag.ToString(), e.Node.Text);
        }

        #region Prepare()
        public void Prepare(ClsFuncs aFuncs)
        {
            funcs = aFuncs;
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
        }
        #endregion

        #region createFuncTree() 创建树函数
        private void createFuncTree()
        {
            //            string cmd = @"
            //SELECT id, mc, bm, jb,
            //       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
            //       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
            //FROM vfuncsa 
            //WHERE jb > 0
            //ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
            //";
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
            DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
            if (userRow.qx >= 1024)
            {
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);
            }
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            foreach (DataRow r in dt.Rows)
            {
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
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
        #endregion

        #region createANode(DataRow r, int jb)创建节点函数
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
        #endregion

        #region trV_NodeMouseDoubleClick 双击节点触发的事件
        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }
        #endregion

        private void trV_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            //没有下级子节点的功能，才进行功能调用。
            if (!e.Node.HasNodes)
                funcs.Call(Int32.Parse(e.Node.Name), e.Node.Tag.ToString(), e.Node.Text);
        }

        private void trV_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }
    }
}