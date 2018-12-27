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

namespace ContainerFountain.XTGL
{
    public partial class FrmMKGL : UserControl
    {
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        private EnumNED NED;
        private int rootId;
        public FrmMKGL()
        {
            InitializeComponent();
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
                if (tn.Parent == null)
                {
                    trV.Nodes.Remove(tn);
                }
                else
                {
                    tn.Parent.Nodes.Remove(tn);
                }
                trV.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXh.Text))
            {
                ClsMsgBox.Jg("��Ų���Ϊ�գ�");
                txtXh.Focus();
                return;
            }
            if (!ClsReg.NaturalNum.IsMatch(txtXh.Text))
            {
                ClsMsgBox.Jg("��ű���Ϊ���֣�");
                txtXh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMc.Text))
            {
                ClsMsgBox.Jg("���Ʋ���Ϊ�գ�");
                txtMc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtBm.Text))
            {
                ClsMsgBox.Jg("���벻��Ϊ�գ�");
                txtBm.Focus();
                return;
            }
            bds.EndEdit();
            ClsD.TextBoxTrim(grpMain);
            try
            {
                tfuncsTableAdapter1.Update(dSedid1.tfuncs);
                trV.SelectedNode.Name = lblId.Text;
                trV.SelectedNode.Text = txtMc.Text;
                trV.SelectedNode.Tag = txtBm.Text;
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
                //��ȡ�Ҽ��˵�����Ϣ��
                //string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
                ClsOplog.Oplog(userRow.id.ToString(), _type, "ģ�����", "ģ�����ƣ�" + txtMc.Text);
            }
            catch (Exception ex)
            {
                ClsMsgBox.Cw("����ģ����Ϣʱ���������´���", ex);
            }
        }

        private void FrmMKGL_Load(object sender, EventArgs e)
        {
            Prepare();
        }

        #region Prepare() ������û��ؼ��ĳ�ʼ�����ⲿ��������ʹ�ù��е�Prepare����ʵ�֡�
        public void Prepare()
        {
            string cmd = "SELECT id FROM tfuncs WHERE bm = 'root'";
            rootId = Convert.ToInt32(ClsMSSQL.GetValue(cmd, ClsDBCon.ConStrKj));
            createFuncTree();
            if (trV.Nodes.Count > 0)
            {
                trV.ExpandAll();
                trV.SelectedNode = trV.Nodes[0];
            }
            // ClsOplog.Oplog(userRow.id.ToString(), "20", "ģ�����", "");
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

        #region createANode(DataRow r, int jb)�������ڵ㺯��
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            tn.Tag = r[bm].ToString();
            return tn;
        }
        #endregion

        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Node.Name))
            {
                int id = Int32.Parse(e.Node.Name);
                tfuncsTableAdapter1.FillById(dSedid1.tfuncs, id);
            }
        }

        private void mnuNewBrother_Click(object sender, EventArgs e)
        {
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            if (trV.SelectedNode.Level == 0)
                trV.Nodes.Add(tn);
            else
                trV.SelectedNode.Parent.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSedid1.tfuncs.Rows.Clear();
            DSedid.tfuncsRow r = (DSedid.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1);
            r.pid = tn.Level == 0 ? rootId : Int32.Parse(tn.Parent.Name);
        }

        private void mnuNewChild_Click(object sender, EventArgs e)
        {
            if (trV.SelectedNode.Level == 4)
            {
                ClsMsgBox.Jg("ģ���β�������5����");
                return;
            }
            trV.Enabled = false;
            TreeNode tn = new TreeNode("*");
            trV.SelectedNode.Nodes.Add(tn);
            trV.SelectedNode = tn;
            dSedid1.tfuncs.Rows.Clear();
            DSedid.tfuncsRow r = (DSedid.tfuncsRow)((DataRowView)bds.AddNew()).Row;
            r.jb = Convert.ToByte(trV.SelectedNode.Level + 1);
            r.pid = Int32.Parse(tn.Parent.Name);
        }

        private void mnuDel_Click(object sender, EventArgs e)
        {
            string is_success = "ʧ�ܣ�";
            string info = "";
            if (trV.SelectedNode.HasNodes)
                ClsMsgBox.Jg("����㲻��ĩ�˽�㣬������ɾ����");
            else
            {
                ClsMsgBox.YesNo("ȷʵҪɾ����ǰģ����", deleting);
                is_success = "�ɹ���";
            }
            if (trV.SelectedNode.Level <= 5)
                info = trV.SelectedNode.Parent.Text + " �µ� " + trV.SelectedNode.Text;
            if (trV.SelectedNode.Level == 6)
                info = trV.SelectedNode.Parent.Parent.Text + " �µ� " + trV.SelectedNode.Parent.Text + "�µ�" + trV.SelectedNode.Text;

            string sss = trV.SelectedNode.Parent.Text;
            ClsOplog.Oplog(userRow.id.ToString(), "50", "ģ�����", "ģ�����ƣ�" + info + "," + is_success);
        }

        #region deleting(object sender, EventArgs e) ɾ����ǰģ��ʱ�Ļص�����
        private void deleting(object sender, EventArgs e)
        {
            DialogResult dr = ((Form)sender).DialogResult;
            if (dr == DialogResult.Yes)
            {
                //ɾ�����ݿ��е�ģ���¼
                string cmd = string.Format("DELETE FROM tfuncs WHERE id = {0}", trV.SelectedNode.Name);
                int rows = ClsMSSQL.ExecuteCmd(cmd, ClsDBCon.ConStrKj);
                if (rows != 1)
                {
                    string s = string.Format("ɾ��ģ�������Ӱ��ļ�¼����{0}��Ϊ1��", rows);
                    ClsMsgBox.Cw(s);
                }
                else
                {
                    //ɾ��ģ�����еĽ��
                    TreeNode tn = trV.SelectedNode;
                    TreeNode tm = tn.NextNode != null ? tn.NextNode :
                        tn.PrevNode != null ? tn.PrevNode : tn.Parent;
                    trV.SelectedNode = tm;
                    if (tn.Level == 0)
                        trV.Nodes.Remove(tn);
                    else
                        tn.Parent.Nodes.Remove(tn);
                }
            }
        }
        #endregion
    }

}