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
    public partial class FrmJGGL : UserControl
    {
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        bool is_new = false;
        string bmlx = "";
        public FrmJGGL()
        {
            InitializeComponent();
        }

        private void FrmJGGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        #region Prepare() 窗体或用户控件的初始化及外部参数传入使用公有的Prepare函数实现。
        public void Prepare()
        {
            fillCmbs();
            createJgTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "机构管理", "");
        }
        #endregion

        #region 为ComboBox填充下拉选项
        private void fillCmbs()
        {
            fillCmbBmlx();
        }
        private void fillCmbBmlx()
        {
            string cmd = @"select dm,mc,dmmc from voptionxm where lbdm='bmlx' order by dm";
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            cmbBmlx.DataSource = dt;
            cmbBmlx.DisplayMember = "dmmc";
            cmbBmlx.ValueMember = "dm";

        }
        #endregion
        #region createJgTree()创建树函数
        private void createJgTree()
        {
            int cj = 0;
            string cmd = @"
SELECT id, mc,jb,
       id0, mc0,id1, mc1, id2, mc2,
       id3, mc3,id4, mc4, id5, mc5,
       id6, mc6
FROM vjigoua
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            if (userRow.qx >= 1024)
            {
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                if (userRow.roleid == 16)
                {
                    cmds[5] = string.Format(@"where id{0} in(select jgid from tmanager_jurisdiction where ygid ={1})
UNION ALL
SELECT id, mc,jb,
id0, mc0,id1, mc1, id2, mc2,
id3, mc3,id4, mc4, id5, mc5,
id6, mc6 
FROM vjigoua
WHERE id ={2}
ORDER BY jb", userRow.jgjb + 1, userRow.id, userRow.jgid);
                    //cj = userRow.jgjb + 1;
                }
                else
                {
                    cmds[5] = string.Format(@"where id{0} ={1}", userRow.jgjb, userRow.jgid);
                    cj = userRow.jgjb;
                }
                cj = userRow.jgjb;
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
        #endregion

        #region createANode(DataRow r, int jb)创建树节点函数
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            return tn;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("名称不可为空！");
                txtMc.Focus();
                return;
            }
            #endregion          
            try
            {
                bds.EndEdit();
                ClsD.TextBoxTrim(grpMain);
                tjigouTableAdapter1.Update(dSedid1.tjigou);
                trV.SelectedNode.Name = lblId.Text;
                trV.SelectedNode.Text = txtMc.Text;
                string _type;
                if (!trV.Enabled)
                {
                    trV.Enabled = true;
                    _type = "40";
                }
                else
                {
                    _type = "30";
                }
                ClsOplog.Oplog(userRow.id.ToString(), _type, "机构管理", "机构名称：" + txtMc.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("保存机构信息时遇到了如下错误：", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            //将暂存到dsJckja1.tfuncs中尚未写入数据库的内容恢复到编辑修改之前的值。
            dSedid1.tfuncs.RejectChanges();
            //如添加了新结点，则需要删除
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                tn.Parent.Nodes.Remove(tn);
                trV.Enabled = true;
            }
        }

      

        #region deleting(object sender, EventArgs e) 删除当前机构时的回调函数
        private void deleting(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = ((Form)sender).DialogResult;
                if (dr == DialogResult.Yes)
                {
                    string cmd = string.Format("delete from tjigou where id={0}", trV.SelectedNode.Name);
                    int rows = ClsMSSQL.ExecuteCmd(cmd, ClsDBCon.ConStrKj);
                    if (rows != 1)
                    {
                        string s = string.Format("删除机构命令影响的记录行数{0}不为1", rows);
                    }
                    else
                    {
                        TreeNode tn = trV.SelectedNode;
                        TreeNode tm = tn.NextNode != null ? tn.NextNode : tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                        trV.SelectedNode = tm;
                        if (tn.Level == 0)
                            trV.Nodes.Remove(tn);
                        else
                            tn.Parent.Nodes.Remove(tn);
                    }
                }
            }
            catch (Exception ex)
            {
                ClsMsgBox.Jg("无法删除该机构");
            }
        }
        #endregion

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 0)
            {
                ClsMsgBox.Jg("不允许为根结点添加同级结点。");
                return;
            }
            is_new = true;
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;   //将新加的结点设为当前的选中结点。
            dSedid1.tjigou.Rows.Clear();
            //先用bds.AddNew()为dsJckja1.tjigou表添加一行,而(DSJckj.tjigouRow)((DataRowView)bds.AddNew()).Row获取新加的行对象
           DSedid.tjigouRow r = (DSedid.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level);
            r.pid = Int32.Parse(tn.Parent.Name);

            if (bmlx == "C")
                cmbBmlx.SelectedValue = "C";
            if (bmlx == "H")
                cmbBmlx.SelectedValue = "H";
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 8)
            {
                ClsMsgBox.Jg("机构层次不允许超过8层");
                return;
            }

            is_new = true;
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSedid1.tjigou.Rows.Clear();
            DSedid.tjigouRow r = (DSedid.tjigouRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level);
            r.pid = Int32.Parse(tn.Parent.Name);

            if (bmlx == "C")
                cmbBmlx.SelectedValue = "C";
            if (bmlx == "H")
                cmbBmlx.SelectedValue = "H";
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            string is_success = "失败！";
            string info = "";
            if (trV.SelectedNode.Level == 0)
                ClsMsgBox.Jg("本结点为根结点，不允许删除！");
            else if (trV.SelectedNode.HasNodes)  //当前结点含有下级结点
                ClsMsgBox.Jg("本节点不是末节点,不允许删除！");
            else
            {
                ClsMsgBox.YesNo("确定要删除当前机构吗？", deleting);
                is_success = "成功！";
            }
            if (trV.SelectedNode.Level <= 5)
                info = trV.SelectedNode.Parent.Text + " 下的 " + trV.SelectedNode.Text;
            if (trV.SelectedNode.Level == 6)
                info = trV.SelectedNode.Parent.Parent.Text + " 下的 " + trV.SelectedNode.Parent.Text + "下的" + trV.SelectedNode.Text;

            string sss = trV.SelectedNode.Parent.Text;
            ClsOplog.Oplog(userRow.id.ToString(), "50", "机构管理", "机构名称：" + info + "," + is_success);
        }

        private void trV_AfterCheck(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            foreach (TreeNode item in node.Nodes)
            {
                item.Checked = e.Node.Checked;
            }
        }

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                int id = Int32.Parse(e.Node.Name);
                tjigouTableAdapter1.FillById(dSedid1.tjigou, id);
                bmlx = cmbBmlx.Text.Substring(0,1).ToUpper();
            }
        }
    }
}