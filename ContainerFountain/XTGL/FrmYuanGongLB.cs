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
using ContainerFountain.Datasets;
using DLTLib.Classes;

#endregion

namespace ContainerFountain.XTGL
{
    public partial class FrmYuanGongLB : UserControl
    {
         DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;
        int id;
        public FrmYuanGongLB()
        {
            InitializeComponent();
        }

        private void FrmYuanGongLB_Load(object sender, EventArgs e)
        {
            Prepare();
        }
        #region Prepare()
        public void Prepare()
        {
            fillCmbPx();

            createJgTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            tjigouTableAdapter1.Fill(dSedid1.tjigou);
            trolesTableAdapter1.Fill(dSedid1.troles);
            tygTableAdapter1.Fill(dSedid1.tyg);
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "Ա������", "");
        }
        private void createJgTree()
        {
            int cj = 0;
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0, id1, mc1, id2, mc2,
       id3, mc3, id4, mc4, id5, mc5,
       id6, mc6
FROM vjigoua 
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            if (userRow.qx >= 1024)
            {
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[5] = string.Format(@"where id{0} ={1}", userRow.jgjb, userRow.jgid);
                cmd = string.Join(Environment.NewLine, cmds);
                cj = userRow.jgjb;
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
                for (int i = cj; i <= jb; i++)
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
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            return tn;
        }
        private void fillCmbPx()
        {
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            lst.Add(new ClsBhMcString("xm", "����"));
            lst.Add(new ClsBhMcString("loginname", "�˻�"));
            cmbPx.DataSource = lst;
            cmbPx.DisplayMember = "Mc";
            cmbPx.ValueMember = "bh";
            cmbPx.SelectedIndex = 0;
        }
        #endregion
        #region createTableAndRelation() ��gw��xl�������
        private void createTableAndRelation()
        {
            string cmd;
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='gw' ORDER BY dm";
            DataTable dtGw = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmd = "SELECT dm,mc FROM toptionxm WHERE lbdm='xl' ORDER BY dm";
            DataTable dtXl = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            dSedid1.Tables.Add(dtGw);
            dSedid1.Tables.Add(dtXl);

            DataRelation rel;
            rel = new DataRelation("yg_gw", dtGw.Columns["dm"], dSedid1.tyg.gwColumn);
            dSedid1.Relations.Add(rel);
            rel = new DataRelation("yg_xl", dtXl.Columns["dm"], dSedid1.tyg.xlColumn);
            dSedid1.Relations.Add(rel);
            //����������еı��ʽExpression
            dSedid1.tyg.gwsColumn.Expression = "Parent(yg_gw).mc";
            dSedid1.tyg.xlsColumn.Expression = "Parent(yg_xl).mc";
        }
        #endregion

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sWhere = "";
            //�ж����ڵ�����ֲ�Ϊ��
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                //ת���ַ�����
                int jgidid = Convert.ToInt32(e.Node.Name);
                //��ѯ�������
                string cmd = string.Format(@"select jb from vjigoua where id={0}", jgidid);
                //ת���ַ�����
                int jb = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                //��ѯ���
                string cmdvjigoua = string.Format(@"select id from vjigoua where id{0}={1}", jb, jgidid);
                //��ѯ��ͼ�е�����
                DataTable dt = ClsMSSQL.GetDataTable(cmdvjigoua, ClsDBCon.ConStrKj);
                //��������
                foreach (DataRow dr in dt.Rows)
                {
                    //�ж�����
                    if (dr == dt.Rows[0])
                    {
                        //���Ӳ�ѯ���
                        sWhere += string.Format(@" where (jgid='{0}') ", dr[0]);
                    }
                    else
                    {
                        //���Ӳ�ѯ���
                        sWhere += string.Format(@" or (jgid='{0}') ", dr[0]);
                    }
                }
                //��ѯ���������Ϣ
                tjigouTableAdapter1.Fill(dSedid1.tjigou);
                trolesTableAdapter1.Fill(dSedid1.troles);
                tygTableAdapter1.FillByWhere(dSedid1.tyg, sWhere);
            }
          }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.NEW, bds, dSedid1, tygTableAdapter1, dgv, Int32.Parse(trV.SelectedNode.Name));
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.EDIT, bds, dSedid1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //���ݱ�Ϊ��ʱ��ִ�б�����
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("ȷ��Ҫɾ���ü�¼��", deleting);
        }

        #region deleting() ɾ��ʱ�Ļص�����
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "Ա������", dgv.Rows[a].Cells[1].Value.ToString() + " " + dgv.Rows[a].Cells[2].Value.ToString());
                bds.RemoveCurrent();
                tygTableAdapter1.Update(dSedid1.tyg);
                ClsD.TurnDgvToBdsCurrRec(dgv);
            }
        }
        #endregion

        private void Frm_closed(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(trV.SelectedNode.Name))
            {
                id = Int32.Parse(trV.SelectedNode.Name);
                string sWhere = string.Format("WHERE jgid={0} ORDER BY {1}", id, cmbPx.SelectedValue);
                tygTableAdapter1.FillByWhere(dSedid1.tyg, sWhere);
            }
            else
            {
                tygTableAdapter1.Fill(dSedid1.tyg);
            }
        }

        private void filltygDgv(object sender, EventArgs e)
        {
            tjigouTableAdapter1.Fill(dSedid1.tjigou);
            trolesTableAdapter1.Fill(dSedid1.troles);
            tygTableAdapter1.Fill(dSedid1.tyg);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            txtXm.Text = txtXm.Text.Trim();
            string sWhere = string.Format(@"
 WHERE  jgid = {2} and  xm LIKE '%{0}%'OR loginname LIKE '%{0}%' ORDER BY {1}", txtXm.Text, cmbPx.SelectedValue, id);
            tygTableAdapter1.FillByWhere(dSedid1.tyg, sWhere);

            //ClsOplog.Oplog(userRow.id.ToString(), "60", "Ա������", trV.SelectedNode.Text + "," + txtXm.Text);
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            FrmYgPie f = new FrmYgPie();
            f.Prepare();
            f.ShowDialog();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FrmYgTjtb f = new FrmYgTjtb();
            f.Prepare();
            f.ShowDialog();
        }
    }
}