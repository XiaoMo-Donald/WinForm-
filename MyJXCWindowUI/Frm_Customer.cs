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
    //客户信息管理  对客户进行操作窗体（继承 BaseInfoForm.cs） 
    public partial class Frm_Customer : MoGuangYuan.MyJXCWindowUI.BaseForm.BaseInfolForm
    {
        private CustomerBLL customerBLL;      //创建一个数据访问层的对象
        List<Customer> list;                 //定义一个List泛型集合（类型是Customer实体类）
        private Customer cust;               //创建一个实体类的对象
        private int currentRowsIndex;        //存放选中的行 获取对应的索引值
        string customerIDSearch;            //存放查询的ID值

        public Frm_Customer()
        {
            InitializeComponent();
            customerBLL = new CustomerBLL();
            BindDateGridView();
            cust = new Customer();
          
        }
        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            //取消 dgEmployeeInfo控件的单元格选中状态
            dgCustomerInfo.CurrentCell.Selected = false;
            
            //查询的提示
            lblSearch.Text = "请输入客户的编号：";
        }
        
        private void BindDateGridView()          //封装填充DateGridView方法
        {
            list = customerBLL.GetList();         //调用方法获取数据库的记录
            dgCustomerInfo.DataSource = list;     //讲获取到的记录填充到 dgEmployeeInfo控件上
        }
        private void dgCustomerInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            
            //解决全选时 索引值超出范围
            if (dgCustomerInfo.CurrentRow.Index > e.RowIndex || dgCustomerInfo.CurrentRow.Index < e.RowIndex)
            {
                return;
            }

            //当前选中行反蓝色显示
            dgCustomerInfo.CurrentRow.Selected = true;

            //获取泛型集合当前选中的行 并给cust赋值
            cust = list[e.RowIndex];
            //获取索引值
            currentRowsIndex = e.RowIndex;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (op == Operation.UPDATE || op == Operation.DELETE)
            {
                txtCustomerID.Text = cust.CustomerID;
                txtCustomerName.Text = cust.CustomerContact.Name;
                txtSpellingCode.Text = cust.CustomerContact.SpellingCode;
                txtCustomerAddress.Text = cust.CustomerContact.Address;
                txtCustomerZipCode.Text = cust.CustomerContact.ZipCode;
                txtCustomerTel.Text = cust.CustomerContact.Tel;
                txtCustomerFax.Text = cust.CustomerContact.Fax;
                txtCustomerBankName.Text = cust.CustomerContact.BankName;
                txtCustomerBankAccount.Text = cust.CustomerContact.BankAccount;
                txtContacter.Text = cust.CustomerContact.Contacter;
                txtCustomerEmail.Text = cust.CustomerContact.Email;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)                //查询
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("请输入客户编号后再查询！", "提示");
                return;
            }

            try
            {
                customerIDSearch = txtSearch.Text.Trim();

                cust = customerBLL.FindByID(customerIDSearch);
                list.Add(cust);
                //将查询到的结果填充到
                dgCustomerInfo.DataSource = list;               

                //把上一次查找到的行取消反蓝色显示
                dgCustomerInfo.Rows[currentRowsIndex].Selected = false;

                //找到查询的项的索引值（获取索引值）
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CustomerID == cust.CustomerID)
                    {
                        //查找到的行反蓝色显示
                        dgCustomerInfo.Rows[i].Selected = true;
                        currentRowsIndex = i;

                        //自动跳转到查找到的行
                        dgCustomerInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;
                        break;
                    }
                }

                //当更新按钮 或者 删除按钮被单击时 执行赋值语句
                if (op == Operation.UPDATE || op == Operation.DELETE)
                {
                    txtCustomerID.Text = cust.CustomerID;
                    txtCustomerName.Text = cust.CustomerContact.Name;
                    txtSpellingCode.Text = cust.CustomerContact.SpellingCode;
                    txtCustomerAddress.Text = cust.CustomerContact.Address;
                    txtCustomerZipCode.Text = cust.CustomerContact.ZipCode;
                    txtCustomerTel.Text = cust.CustomerContact.Tel;
                    txtCustomerFax.Text = cust.CustomerContact.Fax;
                    txtCustomerBankName.Text = cust.CustomerContact.BankName;
                    txtCustomerBankAccount.Text = cust.CustomerContact.BankAccount;
                    txtContacter.Text = cust.CustomerContact.Contacter;
                    txtCustomerEmail.Text = cust.CustomerContact.Email;
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
                    ((TextBox)col).Text = string.Empty;
                }
            }
            //设置所有的控件可用
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Enabled = true;
                }
            }
            txtSpellingCode.Enabled = false;
        }
         private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //读取拼音码
            txtSpellingCode.Text = Comm.HZToSpell(txtCustomerName.Text.Trim());
        }


        private void btnModify_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "修改记录信息";

            //设置所有的控件可用
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Enabled = true;
                }
            }
            txtCustomerID.Enabled = false;
            txtSpellingCode.Enabled = false;

            //不为空的时候重新绑定数据
            if (cust != null)
            {
                txtCustomerID.Text = cust.CustomerID;
                txtCustomerName.Text = cust.CustomerContact.Name;
                txtSpellingCode.Text = cust.CustomerContact.SpellingCode;
                txtCustomerAddress.Text = cust.CustomerContact.Address;
                txtCustomerZipCode.Text = cust.CustomerContact.ZipCode;
                txtCustomerTel.Text = cust.CustomerContact.Tel;
                txtCustomerFax.Text = cust.CustomerContact.Fax;
                txtCustomerBankName.Text = cust.CustomerContact.BankName;
                txtCustomerBankAccount.Text = cust.CustomerContact.BankAccount;
                txtContacter.Text = cust.CustomerContact.Contacter;
                txtCustomerEmail.Text = cust.CustomerContact.Email;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "删除记录信息";

            //设置所有的控件可用
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Enabled = false;
                }
            }

            //不为空的时候重新绑定数据
            if (cust!=null)
            {
                txtCustomerID.Text = cust.CustomerID;
                txtCustomerName.Text = cust.CustomerContact.Name;
                txtSpellingCode.Text = cust.CustomerContact.SpellingCode;
                txtCustomerAddress.Text = cust.CustomerContact.Address;
                txtCustomerZipCode.Text = cust.CustomerContact.ZipCode;
                txtCustomerTel.Text = cust.CustomerContact.Tel;
                txtCustomerFax.Text = cust.CustomerContact.Fax;
                txtCustomerBankName.Text = cust.CustomerContact.BankName;
                txtCustomerBankAccount.Text = cust.CustomerContact.BankAccount;
                txtContacter.Text = cust.CustomerContact.Contacter;
                txtCustomerEmail.Text = cust.CustomerContact.Email;
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

                cust.CustomerContact = new ContactInfo();
                //获取参数
                cust.CustomerID = txtCustomerID.Text.Trim();
                cust.CustomerContact.Name = txtCustomerName.Text.Trim();
                cust.CustomerContact.SpellingCode = txtSpellingCode.Text.Trim();
                cust.CustomerContact.Address = txtCustomerAddress.Text.Trim();
                cust.CustomerContact.ZipCode = txtCustomerZipCode.Text.Trim();
                cust.CustomerContact.Tel = txtCustomerTel.Text.Trim();
                cust.CustomerContact.Fax = txtCustomerFax.Text.Trim();
                cust.CustomerContact.BankName = txtCustomerBankName.Text.Trim();
                cust.CustomerContact.BankAccount = txtCustomerBankAccount.Text.Trim();
                cust.CustomerContact.Contacter = txtContacter.Text.Trim();
                cust.CustomerContact.Email = txtCustomerEmail.Text.Trim();
                

                try
                {
                    //判断执行是否成功（新增）
                    if (customerBLL.Insert(cust))
                    {
                        MessageBox.Show("新增成功！", "提示");

                        //清空控件的文本
                        foreach (Control col in gbInfo.Controls)
                        {
                            if (col is TextBox)
                            {
                                ((TextBox)col).Text = string.Empty;
                            }
                        }                       
                        BindDateGridView();                         //调用填充方法 重新填充DateGridView的数据（刷新结果）
                        dgCustomerInfo.CurrentRow.Selected = false;     //取消行的选中状态（第一行）

                        for (int i = 0; i < list.Count; i++)        //新增的当前行被选中
                        {
                            if (list[i].CustomerID==cust.CustomerID)
                            {
                                dgCustomerInfo.Rows[i].Selected = true;

                                //自动跳转到查找到的行
                                dgCustomerInfo.FirstDisplayedScrollingRowIndex = i;
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
                if (cust== null)
                {
                    MessageBox.Show("请选择要修改的数据！", "提示");
                }

                cust.CustomerContact = new ContactInfo();
                //获取参数
                cust.CustomerID = txtCustomerID.Text.Trim();
                cust.CustomerContact.Name = txtCustomerName.Text.Trim();
                cust.CustomerContact.SpellingCode = txtSpellingCode.Text.Trim();
                cust.CustomerContact.Address = txtCustomerAddress.Text.Trim();
                cust.CustomerContact.ZipCode = txtCustomerZipCode.Text.Trim();
                cust.CustomerContact.Tel = txtCustomerTel.Text.Trim();
                cust.CustomerContact.Fax = txtCustomerFax.Text.Trim();
                cust.CustomerContact.BankName = txtCustomerBankName.Text.Trim();
                cust.CustomerContact.BankAccount = txtCustomerBankAccount.Text.Trim();
                cust.CustomerContact.Contacter = txtContacter.Text.Trim();
                cust.CustomerContact.Email = txtCustomerEmail.Text.Trim();
                
                try
                {
                    //判断执行是否成功（更新）
                    if (customerBLL.Update(cust))
                    {
                        
                        MessageBox.Show("更新成功！", "提示");
                        BindDateGridView();                                   //重新填充ateGridView （刷新结果）
                        dgCustomerInfo.CurrentRow.Selected = false;               //取消行的选中状态（第一行）
                        dgCustomerInfo.Rows[currentRowsIndex].Selected = true;    //将当前被更新的行进行反蓝色显示
                       
                        dgCustomerInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;  //自动跳转到查找到的行
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
                if (cust == null)
                {
                    MessageBox.Show("请选择要删除的数据！", "提示");
                }

                //弹出是否确认删除的对话框
                DialogResult result = MessageBox.Show("您是否真的要删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (customerBLL.Delete(cust))
                        {
                            MessageBox.Show("删除成功", "提示");
                            BindDateGridView();
                            dgCustomerInfo.CurrentRow.Selected = false;   //取消行的选中状态（第一行）                          
                          
                            //清空控件的文本
                            foreach (Control col in gbInfo.Controls)
                            {
                                if (col is TextBox)
                                {
                                    ((TextBox)col).Text = string.Empty;
                                }
                            }            
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

        private void dgCustomerInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "customerName")
            {
                e.Value = ((ContactInfo)e.Value).Name;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "spellingCode")
            {
                e.Value = ((ContactInfo)e.Value).SpellingCode;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "address")
            {
                 e.Value = ((ContactInfo)e.Value).Address;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "zipCode")
            {
                e.Value = ((ContactInfo)e.Value).ZipCode;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "tel")
            {
                e.Value = ((ContactInfo)e.Value).Tel;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "fax")
            {
                e.Value = ((ContactInfo)e.Value).Fax;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "bankName")
            {
                e.Value = ((ContactInfo)e.Value).BankName;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "bankAccount")
            {
                e.Value = ((ContactInfo)e.Value).BankAccount;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "contacter")
            {
                e.Value = ((ContactInfo)e.Value).Contacter;
            }
            else if (dgCustomerInfo.Columns[e.ColumnIndex].Name == "email")
            {
                e.Value = ((ContactInfo)e.Value).Email;
            }
          
        }
      
    }
}
