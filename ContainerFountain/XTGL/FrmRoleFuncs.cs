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
        #region �Զ������
        private int roleId;
        private List<int> funcsLst;
        #endregion
        public FrmRoleFuncs()
        {
            InitializeComponent();
        }

        #region Prepare(int aRoleId, string aRoleMc) ������û��ؼ��ĳ�ʼ�����ⲿ��������ʹ�ù��е�Prepare����ʵ�֡�
        public void Prepare(int aRoleId, string aRoleMc)
        {
            roleId = aRoleId;
            this.Text += "��" + aRoleMc;
            funcsLst = getFuncsList(roleId);
            createFuncTree();
            trV.ExpandAll();
        }
        #endregion

        #region getFuncsList(int aRoleId) ��ȡ������ɫ�����й���ģ��id
        // <summary>
        /// ��ȡ������ɫ�����й���ģ��id
        /// </summary>
        /// <param name="aRoleId"></param>
        /// <returns></returns>
        private List<int> getFuncsList(int aRoleId)
        {
            string cmd = "SELECT funcid FROM trolefuncs WHERE roleid = " + roleId;
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //ʹ��Linq��DataTable�е�����������funcidת��Ϊһ��������List<int>
            List<int> lst = (from r in dt.AsEnumerable() select r.Field<int>("funcid")).ToList<int>();
            return lst;
        }
        #endregion

        #region createFuncTree()����������
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
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        tn = createANode(r, i);
                        if (tp == null)
                            trV.Nodes.Add(tn);//��trV�ؼ���ӽڵ�
                        else
                            tp.Nodes.Add(tn);//�򸸽ڵ�tp����ӽڵ�
                    }
                }
            }
        }
        #endregion

        #region createANode(DataRow r, int jb)�����ڵ㺯��
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            tn.CheckBox = CheckBoxVisibility.True;
            tn.Checked = funcsLst.Contains(Convert.ToInt32(r[id]));
            return tn;
        }
        #endregion

        #region getAllCheckedIds(TreeNode pNode) �ݹ�ػ�ø����������ѡ�е�ĩ�����ڵ�(������ģ��)��id�б�
        /// <summary>
        /// �ݹ�ػ�ø����������ѡ�е�ĩ�����ڵ�(������ģ��)��id�б�
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

            //�������ѡ�е�ĩ�����ڵ�(������ģ��)��id�б�
            funcsLst.Clear();
            foreach (TreeNode node in trV.Nodes)
                getAllCheckedIds(node);
            //ɾ����ǰ��ɫ��ԭ�еĹ���ģ��
            trolefuncsTableAdapter trolefuncsTableAdapter1 = new trolefuncsTableAdapter();
            trolefuncsTableAdapter1.DeleteByRoleId(roleId);
            //��trolefuncs���в�������ѡ�еĹ���ģ��id
            //����������һ���ɲ��������¼��INSERT���
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