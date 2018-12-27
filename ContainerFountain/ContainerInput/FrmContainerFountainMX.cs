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
        //自定义数据
        private EnumNED NED;
        private DataGridView dgv;
        DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
        private static string container_no = "";//饮水机编号
        public static string address = "";//饮水机所在地址
        private int container_id = 0;//饮水机id
        private DSContainerFountain.tcontainer_statusRow container_statusRow;
        public FrmContainerFountainMX()
        {
            InitializeComponent();
        }

        public void prepare(EnumNED aNED, int ajgid, DataGridView adgv = null, int acontainer_id = 0)
        {

            //定义
            dgv = adgv;
            NED = aNED;
            fillcmds();
            binding();
            container_id = acontainer_id;
            //新增
            if (NED == EnumNED.NEW)
            {
                //新增饮水机记录时向饮水机状态表中录入数据
                DSContainerFountain.tcontainerRow containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bdsContainer.AddNew()).Row;
                container_statusRow = (DSContainerFountain.tcontainer_statusRow)((DataRowView)bdsContainer_status.AddNew()).Row;
                //定义数据库的固定数据
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
            //详细
            if (NED == EnumNED.DETAIL)
            {
                btnSave.Enabled = false;

            }
            //查询货柜表
            tcontainerTableAdapter1.FillById(dsContainerFountain1.tcontainer, container_id);
            //查询货柜状态表
            tcontainer_statusTableAdapter1.FillByContainer_id(dsContainerFountain1.tcontainer_status, container_id);
            //给数据赋值
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
            //查询表数据
            ClsVWG.FillCmbBySQL(cmbscreen_type, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillcmbmodeltype()
        private void fillcmbmodeltype()
        {
            //查询语句
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm='modeltype'");
            //查询表数据
            ClsVWG.FillCmbBySQL(cmbmodeltype, cmd, ClsDBCon.ConStrKj, true);
        }
        #endregion

        #region fillCmbJgTree(TreeView trV)
        private void fillCmbJgTree(TreeView trV)
        {
            //查询语句
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1 in (3,4)
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";          //判断权限
            if (userRow.qx >= 1024)
            {
                //查询语句
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                cmd = string.Join(Environment.NewLine, cmds);

            }
            //获取表的数据
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //声明变量
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string idFld, mcFld;
            //对数据进行遍历
            foreach (DataRow r in dt.Rows)
            {
                //获取机构的信息
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //遍历获取机构的编号
                for (int i = 1; i <= jb; i++)
                {
                    //z在trv中进行显示
                    idFld = "id" + i;
                    tns = trV.Nodes.Find(r[idFld].ToString(), true);
                    if (tns.Length > 0)
                        tp = tns[0];
                    else
                    {
                        //增加新的
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
                #region 判断所填信息是否可用
                if (string.IsNullOrEmpty(txtcontainer_name.Text.Trim()) || string.IsNullOrEmpty(txtcontainer_no.Text.Trim())
                    || cmbmodeltype.SelectedIndex <= 0 || cmbscreen_type.SelectedIndex <= 0)
                {
                    //没有值弹窗
                    ClsMsgBox.Ts("带（*）号的项均为必填项，请认真填写！");
                    //返回到界面
                    return;
                }
                //判断编号的信息
                if (txtcontainer_no.Text == "")
                {
                    //弹窗
                    ClsMsgBox.Ts("请重新扫码货柜编号");
                    //关闭编号
                    txtcontainer_no.Clear();
                    txtcontainer_no.Focus();
                    return;
                }
                #endregion
                //判断是否是进行新增
                if (NED == EnumNED.NEW)
                {
                    //获取修改的信息      
                    bdsContainer.EndEdit();
                    //更改数据库的信息
                    tcontainerTableAdapter1.Update(dsContainerFountain1.tcontainer);
                    //sql语句查询编号
                    string cmd = string.Format(@" SELECT id FROM tcontainer where container_no='{0}'", txtcontainer_no.Text);
                    //获得产品的编号
                    container_id = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                    //给编号赋值
                    container_statusRow.container_id = container_id;
                    //修改数据库的信息
                    bdsContainer_status.EndEdit();
                    tcontainer_statusTableAdapter1.Update(dsContainerFountain1.tcontainer_status);

                    //tableAdapterManager1.UpdateAll(dScontainer1);

                }
                else
                {

                    //获取修改的信息
                    bdsContainer_status.EndEdit();
                    //修改数据库的信息
                   tcontainer_statusTableAdapter1.Update(dsContainerFountain1.tcontainer_status);
                    //获取修改的信息
                   bdsContainer.EndEdit();
                    //修改数据库的信息
                    tcontainerTableAdapter1.Update(dsContainerFountain1.tcontainer);
                    ClsD.TurnDgvToBdsCurrRec(dgv);
                }

            }
            catch (Exception ex)
            {
                //输出异常的信息
                ClsMsgBox.Cw(ex.ToString());
            }

            //判断返回的类型
            this.DialogResult = DialogResult.OK;
            string _type = NED == EnumNED.NEW ? "40" : NED == EnumNED.EDIT ? "30" : "";
            ClsOplog.Oplog(userRow.id.ToString(), _type, "自动售货机信息录入", "机构：" + cmbJgTree.Text + "货柜名称：" + txtcontainer_name.Text + "货柜编号：" + lblpay_parameter.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //关闭bds的信息
            bdsContainer.CancelEdit();
            //返回类型是关闭
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtWaterFountain_no_LostFocus(object sender, EventArgs e)
        {
            //判断货柜编号是否为空
            if (string.IsNullOrEmpty(txtcontainer_no.Text.Trim()))
            {
                //返回
                return;
            }
         
            //判断货柜编号是否重复
            #region 判断货柜编号是否重复
            //查询产品的编号
            string cmd = string.Format(@"select container_no from tcontainer");
            //获取表的信息
            DataTable dtWaterFountain_no = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //遍历表的数据
            foreach (DataRow dr in dtWaterFountain_no.Rows)
            {
                //获取表的信息
                //string a = dr[0].ToString();
                //对编号进行判断
                if (txtcontainer_no.Text == dr[0].ToString())
                {
                    //对编号进行移除
                    txtcontainer_no.Focus();
                    txtcontainer_no.Clear();
                    //弹窗
                    ClsMsgBox.Ts("扫描货柜编码重复！");
                    //给编号赋值
                    container_no = "";
                    return;
                }
            }
            #endregion
            //给二维码编号进行赋值
            lblpay_parameter.Text = txtcontainer_no.Text;
            //获取表的数据
            DSContainerFountain.tcontainerRow containerRow_current = (DSContainerFountain.tcontainerRow)((DataRowView)bdsContainer.Current).Row;
            //给表中的数据进行赋值
            containerRow_current.container_no = txtcontainer_no.Text;
            containerRow_current.pay_parameter = txtcontainer_no.Text;
        }
    }
   


}
