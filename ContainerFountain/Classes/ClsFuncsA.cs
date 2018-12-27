using ContainerFountain.ContainerInput;
using ContainerFountain.ProductType;
using ContainerFountain.XTGL;
using DLTLib.Classes;
using Gizmox.WebGUI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContainerFountain.Classes
{
    public class ClsFuncsA:ClsFuncs
    {
        private TabPage tp;
        public ClsFuncsA(TabPage aTp)
        {
            tp = aTp;
        }
        public override void Call(int aId, string aBm, string aMc)
        {
            tp.Controls.Clear();  //tp即tpMain中的控件清除。   
            #region 系统管理
            //机构管理
            if (string.Compare(aBm, "xtgl-jggl", true) == 0)
            {
                FrmJGGL c = new FrmJGGL();
                tp.Controls.Add(c);
                return;
            }
            //模块管理
            if (string.Compare(aBm, "xtgl-mkgl", true) == 0)
            {
                FrmMKGL c = new FrmMKGL();
                tp.Controls.Add(c);
                return;
            }
            //选项管理
            if (string.Compare(aBm, "xtgl-xxgl", true) == 0)
            {
                FrmOptionLBLB c = new FrmOptionLBLB();
                tp.Controls.Add(c);
                return;
            }
            //角色管理
            if (string.Compare(aBm, "xtgl-jsgl", true) == 0)
            {
                FrmRolesLB c = new FrmRolesLB();
                tp.Controls.Add(c);
                return;
            }
            //员工管理
            if (string.Compare(aBm, "xtgl-yggl", true) == 0)
            {
                FrmYuanGongLB c = new FrmYuanGongLB();
                c.Dock = DockStyle.Fill;
                tp.Controls.Add(c);
                return;
            }
            //配置管理
            if (string.Compare(aBm, "xtgl-config", true) == 0)
            {
                FrmConfig c = new FrmConfig();
                tp.Controls.Add(c);
                return;
            }
            #endregion

            #region 货柜配置
            //信息录入
            if (string.Compare(aBm, "ContainerInput", true) == 0)
            {
                FrmContainerFountain c = new FrmContainerFountain();
                tp.Controls.Add(c);
                c.Prepare();
                return;
            }
            //状态查询
            if (string.Compare(aBm, "statusQuery", true) == 0)
            {
                ContainerFountain.Containerheartbeat.Containerheartbeat c = new ContainerFountain.Containerheartbeat.Containerheartbeat();
                tp.Controls.Add(c);
                c.Prepare();
                return;
            }
            //产品类型
            if (string.Compare(aBm, "ProductType", true) == 0)
            {
                FrmProductType c = new FrmProductType();
                tp.Controls.Add(c);
                c.Prepare();
                return;
            }
            #endregion

            ClsMsgBox.Jg(aId + "," + aBm + "," + aMc + Environment.NewLine
              + "此功能正在实现中...");
        }
    }
}