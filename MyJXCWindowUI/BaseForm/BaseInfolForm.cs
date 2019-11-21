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

namespace MoGuangYuan.MyJXCWindowUI.BaseForm
{
    //基本信息管理的父类窗体
    public partial class BaseInfolForm : Form
    {
        protected Operation op;            //创建一个枚举对象
        public BaseInfolForm()
        {
            InitializeComponent();
            gbInfo.Text = "新增记录信息";  //给当前的gbInfo控件的标题起名称
        }
        //private void btnSearch_Click(object sender, EventArgs e)    //查询
        //{
        //    op = Operation.SEARCH;
        //}

        private void btnNewAdd_Click(object sender, EventArgs e)  //新增
        {
            op = Operation.INSERT;   //记下当前状态（标记）
            gbInfo.Visible = true;
            btnNewAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            
        }      

        private void btnModify_Click(object sender, EventArgs e)   //修改
        {
            op = Operation.UPDATE;   //记下当前状态（标记）
            gbInfo.Visible = true;
            btnNewAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)   //删除
        {
            op = Operation.DELETE;   //记下当前状态（标记）
            gbInfo.Visible = true;
            btnNewAdd.Enabled = false;
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)   //取消
        {
            op = Operation.NONE;    //记下当前状态（标记）
            gbInfo.Visible = false;
            btnNewAdd.Enabled = btnModify.Enabled = btnDelete.Enabled = true;   //恢复按钮初始状态

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //op = Operation.SEARCH;   //记下当前状态（标记）
        }

        private void btnSearchCancel_Click(object sender, EventArgs e)
        {
            //清空
            txtSearch.Text = string.Empty;        
        }

     
    }
}
