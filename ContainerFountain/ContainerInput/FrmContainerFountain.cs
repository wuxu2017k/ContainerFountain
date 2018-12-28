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
using System.Data.SqlClient;

#endregion

namespace ContainerFountain.ContainerInput
{
    public partial class FrmContainerFountain : UserControl
    {
        DSedid.vusersRow userRow= VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        public FrmContainerFountain()
        {
            InitializeComponent();
        }

        #region Prepare()
        public void Prepare()
        {
            //����һ���жϣ��Ƿ������µ����ݣ��Զ����£���ȡ���µ����ݿ����Ϣ
            try
            {
                ////�ж��Ƿ���ڱ�,�����ɾ��
                //if (dSwaterFountain1.Tables.Contains("dtmodeltype"))
                //{
                //    dSwaterFountain1.Tables.Remove("dtmodeltype");
                //}
                //if (dSwaterFountain1.Tables.Contains("dtscreen_type"))
                //{
                //    dSwaterFountain1.Tables.Remove("dtscreen_type");
                //}
                //if (dSwaterFountain1.Relations.Contains("relmodeltype"))
                //{
                //    dSwaterFountain1.Relations.Remove("relmodeltype");
                //}
                //if (dSwaterFountain1.Relations.Contains("relscreen_type"))
                //{
                //    dSwaterFountain1.Relations.Remove("relscreen_type");
                //}
                //if (dSwaterFountain1.Tables.Contains("dtcount"))
                //{
                //    dSwaterFountain1.Tables.Remove("dtcount");
                //}
                //if (dSwaterFountain1.Relations.Contains("relCount"))
                //{
                //    dSwaterFountain1.Relations.Remove("relCount");
                //}
                //��̬����ֵ
                CreateTableAndRelation();
                //����������
                createFuncTree();
                //�жϽڵ��Ƿ���ֵ
                if (trV.Nodes.Count > 0)
                {
                    //�����еĽڵ�
                    trV.ExpandAll();
                    //��ʾ�ڵ���
                    trV.SelectedNode = trV.Nodes[0];
                }
                //��ѯ���������Ϣ
                tjigouTableAdapter1.Fill(dsContainerFountain1.tjigou);
                //��ѯ����״̬�����Ϣ
                tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                //��ѯ��������Ϣ
               tcontainerTableAdapter1.Fill(dsContainerFountain1.tcontainer);
                //CreateTableAndRelation_count();            
            }
            catch (Exception ex)
            {
            }
        }

        #region createFuncTree()
        private void createFuncTree()
        {
            //��ѯ���
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1=3
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            //��ȡ�û���Ϣ�У�����û���������ȡnull
             DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
            //�ж��û��е�Ȩ��
            if (userRow.qx >= 1024)
            {
                //sql��� �ָ��ַ���
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                //��ȡ��ɫ����Ϣ
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                //�����ַ���
                cmd = string.Join(Environment.NewLine, cmds);
            }
            //�������ݱ����Ϣ
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //��������
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //�������ݱ����Ϣ
            foreach (DataRow r in dt.Rows)
            {
                //��ȡ����Ϊjb����Ϣ
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //��������
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    //������r[id].ToString()Ϊ�����Ҿ���ָ���������ڵ㣬����ѡ�������ӽڵ㣬����һ��list[]��
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //�ж����ڵ�ĳ���
                    if (tns.Length > 0)
                        //�����ڵ㸳ֵ
                        tp = tns[0];
                    else
                    {
                        //�����µĽڵ�
                        tn = createANode(r, i);
                        if (tp == null)
                            //��trV�ؼ���ӽڵ�
                            trV.Nodes.Add(tn);
                        else
                            //�򸸽ڵ�tp����ӽڵ�
                            tp.Nodes.Add(tn);
                        tp = tn;
                    }
                }
            }
        }

        #endregion

        #region  createANode()
        private TreeNode createANode(DataRow r, int jb)
        {
            string id = "id" + jb;
            string mc = "mc" + jb;
            //string bm = "bm" + jb;
            //ʹ��ָ�����ı���ʼ�� TreeNode �����ʵ����
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            //tn.Tag = r[bm].ToString();
            return tn;
        }
        #endregion

        #region CreateTableAndRelation()
        private void CreateTableAndRelation()
        {
            //sql����ȡ���룬���Ƶ���Ϣ
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm=@lbdm");
            //����һ��SqlParameter����һ�����������֣��ڶ�������ֵ
            SqlParameter paramodeltype = new SqlParameter("@lbdm", "modeltype");
            //��һ����Ľṹ�ٽ�һ����
            DataTable dtmodeltype = dsContainerFountain1.Tables.Add("dtmodel_type");
            //��ȡ�����Ϣ
            dtmodeltype = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, paramodeltype);
            //��ӱ����Ϣ
            dsContainerFountain1.Tables.Add(dtmodeltype);
            //��ӱ��ϵ
            DataRelation relmodel_type = new DataRelation("relmodel_type", dtmodeltype.Columns["dm"],dsContainerFountain1.tcontainer.Columns["modeltype"]);
            //����һ��SqlParameter����һ�����������֣��ڶ�������ֵ
            SqlParameter parascreen_type = new SqlParameter("@lbdm", "screen_type");
            //����һ���µı�
            DataTable dtscreen_type = dsContainerFountain1.Tables.Add("dtscreen_type");
            //��ѯ�������
            dtscreen_type = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, parascreen_type);
            //���������Ϣ
            dsContainerFountain1.Tables.Add(dtscreen_type);
            //��ӱ��ϵ
            DataRelation relscreen_type = new DataRelation("relscreen_type", dtscreen_type.Columns["dm"], dsContainerFountain1.tcontainer.Columns["screen_type"]);
            //���ݼ���ӹ�ϵ
            dsContainerFountain1.Relations.Add(relmodel_type);
            dsContainerFountain1.Relations.Add(relscreen_type);
            //�����ݼ��е���Ϣ��ֵ
            dsContainerFountain1.tcontainer.model_type_nameColumn.Expression = "Parent(relmodel_type).mc";
            dsContainerFountain1.tcontainer.screen_type_nameColumn.Expression = "Parent(relscreen_type).mc";
        }
        #endregion

        #endregion

        #region trV_AfterSelect()
        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Sql���
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
                tjigouTableAdapter1.Fill(dsContainerFountain1.tjigou);
                //��ѯ��������Ϣ
                tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                tcontainerTableAdapter1.FillByWhere(dsContainerFountain1.tcontainer, sWhere);
            }
            }

        #endregion

        #region ���ܰ���

        #region ����
        private void btnNew_Click(object sender, EventArgs e)
        {
            //�ж��Ƿ�ѡ�������������
            if (string.IsNullOrEmpty(trV.SelectedNode.Name))
            {
                ClsMsgBox.Ts("��ѡ���������");
                return;
            }
            //��ȡ������ת����������
            //int jgid = Convert.ToInt32(trV.SelectedNode);
            int jgid = Convert.ToInt32(trV.SelectedNode.Name);
            //�����µ�ģ��
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //����ģ���еķ���
            f.prepare(EnumNED.NEW, jgid, dgv);
            //��ʾģ��
            f.ShowDialog();
            //�ر�ģ��
            f.Closed += new EventHandler(frmClosed);
        }

        #region frmClosed()
        private void frmClosed(object sender, EventArgs e)
        {
            //��������
            string sWhere = "";
            //�ж��Ƿ�ѡ�������������
            if (!string.IsNullOrEmpty(trV.SelectedNode.Name))
            {
                //��ȡѡȡ�Ļ�������Ϣת����������
                int jgidid = Convert.ToInt32(trV.SelectedNode.Name);
                //��ѯ�������Ʋ�ѯ������id����Ϣ
                string cmd = string.Format(@"select jb from vjigoua where id={0}", jgidid);
                //��ȡ��������Ϣת����������
                int jb = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                //��ѯ��ͼ�е����ݵ�id
                string cmdvjigoua = string.Format(@"select id from vjigoua where id{0}={1}", jb, jgidid);
                //���ر����ݲ�ѯ���
                DataTable dt = ClsMSSQL.GetDataTable(cmdvjigoua, ClsDBCon.ConStrKj);
                //����������
                foreach (DataRow dr in dt.Rows)
                {
                    //�ж����ݵ���Ϣ
                    if (dr == dt.Rows[0])
                    {

                        //�������Ĳ�ѯ����
                        sWhere += string.Format(@" where (jgid='{0}') ", dr[0]);
                    }
                    else
                    {

                        //�������Ĳ�ѯ����
                        sWhere += string.Format(@" or (jgid='{0}') ", dr[0]);
                    }
                }
                //��ѯ����״̬�����Ϣ
               tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                //��ѯ��������Ϣ
                tcontainerTableAdapter1.FillByWhere(dsContainerFountain1.tcontainer, sWhere);
            }
        }
        #endregion

        #endregion

        #endregion

        #region �༭
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //�ж�Dgv����ļ�����ֵ�Ƿ�Ϊ��
            if (dgv.CurrentRow == null)
            {
                //����������
                ClsMsgBox.Ts("��ѡ����ˮ���б��е�һ�����ݣ�");
                return;
            }
            //��dgv�е�ֵ����ת���ַ�����
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            int container_id = tmp_containerRow.id;
            int jgid = tmp_containerRow.jgid;
            //�����µ�ģ��
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //����ģ���еķ���
            f.prepare(EnumNED.EDIT, jgid, dgv, container_id);
            //��ʾ����
            f.ShowDialog();
            //�ر�ģ��
            f.Closed += new EventHandler(frmClosed);
        }
        #endregion

        #region ��ϸ
        private void btnDetail_Click(object sender, EventArgs e)
        {
            //�ж�dgv�ļ����Ƿ�Ϊ��
            if (dgv.CurrentRow == null)
            {
                //����������
                ClsMsgBox.Ts("��ѡ������б��е�һ�����ݣ�");
                return;
            }
            //����ֵ�����ַ�����ת����dgv��ֵ
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            int container_id = tmp_containerRow.id;
            int jgid = tmp_containerRow.jgid;
            //�����µ�ģ��
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //����ģ���еķ���
            f.prepare(EnumNED.DETAIL, jgid, dgv, container_id);
            //��ʾ����
            f.ShowDialog();
            //�رմ���
            f.Closed += new EventHandler(frmClosed);
        }

        #endregion

        #region ɾ��
        private void btnDel_Click(object sender, EventArgs e)
        {
            //��������ݲ�Ϊ��
            if (dgv.SelectedRows != null)
            {
                //����������ɾ���ķ���
                ClsMsgBox.YesNo("ȷ��Ҫɾ����", deleting);
            }
        }

        private void deleting(object sender, EventArgs e)
        {
          
            DialogResult dr = ((Form)sender).DialogResult;
            //�жϷ�������
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //�Ƴ�dgv������ѡ�е�����
                    // dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
                    bds.RemoveCurrent();
                 
                    tcontainerTableAdapter1.Update(dsContainerFountain1.tcontainer);
                }
                catch (Exception ex)
                {
                }
            }
        }

        #endregion

        private void btnproduct_Click(object sender, EventArgs e)
        {
            //�ж��Ƿ���Dgv�е�����
            if (bds.Current == null)
            {
                //��������
                ClsMsgBox.Ts("��ѡ����ˮ���б��е�һ�����ݣ�");
                return;
            }
            DSContainerFountain.tcontainerRow tmp_containerRow= (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            FrmContainerPrice f = new FrmContainerPrice();
            f.ShowDialog();
            f.prepare(tmp_containerRow.id,tmp_containerRow.container_no);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //�ж��Ƿ���Dgv�е�����
            if (bds.Current == null)
            {
                //��������
                ClsMsgBox.Ts("��ѡ����ˮ���б��е�һ�����ݣ�");
                return;
            }
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            FrmRepair f = new FrmRepair();
            f.ShowDialog();
            f.prepare(tmp_containerRow.id, tmp_containerRow.container_no);
        }
    }
}