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
                //��ʾ���е�����
                trV.ExpandAll();
                //��ʾ���еĽڵ���
                trV.SelectedNode = trV.Nodes[0];
            }
            vNumberQueryTableAdapter1.Fill(dsNumberQuery1.vNumberQuery);
        }
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

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //��ȡ���е�����
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                string sWhere = string.Format("where  id{0}={1}", e.Node.Tag, e.Node.Name);

               vNumberQueryTableAdapter1.FillByWhere(dsNumberQuery1.vNumberQuery, sWhere);
                
            }
            #region �������ֵ
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