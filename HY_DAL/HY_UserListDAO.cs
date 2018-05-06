/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   用户列表DAL层
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HY_DbSqlHelp;
using HY_Model;

namespace HY_DAL
{
    public class HY_UserListDAO
    {
        private static SqlDataReader sdr;

        /// <summary>
        /// 返回SqlDataReader人员信息列表
        /// </summary>
        /// <returns></returns>
        public  SqlDataReader f_hyUserLiset(string sql)
        {          
            HY_DbSqlHelp.DBsqlHelp hysqlhelp = new DBsqlHelp();
            sdr = hysqlhelp.reder(sql);
            return sdr;      
        }

        /// <summary>
        /// 返回DataTable人员信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_hyUserLiset()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select  * from HY_user";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
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
