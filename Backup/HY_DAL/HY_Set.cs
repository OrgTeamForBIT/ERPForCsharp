/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统DAL层
 */  
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HY_DbSqlHelp;
using HY_Model;

namespace HY_DAL
{
    public class HY_Set
    {
        HY_DbSqlHelp.DBsqlHelp hy_help;
        private static SqlDataReader sdr;
        public HY_Set()
        {
            hy_help = new DBsqlHelp();
        }
        /// <summary>
        /// DataTable信息
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable userSecurity(string sql)
        {
            try
            {
                DataTable dt = new DataTable();     
                dt = hy_help.ExecuteQuery(sql);
                return dt;
            }
            catch (Exception EX)
            {               
                throw EX;
            }
            
        }
        /// <summary>
        /// 返回SqlDataReader信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {
            sdr = hy_help.reder(sql);
            return sdr;
        }
        /// <summary>
        /// 用户执行增加操作
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int userOperation(HY_Model.User model)
        {
            try
            {
                string sql = "insert into HY_user(h_UserName,h_yUserPwd,h_Status) values('" + model.UserName + "','" + model.PassWord + "','"+model.UserStatus+"')";
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {
                
                throw EX;
            }
            
        }

        /// <summary>
        /// 该方法更新用户帐户信息
        /// </summary>
        /// <param name="model">用户表实体层</param>
        /// <returns></returns>
        public int userOperationUpdate(HY_Model.User model,int h_ID)
        {
            try
            {
                string sql = "update HY_User set h_UserName='" + model.UserName + "',h_yUserPwd='" + model.PassWord + "',h_Status='" + model.UserStatus + "' where h_ID='" + h_ID + "'";
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {
                throw EX;
            }
            
        }

        /// <summary>
        /// 更新权限
        /// </summary>
        /// <param name="model">用户权限实体类</param>
        /// <param name="user">用户</param>
        /// <returns></returns>
        public int userSecurityUpdate(HY_Model.User model, string user)
        {
            try
            {
                string sql = "update HY_User set h_Security='" + model.Security + "' where h_UserName='" + user + "'";
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {

                throw EX;
            }

        }
        /// <summary>
        /// 验证登陆用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable userAuthentication(HY_Model.User model)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select h_UserName,h_yUserPwd,h_yUserPwd,h_Status from HY_User where h_UserName='" + model.UserName + "' and h_yUserPwd='" + model.PassWord + "'";
                dt = hy_help.ExecuteQuery(sql);
                return dt;
            }
            catch (Exception EX)
            {               
                throw EX;
            }
            
        }

    }
}
