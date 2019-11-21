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
    public partial class Frm_ChooseProduct : Form
    {
        List<Product> list = new List<Product>();    //定义一个产品的泛型集合   存放数据源
        private Product product;                     //定义一个产品的对象 存放当前选中行的值     

        public Frm_ChooseProduct()
        {
            InitializeComponent();

            //绑定数据源
            list = new ProductBLL().GetList();
            dgChooseProductInfo.DataSource = list;
            dgChooseProductInfo.Columns[8].Visible = false;
            dgChooseProductInfo.Columns[9].Visible = false;
            dgChooseProductInfo.Columns[10].Visible = false;

        }

        private void Frm_ChooseProduct_Load(object sender, EventArgs e)
        {
            //取消第一个单元格的反蓝色显示
            dgChooseProductInfo.CurrentCell.Selected = false;
        }

        private void dgChooseProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //反蓝色显示当前选中的行
            dgChooseProductInfo.CurrentRow.Selected = true;
        }

        private void dgChooseProductInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前选择行的数据
            product = list[e.RowIndex];

            //定义一个明细的对象获取产品的ID值
            PurchaseDetail detail = new PurchaseDetail();
            detail.ProductID = product.ProductID;

            //设置价格默认为0
            detail.PurchasePrice = 0;
            detail.Quantity = 0;

            //双击后得到的值 传回订单填写窗体的DataGridView控件（订单明细）
            Frm_FillPurchaseBill.purchaseDetail_Add = detail;

            //关闭当前窗体
            this.Close();
        }

        private void txtSearchBySpellingCode_TextChanged(object sender, EventArgs e)
        {
            string spellingCode = txtSearchBySpellingCode.Text.Trim();

            //根据拼音码模糊查询
            list = new ProductBLL().SelectProductBySpellingCode(spellingCode);
            dgChooseProductInfo.DataSource = list;
            if (list.Count != 0)
            {
                //取消第一个单元格的反蓝色显示
                dgChooseProductInfo.CurrentCell.Selected = false;
            }
        }


    }
}
