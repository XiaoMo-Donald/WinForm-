using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoGuangYuan.BLL;
using MoGuangYuan.Model;

namespace MoGuangYuan.MyJXCWindowUI
{
    //产品信息管理  对产品进行操作窗体（继承 BaseInfoForm.cs） 
    public partial class Frm_Product : MoGuangYuan.MyJXCWindowUI.BaseForm.BaseInfolForm
    {
        private ProductBLL productBLL;     //创建一个数据访问层的对象
        List<Product> list;                 //定义一个List泛型集合（类型是Product实体类）
        private Product prod;               //创建一个实体类的对象
        private int currentRowsIndex;        //存放选中的行 获取对应的索引值
        string productIDSearch;            //存放查询的ID值

        public Frm_Product()
        {
            InitializeComponent();
            productBLL = new ProductBLL();
            BindDateGridView();

        }

        private void BindDateGridView()          //封装填充DateGridView方法
        {
            list = productBLL.GetList();         //调用方法获取数据库的记录           
            dgProductInfo.DataSource = list;     //讲获取到的记录填充到dgProductInfo控件上
        }
        private void Frm_Product_Load(object sender, EventArgs e)
        {
            //取消dgProductInfo控件的单元格选中状态
            dgProductInfo.CurrentCell.Selected = false;
            //绑定
            cbCategory.DataSource = new CategoryBLL().GetList();
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";

            //查询的提示
            lblSearch.Text = "请输入产品的编号：";

        }

        private void dgProductInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //解决全选时 索引值超出范围
            if (dgProductInfo.CurrentRow.Index > e.RowIndex || dgProductInfo.CurrentRow.Index < e.RowIndex)
            {
                return;
            }

            //当前选中行反蓝色显示
            dgProductInfo.CurrentRow.Selected = true;

            //获取泛型集合当前选中的行 并给prod赋值
            prod = list[e.RowIndex];
            //获取索引值
            currentRowsIndex = e.RowIndex;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (op == Operation.UPDATE || op == Operation.DELETE)
            {
                txtProductID.Text = prod.ProductID;
                txtProductName.Text = prod.ProductName;
                txtSpellingCode.Text = prod.SpellingCode;
                txtBarcode.Text = prod.Barcode;
                txtSpecial.Text = prod.Special;
                txtUnit.Text = prod.Unit;
                txtOrigin.Text = prod.Origin;
                cbCategory.SelectedValue = prod.CategoryID;
                txtPurchasePrice.Text = prod.PurchasePrice.ToString();
                txtSalePrice.Text = prod.SalePrice.ToString();
                txtQuantity.Text = prod.Quantity.ToString();

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("请输入产品编号后再查询！", "提示");
                return;
            }

            try
            {
                productIDSearch = txtSearch.Text.Trim();
                prod = productBLL.FindByID(productIDSearch);
                list.Add(prod);
                //将查询到的结果填充到
                dgProductInfo.DataSource = list;

                //把上一次查找到的行取消反蓝色显示
                dgProductInfo.Rows[currentRowsIndex].Selected = false;

                //找到查询的项的索引值（获取索引值）
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].ProductID == prod.ProductID)
                    {
                        //查找到的行反蓝色显示
                        dgProductInfo.Rows[i].Selected = true;
                        currentRowsIndex = i;

                        //自动跳转到查找到的行
                        dgProductInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;
                        break;
                    }
                }
                //当更新按钮 或者 删除按钮被单击时 执行赋值语句
                if (op == Operation.UPDATE || op == Operation.DELETE)
                {
                    txtProductID.Text = prod.ProductID;
                    txtProductName.Text = prod.ProductName;
                    txtSpellingCode.Text = prod.SpellingCode;
                    txtBarcode.Text = prod.Barcode;
                    txtSpecial.Text = prod.Special;
                    txtUnit.Text = prod.Unit;
                    txtOrigin.Text = prod.Origin;
                    cbCategory.SelectedValue = prod.CategoryID;
                    txtPurchasePrice.Text = prod.PurchasePrice.ToString();
                    txtSalePrice.Text = prod.SalePrice.ToString();
                    txtQuantity.Text = prod.Quantity.ToString();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("没有该记录！", "提示");
            }

        }
        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "新增记录信息";

            //使用遍历组合框 里 的控件 初始化（清除）控件的文本值
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Text = "";
                }
            }

            txtPurchasePrice.Text = "0";
            txtSalePrice.Text = "0";
            txtQuantity.Text = "0";
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Enabled = true;
                }
            }
            txtSpellingCode.Enabled = false;
            txtPurchasePrice.Enabled = false;
            txtSalePrice.Enabled = false;
            txtQuantity.Enabled = false;
            cbCategory.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "修改记录信息";
            txtProductID.Enabled = false;
            txtProductName.Enabled = true;
            txtSpellingCode.Enabled = false;
            txtBarcode.Enabled = true;
            txtSpecial.Enabled = true;
            txtUnit.Enabled = true;
            txtOrigin.Enabled = true;
            cbCategory.Enabled = true;
            txtPurchasePrice.Enabled = false;
            txtSalePrice.Enabled = false;
            txtQuantity.Enabled = false;


            //解决单元格被选中时 单击修改按钮不能赋值的问题
            if (prod != null)
            {
                txtProductID.Text = prod.ProductID;
                txtProductName.Text = prod.ProductName;
                txtSpellingCode.Text = prod.SpellingCode;
                txtBarcode.Text = prod.Barcode;
                txtSpecial.Text = prod.Special;
                txtUnit.Text = prod.Unit;
                txtOrigin.Text = prod.Origin;
                cbCategory.SelectedValue = prod.CategoryID;
                txtPurchasePrice.Text = prod.PurchasePrice.ToString();
                txtSalePrice.Text = prod.SalePrice.ToString();
                txtQuantity.Text = prod.Quantity.ToString();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "删除记录信息";
            cbCategory.Enabled = false;

            //使用遍历设置文本框的属性（不可用）
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Enabled = false;
                }
            }

            //解决单元格被选中时 单击修改按钮不能赋值的问题
            if (prod != null)
            {
                txtProductID.Text = prod.ProductID;
                txtProductName.Text = prod.ProductName;
                txtSpellingCode.Text = prod.SpellingCode;
                txtBarcode.Text = prod.Barcode;
                txtSpecial.Text = prod.Special;
                txtUnit.Text = prod.Unit;
                txtOrigin.Text = prod.Origin;
                cbCategory.SelectedValue = prod.CategoryID;
                txtPurchasePrice.Text = prod.PurchasePrice.ToString();
                txtSalePrice.Text = prod.SalePrice.ToString();
                txtQuantity.Text = prod.Quantity.ToString();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (op == Operation.INSERT)   //新增按钮被点击
            {
                //判断是否输入了所有的值
                foreach (Control col in gbInfo.Controls)
                {
                    if (col is TextBox && col.Text == "")
                    {
                        MessageBox.Show("请输入所有的值", "提示");
                        return;
                    }
                }

                SetProductParmeters();  //调用方法 赋值

                try
                {
                    //判断执行是否成功（新增）
                    if (productBLL.Insert(prod))
                    {
                        MessageBox.Show("新增成功！", "提示");
                        //清空
                        foreach (Control col in gbInfo.Controls)
                        {
                            if (col is TextBox)
                            {
                                ((TextBox)col).Text = string.Empty;
                            }
                        }

                        BindDateGridView();                         //调用填充方法 重新填充DateGridView的数据（刷新结果）
                        dgProductInfo.CurrentRow.Selected = false;     //取消行的选中状态（第一行）

                        for (int i = 0; i < list.Count; i++)        //新增的当前行被选中
                        {
                            if (list[i].ProductID == prod.ProductID)
                            {
                                dgProductInfo.Rows[i].Selected = true;
                                //自动跳转到查找到的行
                                dgProductInfo.FirstDisplayedScrollingRowIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("新增失败！", "提示");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else if (op == Operation.UPDATE)   //修改按钮被点击
            {
                if (prod == null)
                {
                    MessageBox.Show("请选择要修改的数据！", "提示");
                }


                SetProductParmeters();  //调用方法 赋值

                try
                {
                    //判断执行是否成功（更新）
                    if (productBLL.Update(prod))
                    {

                        MessageBox.Show("更新成功！", "提示");
                        BindDateGridView();                                   //重新填充ateGridView （刷新结果）
                        dgProductInfo.CurrentRow.Selected = false;               //取消行的选中状态（第一行）
                        dgProductInfo.Rows[currentRowsIndex].Selected = true;    //将当前被更新的行进行反蓝色显示
                        //自动跳转到查找到的行
                        dgProductInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;
                    }
                    else
                    {
                        MessageBox.Show("更新失败！", "提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else if (op == Operation.DELETE)   //删除按钮被点击
            {
                if (prod == null)
                {
                    MessageBox.Show("请选择要删除的数据！", "提示");
                }

                //弹出是否确认删除的对话框
                DialogResult result = MessageBox.Show("您是否真的要删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (productBLL.Delete(prod))
                        {
                            MessageBox.Show("删除成功", "提示");
                            BindDateGridView();
                            dgProductInfo.CurrentRow.Selected = false;   //取消行的选中状态（第一行）
                            prod = null;                                 //清空参数

                            //直接初始化 当前窗口
                            btnNewAdd.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                            gbInfo.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("删除失败！", "提示");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void SetProductParmeters()   //获取文本框的值给对象的属性赋值（封装成方法）
        {
            prod = new Product();
            prod.ProductID = txtProductID.Text.Trim();
            prod.ProductName = txtProductName.Text.Trim();
            prod.SpellingCode = txtSpellingCode.Text.Trim();
            prod.Barcode = txtBarcode.Text.Trim();
            prod.Special = txtSpecial.Text.Trim();
            prod.Unit = txtUnit.Text.Trim();
            prod.Origin = txtOrigin.Text.Trim();
            prod.CategoryID = cbCategory.SelectedValue.ToString().Trim();
            prod.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text.Trim());
            prod.SalePrice = Convert.ToDouble(txtSalePrice.Text.Trim());
            prod.Quantity = Convert.ToInt32(txtQuantity.Text.Trim());
        }

        private void dgProductInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgProductInfo.Columns[e.ColumnIndex].Name == "categoryID")
            {
                e.Value = new CategoryBLL().FindByID(e.Value.ToString()).CategoryName;
            }
        }

        //读取拼音码
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            txtSpellingCode.Text = Comm.HZToSpell(txtProductName.Text.Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

     
    }
}
