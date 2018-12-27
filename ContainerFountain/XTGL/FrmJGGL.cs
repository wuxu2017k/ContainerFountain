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

        #region Prepare() ������û��ؼ��ĳ�ʼ�����ⲿ��������ʹ�ù��е�Prepare����ʵ�֡�
        public void Prepare()
        {
            fillCmbs();
            createJgTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "��������", "");
        }
        #endregion

        #region ΪComboBox�������ѡ��
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
        #region createJgTree()����������
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

        #region createANode(DataRow r, int jb)�������ڵ㺯��
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
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
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
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
                ClsOplog.Oplog(userRow.id.ToString(), _type, "��������", "�������ƣ�" + txtMc.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("���������Ϣʱ���������´���", ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bds.CancelEdit();
            //���ݴ浽dsJckja1.tfuncs����δд�����ݿ�����ݻָ����༭�޸�֮ǰ��ֵ��
            dSedid1.tfuncs.RejectChanges();
            //��������½�㣬����Ҫɾ��
            if (!trV.Enabled)
            {
                TreeNode tn = trV.SelectedNode;
                TreeNode tm = tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                trV.SelectedNode = tm;
                tn.Parent.Nodes.Remove(tn);
                trV.Enabled = true;
            }
        }

      

        #region deleting(object sender, EventArgs e) ɾ����ǰ����ʱ�Ļص�����
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
                        string s = string.Format("ɾ����������Ӱ��ļ�¼����{0}��Ϊ1", rows);
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
                ClsMsgBox.Jg("�޷�ɾ���û���");
            }
        }
        #endregion

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 0)
            {
                ClsMsgBox.Jg("������Ϊ��������ͬ����㡣");
                return;
            }
            is_new = true;
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;   //���¼ӵĽ����Ϊ��ǰ��ѡ�н�㡣
            dSedid1.tjigou.Rows.Clear();
            //����bds.AddNew()ΪdsJckja1.tjigou�����һ��,��(DSJckj.tjigouRow)((DataRowView)bds.AddNew()).Row��ȡ�¼ӵ��ж���
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
                ClsMsgBox.Jg("������β�������8��");
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
            string is_success = "ʧ�ܣ�";
            string info = "";
            if (trV.SelectedNode.Level == 0)
                ClsMsgBox.Jg("�����Ϊ����㣬������ɾ����");
            else if (trV.SelectedNode.HasNodes)  //��ǰ��㺬���¼����
                ClsMsgBox.Jg("���ڵ㲻��ĩ�ڵ�,������ɾ����");
            else
            {
                ClsMsgBox.YesNo("ȷ��Ҫɾ����ǰ������", deleting);
                is_success = "�ɹ���";
            }
            if (trV.SelectedNode.Level <= 5)
                info = trV.SelectedNode.Parent.Text + " �µ� " + trV.SelectedNode.Text;
            if (trV.SelectedNode.Level == 6)
                info = trV.SelectedNode.Parent.Parent.Text + " �µ� " + trV.SelectedNode.Parent.Text + "�µ�" + trV.SelectedNode.Text;

            string sss = trV.SelectedNode.Parent.Text;
            ClsOplog.Oplog(userRow.id.ToString(), "50", "��������", "�������ƣ�" + info + "," + is_success);
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