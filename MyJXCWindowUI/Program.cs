using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoGuangYuan.MyJXCWindowUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Category());     //产品类别
            //Application.Run(new Frm_Product());      //产品管理
            //Application.Run(new Frm_Employee());     //员工管理 
            //Application.Run(new Frm_Customer());     //客户管理 
            //Application.Run(new Frm_Supplier());     //供应商管理


            //Application.Run(new BaseForm.BasePurChaseBillForm());                  //销售
            //Application.Run(new PurchaseManage.Frm_FillPurchaseBill());            //业务员填单(下订单)
            //Application.Run(new PurchaseManage.Frm_ExamPurchaseBill());            //审核员审核订单
            //Application.Run(new PurchaseManage.Frm_InStockCheck());                //仓库保管员审核签名
            //Application.Run(new Frm_SystemUser());                                   //用户权限管理

            Application.Run(new Frm_MainForm());                                   //用户权限管理

            
        }
    }
}
