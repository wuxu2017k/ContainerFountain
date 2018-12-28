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
            //增加一层判断，是否是最新的数据，自动更新，获取最新的数据库的信息
            try
            {
                ////判断是否存在表,如果有删除
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
                //动态绑定列值
                CreateTableAndRelation();
                //创建树函数
                createFuncTree();
                //判断节点是否有值
                if (trV.Nodes.Count > 0)
                {
                    //打开所有的节点
                    trV.ExpandAll();
                    //显示节点数
                    trV.SelectedNode = trV.Nodes[0];
                }
                //查询机构表的信息
                tjigouTableAdapter1.Fill(dsContainerFountain1.tjigou);
                //查询货柜状态表的信息
                tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                //查询货柜表的信息
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
            //查询语句
            string cmd = @"
SELECT id, mc, jb,
       id0, mc0,  id1, mc1, id2, mc2,
       id3, mc3, id4, mc4,  id5, mc5, id6,mc6
FROM vjigoua 
WHERE jb > 0 AND id1=3
ORDER BY xh0, xh1, xh2, xh3, xh4, xh5,xh6
";
            //获取用户信息行，如果用户不存在则取null
             DSedid.vusersRow userRow = VWGContext.Current.Session["userRow"] as DSedid.vusersRow;
            //判断用户行的权限
            if (userRow.qx >= 1024)
            {
                //sql语句 分割字符串
                string[] cmds = cmd.Split(new string[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                //获取角色的信息
                cmds[4] = string.Format(@"WHERE id IN 
(SELECT funcid FROM trolefuncs WHERE roleid = {0})", userRow.roleid);
                //加入字符串
                cmd = string.Join(Environment.NewLine, cmds);
            }
            //返回数据表的信息
            DataTable dt = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj);
            //声明变量
            TreeNode tn, tp;
            TreeNode[] tns;
            int jb;
            string id;
            //遍历数据表的信息
            foreach (DataRow r in dt.Rows)
            {
                //获取名字为jb的信息
                jb = Convert.ToInt32(r["jb"].ToString());
                tp = null;
                //遍历数据
                for (int i = 1; i <= jb; i++)
                {
                    id = "id" + i;
                    //按照以r[id].ToString()为名查找具有指定键的树节点，可以选择搜索子节点，返回一个list[]。
                    tns = trV.Nodes.Find(r[id].ToString(), true);
                    //判断树节点的长度
                    if (tns.Length > 0)
                        //给树节点赋值
                        tp = tns[0];
                    else
                    {
                        //创建新的节点
                        tn = createANode(r, i);
                        if (tp == null)
                            //向trV控件添加节点
                            trV.Nodes.Add(tn);
                        else
                            //向父节点tp中添加节点
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
            //使用指定的文本初始化 TreeNode 类的新实例。
            TreeNode tn = new TreeNode(r[mc].ToString());
            tn.Name = r[id].ToString();
            //tn.Tag = r[bm].ToString();
            return tn;
        }
        #endregion

        #region CreateTableAndRelation()
        private void CreateTableAndRelation()
        {
            //sql语句获取代码，名称的信息
            string cmd = string.Format(@"select dm,mc from toptionxm where lbdm=@lbdm");
            //创建一个SqlParameter，第一个参数是名字，第二个参数值
            SqlParameter paramodeltype = new SqlParameter("@lbdm", "modeltype");
            //上一个表的结构再建一个表
            DataTable dtmodeltype = dsContainerFountain1.Tables.Add("dtmodel_type");
            //获取表的信息
            dtmodeltype = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, paramodeltype);
            //添加表的信息
            dsContainerFountain1.Tables.Add(dtmodeltype);
            //添加表关系
            DataRelation relmodel_type = new DataRelation("relmodel_type", dtmodeltype.Columns["dm"],dsContainerFountain1.tcontainer.Columns["modeltype"]);
            //创建一个SqlParameter，第一个参数是名字，第二个参数值
            SqlParameter parascreen_type = new SqlParameter("@lbdm", "screen_type");
            //建立一个新的表
            DataTable dtscreen_type = dsContainerFountain1.Tables.Add("dtscreen_type");
            //查询表的数据
            dtscreen_type = ClsMSSQL.GetDataTable(cmd, ClsDBCon.ConStrKj, parascreen_type);
            //给表添加信息
            dsContainerFountain1.Tables.Add(dtscreen_type);
            //添加表关系
            DataRelation relscreen_type = new DataRelation("relscreen_type", dtscreen_type.Columns["dm"], dsContainerFountain1.tcontainer.Columns["screen_type"]);
            //数据集添加关系
            dsContainerFountain1.Relations.Add(relmodel_type);
            dsContainerFountain1.Relations.Add(relscreen_type);
            //给数据集中的信息赋值
            dsContainerFountain1.tcontainer.model_type_nameColumn.Expression = "Parent(relmodel_type).mc";
            dsContainerFountain1.tcontainer.screen_type_nameColumn.Expression = "Parent(relscreen_type).mc";
        }
        #endregion

        #endregion

        #region trV_AfterSelect()
        private void trV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Sql语句
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
                tjigouTableAdapter1.Fill(dsContainerFountain1.tjigou);
                //查询货柜表的信息
                tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                tcontainerTableAdapter1.FillByWhere(dsContainerFountain1.tcontainer, sWhere);
            }
            }

        #endregion

        #region 功能按键

        #region 新增
        private void btnNew_Click(object sender, EventArgs e)
        {
            //判断是否选择机构树的名字
            if (string.IsNullOrEmpty(trV.SelectedNode.Name))
            {
                ClsMsgBox.Ts("请选择机构树！");
                return;
            }
            //获取机构树转换数据类型
            //int jgid = Convert.ToInt32(trV.SelectedNode);
            int jgid = Convert.ToInt32(trV.SelectedNode.Name);
            //进入新的模块
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //调用模块中的方法
            f.prepare(EnumNED.NEW, jgid, dgv);
            //显示模块
            f.ShowDialog();
            //关闭模块
            f.Closed += new EventHandler(frmClosed);
        }

        #region frmClosed()
        private void frmClosed(object sender, EventArgs e)
        {
            //声明变量
            string sWhere = "";
            //判断是否选择机构树的数据
            if (!string.IsNullOrEmpty(trV.SelectedNode.Name))
            {
                //获取选取的机构树信息转换数据类型
                int jgidid = Convert.ToInt32(trV.SelectedNode.Name);
                //查询机构名称查询出机构id的信息
                string cmd = string.Format(@"select jb from vjigoua where id={0}", jgidid);
                //获取机构的信息转换数据类型
                int jb = Convert.ToInt32(ClsMSSQL.GetStr(cmd, ClsDBCon.ConStrKj));
                //查询视图中的数据的id
                string cmdvjigoua = string.Format(@"select id from vjigoua where id{0}={1}", jb, jgidid);
                //返回表数据查询语句
                DataTable dt = ClsMSSQL.GetDataTable(cmdvjigoua, ClsDBCon.ConStrKj);
                //遍历表数据
                foreach (DataRow dr in dt.Rows)
                {
                    //判断数据的信息
                    if (dr == dt.Rows[0])
                    {

                        //增加语句的查询条件
                        sWhere += string.Format(@" where (jgid='{0}') ", dr[0]);
                    }
                    else
                    {

                        //增加语句的查询条件
                        sWhere += string.Format(@" or (jgid='{0}') ", dr[0]);
                    }
                }
                //查询货柜状态表的信息
               tcontainer_statusTableAdapter1.Fill(dsContainerFountain1.tcontainer_status);
                //查询货柜表的信息
                tcontainerTableAdapter1.FillByWhere(dsContainerFountain1.tcontainer, sWhere);
            }
        }
        #endregion

        #endregion

        #endregion

        #region 编辑
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //判断Dgv里面的集合数值是否为空
            if (dgv.CurrentRow == null)
            {
                //弹窗并返回
                ClsMsgBox.Ts("请选择饮水机列表中的一行数据！");
                return;
            }
            //给dgv中的值进行转换字符类型
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            int container_id = tmp_containerRow.id;
            int jgid = tmp_containerRow.jgid;
            //进入新的模块
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //调用模块中的方法
            f.prepare(EnumNED.EDIT, jgid, dgv, container_id);
            //显示窗体
            f.ShowDialog();
            //关闭模块
            f.Closed += new EventHandler(frmClosed);
        }
        #endregion

        #region 详细
        private void btnDetail_Click(object sender, EventArgs e)
        {
            //判断dgv的集合是否为空
            if (dgv.CurrentRow == null)
            {
                //弹窗并返回
                ClsMsgBox.Ts("请选择货柜列表中的一行数据！");
                return;
            }
            //对数值进行字符类型转换给dgv赋值
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            int container_id = tmp_containerRow.id;
            int jgid = tmp_containerRow.jgid;
            //进入新的模块
            FrmContainerFountainMX f = new FrmContainerFountainMX();
            //调用模块中的方法
            f.prepare(EnumNED.DETAIL, jgid, dgv, container_id);
            //显示窗体
            f.ShowDialog();
            //关闭窗体
            f.Closed += new EventHandler(frmClosed);
        }

        #endregion

        #region 删除
        private void btnDel_Click(object sender, EventArgs e)
        {
            //点击的数据不为空
            if (dgv.SelectedRows != null)
            {
                //弹窗，调用删除的方法
                ClsMsgBox.YesNo("确定要删除吗？", deleting);
            }
        }

        private void deleting(object sender, EventArgs e)
        {
          
            DialogResult dr = ((Form)sender).DialogResult;
            //判断返回类型
            if (dr == DialogResult.Yes)
            {
                try
                {
                    //移除dgv集合所选行的数据
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
            //判断是否点击Dgv中的数据
            if (bds.Current == null)
            {
                //弹窗返回
                ClsMsgBox.Ts("请选择饮水机列表中的一行数据！");
                return;
            }
            DSContainerFountain.tcontainerRow tmp_containerRow= (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            FrmContainerPrice f = new FrmContainerPrice();
            f.ShowDialog();
            f.prepare(tmp_containerRow.id,tmp_containerRow.container_no);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否点击Dgv中的数据
            if (bds.Current == null)
            {
                //弹窗返回
                ClsMsgBox.Ts("请选择饮水机列表中的一行数据！");
                return;
            }
            DSContainerFountain.tcontainerRow tmp_containerRow = (DSContainerFountain.tcontainerRow)((DataRowView)bds.Current).Row;
            FrmRepair f = new FrmRepair();
            f.ShowDialog();
            f.prepare(tmp_containerRow.id, tmp_containerRow.container_no);
        }
    }
}