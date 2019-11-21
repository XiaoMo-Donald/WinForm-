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
using Sunisoft.IrisSkin;

namespace MoGuangYuan.MyJXCWindowUI
{
    public partial class Frm_MainForm : Form
    {
        private SystemUserBLL userBll;
        private SystemUser user;
        private SkinEngine skinEngine;    //更换皮肤
         int rand = 10; //窗口抖动
        private string userID;    //存放登录的用户名
        private string password;  //存放登录的密码
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        ToolStripMenuItem[] t1 = new ToolStripMenuItem[5];
        ToolStripMenuItem[] t2 = new ToolStripMenuItem[3];
        ToolStripMenuItem[] t3 = new ToolStripMenuItem[2];
        ToolStripMenuItem[] t4 = new ToolStripMenuItem[2];
        public Frm_MainForm()
        {
            InitializeComponent();
            userBll = new SystemUserBLL();
            ((ToolStripMenuItem)menuStrip1.Items[0]).DropDownItems.CopyTo(t1, 0);
            ((ToolStripMenuItem)menuStrip1.Items[1]).DropDownItems.CopyTo(t2, 0);
            ((ToolStripMenuItem)menuStrip1.Items[2]).DropDownItems.CopyTo(t3, 0);
            ((ToolStripMenuItem)menuStrip1.Items[3]).DropDownItems.CopyTo(t4, 0);

            //加载窗体皮肤
            skinEngine = new SkinEngine();
        }
        private void Frm_MainForm_Load(object sender, EventArgs e)
        {
            //设置菜单项为初始状态
            for (int num = 0; num < menuStrip1.Items.Count - 1; num++)
            {
                menuStrip1.Items[num].Enabled = false;
            }
            //gbUserLogin.Visible = true;
            //gbUserInfoWelcome.Visible = false;
            txtUserID.Focus();
            lbWelcomeInfo.Text = "  用户暂未登录";
            lbUserName.Text = "登录后显示";
            lbDepartMent.Text = "登录后显示";

            btnCancellation.Enabled = false;
            btnExit.Enabled = false;
        }

        private T ActivateMdiChildren<T>() where T : Form, new()   //激活子窗体
        {
            //如果当前子窗体已经打开 则激活即可
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.Activate();
                    f.WindowState = FormWindowState.Maximized;
                    return f as T;
                }
            }
            //设置子窗体 在MDI父窗体中打开
            T frm = new T();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            return frm;
        }
        private void 产品分类管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_Category>();
        }

        private void 产品信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_Product>();
        }

        private void 供应商信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_Supplier>();
        }

        private void 客户信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_Customer>();
        }

        private void 员工信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_Employee>();
        }

        private void 填写进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_FillPurchaseBill frm = ActivateMdiChildren<PurchaseManage.Frm_FillPurchaseBill>();
            frm.ClerkID = userID;
        }

        private void 审核进货单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_ExamPurchaseBill frm = ActivateMdiChildren<PurchaseManage.Frm_ExamPurchaseBill>();
            frm.ExaminerID = userID;
        }

        private void 检查货物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseManage.Frm_InStockCheck frm = ActivateMdiChildren<PurchaseManage.Frm_InStockCheck>();
            frm.CustodianID = userID;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ChangePassword frm = ActivateMdiChildren<Frm_ChangePassword>();
            frm.UserID = userID;
        }

        private void 用户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ActivateMdiChildren<Frm_SystemUser>();
        }

        private void btnLogin_Click(object sender, EventArgs e)  //登录
        {
            if (txtUserID.Text == "")
            {
                MessageBox.Show("请输入用户名！", "提示");
                txtUserID.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("请输入密码！", "提示");
                txtPassword.Focus();
                return;
            }

            userID = txtUserID.Text.Trim();
            password = txtPassword.Text.Trim();
            try
            {
                if (userBll.UserLogin(userID, password))
                {
                    //MessageBox.Show("登录成功", "提示");

                    基本信息ToolStripMenuItem.Enabled = true;
                    进货管理ToolStripMenuItem.Enabled = true;
                    销售管理ToolStripMenuItem.Enabled = true;
                    用户管理ToolStripMenuItem.Enabled = true;
                    //gbUserLogin.Visible = false;
                    //gbUserInfoWelcome.Visible = true;
                    txtPassword.Text = "";
                    lbWelcomeInfo.Text = "欢迎进入\r\n\r\n进销存管理系统";
                    lbWelcomeInfo.TextAlign = ContentAlignment.MiddleCenter; //设置格式
                    lbDepartMent.Text = "暂无部门";
                    btnCancellation.Enabled = true;
                    btnExit.Enabled = true;
                    txtUserID.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                    btnClearAll.Enabled = false;

                    if (userID == "admin")
                    {
                        lbUserName.Text = userID;
                    }
                    else
                    {
                        lbUserName.Text = new EmployeeBLL().FindByID(userID).EmployeeName;
                    }
                    user = userBll.FindByID(userID);      //根据ID找到用户

                    int baseFunction = user.BaseFunction;
                    GetUserFunction(baseFunction, t1, 0);
                    int purchaseFunction = user.PurchaseFunction;
                    GetUserFunction(purchaseFunction, t2, 1);
                    int saleFunction = user.SaleFunction;
                    GetUserFunction(saleFunction, t3, 2);
                    int userFunction = user.UserFunction;
                    GetUserFunction(userFunction, t4, 3);
                }
                else
                {                   
                    //设置窗口抖动
                    int recordx = this.Left;
                    int recordy = this.Top;
                    Random random = new Random();

                    for (int i = 0; i < 150; i++)
                    {
                        int x = random.Next(rand);
                        int y = random.Next(rand);
                        if (x % 2 == 0)
                        {
                            this.Left = this.Left + x;
                        }
                        else
                        {
                            this.Left = this.Left - x;
                        }
                        if (y % 2 == 0)
                        {
                            this.Top = this.Top + y;
                        }
                        else
                        {
                            this.Top = this.Top - y;
                        }
                        this.Left = recordx;
                        this.Top = recordy;
                    }
                    MessageBox.Show("登录失败,请检查您的用户名和密码！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCancellation_Click(object sender, EventArgs e)   //注销
        {

            //gbUserLogin.Visible = true;
            //gbUserInfoWelcome.Visible = false;

            lbWelcomeInfo.Text = "  用户暂未登录";
            lbUserName.Text = "登录后显示";
            lbDepartMent.Text = "登录后显示";

            btnCancellation.Enabled = false;
            btnExit.Enabled = false;
            txtUserID.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            btnClearAll.Enabled = true;

            txtUserID.Text = "";
            txtPassword.Text = "";
            userID = null;
            password = null;

            //设置菜单项为初始状态
            for (int num = 0; num < menuStrip1.Items.Count - 1; num++)
            {
                menuStrip1.Items[num].Enabled = false;
            }
            //关闭所有的子窗体
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
        private void btnClearAll_Click(object sender, EventArgs e)  //清空登录账号和密码
        {
            txtUserID.Text = "";
            txtPassword.Text = "";
            userID = null;
            password = null;
            txtUserID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)  //退出
        {
            Application.Exit();
        }
        private void GetUserFunction(int function, ToolStripMenuItem[] t, int num)   //获取用户的权限
        {
            if (function == 0)
            {
                menuStrip1.Items[num].Enabled = false;
            }
            else
            {
                menuStrip1.Items[num].Enabled = true;

                for (int i = 0; i < t.Length; i++)
                {
                    if (function % 2 == 0)
                    {
                        t[i].Enabled = false;
                    }
                    else
                    {
                        t[i].Enabled = true;
                    }
                    function = function / 2;
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                if (txtUserID.Text == "")
                {
                    MessageBox.Show("请输入用户名！", "提示");
                    txtUserID.Focus();
                    return;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("请输入密码！", "提示");
                    txtPassword.Focus();
                    return;
                }

                userID = txtUserID.Text.Trim();
                password = txtPassword.Text.Trim();
                try
                {
                    if (userBll.UserLogin(userID, password))
                    {
                        //MessageBox.Show("登录成功", "提示");

                        基本信息ToolStripMenuItem.Enabled = true;
                        进货管理ToolStripMenuItem.Enabled = true;
                        销售管理ToolStripMenuItem.Enabled = true;
                        用户管理ToolStripMenuItem.Enabled = true;
                        //gbUserLogin.Visible = false;
                        //gbUserInfoWelcome.Visible = true;
                        txtPassword.Text = "";
                        lbWelcomeInfo.Text = "欢迎进入\r\n\r\n进销存管理系统";
                        lbWelcomeInfo.TextAlign = ContentAlignment.MiddleCenter; //设置格式
                        lbDepartMent.Text = "暂无部门";
                        btnCancellation.Enabled = true;
                        btnExit.Enabled = true;
                        txtUserID.Enabled = false;
                        txtPassword.Enabled = false;
                        btnLogin.Enabled = false;
                        btnClearAll.Enabled = false;

                        if (userID == "admin")
                        {
                            lbUserName.Text = userID;
                        }
                        else
                        {
                            lbUserName.Text = new EmployeeBLL().FindByID(userID).EmployeeName;
                        }
                        user = userBll.FindByID(userID);      //根据ID找到用户

                        int baseFunction = user.BaseFunction;
                        GetUserFunction(baseFunction, t1, 0);
                        int purchaseFunction = user.PurchaseFunction;
                        GetUserFunction(purchaseFunction, t2, 1);
                        int saleFunction = user.SaleFunction;
                        GetUserFunction(saleFunction, t3, 2);
                        int userFunction = user.UserFunction;
                        GetUserFunction(userFunction, t4, 3);
                    }
                    else
                    {
                        MessageBox.Show("登录失败,请检查您的账号和密码！", "提示");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTimeNow.Text = "系统当前时间：" + DateTime.Now.ToLongTimeString();
        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////读取本地帮助文档（程序运行的当前目录下）
            //System.Diagnostics.Process.Start(Application.StartupPath + "/help.html");
        }
        private void 反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ////第一个参数设置默认浏览器 第二个设置网址
            //System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://www.baidu.com");
            System.Diagnostics.Process.Start("http://bolg.iskuba.pw");
        }

        private void 软件官网ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 交流论坛ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于我门ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关于本软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text.Length == 0 //隐藏子窗体图标
                || e.Item.Text == "最小化(&N)"//隐藏最小化按钮
                || e.Item.Text == "还原(&R)"//隐藏还原按钮
                || e.Item.Text == "关闭(&C)")//隐藏最关闭按钮
            {
                e.Item.Visible = false;
            }
        }
      
        private void 默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //恢复颜色为默认 
            skinEngine.Active = false;
        }

        private void 护眼绿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\Midsummer.ssk";
        }

        private void 青涩派ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\Emerald.ssk";
        }

        private void 灰蓝配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\DiamondBlue.ssk";
        }

        private void 天空蓝ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\DeepCyan.ssk";
        }

        private void 橘子橙ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\OneOrange.ssk";
        }

        private void 炫酷黑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\Calmness.ssk";
        }

        private void 机械灰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skinEngine.Active = true;
            //获取指定的皮肤文件
            skinEngine.SkinFile = "Skins\\SteelBlack.ssk";
        }


    }
}
