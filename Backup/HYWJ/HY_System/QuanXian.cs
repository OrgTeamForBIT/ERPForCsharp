/*  
 * 作者: JOY 
 * 创建时间: 2010-01-15 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:  权限验证
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace HYWJ.HY_System
{
    public class QuanXian
    {
        //自定义权限判断
        public bool f_QuanXian(string aa, string UserName)
        {
            HY_BLL.HY_setbll hyset = new HY_BLL.HY_setbll();
            string sql = "select h_UserName,h_Security from HY_user where h_UserName='" + UserName + "'";
            DataTable dt = hyset.userSecurity(sql);
            if (dt.Rows.Count > 0)
            {
                string s;
                string cc = dt.Rows[0][1].ToString();
                string[] sArray = cc.Split(',');
                foreach (string i in sArray)
                {
                    s = i.ToString();
                    if (s == aa)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
