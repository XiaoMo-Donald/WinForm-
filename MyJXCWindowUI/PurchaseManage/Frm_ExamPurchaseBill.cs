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
    //审核进货单窗口（继承 BasePurChaseBillForm.cs） 

    public partial class Frm_ExamPurchaseBill : MoGuangYuan.MyJXCWindowUI.BaseForm.BasePurChaseBillForm
    {
        private string examinerID;  //审核员ID字段(登录的时候传值)
        public string ExaminerID
        {
            get { return examinerID; }
            set { examinerID = value; }
        }
        public Frm_ExamPurchaseBill()
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

        private void btnReviewTheSignature_Click(object sender, EventArgs e)
        {

            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要审核的订单！", "提示");
                return;
            }
            if (bill.Examiner != "")    //订单已审核不能再审核
            {
                MessageBox.Show("该订单已经审核，不能再审核！", "提示");
                return;
            }
            if (bill.OnProcess == 1)    //订单已撤销不能审核
            {
                MessageBox.Show("该订单已经撤销，不能审核！", "提示");
                return;
            }
            if (bill.OnProcess == 2)   //订单已完成 不能审核
            {
                MessageBox.Show("该订单已经完成，不能审核！", "提示");
                return;
            }
            bill.Examiner = examinerID;    //设置审核员ID为当前登录的用户ID（审核员）
            try
            {
                if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                {
                    MessageBox.Show("订单审核签名成功！", "提示");
                    txtOnProcess.Text = "执行(已审核)";
                    txtExaminer.Text = new EmployeeBLL().FindByID(examinerID).EmployeeName;
                }
                else
                {
                    MessageBox.Show("订单审核签名失败", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbPurChaseID_Click(object sender, EventArgs e)  //显示底部的业务员 审核员 保管员的姓名
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

        private void btnCancelTheAuditSignature_Click(object sender, EventArgs e)
        {
            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要取消审核签名的订单！", "提示");
                return;
            }
            if (bill.OnProcess == 1)    //订单已撤销不能取消审核签名
            {
                MessageBox.Show("该订单已经撤销，不能撤销审核签名！", "提示");
                return;
            }
            if (bill.OnProcess == 2)         //订单已完成不能取消审核签名
            {
                MessageBox.Show("该订单已经完成，不能撤销审核签名！", "提示");
                return;
            }
            bill.Examiner = "";              //设置审核员为空
            try
            {
                if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                {
                    MessageBox.Show("订单撤销审核签名成功！", "提示");
                    txtOnProcess.Text = "执行(未审核)";
                    txtExaminer.Text = "";
                }
                else
                {
                    MessageBox.Show("订单撤销审核签名失败", "提示");

                    //重新绑定订单
                    bill = new PurchaseBillBLL().FindByID(bill.PurchaseID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExaminerUndo_Click(object sender, EventArgs e)     //保管员撤销订单 （操作）
        {
            if (bill == null)  //是否选择了订单
            {
                MessageBox.Show("请选择需要撤销的订单！", "提示");
                return;
            }
            if (bill.OnProcess == 1)    //订单已撤销不能撤销
            {
                MessageBox.Show("该订单已经撤销，不需要再进行操作！", "提示");
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
                bill.OnProcess = 1;                  //审核员撤销完成（状态设置为 1=撤销 ）
                bill.Memo = txtMemo.Text.Trim();     //审核员撤销需要填写撤销原因（备注）
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

        private void btnExaminerRestore_Click(object sender, EventArgs e)      //保管员恢复订单 （操作）
        {
            if (bill == null)          //是否选择了订单
            {
                MessageBox.Show("请选择需要恢复的订单！", "提示");
                return;
            }
            if (bill.OnProcess == 2)   //订单已完成 不能恢复
            {
                MessageBox.Show("该订单已经完成，不能进行恢复操作！", "提示");
                return;
            }
            if (bill.OnProcess == 0)
            {
                MessageBox.Show("该订单未被撤销，不能进行恢复操作！", "提示");
                return;
            }
            bill.OnProcess = 0;        //审核员恢复完成（状态设置为 0=执行 ）
            try
            {
                if (new PurchaseBillBLL().UpdatePurchaseBillOnly(bill))
                {
                    MessageBox.Show("订单恢复成功！", "提示");
                    txtOnProcess.Text = "执行(未审核)";
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
