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
using MoGuangYuan.Common;

namespace MoGuangYuan.MyJXCWindowUI
{
    public partial class Frm_SystemUser : Form
    {
        private SystemUserBLL userBLL;
        //List<string> idList;            //获取用户ID 方法1 
        private SystemUser user;        //存放用户的信息（权限）   
        private Encrypt encrypt;

        CheckBox[] c1 = new CheckBox[5];   //基本信息管理权限控件数组
        CheckBox[] c2 = new CheckBox[3];   //进货管理权限控件数组
        CheckBox[] c3 = new CheckBox[2];   //销售管理权限控件数组
        CheckBox[] c4 = new CheckBox[2];   //用户管理权限控件数组

        public Frm_SystemUser()
        {
            InitializeComponent();
            userBLL = new SystemUserBLL();
            encrypt = new Encrypt();
            //绑定获取所有的用户ID（方法：1 2 3 4 ）

            //方法 2 3 4 定义一个泛型集合
            List<SystemUser> userIDList = userBLL.GetList();
            List<string> idList = new List<string>();

            //方法1.写GetAllUserID只获取用户ID的存储过程
            //BindlistBox();

            //方法2.用Foreach循环
            foreach (SystemUser u in userIDList)
            {
                if (u.UserID != "admin")
                {
                    idList.Add(u.UserID);
                }
            }
            lbUserList.DataSource = idList;
            lbUserList.SelectedIndex = -1;

            //方法3.用Lingq表达式


            //方法4.用Linbada表达式


            //给相应的数组赋值（值为控件名）
            c1[0] = cbCategoryManagement;
            c1[1] = cbProductInfoManagement;
            c1[2] = cbSupplierInfoManagement;
            c1[3] = cbCustomerInfoManagement;
            c1[4] = cbEmployeesInfoManagement;

            c2[0] = cbFillPurchaseBill;
            c2[1] = cbExamPurchaseBill;
            c2[2] = cbInStockCheck;

            c3[0] = cbSalesManagement;
            c3[1] = cbSalesReturn;

            c4[0] = cbChangeThePassword;
            c4[1] = cbUserManagement;
        }

        //private void BindlistBox()  //封装绑定lbUserList 获取所有的用户ID的方法
        //{
        //    idList = userBLL.GetAllUserID();
        //    lbUserList.DataSource = idList;
        //    lbUserList.SelectedIndex = -1;
        //}
        private void lbUserList_Click(object sender, EventArgs e)
        {
            if (lbUserList.DataSource != null)
            {
                //获取用户的ID
                string userID = lbUserList.SelectedItem.ToString();

                //获取用户信息
                user = userBLL.FindByID(userID);

                txtUserName.Text = user.UserID;
                txtPassword.Text = user.Password.ToString();
                txtName.Text = new EmployeeBLL().FindByID(user.UserID).EmployeeName;

                //获取当前用户的权限 调用 Recover()方法 （自定义方法）
                Recover(user.BaseFunction, c1);
                Recover(user.PurchaseFunction, c2);
                Recover(user.SaleFunction, c3);
                Recover(user.UserFunction, c4);
            }
        }

        private void Recover(int function, CheckBox[] c)   //获取当前用户的权限 
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (function % 2 == 1)
                {
                    c[i].Checked = true;
                }
                else
                {
                    c[i].Checked = false;
                }
                function = function / 2;
            }
        }
        private void SetAll(bool b, CheckBox[] c)     //设置全选或者取消全部权限（用于每个权限的管理）
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            for (int i = 0; i < c.Length; i++)
            {
                c[i].Checked = b;
            }
        }
        private void btnSelectPermissionsAll_Click(object sender, EventArgs e)  //选择全部权限 （全局）
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(true, c1);
            SetAll(true, c2);
            SetAll(true, c3);
            SetAll(true, c4);
        }

        private void btnRemovePermissionsAll_Click(object sender, EventArgs e)  //清除全部权限 （全局）
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(false, c1);
            SetAll(false, c2);
            SetAll(false, c3);
            SetAll(false, c4);
        }

        private void btnSelectPermissionsForBaseFunction_Click(object sender, EventArgs e)   //选择基本权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(true, c1);
        }



        private void btnRemovePermissionsForBaseFunction_Click(object sender, EventArgs e)   //清除基本权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(false, c1);
        }

        private void btnRestorePermissionsForBaseFunction_Click(object sender, EventArgs e)   //恢复基本权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            Recover(user.BaseFunction, c1);
        }

        private void btnSelectPermissionsForPurchaseFunction_Click(object sender, EventArgs e)  //选择进货管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(true, c2);
        }

        private void btnRemovePermissionsForPurchaseFunction_Click(object sender, EventArgs e)   //清除进货管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(false, c2);
        }

        private void btnRestorePermissionsForPurchaseFunction_Click(object sender, EventArgs e)   //恢复进货管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            Recover(user.PurchaseFunction, c2);
        }

        private void btnSelectPermissionsForSaleFunction_Click(object sender, EventArgs e)    //选择销售管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(true, c3);
        }

        private void btnRemovePermissionsForSaleFunction_Click(object sender, EventArgs e)    //清除销售管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(false, c3);
        }

        private void btnRestorePermissionsForSaleFunction_Click(object sender, EventArgs e)   //恢复销售管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            Recover(user.SaleFunction, c3);
        }

        private void btnSelectPermissionsForUserFunction_Click(object sender, EventArgs e)    //选择用户管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(true, c4);
        }

        private void btnRemovePermissionsForUserFunction_Click(object sender, EventArgs e)    //清除用户管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            SetAll(false, c4);
        }

        private void btnRestroePermissionsForUserFunction_Click(object sender, EventArgs e)    //恢复用户管理权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            Recover(user.UserFunction, c4);
        }

        private void btnRestorePermissionsAll_Click(object sender, EventArgs e)   //恢复当前用户的全部权限
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
            Recover(user.BaseFunction, c1);
            Recover(user.PurchaseFunction, c2);
            Recover(user.SaleFunction, c3);
            Recover(user.UserFunction, c4);
        }

        private void btnConfirm_Click(object sender, EventArgs e)     //确定按钮（保存当前的操作——设置用户的权限）
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }

            //获取新的值
            //user.Password = txtPassword.Text.Trim();

            //取权限转换为十进制
            user.BaseFunction = ConvertSumResult(c1);
            user.PurchaseFunction = ConvertSumResult(c2);
            user.SaleFunction = ConvertSumResult(c3);
            user.UserFunction = ConvertSumResult(c4);

            if (userBLL.Update(user))
            {
                MessageBox.Show("用户权限修改成功！", "提示");
                return;
            }
            else
            {
                MessageBox.Show("用户权限修改失败！", "提示");
                return;
            }

        }

        private int ConvertSumResult(CheckBox[] c)   //二进制转换十进制（界面权限为二进制，数据库里为十进制）
        {
            //存放十进制数值
            int sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Checked)
                {
                    sum = sum + (int)Math.Pow(2, i);
                }
            }
            return sum;
        }

        private void btnCancel_Click(object sender, EventArgs e)  //取消（关闭窗体）
        {
            this.Close();
        }

        private void btnInitializePassword_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("请选择一个用户进行操作！", "提示");
                return;
            }
             //弹出是否确认删除的对话框
            DialogResult result = MessageBox.Show("您是否真的要初始化当前用户的密码?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //获取新的值            
                user.Password = encrypt.encryPassword("666666");

                if (userBLL.Update(user))
                {
                    MessageBox.Show("用户密码初始化成功！", "提示");
                    txtPassword.Text = "666666";
                    return;
                }
                else
                {
                    MessageBox.Show("用户密码初始化失败！", "提示");
                    return;
                }
            }
        }


    }
}
