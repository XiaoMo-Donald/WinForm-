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

namespace MoGuangYuan.MyJXCWindowUI.BaseForm
{
    //进货业务管理窗体的父类 窗体

    public partial class BasePurChaseBillForm : Form
    {
        private PurchaseBillBLL billBLL;
        List<string> idList;                             //泛型集合 存放订单的编号
        protected PurchaseBill bill;
        protected List<PurchaseDetail> detailList;       //存放查询后点击的订单编号的相应的订单明细
        protected PurchaseDetail purchaseDetail_Delete;  //订单明细
        public BasePurChaseBillForm()
        {
            InitializeComponent();
            billBLL = new PurchaseBillBLL();

        }
        private void BasePurChaseBillForm_Load(object sender, EventArgs e)
        {
            //默认显示的是第一个查询条件
            cbSearch.SelectedIndex = 0;
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //查询时 根据选择的查询条件 设置相应的控件的属性
            if (cbSearch.SelectedIndex == 4)
            {
                txtSearch.Enabled = false;
                dtBeginTime.Enabled = true;
                dtEndTime.Enabled = true;
            }
            else
            {
                txtSearch.Enabled = true;
                dtBeginTime.Enabled = false;
                dtEndTime.Enabled = false;
            }

            //选择不同的查询条件时 清空相应的值
            lbPurChaseID.DataSource = null;
            bill = null;
            idList = null;
            dgPurchaseDetaillInfo.DataSource = null;

            txtSearch.Text = "";
            txtStockDate.Text = "";
            txtOnProcess.Text = "";
            txtMemo.Text = "";
            txtPurchaseID.Text = "";
            txtTotalPrice.Text = "";
            lbPurChaseID.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)   //查询按钮
        {
            string searchValue = "";
            DateTime beginDate;
            DateTime endDate;

            if (cbSearch.SelectedIndex != 4)
            {
                searchValue = txtSearch.Text.Trim();
                if (searchValue == "")
                {
                    MessageBox.Show("请输入值！", "提示");
                    return;
                }
            }

            try
            {

                if (cbSearch.SelectedIndex == 0)
                {
                    idList = billBLL.FindPurchaseIDByID(searchValue);
                }
                else if (cbSearch.SelectedIndex == 1)
                {
                    idList = billBLL.FindPurchaseIDByClerk(searchValue);
                }
                else if (cbSearch.SelectedIndex == 2)
                {
                    idList = billBLL.FindPurchaseIDByExaminer(searchValue);
                }
                else if (cbSearch.SelectedIndex == 3)
                {
                    int onProcess = 0;
                    onProcess = Convert.ToInt16(searchValue);

                    if (onProcess > 2 || onProcess < 0)
                    {
                        MessageBox.Show("请输入正确的状态值！ \r\n\r\n  0 = 执行\r\n  1 = 撤销\r\n  2 = 恢复", "提示");
                        return;
                    }
                    idList = billBLL.FindPurchaseIDByOnProcess(onProcess);
                }
                else if (cbSearch.SelectedIndex == 4)
                {
                    beginDate = dtBeginTime.Value.Date;
                    TimeSpan ts = new TimeSpan(0,0,0,1);
                    endDate = dtEndTime.Value.AddDays(1).Subtract(ts);

                    idList = billBLL.FindPurchaseIDByPurchaseDate(beginDate, endDate);
                }

                //判断返回的值是否为空 若为空 抛出提示 不为空则填充
                if (idList.Count == 0)
                {
                    MessageBox.Show("没有找到该记录！", "提示");
                }
                else
                {
                    lbPurChaseID.DataSource = idList;
                }

                lbPurChaseID.SelectedIndex = -1;  //取消反蓝显示

            }
            catch (FormatException)
            {
                MessageBox.Show("请输入正确的状态值！ \r\n\r\n  0 = 执行\r\n  1 = 撤销\r\n  2 = 恢复", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbPurChaseID_Click(object sender, EventArgs e)
        {
            try
            {
                //定义变量取出列表中被选中的purChaseID值
                string purChaseID = lbPurChaseID.SelectedItem.ToString();

                //根据订单编号执行方法查询订单明细
                bill = billBLL.FindByID(purChaseID);

                //显示结果到控件: 订单基本信息
                dtPurchaseDate.Value = bill.PurchaseDate;
                txtPurchaseID.Text = bill.PurchaseID;
                cbSupplier.SelectedValue = bill.SupplierID;

                if (bill.StockDate == new DateTime())   //判断日期是否为空 如果为空 则填充空值 否则填充实际的数据库里的值
                {
                    txtStockDate.Text = "";
                }
                else
                {
                    txtStockDate.Text = bill.StockDate.ToShortDateString();
                }

                if (bill.OnProcess == 0)               //判断执行状态是什么 然后填充相对应的文本的值
                {
                    if (bill.Examiner == "")
                    {
                        txtOnProcess.Text = "执行(未审核)";
                    }
                    else
                    {
                        txtOnProcess.Text = "执行(已审核)";
                    }
                }
                else if (bill.OnProcess == 1)
                {
                    txtOnProcess.Text = "撤销";
                }
                else if (bill.OnProcess == 2)
                {
                    txtOnProcess.Text = "完成";
                }

                txtMemo.Text = bill.Memo;

                //显示结果到控件: 订单明细信息
                detailList = bill.DetailList;
                if (detailList.Count == 0)
                {
                    dgPurchaseDetaillInfo.DataSource = null;
                }
                else
                {
                    //绑定订单明细
                    BinDataGiidViewDetail();
                }
            }
            catch (Exception)
            {
            }
        }
        private void dgPurchaseDetaillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //解决索引值超出范围
            if (dgPurchaseDetaillInfo.CurrentRow.Index > e.RowIndex || dgPurchaseDetaillInfo.CurrentRow.Index < e.RowIndex)
            {
                return;
            }
            //反蓝显示
            dgPurchaseDetaillInfo.CurrentRow.Selected = true;

            //取当前索引的行的值
            purchaseDetail_Delete = detailList[e.RowIndex];

            //当前行的状态为可编辑
            dgPurchaseDetaillInfo.BeginEdit(true);
        }

        protected void BinDataGiidViewDetail()    //绑定订单明细
        {

            dgPurchaseDetaillInfo.DataSource = null;
            dgPurchaseDetaillInfo.DataSource = detailList;
            if (dgPurchaseDetaillInfo.DataSource != null)
            {
                dgPurchaseDetaillInfo.CurrentCell.Selected = false;
            }
            dgPurchaseDetaillInfo.AutoGenerateColumns = false;

            dgPurchaseDetaillInfo.Columns[0].DataPropertyName = "purchaseID";
            dgPurchaseDetaillInfo.Columns[0].HeaderText = "订单编号";
            //dgPurchaseDetaillInfo.Columns[0].Width = 90;
            dgPurchaseDetaillInfo.Columns[0].ReadOnly = true;

            dgPurchaseDetaillInfo.Columns[1].DataPropertyName = "purchaseDetailID";
            dgPurchaseDetaillInfo.Columns[1].HeaderText = "订单明细编号";
            //dgPurchaseDetaillInfo.Columns[1].Width = 90;
            dgPurchaseDetaillInfo.Columns[1].ReadOnly = true;

            dgPurchaseDetaillInfo.Columns[2].DataPropertyName = "productID";
            dgPurchaseDetaillInfo.Columns[2].HeaderText = "产品名称";
            dgPurchaseDetaillInfo.Columns[2].Width = 200;
            dgPurchaseDetaillInfo.Columns[2].ReadOnly = true;

            dgPurchaseDetaillInfo.Columns[3].DataPropertyName = "purchasePrice";
            dgPurchaseDetaillInfo.Columns[3].HeaderText = "产品价格";
            //dgPurchaseDetaillInfo.Columns[3].Width = 90;
            dgPurchaseDetaillInfo.Columns[3].ReadOnly = true;

            dgPurchaseDetaillInfo.Columns[4].DataPropertyName = "quantity";
            dgPurchaseDetaillInfo.Columns[4].HeaderText = "产品数量";
            //dgPurchaseDetaillInfo.Columns[4].Width = 90;
            dgPurchaseDetaillInfo.Columns[4].ReadOnly = true;

            dgPurchaseDetaillInfo.Columns[5].DataPropertyName = "TotalPrice";
            dgPurchaseDetaillInfo.Columns[5].HeaderText = "总价(元)";
            //dgPurchaseDetaillInfo.Columns[5].Width = 90;
            dgPurchaseDetaillInfo.Columns[5].ReadOnly = true;
        }

      
        private void dgPurchaseDetaillInfo_CurrentCellChanged(object sender, EventArgs e)
        {
            //计算和显示总价格
            decimal totalPrice = 0;
            foreach (PurchaseDetail p in detailList)
            {
                totalPrice += p.TotalPrice;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }

        private void dgPurchaseDetaillInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
            {
                return;
            }
            if (dgPurchaseDetaillInfo.Columns[e.ColumnIndex].Name == "ProductID")
            {
                e.Value = new ProductBLL().FindByID(e.Value.ToString()).ProductName;
            }

        }


    }
}
