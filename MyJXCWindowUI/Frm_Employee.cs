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
    //员工信息管理 对员工进行操作窗体（继承 BaseInfoForm.cs）
    public partial class Frm_Employee : MoGuangYuan.MyJXCWindowUI.BaseForm.BaseInfolForm
    {
        private EmployeeBLL employeeBLL;       //创建一个数据访问层的对象
        List<Employee> list;                 //定义一个List泛型集合（类型是Employee实体类）
        private Employee empl;               //创建一个实体类的对象
        private int currentRowsIndex;        //存放选中的行 获取对应的索引值
        string employeeIDSearch;            //存放查询的ID值

        public Frm_Employee()
        {
            InitializeComponent();
            employeeBLL = new EmployeeBLL();
            empl = new Employee();
            BindDateGridView();

        }
        private void BindDateGridView()          //封装填充DateGridView方法
        {
            list = employeeBLL.GetList();         //调用方法获取数据库的记录           
            dgEmployeeInfo.DataSource = list;     //讲获取到的记录填充到 dgEmployeeInfo控件上
        }
        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            //if (dgEmployeeInfo.DataSource != null)
            //{
            //    //取消 dgEmployeeInfo控件的单元格选中状态
            //    dgEmployeeInfo.CurrentCell.Selected = false;
            //}

            //查询的提示
            lblSearch.Text = "请输入员工的编号：";
        }

        private void dgEmployeeInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //解决全选时 索引值超出范围
            if (dgEmployeeInfo.CurrentRow.Index > e.RowIndex || dgEmployeeInfo.CurrentRow.Index < e.RowIndex)
            {
                return;
            }

            //当前选中行反蓝色显示
            dgEmployeeInfo.CurrentRow.Selected = true;

            //获取泛型集合当前选中的行 并给 empl赋值
            empl = list[e.RowIndex];
            //获取索引值
            currentRowsIndex = e.RowIndex;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (op == Operation.UPDATE || op == Operation.DELETE)
            {
                txtEmployeeID.Text = empl.EmployeeID;
                txtEmployeeName.Text = empl.EmployeeName;
                txtEmployeeBrief.Text = empl.Brief;
                if (empl.Sex == 1)
                {
                    cbEmployeeSex.Text = "男";
                }
                else
                {
                    cbEmployeeSex.Text = "女";
                }
                dtEmployeeBirthday.Value = empl.Birthday;

            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("请输入员工编号后再查询！", "提示");
                return;
            }

            try
            {
                employeeIDSearch = txtSearch.Text.Trim();

                empl = employeeBLL.FindByID(employeeIDSearch);
                list.Add(empl);
                //将查询到的结果填充到
                dgEmployeeInfo.DataSource = list;

                //把上一次查找到的行取消反蓝色显示
                dgEmployeeInfo.Rows[currentRowsIndex].Selected = false;

                //找到查询的项的索引值（获取索引值）
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].EmployeeID == empl.EmployeeID)
                    {
                        //查找到的行反蓝色显示
                        dgEmployeeInfo.Rows[i].Selected = true;
                        currentRowsIndex = i;

                        //自动跳转到查找到的行
                        dgEmployeeInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;
                        break;
                    }
                }

                //当更新按钮 或者 删除按钮被单击时 执行赋值语句
                if (op == Operation.UPDATE || op == Operation.DELETE)
                {
                    txtEmployeeID.Text = empl.EmployeeID;
                    txtEmployeeName.Text = empl.EmployeeName;
                    txtEmployeeBrief.Text = empl.Brief;
                    if (empl.Sex == 1)
                    {
                        cbEmployeeSex.Text = "男";
                    }
                    else
                    {
                        cbEmployeeSex.Text = "女";
                    }
                    dtEmployeeBirthday.Value = empl.Birthday;

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

            //初始化（清除）文本控件的值
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeeBrief.Text = string.Empty;
            cbEmployeeSex.Text = null;
            dtEmployeeBirthday.Value = DateTime.Now;

            //设置相应的控件属性（因部分控件在执行更新时会被设置为不可用）
            txtEmployeeID.Enabled = true;
            txtEmployeeName.Enabled = true;
            txtEmployeeBrief.Enabled = true;
            cbEmployeeSex.Enabled = true;
            dtEmployeeBirthday.Enabled = true;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "修改记录信息";
            txtEmployeeID.Enabled = false;

            //设置相应的控件属性（因部分控件在执行更新时会被设置为不可用）
            txtEmployeeName.Enabled = true;
            txtEmployeeBrief.Enabled = true;
            cbEmployeeSex.Enabled = true;
            dtEmployeeBirthday.Enabled = true;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (empl != null)
            {
                txtEmployeeID.Text = empl.EmployeeID;
                txtEmployeeName.Text = empl.EmployeeName;
                txtEmployeeBrief.Text = empl.Brief;
                if (empl.Sex == 1)
                {
                    cbEmployeeSex.Text = "男";
                }
                else
                {
                    cbEmployeeSex.Text = "女";
                }
                dtEmployeeBirthday.Value = empl.Birthday;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            gbInfo.Text = "删除记录信息";

            //设置相应的控件为不可用
            txtEmployeeID.Enabled = false;
            txtEmployeeName.Enabled = false;
            txtEmployeeBrief.Enabled = false;
            cbEmployeeSex.Enabled = false;
            dtEmployeeBirthday.Enabled = false;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (empl != null)
            {
                txtEmployeeID.Text = empl.EmployeeID;
                txtEmployeeName.Text = empl.EmployeeName;
                txtEmployeeBrief.Text = empl.Brief;
                if (empl.Sex == 1)
                {
                    cbEmployeeSex.Text = "男";
                }
                else
                {
                    cbEmployeeSex.Text = "女";
                }

                dtEmployeeBirthday.Value = empl.Birthday;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (op == Operation.INSERT)   //新增按钮被点击
            {
                //判断是否已经输入了所有的值
                foreach (Control col in gbInfo.Controls)
                {
                    if (col is TextBox && col.Text == "")
                    {
                        MessageBox.Show("请输入所有的值", "提示");
                        return;
                    }
                }
                if (cbEmployeeSex.Text == null)
                {
                    MessageBox.Show("请输入所有的值", "提示");
                    return;
                }

                //给实体类赋值
                empl.EmployeeID = txtEmployeeID.Text.Trim();
                empl.EmployeeName = txtEmployeeName.Text.Trim();
                if (cbEmployeeSex.Text == "男")
                {
                    empl.Sex = 1;
                }
                else
                {
                    empl.Sex = 0;
                }
                empl.Birthday = dtEmployeeBirthday.Value.Date;
                empl.Brief = txtEmployeeBrief.Text.Trim();

                try
                {
                    //判断执行是否成功（新增）
                    if (employeeBLL.Insert(empl))
                    {
                        MessageBox.Show("新增成功！", "提示");

                        RestoreControlValue();  //重置控件的值

                        BindDateGridView();                         //调用填充方法 重新填充DateGridView的数据（刷新结果）
                        dgEmployeeInfo.CurrentRow.Selected = false;     //取消行的选中状态（第一行）

                        for (int i = 0; i < list.Count; i++)        //新增的当前行被选中
                        {
                            if (list[i].EmployeeID == empl.EmployeeID)
                            {
                                dgEmployeeInfo.Rows[i].Selected = true;
                                //自动跳转到查找到的行
                                dgEmployeeInfo.FirstDisplayedScrollingRowIndex = i;
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("新增失败！", "提示");
                        RestoreControlValue();  //重置控件的值
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            else if (op == Operation.UPDATE)
            {
                if (empl == null)
                {
                    MessageBox.Show("请选择要修改的数据！", "提示");
                }

                //给实体类赋值
                empl.EmployeeID = txtEmployeeID.Text.Trim();
                empl.EmployeeName = txtEmployeeName.Text.Trim();
                if (cbEmployeeSex.Text == "男")
                {
                    empl.Sex = 1;
                }
                else
                {
                    empl.Sex = 0;
                }
                empl.Birthday = dtEmployeeBirthday.Value.Date;
                empl.Brief = txtEmployeeBrief.Text.Trim();


                try
                {
                    //判断执行是否成功（更新）
                    if (employeeBLL.Update(empl))
                    {
                        MessageBox.Show("更新成功！", "提示");
                        BindDateGridView();                                   //重新填充ateGridView （刷新结果）
                        dgEmployeeInfo.CurrentRow.Selected = false;               //取消行的选中状态（第一行）
                        dgEmployeeInfo.Rows[currentRowsIndex].Selected = true;    //将当前被更新的行进行反蓝色显示
                        //自动跳转到查找到的行
                        dgEmployeeInfo.FirstDisplayedScrollingRowIndex = currentRowsIndex;
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
            else if (op == Operation.DELETE)
            {
                //弹出是否确认删除的对话框
                DialogResult result = MessageBox.Show("您是否真的要删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (employeeBLL.Delete(empl))
                        {
                            MessageBox.Show("删除成功", "提示");
                            BindDateGridView();
                            dgEmployeeInfo.CurrentRow.Selected = false;   //取消行的选中状态（第一行）   

                            //直接初始化 当前窗口
                            btnNewAdd.Enabled = btnModify.Enabled = btnDelete.Enabled = true;
                            gbInfo.Visible = false;

                            //初始化（清除）文本控件的值
                            txtEmployeeID.Text = string.Empty;
                            txtEmployeeName.Text = string.Empty;
                            txtEmployeeBrief.Text = string.Empty;
                            cbEmployeeSex.Text = null;
                            dtEmployeeBirthday.Value = DateTime.Now;
                            empl = null;
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

        private void RestoreControlValue()   //重置控件的值
        {
            //初始化文本控件的值(清空)
            foreach (Control col in gbInfo.Controls)
            {
                if (col is TextBox)
                {
                    ((TextBox)col).Text = string.Empty;
                }
            }
            dtEmployeeBirthday.Value = DateTime.Now;
        }

        private void dgEmployeeInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgEmployeeInfo.Columns[e.ColumnIndex].Name == "sex")
            {
                if (Convert.ToInt32(e.Value) == 1)
                {
                    e.Value = "男";
                }
                else
                {
                    e.Value = "女";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RestoreControlValue();  //重置控件的值
        }


    }
}
