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
    //产品分类管理 对分类进行操作窗体（继承 BaseInfoForm.cs） 

    public partial class Frm_Category : MoGuangYuan.MyJXCWindowUI.BaseForm.BaseInfolForm
    {
        private CategoryBLL categoryBll;     //创建一个数据访问层的对象
        List<Category> list;                 //定义一个List泛型集合（类型是Category实体类）
        private Category cate;               //创建一个实体类的对象
        private int currentRowsIndex;        //存放选中的行 获取对应的索引值
        string categoryIDSearch ;            //存放查询的ID值

        public Frm_Category()
        {
            InitializeComponent();
            categoryBll = new CategoryBLL();  //将对象实例化
            BindDateGridView();                //调用封装的方法
        }

        private void BindDateGridView()        //封装填充DateGridView方法
        {
            list = categoryBll.GetList();     //调用方法获取数据库的记录           
            dgCategroy.DataSource = list;     //讲获取到的记录填充到dgCategroy控件上
        }
        private void Frm_Category_Load(object sender, EventArgs e)     //窗体载入事件
        {
            //取消dgCategroy控件的单元格选中状态
            dgCategroy.CurrentCell.Selected = false;

            //查询的提示
            lblSearch.Text = "请输入产品类别编号：";
        }
        private void dgCategroy_CellClick(object sender, DataGridViewCellEventArgs e)   //单元格单击事件
        {
            //解决索引值超出范围
            if (dgCategroy.CurrentRow.Index > e.RowIndex || dgCategroy.CurrentRow.Index < e.RowIndex)
            {
                return;
            }

            //当前选中行反蓝色显示
            dgCategroy.CurrentRow.Selected = true;

            //获取泛型集合当前选中的行 并给cate赋值
            cate = list[e.RowIndex];
            //获取索引值
            currentRowsIndex = e.RowIndex;

            //当更新按钮 或者 删除按钮被单击时 执行赋值语句
            if (op == Operation.UPDATE || op == Operation.DELETE)
            {
                txtCategoryID.Text = cate.CategoryID;
                txtCategoryName.Text = cate.CategoryName;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)      //查询按钮事件
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("请输入产品类别编号后再查询！", "提示");
                return;
            }

            try
            {
                categoryIDSearch = txtSearch.Text.Trim();

                cate = categoryBll.FindByID(categoryIDSearch);
                list.Add(cate);
                //将查询到的结果填充

                dgCategroy.DataSource = list;
                //找到查询的项的索引值（获取索引值）
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].CategoryID == cate.CategoryID)
                    {
                        //查找到的行反蓝色显示
                        dgCategroy.Rows[i].Selected = true;
                        currentRowsIndex = i;

                        //自动跳转到查找到的行
                        dgCategroy.FirstDisplayedScrollingRowIndex = currentRowsIndex;
                        break;
                    }
                }
                //当更新按钮 或者 删除按钮被单击时 执行赋值语句
                if (op == Operation.UPDATE || op == Operation.DELETE)
                {
                    //给控件赋值
                    txtCategoryID.Text = cate.CategoryID;
                    txtCategoryName.Text = cate.CategoryName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("没有该记录！", "提示");
            }

        }      


        private void btnNewAdd_Click(object sender, EventArgs e)      //新增按钮事件
        {
            gbInfo.Text = "新增记录信息";
            txtCategoryID.Enabled = true;
            txtCategoryName.Enabled = true;
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }

        private void btnModify_Click(object sender, EventArgs e)      //修改按钮事件
        {
            gbInfo.Text = "修改记录信息";
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = true;

            //解决单元格被选中时 单击修改按钮不能赋值的问题
            if (cate != null)
            {
                txtCategoryID.Text = cate.CategoryID;
                txtCategoryName.Text = cate.CategoryName;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)      //删除按钮事件
        {
            gbInfo.Text = "删除记录信息";
            txtCategoryID.Enabled = false;
            txtCategoryName.Enabled = false;

            //解决单元格被选中时 单击修改按钮不能赋值的问题
            if (cate != null)
            {
                txtCategoryID.Text = cate.CategoryID;
                txtCategoryName.Text = cate.CategoryName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)     //存盘按钮事件
        {
            if (op == Operation.INSERT)   //新增按钮被点击
            {
                //判断是否输入了所有的值
                if (txtCategoryID.Text == "" || txtCategoryName.Text == "")
                {
                    MessageBox.Show("请输入所有的值", "提示");
                }

                //获取文本框的值给对象的属性赋值
                cate = new Category();
                cate.CategoryID = txtCategoryID.Text.Trim();
                cate.CategoryName = txtCategoryName.Text.Trim();

                try
                {
                    //判断执行是否成功（新增）
                    if (categoryBll.Insert(cate))
                    {
                        MessageBox.Show("新增成功！", "提示");
                        txtCategoryID.Text = string.Empty;          //清空文本框的值（效率比clear高）
                        txtCategoryName.Text = string.Empty;        //清空文本框的值（效率比clear高）

                        BindDateGridView();                         //调用填充方法 重新填充DateGridView的数据（刷新结果）
                        dgCategroy.CurrentRow.Selected = false;     //取消行的选中状态（第一行）

                        for (int i = 0; i < list.Count; i++)        //新增的当前行被选中
                        {
                            if (list[i].CategoryID == cate.CategoryID)
                            {
                                dgCategroy.Rows[i].Selected = true;

                                //自动跳转到查找到的行
                                dgCategroy.FirstDisplayedScrollingRowIndex = i;
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
                if (cate == null)
                {
                    MessageBox.Show("请选择要修改的数据！", "提示");
                    return;
                }

                cate.CategoryName = txtCategoryName.Text.Trim();              //获取文本框的值给对象的属性赋值

                try
                {
                    //判断执行是否成功（更新）
                    if (categoryBll.Update(cate))
                    {
                        MessageBox.Show("更新成功！", "提示");
                        BindDateGridView();                                   //重新填充ateGridView （刷新结果）
                        dgCategroy.CurrentRow.Selected = false;               //取消行的选中状态（第一行）
                        dgCategroy.Rows[currentRowsIndex].Selected = true;    //将当前被更新的行进行反蓝色显示
                        //自动跳转到查找到的行
                        dgCategroy.FirstDisplayedScrollingRowIndex = currentRowsIndex;

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
                if (cate == null)
                {
                    MessageBox.Show("请选择要删除的数据！", "提示");
                }

                //弹出是否确认删除的对话框
                DialogResult result = MessageBox.Show("您是否真的要删除?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (categoryBll.Delete(cate))
                        {
                            MessageBox.Show("删除成功", "提示");
                            BindDateGridView();
                            dgCategroy.CurrentRow.Selected = false;   //取消行的选中状态（第一行）
                            cate = null;                              //清空参数

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }




    }
}
