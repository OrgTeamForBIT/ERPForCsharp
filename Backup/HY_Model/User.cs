/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   用户表实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class User
    {
        private string userName;
        private string passWord;
        private int userStatus;
        private string department;
        private string security;


        /// <summary>
        /// 获取或设置用户登陆帐户名
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>
        /// 获取或设置用户密码
        /// </summary>
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
        /// <summary>
        /// 获取注册用户状态
        /// </summary>
        public int UserStatus
        {
            get { return userStatus; }
            set { userStatus = value; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
         /// <summary>
         /// 权限设置
         /// </summary>
        public string Security
        {
            get { return security; }
            set { security = value; }
        }
    }
}
