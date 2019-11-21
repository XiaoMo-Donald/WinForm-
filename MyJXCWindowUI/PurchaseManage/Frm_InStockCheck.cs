using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoGuangYuan.Model;
using MoGuangYuan.BLL;

namespace MoGuangYuan.MyJXCWindowUI.PurchaseManage
{
    //货物入库检验界面（继承BasePurChaseBillForm.cs） 
    public partial class Frm_InStockCheck : MoGuangYuan.MyJXCWindowUI.BaseForm.BasePurChaseBillForm
    {
        private string custodianID;  //保管员ID字段(登录的时候传值)
        public string CustodianID
        {
            get { return custodianID; }
            set { custodianID = value; }
        }
        public Frm_InStockCheck()
        {
            InitializeComponent();
            //绑定供应商名称
            List<Supplier> supplierList = new SupplierBLL().GetList();
            var idAndNameList = from s in supplierList select new { s.SupplierID, s.SupplierContact.Name };
            cbSupplier.DataSource = idAndNameList.ToList();
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "SupplierID";
            txtMemo.Enabled = true;
        }

        private void btnInspectionBySignature_Click(object sender, EventArgs e)     //保管员签名
        {
            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要检验的订单！", "提示");
                return;
            }
            if (bill.Custodian != "")    //订单已审核不能再审核
            {
                MessageBox.Show("该订单已检验，不能再次进行操作！", "提示");
                return;
            }
            if (bill.OnProcess == 1)    //订单已撤销不能审核
            {
                MessageBox.Show("该订单已经撤销，不能再检验！", "提示");
                return;
            }
            if (bill.OnProcess == 2)   //订单已完成 不能审核
            {
                MessageBox.Show("该订单已经完成，不能再检验！", "提示");
                return;
            }
            if (bill.Examiner == "")
            {
                MessageBox.Show("该订单未审核，请等待审核员审核后再进行操作！", "提示");
                return;
            }
            bill.OnProcess = 2;                  //保管员审核完成 入库（状态设置为 2=完成 ）
            bill.Custodian = custodianID;        //设置保管员ID为当前登录的用户ID（审核员）
            bill.StockDate = DateTime.Now.Date;  //设置入库日期为当期日期
            try
            {
                if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                {
                    MessageBox.Show("订单检验签名成功！", "提示");
                    txtOnProcess.Text = "完成";
                    txtStockDate.Text = DateTime.Now.ToShortDateString();
                    txtCustodian.Text = new EmployeeBLL().FindByID(custodianID).EmployeeName;
                }
                else
                {
                    MessageBox.Show("订单检验签名失败", "提示");
                    //重新绑定订单
                    bill = new PurchaseBillBLL().FindByID(bill.PurchaseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbPurChaseID_Click(object sender, EventArgs e)
        {
            txtClerk.Text = new EmployeeBLL().FindByID(bill.Clerk).EmployeeName;

            if (bill.Examiner == "")   //审核员
            {
                txtExaminer.Text = "";
            }
            else
            {
                txtExaminer.Text = new EmployeeBLL().FindByID(bill.Examiner).EmployeeName;
            }
            if (bill.Custodian == "")  //保管员
            {
                txtCustodian.Text = "";
            }
            else
            {
                txtCustodian.Text = new EmployeeBLL().FindByID(bill.Custodian).EmployeeName;
            }
        }


        private void btnUndo_Click(object sender, EventArgs e)     //保管员撤销订单 （操作）
        {
            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要撤销的订单！", "提示");
                return;
            }
            if (bill.OnProcess == 1)    //订单已撤销不能撤销
            {
                MessageBox.Show("该订单已经撤销，需要再进行操作！", "提示");
                return;
            }
            if (bill.OnProcess == 2)   //订单已完成 不能撤销
            {
                MessageBox.Show("该订单已经完成，不能进行撤销操作！", "提示");
                return;
            }
            if (txtMemo.Text == "")    //订单撤销原因（备注）
            {
                MessageBox.Show("请填写撤销原因后再进行操作！", "提示");
                return;
            }

            //弹出是否确认撤销的对话框
            DialogResult result = MessageBox.Show("您是否真的要撤销?", "撤销确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bill.OnProcess = 1;                  //保管员撤销完成（状态设置为 1=撤销 ）
                bill.Memo = txtMemo.Text.Trim();     //保管员撤销需要填写撤销原因（备注）
                try
                {
                    if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                    {
                        MessageBox.Show("订单撤销成功！", "提示");
                        txtOnProcess.Text = "撤销";
                    }
                    else
                    {
                        MessageBox.Show("订单撤销失败", "提示");
                        //重新绑定订单
                        bill = new PurchaseBillBLL().FindByID(bill.PurchaseID);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)    //保管员恢复订单 （操作）
        {
            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要恢复的订单！", "提示");
                return;
            }
            if (bill.OnProcess == 0)
            {
                MessageBox.Show("该订单不需要撤销！", "提示");
                return;
            }
            if (bill.OnProcess == 2)   //订单已完成 不能恢复
            {
                MessageBox.Show("该订单已经完成，不能进行恢复操作！", "提示");
                return;
            }
            bill.OnProcess = 0;        //保管员恢复完成（状态设置为 0=执行 ）
            try
            {
                if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                {
                    MessageBox.Show("订单恢复成功！", "提示");
                    txtOnProcess.Text = "执行";
                }
                else
                {
                    MessageBox.Show("订单恢复失败", "提示");
                    //重新绑定订单
                    bill = new PurchaseBillBLL().FindByID(bill.PurchaseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
