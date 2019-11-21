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
    public partial class Frm_FillPurchaseBill : MoGuangYuan.MyJXCWindowUI.BaseForm.BasePurChaseBillForm
    {
        private Operation op;
        public static PurchaseDetail purchaseDetail_Add;
        private PurchaseBillBLL billBll;
        private string clerkID;                          //存放业务员

        public string ClerkID
        {
            get { return clerkID; }
            set { clerkID = value; }
        }

        public Frm_FillPurchaseBill()
        {
            InitializeComponent();

            //绑定供应商名称
            List<Supplier> supplierList = new SupplierBLL().GetList();
            var idAndNameList = from s in supplierList select new { s.SupplierID, s.SupplierContact.Name };
            cbSupplier.DataSource = idAndNameList.ToList();
            cbSupplier.DisplayMember = "Name";
            cbSupplier.ValueMember = "SupplierID";

            billBll = new PurchaseBillBLL();

            //默认操作值为NONE无
            op = Operation.NONE;
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = Operation.NONE;
            bill = null;
            //把相应的控件 设置为可用或不可用
            btnAdd.Enabled = btnModify.Enabled = btnUndo.Enabled = true;
            btnDeleteTheDetailInformation.Enabled = btnTheNewDetailInformation.Enabled = false;
            btnSeave.Enabled = btnCancel.Enabled = false;
        }
        private void btnModify_Click(object sender, EventArgs e)  //修改
        {
            op = Operation.UPDATE;

            //判断是否选择了订单
            if (bill == null)
            {
                MessageBox.Show("请选择订单！", "提示");
                return;
            }
            //完成、撤消状态下不可以修改
            if (bill.OnProcess == 1)
            {
                MessageBox.Show("订单已经撤消，不能修改！", "提示");
                return;
            }
            else if (bill.OnProcess == 2)
            {
                MessageBox.Show("订单已经完成，不能修改！", "提示");
                return;
            }
            //已经审核过不可以修改
            if (bill.Examiner == null)
            {
                MessageBox.Show("订单已经审核，不能修改！", "提示");
                return;
            }

            //设置控件的属性
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnUndo.Enabled = false;
            btnSeave.Enabled = true;
            btnCancel.Enabled = true;
            btnTheNewDetailInformation.Enabled = true;
            btnDeleteTheDetailInformation.Enabled = true;
            cbSupplier.Enabled = true;
            txtMemo.Enabled = true;
            lbPurChaseID.Enabled = false;
            txtPurchaseID.Enabled = true;

            //设置3 4列为可编辑状态
            if (bill.DetailList.Count != 0)
            {
                dgPurchaseDetaillInfo.Columns[3].ReadOnly = false;
                dgPurchaseDetaillInfo.Columns[4].ReadOnly = false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            op = Operation.INSERT;

            lbPurChaseID.Enabled = false;

            //屏蔽编号
            if (dgPurchaseDetaillInfo.Rows.Count != 0)
            {
                dgPurchaseDetaillInfo.Columns[0].Visible = false;
            }

            //恢复为默认的设置
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnUndo.Enabled = false;
            btnSeave.Enabled = true;
            btnCancel.Enabled = true;
            btnTheNewDetailInformation.Enabled = true;
            btnDeleteTheDetailInformation.Enabled = true;
            dtPurchaseDate.Enabled = true;
            txtMemo.Enabled = true;
            cbSupplier.Enabled = true;
            dgPurchaseDetaillInfo.DataSource = null;

            dtPurchaseDate.Value = DateTime.Now; //让业务员点击新增的时候自动生成订单编号

            txtOnProcess.Text = "执行";
            bill = new PurchaseBill();
            bill.DetailList = new List<PurchaseDetail>();
            detailList = new List<PurchaseDetail>();

            if (bill.DetailList.Count != 0)  //设置3 4列为可编辑状态
            {
                dgPurchaseDetaillInfo.Columns[3].ReadOnly = false;
                dgPurchaseDetaillInfo.Columns[4].ReadOnly = false;
            }

        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            op = Operation.DELETE;
            //判断是否选择了订单
            if (bill == null)
            {
                MessageBox.Show("请选择订单！", "提示");
                return;
            }
            //完成、撤消状态下不可以修改
            if (bill.OnProcess == 1)
            {
                MessageBox.Show("订单已经撤消，不能再进行操作！", "提示");
                return;
            }
            else if (bill.OnProcess == 2)
            {
                MessageBox.Show("订单已经完成，不能撤销！", "提示");
                return;
            }
            //已经审核过不可以修改
            if (bill.Examiner != "")
            {
                MessageBox.Show("订单已经审核，不能撤销！", "提示");
                return;
            }

            cbSupplier.Enabled = false;
            btnAdd.Enabled = false;
            btnModify.Enabled = false;
            btnUndo.Enabled = false;
            btnSeave.Enabled = true;
            btnCancel.Enabled = true;
            txtMemo.Enabled = true;
            lbPurChaseID.Enabled = false;

        }

        private void btnDeleteTheDetailInformation_Click(object sender, EventArgs e)
        {
            //判断是否选择了明细
            if (dgPurchaseDetaillInfo.SelectedCells == null)
            {
                MessageBox.Show("请选择订单明细！", "提示");
                return;
            }

            //弹出是否确认删除的对话框
            DialogResult result = MessageBox.Show("您是否真的要删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //移除选定的订单明细
                detailList.Remove(purchaseDetail_Delete);
                MessageBox.Show("订单明细已成功移除！", "提示");

                //重新排序明细
                int i = 1;
                foreach (PurchaseDetail p in bill.DetailList)
                {
                    p.PurchaseDetailID = i;
                    i++;
                }
                //重新绑定订单明细
                //BinDataGiidViewDetail();
                dgPurchaseDetaillInfo.DataSource = null;
                dgPurchaseDetaillInfo.DataSource = detailList;

                //设置3 4列为可编辑状态
                if (bill.DetailList.Count != 0)
                {
                    dgPurchaseDetaillInfo.Columns[3].ReadOnly = false;
                    dgPurchaseDetaillInfo.Columns[4].ReadOnly = false;
                }
                //移除完毕清空
                purchaseDetail_Delete = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lbPurChaseID.Enabled = true;
            btnAdd.Enabled = btnModify.Enabled = btnUndo.Enabled = true;
            dgPurchaseDetaillInfo.DataSource = null;
            bill = null;
            btnSeave.Enabled = false;
            btnCancel.Enabled = false;
            btnTheNewDetailInformation.Enabled = false;
            btnDeleteTheDetailInformation.Enabled = false;
            cbSupplier.Enabled = false;
            txtMemo.Enabled = false;
            dtPurchaseDate.Enabled = false;
            lbPurChaseID.SelectedIndex = -1; //取消当前选择的行           

        }

        private void btnTheNewDetailInformation_Click(object sender, EventArgs e)
        {
            //弹出产品选择窗体
            Frm_ChooseProduct chooseProduct = new Frm_ChooseProduct();
            chooseProduct.ShowDialog();

            //判断是否有值
            if (purchaseDetail_Add == null)
            {
                return;
            }

            //遍历当前的所有记录是否存在相同的
            foreach (PurchaseDetail p in detailList)
            {
                if (p.ProductID == purchaseDetail_Add.ProductID)
                {
                    MessageBox.Show("该产品已存在！", "提示");
                    purchaseDetail_Add = null;    //清空
                    return;
                }
            }
            //purchaseDetail_Add.PurchaseID = txtPurchaseID.Text.Trim();     //获取订单编号
            purchaseDetail_Add.PurchaseDetailID = detailList.Count + 1;      //获取订单明细编号
            detailList.Add(purchaseDetail_Add);                              //将记录填充到泛型集合

            //绑定订单明细
            BinDataGiidViewDetail();                                        //重新填充数据（刷新）
            dgPurchaseDetaillInfo.Columns[0].Visible = false;               //屏蔽第一行的订单编号
            //dgPurchaseDetaillInfo.DataSource = null;                         //重新填充数据（刷新）
            //dgPurchaseDetaillInfo.DataSource = detailList;

            if (detailList.Count != 0)  //设置3 4列为可编辑状态
            {
                dgPurchaseDetaillInfo.Columns[3].ReadOnly = false;
                dgPurchaseDetaillInfo.Columns[4].ReadOnly = false;
            }
        }

        private void btnSeave_Click(object sender, EventArgs e)
        {
            if (op == Operation.INSERT || op == Operation.UPDATE)
            {
                //判断是否有值
                if (detailList == null || detailList.Count() == 0)
                {
                    MessageBox.Show("该订单不能没有明细！", "提示");
                    return;
                }
                foreach (PurchaseDetail p in detailList)
                {
                    if (p.Quantity == 0 || p.PurchasePrice == 0)
                    {
                        MessageBox.Show("订单明细的价格或数量不能为0", "提示");
                        return;
                    }
                }
            }
            if (op == Operation.INSERT)    //插入（新增订单）
            {
                //取值                
                bill.PurchaseID = txtPurchaseID.Text.Trim();
                bill.PurchaseDate = dtPurchaseDate.Value;
                bill.StockDate = new DateTime();
                bill.SupplierID = cbSupplier.SelectedValue.ToString();
                bill.OnProcess = 0;
                bill.Clerk = clerkID;
                bill.Examiner = "";
                bill.Custodian = "";
                bill.Memo = txtMemo.Text.Trim();

                foreach (PurchaseDetail p in detailList)
                {
                    p.PurchaseID = txtPurchaseID.Text.Trim();
                }
                bill.DetailList = detailList;

                if (billBll.Insert(bill))
                {
                    MessageBox.Show("新增成功！", "提示");

                    ////根据订单编号执行方法查询订单明细
                    //bill = new PurchaseBillBLL().FindByID(txtPurchaseID.Text.Trim());     
      
                    //默认显示的是第一个查询条件
                    cbSearch.SelectedIndex = 0;

                    //显示新的订单编号在lbPurChaseID控件上
                    string PurchaseID = txtPurchaseID.Text.Trim();
                    List<string> listPurchaseID = new List<string>();
                    listPurchaseID.Add(PurchaseID);
                    lbPurChaseID.DataSource = listPurchaseID;
                    lbPurChaseID.SelectedIndex = -1;  //取消反蓝显示

                    //恢复为默认的设置
                    op = Operation.NONE;
                    lbPurChaseID.Enabled = true;
                    btnAdd.Enabled = true;
                    btnModify.Enabled = true;
                    btnUndo.Enabled = true;
                    btnSeave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnTheNewDetailInformation.Enabled = false;
                    btnDeleteTheDetailInformation.Enabled = false;
                    dgPurchaseDetaillInfo.DataSource = null;
                    txtPurchaseID.Text = "";
                    txtSearch.Text = "";                    

                }
                else
                {
                    MessageBox.Show("新增失败！", "提示");
                    return;
                }
            }
            else if (op == Operation.UPDATE)    //更新订单
            {
                try
                {
                    //取值
                    foreach (PurchaseDetail p in detailList)
                    {
                        p.PurchaseID = txtPurchaseID.Text.Trim();
                    }
                    bill.SupplierID = cbSupplier.SelectedValue.ToString();
                    bill.Memo = txtMemo.Text.Trim();
                    bill.DetailList = detailList;

                    if (billBll.Update(bill))
                    {
                        MessageBox.Show("修改成功！", "提示");

                        ////根据订单编号执行方法查询订单明细
                        //bill = new PurchaseBillBLL().FindByID(txtPurchaseID.Text.Trim());

                        //恢复为默认的设置
                        op = Operation.NONE;
                        btnAdd.Enabled = true;
                        btnModify.Enabled = true;
                        btnUndo.Enabled = true;
                        btnSeave.Enabled = false;
                        btnCancel.Enabled = false;
                        btnTheNewDetailInformation.Enabled = false;
                        btnDeleteTheDetailInformation.Enabled = false;
                        bill = null;
                        lbPurChaseID.Enabled = true;
                        lbPurChaseID.SelectedIndex = -1;
                        dgPurchaseDetaillInfo.DataSource = null;

                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "提示");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (op == Operation.DELETE)    //撤销订单
            {
                if (txtMemo.Text == "")
                {
                    MessageBox.Show("请填写撤销原因（备注）！", "提示");
                    return;
                }
                DialogResult result = MessageBox.Show("您是否真的要撤销?", "撤销确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bill.OnProcess = 1;
                    bill.Memo = txtMemo.Text.Trim();
                    try
                    {
                        if (billBll.UpdatePurchaseBillOnly(bill))
                        {
                            MessageBox.Show("订单撤销成功！", "提示");

                            //恢复为默认的设置
                            op = Operation.NONE;
                            btnAdd.Enabled = true;
                            btnModify.Enabled = true;
                            btnUndo.Enabled = true;
                            btnSeave.Enabled = false;
                            btnCancel.Enabled = false;
                            btnTheNewDetailInformation.Enabled = false;
                            btnDeleteTheDetailInformation.Enabled = false;
                            dtPurchaseDate.Enabled = true;
                            txtMemo.Enabled = false;
                            cbSupplier.Enabled = false;
                            lbPurChaseID.Enabled = true;
                            lbPurChaseID.SelectedIndex = -1; //取消当前选择的行   
                            bill = null;
                            dgPurchaseDetaillInfo.DataSource = null;
                        }
                        else
                        {
                            MessageBox.Show("订单撤销失败", "提示");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void dtPurchaseDate_ValueChanged(object sender, EventArgs e)
        {
            //根据日期创建编号
            txtPurchaseID.Text = billBll.CreatePurchaseID(dtPurchaseDate.Value.Date);
        }



    }
}
