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

namespace ContainerFountain.ContainerInput
{
    public partial class FrmContainerFountainMX : Form
    {
        //�Զ�������
        private EnumNED NED;
        private DataGridView dgv;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        private static string container_no = "";//��ˮ�����
        public static string address = "";//��ˮ�����ڵ�ַ
        private int container_id = 0;//��ˮ��id
        private DSContainerFountain.tcontainer_statusRow container_statusRow;
        public FrmContainerFountainMX()
        {
            InitializeComponent();
        }

        public void prepare(EnumNED aNED, int ajgid, DataGridView adgv = null, int acontainer_id = 0)
        {

            //����
            dgv = adgv;
            NED = aNED;
            fillcmds();
            binding();
            container_id = acontainer_id;
            //����
            if (NED == EnumNED.NEW)
            {
                //������ˮ����¼ʱ����ˮ��״̬����¼������
                DSContainerFountain.tcontainerRow containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bdsContainer.AddNew()).Row;
                container_statusRow = (DSContainerFountain.tcontainer_statusRow)((DataRowView)bdsContainer_status.AddNew()).Row;
                //�������ݿ�Ĺ̶�����
                container_statusRow.gprs_signal = 1;
                container_statusRow.gprs_status = true;
                container_statusRow.upload_time = DateTime.Now;
                container_statusRow.status = true;
                container_statusRow.cash = 0;
                containerRow.jgid = ajgid;
                containerRow.record_time = DateTime.Now;
                txtcontainer_no.Enabled = true;
                return;
            }
            //��ϸ
            if (NED == EnumNED.DETAIL)
            {
                btnSave.Enabled = false;

            }
            //��ѯ�����
            tcontainerTableAdapter1.FillById(dsContainerFountain1.tcontainer, container_id);
            //��ѯ����״̬��
            tcontainer_statusTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_status, container_id);
            //�����ݸ�ֵ
            DSContainerFountain.tcontainerRow containerRow_current = (DSContainerFountain.tcontainerRow)((DataRowView)bdsContainer.Current).Row;
            container_no = containerRow_current.container_no;
            txtcontainer_no.Text = containerRow_current.container_no;
            txtcontainer_no.ReadOnly = true;
            textBox1.GotFocus -= new EventHandler(textBox1_GotFocus);
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region fillcmds()
        private void fillcmds()
        {
            fillCmbJgTree(cmbJgTree.Tree);
            fillcmbmodeltype();
            fillcmbscreen_type();
        }

        #region fillcmbscreen_type()
        private void fillcmbscreen_type()
        {
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='screen_type'");
            //��ѯ������
            ClsVWG.FillCmbBySQL(cmbscreen_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillcmbmodeltype()
        private void fillcmbmodeltype()
        {
            //��ѯ���
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='modeltype'");
            //��ѯ������
            ClsVWG.FillCmbBySQL(cmbmodeltype, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillCmbJgTree(TreeView trV)
        private void fillCmbJgTree(TreeView trV)
        {
            //��ѯ���
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1 in (3,4)
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";          //�ж�Ȩ��
            if (userRow.qx >= 1024)
            {
                //��ѯ���
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);

            }
            //��ȡ�������
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //��������
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string idFld, mcFld;
            //�����ݽ��б���
            foreach (DataRow r in dt.Rows)
            {
                //��ȡ��������Ϣ
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //������ȡ�����ı��
                for (int i = 1; i <= jb; i++)
                {
                    //z��trv�н�����ʾ
                    idFld = "id" + i;
                    tns = trV.Nodes.Find(r[idFld].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        //�����µ�
                        mcFld = "mc" + i;
                        tn = new TreeNode(r[idFld].ToString() + ":" + r[mcFld].ToString());
                        tn.Name = r[idFld].ToString();
                        tn.ImageIndex = 0;
                        tn.SelectedImageIndex = 1;
                        if (tp == null)
                            trV.Nodes.Add(tn);
                        else
                            tp.Nodes.Add(tn);
                        tp = tn;
                    }
                }
            }
        }

        #endregion

        #endregion

        #region binding()
        private void binding()
        {
            this.cmbmodeltype.DataBindings.Clear();
            this.cmbmodeltype.DataBindings.Add(new Binding("selectedValue", this.bdsContainer, "modeltype"
                , true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbscreen_type.DataBindings.Clear();
            this.cmbscreen_type.DataBindings.Add(new Binding("selectedValue", this.bdsContainer, "screen_type", true,
                DataSourceUpdateMode.OnPropertyChanged));
            this.cmbJgTree.DataBindings.Clear();
            this.cmbJgTree.DataBindings.Add(new Binding("SelectedValue", this.bdsContainer, "jgid", true,
                DataSourceUpdateMode.OnPropertyChanged));
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region �ж�������Ϣ�Ƿ����
                if (string.IsNullOrEmpty(txtcontainer_name.Text.Trim()) || string.IsNullOrEmpty(txtcontainer_no.Text.Trim())
                    || cmbmodeltype.SelectedIndex <= 0 || cmbscreen_type.SelectedIndex <= 0)
                {
                    //û��ֵ����
                    ClsMsgBox.Ts("����*���ŵ����Ϊ�������������д��");
                    //���ص�����
                    return;
                }
                //�жϱ�ŵ���Ϣ
                if (txtcontainer_no.Text == "")
                {
                    //����
                    ClsMsgBox.Ts("������ɨ�������");
                    //�رձ��
                    txtcontainer_no.Clear();
                    txtcontainer_no.Focus();
                    return;
                }
                #endregion
                //�ж��Ƿ��ǽ�������
                if (NED == EnumNED.NEW)
                {
                    //��ȡ�޸ĵ���Ϣ      
                    bdsContainer.EndEdit();
                    //�������ݿ����Ϣ
                    tcontainerTableAdapter1.Update(dsContainerFountain1.tcontainer);
                    //sql����ѯ���
                    string cmd = string.Format(@" SELECT id FROM tcontainer where container_no='{0}'", txtcontainer_no.Text);
                    //��ò�Ʒ�ı��
                    container_id = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                    //����Ÿ�ֵ
                    container_statusRow.container_id = container_id;
                    //�޸����ݿ����Ϣ
                    bdsContainer_status.EndEdit();
                    tcontainer_statusTableAdapter1.Update(dsContainerFountain1.tcontainer_status);

                    //tableAdapterManager1.UpdateAll(dScontainer1);

                }
                else
                {

                    //��ȡ�޸ĵ���Ϣ
                    bdsContainer_status.EndEdit();
                    //�޸����ݿ����Ϣ
                   tcontainer_statusTableAdapter1.Update(dsContainerFountain1.tcontainer_status);
                    //��ȡ�޸ĵ���Ϣ
                   bdsContainer.EndEdit();
                    //�޸����ݿ����Ϣ
                    tcontainerTableAdapter1.Update(dsContainerFountain1.tcontainer);
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }

            }
            catch (Exception ex)
            {
                //����쳣����Ϣ
                ClsMsgBox.Cw(ex.ToString());
            }

            //�жϷ��ص�����
            this.DialogResult = DialogResult.OK;
            string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
            ClsOplog.Oplog(userRow.id.ToString(), _type, "�Զ��ۻ�����Ϣ¼��", "������" + cmbJgTree.Text + "�������ƣ�" + txtcontainer_name.Text + "�����ţ�" + lblpay_parameter.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //�ر�bds����Ϣ
            bdsContainer.CancelEdit();
            //���������ǹر�
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtWaterFountain_no_LostFocus(object sender, EventArgs e)
        {
            //�жϻ������Ƿ�Ϊ��
            if (string.IsNullOrEmpty(txtcontainer_no.Text.Trim()))
            {
                //����
                return;
            }
         
            //�жϻ������Ƿ��ظ�
            #region �жϻ������Ƿ��ظ�
            //��ѯ��Ʒ�ı��
            string cmd = string.Format(@"select container_no from tcontainer");
            //��ȡ�����Ϣ
            DataTable dtWaterFountain_no = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //�����������
            foreach (DataRow dr in dtWaterFountain_no.Rows)
            {
                //��ȡ�����Ϣ
                //string a = dr[0].ToString();
                //�Ա�Ž����ж�
                if (txtcontainer_no.Text == dr[0].ToString())
                {
                    //�Ա�Ž����Ƴ�
                    txtcontainer_no.Focus();
                    txtcontainer_no.Clear();
                    //����
                    ClsMsgBox.Ts("ɨ���������ظ���");
                    //����Ÿ�ֵ
                    container_no = "";
                    return;
                }
            }
            #endregion
            //����ά���Ž��и�ֵ
            lblpay_parameter.Text = txtcontainer_no.Text;
            //��ȡ�������
            DSContainerFountain.tcontainerRow containerRow_current = (DSContainerFountain.tcontainerRow)((DataRowView)bdsContainer.Current).Row;
            //�����е����ݽ��и�ֵ
            containerRow_current.container_no = txtcontainer_no.Text;
            containerRow_current.pay_parameter = txtcontainer_no.Text;
        }
    }
   


}
