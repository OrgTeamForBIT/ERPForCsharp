/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统登陆窗体
 */  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HY_BLL;
using HY_Model;
using System.IO;
using DevComponents.DotNetBar;

//源码下载www.51aspx.com
namespace HYWJ
{
    public partial class Logon : Office2007Form
    {
        public Logon()
        {
            InitializeComponent();
        }        
        /// <summary>
        /// 自定义登陆
        /// </summary>
        private void LoGIin()
        {
            //TODO
            bool isEmpty = UserInputCheck();
            if (isEmpty == true)
            {
                HY_Model.User u = new User();
                u.UserName = this.userName.Text.Trim();
                u.PassWord = this.passWord.Text.Trim();

                HY_BLL.HY_setbll hyset = new HY_setbll();
                DataTable dt = hyset.userAuthentication(u);
                if (dt.Rows.Count > 0)
                {
                    if (int.Parse(dt.Rows[0]["h_Status"].ToString()) > 0)
                    {
                        string user = this.userName.Text.Trim();
                        if (!this.userName.AutoCompleteCustomSource.Contains(user))
                        {
                            this.userName.AutoCompleteCustomSource.Add(user);
                        }
                        MianForm mf = new MianForm();
                        mf.UserName = this.userName.Text.Trim();
                        mf.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBoxEx.Show("此账户已被锁定暂无法登录！", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.userName.Text = "";
                        this.passWord.Text = "";
                        this.userName.Focus();
                    }
                }
                else
                {
                    MessageBoxEx.Show("登陆失败：用户名或密码错误,请重新输入!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.userName.Text = "";
                    this.passWord.Text = "";
                    this.userName.Focus();

                }
            }
        }
        /// <summary>
        /// 用户输入验证
        /// </summary>
        /// <returns></returns>
        private bool UserInputCheck()
        {
            // 保存登录名称
            string loginName = this.userName.Text.Trim();
            // 保存用户密码
            string userPwd = this.passWord.Text.Trim();

            // 开始验证
            if (string.IsNullOrEmpty(loginName))
            {
               
                this.toolTip.ToolTipIcon = ToolTipIcon.Info;
                this.toolTip.ToolTipTitle = "登录提示";
                Point showLocation = new Point(
                    this.userName.Location.X + this.userName.Width,
                    this.userName.Location.Y);
                this.toolTip.Show("请您输入登录账户名！", this, showLocation, 5000);
                this.userName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(userPwd))
            {
            
                this.toolTip.ToolTipIcon = ToolTipIcon.Info;
                this.toolTip.ToolTipTitle = "登录提示";
                Point showLocation = new Point(
                    this.passWord.Location.X + this.passWord.Width,
                    this.passWord.Location.Y);
                this.toolTip.Show("请您输入登陆账户密码！", this, showLocation, 5000);
                this.passWord.Focus();
                return false;
            }
            else if (userPwd.Length < 6)
            {
                this.toolTip.ToolTipIcon = ToolTipIcon.Warning;
                this.toolTip.ToolTipTitle = "登录警告";
                Point showLocation = new Point(
                    this.passWord.Location.X + this.passWord.Width,
                    this.passWord.Location.Y);
                this.toolTip.Show("用户密码长度不能小于六位！", this, showLocation, 5000);
                this.passWord.Focus();
                return false;
            }

            // 如果已通过以上所有验证则返回真
            return true;
        }
        // 写登陆成功的用户名
        private void SaveHistroy()
        {
            string fileName = Path.Combine(Application.StartupPath, @"History.txt");
            StreamWriter writer = new StreamWriter(fileName,false,Encoding.Default);
            foreach (string name in this.userName.AutoCompleteCustomSource)
            {
                writer.WriteLine(name);
            }
            writer.Flush();
            writer.Close();

        }

        // 读登陆成功的用户名
        private void LoadHistroy()
        {
            string fileName = Path.Combine(Application.StartupPath, @"History.txt");
            if (File.Exists(fileName))
            {
                StreamReader reader = new StreamReader(fileName,Encoding.Default);
                string name = reader.ReadLine();
                while (name != null)
                {
                    this.userName.AutoCompleteCustomSource.Add(name);
                    this.userName.Items.Add(name);
                    name = reader.ReadLine();
                }
                reader.Close();
            }

        }

        private void Logon_Load(object sender, EventArgs e)
        {
            LoadHistroy();
            this.userName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.userName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void Logon_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveHistroy();
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DL_Click_1(object sender, EventArgs e)
        {
            LoGIin();
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void passWord_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户是否按了回车
            if (e.KeyValue == 13)
            {
                LoGIin();
            }
        }

        private void userName_KeyDown(object sender, KeyEventArgs e)
        {
            //判断用户是否按了回车
            if (e.KeyValue == 13)
            {
                LoGIin();
            }
        }
    }
}
