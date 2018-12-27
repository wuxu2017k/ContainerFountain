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
using ContainerFountain.Datasets.DSedidTableAdapters;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmRoleFuncs : Form
    {
        #region 自定义变量
        private int roleId;
        private List<int> funcsLst;
        #endregion
        public FrmRoleFuncs()
        {
            InitializeComponent();
        }

        #region Prepare(int aRoleId, string aRoleMc) 窗体或用户控件的初始化及外部参数传入使用公有的Prepare函数实现。
        public void Prepare(int aRoleId, string aRoleMc)
        {
            roleId = aRoleId;
            this.Text += "—" + aRoleMc;
            funcsLst = getFuncsList(roleId);
            createFuncTree();
            trV.ExpandAll();
        }
        #endregion

        #region getFuncsList(int aRoleId) 获取给定角色的所有功能模块id
        // <summary>
        /// 获取给定角色的所有功能模块id
        /// </summary>
        /// <param name="aRoleId"></param>
        /// <returns></returns>
        private List<int> getFuncsList(int aRoleId)
        {
            string cmd = "SELECT funcid FROM trolefuncs WHERE roleid = " + roleId;
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //使用Linq将DataTable中的整数数据列funcid转换为一个更简洁的List<int>
            List<int> lst = (from r in dt.AsEnumerable() select r.Field<int>("funcid")).ToList<int>();
            return lst;
        }
        #endregion

        #region createFuncTree()创建树函数
        private void createFuncTree()
        {
            string cmd = @"
SELECT id, mc, bm, jb,
       id0, mc0, bm0, id1, mc1, bm1, id2, mc2, bm2,
       id3, mc3, bm3, id4, mc4, bm4, id5, mc5, bm5 
FROM vfuncsa 
WHERE jb > 0
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5
";
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
            tn.CheckBox = CheckBoxVisibility.True;
            tn.Checked = funcsLst.Contains(Convert.ToInt32(r[id]));
            return tn;
        }
        #endregion

        #region getAllCheckedIds(TreeNode pNode) 递归地获得给定结点所有选中的末端树节点(即功能模块)的id列表
        /// <summary>
        /// 递归地获得给定结点所有选中的末端树节点(即功能模块)的id列表
        /// </summary>
        private void getAllCheckedIds(TreeNode pNode)
        {
            foreach (TreeNode node in pNode.Nodes)
            {
                if (!node.HasNodes && node.Checked)
                {
                    funcsLst.Add(Convert.ToInt32(node.Name));
                }
                getAllCheckedIds(node);
            }
        }
        #endregion
        private void trV_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = e.Node.Checked;
            }
        }

        private void trV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.HasNodes)
                if (e.Node.IsExpanded)
                    e.Node.Collapse();
                else
                    e.Node.Expand();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //获得所有选中的末端树节点(即功能模块)的id列表
            funcsLst.Clear();
            foreach (TreeNode node in trV.Nodes)
                getAllCheckedIds(node);
            //删除当前角色的原有的功能模块
            trolefuncsTableAdapter trolefuncsTableAdapter1 = new trolefuncsTableAdapter();
            trolefuncsTableAdapter1.DeleteByRoleId(roleId);
            //向trolefuncs表中插入所有选中的功能模块id
            //方法：构造一个可插入多条记录的INSERT语句
            if (funcsLst.Count > 0)
            {
                string[] insLst = funcsLst.ConvertAll(
                    delegate (int n)
                    {
                        string s = roleId + "," + n;
                        return ClsQ.Q0(s, '(');
                    }).ToArray();
                string str = string.Join(",", insLst);
                string sql = "INSERT INTO trolefuncs (roleid, funcid) VALUES " + str;
                ClsMSSQL.ExecuteCmd(sql, ClsDBCon.ConStrKj);
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}