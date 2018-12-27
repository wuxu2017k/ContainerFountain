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
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "员工管理", "");
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
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            return tn;
        }
        private void fillCmbPx()
        {
            List<ClsBhMcString> lst = new List<ClsBhMcString>();
            lst.Add(new ClsBhMcString("xm", "姓名"));
            lst.Add(new ClsBhMcString("loginname", "账户"));
            cmbPx.DataSource = lst;
            cmbPx.DisplayMember = "Mc";
            cmbPx.ValueMember = "bh";
            cmbPx.SelectedIndex = 0;
        }
        #endregion
        #region createTableAndRelation() 对gw、xl建立外键
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
            //设置新添加列的表达式Expression
            dSedid1.tyg.gwsColumn.Expression = "Parent(yg_gw).mc";
            dSedid1.tyg.xlsColumn.Expression = "Parent(yg_xl).mc";
        }
        #endregion

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string sWhere = "";
            //判断树节点的名字不为空
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                //转换字符类型
                int jgidid = Convert.ToInt32(e.Node.Name);
                //查询机构语句
                string cmd = string.Format(@"select jb from vjigoua where id={0}", jgidid);
                //转换字符类型
                int jb = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                //查询语句
                string cmdvjigoua = string.Format(@"select id from vjigoua where id{0}={1}", jb, jgidid);
                //查询视图中的数据
                DataTable dt = ClsMSSQL.GetDataTable(cmdvjigoua, ClsDBCon.ConStrKj);
                //遍历数据
                foreach (DataRow dr in dt.Rows)
                {
                    //判断数据
                    if (dr == dt.Rows[0])
                    {
                        //增加查询语句
                        sWhere += string.Format(@" where (jgid='{0}') ", dr[0]);
                    }
                    else
                    {
                        //增加查询语句
                        sWhere += string.Format(@" or (jgid='{0}') ", dr[0]);
                    }
                }
                //查询机构表的信息
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
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.EDIT, bds, dSedid1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            FrmYuanGongXX f = new FrmYuanGongXX();
            f.Prepare(EnumNED.DETAIL, bds, dSedid1, tygTableAdapter1, dgv);
            f.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //数据表为空时不执行本操作
            if (bds.Current == null)
                return;
            ClsMsgBox.YesNo("确定要删除该记录吗？", deleting);
        }

        #region deleting() 删除时的回调函数
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                int a = dgv.CurrentRow.Index;
                ClsOplog.Oplog(userRow.id.ToString(), "50", "员工管理", dgv.Rows[a].Cells[1].Value.ToString() + " " + dgv.Rows[a].Cells[2].Value.ToString());
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

            //ClsOplog.Oplog(userRow.id.ToString(), "60", "员工管理", trV.SelectedNode.Text + "," + txtXm.Text);
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