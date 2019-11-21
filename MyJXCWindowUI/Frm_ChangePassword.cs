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

namespace MoGuangYuan.MyJXCWindowUI
{
    public partial class Frm_ChangePassword : Form
    {
        private SystemUserBLL userBll;
        private string userID;
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public Frm_ChangePassword()
        {
            InitializeComponent();
            userBll = new SystemUserBLL();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;

            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string newPasswordConFirm = txtNewPasswordConFirm.Text.Trim();

            if (userID == null)
            {
                MessageBox.Show("请选择一个用户修改密码！", "提示");
                oldPassword = "";
                newPassword = "";
                newPasswordConFirm = "";
                return;
            }

            if (txtOldPassword.Text=="")
            {
                //MessageBox.Show("旧密码不能为空！", "提示");
                label6.Visible = true;
                label6.Text = "旧密码不能为空！";
                txtOldPassword.Focus();
                return;
            }
            if (txtNewPassword.Text=="")
            {
                //MessageBox.Show("新密码不能为空！", "提示");
                label7.Visible = true;
                label7.Text = "新密码不能为空！";
                txtNewPassword.Focus();
                return;
            }
            if (txtNewPasswordConFirm.Text=="")
            {
                //MessageBox.Show("请输入确认密码！", "提示");
                label8.Visible = true;
                label8.Text = "请输入确认密码！";
                txtNewPasswordConFirm.Focus();
                return;
            }
            if (newPassword != newPasswordConFirm)
            {
                //MessageBox.Show("新密码两次输入不相符！", "提示");
                label7.Visible = true;
                label7.Text = "新密码两次输入不相符！";
                label8.Visible = true;
                label8.Text = "新密码两次输入不相符！";
                return;
            }
            try
            {               
                if (!userBll.UserLogin(userID, oldPassword))
                {
                    //MessageBox.Show("旧密码不正确！", "提示");
                    label6.Visible = true;
                    label6.Text = "旧密码不正确！";
                    txtOldPassword.Focus();
                    return;
                }
                if (txtOldPassword.Text==txtNewPasswordConFirm.Text)
                {
                    //MessageBox.Show("新密码不能与旧密码相同！", "提示");
                    label7.Visible = true;
                    label7.Text = "新密码不能与旧密码相同！";
                    txtNewPassword.Focus();
                    return;
                }

                if (userBll.ChangeUserPassword(userID, newPassword))
                {
                    //MessageBox.Show("恭喜您，密码修改成功！\r\n\r\n您的新密码:  " + newPassword + "\r\n\r\n请您妥善保管好您的密码，请勿告诉他人！", "提示");
                    //MessageBox.Show("恭喜您，密码修改成功！\r\n\r\n温馨提醒：\r\n    请您妥善保管好您的密码，请勿告诉他人！", "提示");
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible =false;
                    label7.Visible = false;
                    label8.Visible = false;

                    oldPassword = "";
                    newPassword = "";
                    newPasswordConFirm = "";
                }
                else
                {
                    MessageBox.Show("密码修改失败！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtNewPasswordConFirm.Text = "";
            label4.Visible = false;
            label5.Visible = false;
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;           
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            if (txtNewPassword.Text==txtNewPasswordConFirm.Text)
            {
                label8.Visible = false;
            }
           
        }

        private void txtNewPasswordConFirm_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            if (txtNewPassword.Text == txtNewPasswordConFirm.Text)
            {
                label7.Visible = false;
            }           
            label8.Visible = false;
        }
         
    }
}
