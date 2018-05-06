/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商信息DAL层
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DbSqlHelp;
using HY_Model;
using System.Data.SqlClient;

namespace HY_DAL
{
    public class HY_SupplierDAO
    {
        private static SqlDataReader sdr;

        /// <summary>
        /// 返回SqlDataReader人员信息列表
        /// </summary>
        /// <param name="sql">sql</param>
        /// <returns></returns>
        public SqlDataReader f_SupplierLiset(string sql)
        {
            try
            {
                HY_DbSqlHelp.DBsqlHelp hysqlhelp = new DBsqlHelp();
                sdr = hysqlhelp.reder(sql);
                return sdr;
            }
            catch (Exception EX)
            {
                
                throw EX;
            }
               

        }
        /// <summary>
        /// 新增供应商信息
        /// </summary>
        /// <param name="model">供应商信息实体层</param>
        /// <returns></returns>
        public int com_Supplier(HY_Model.HY_Supplier model)
        {
            try
            {
                string sql = "insert into HY_Supplier(s_gyName,s_jName,s_Area,s_cpName,s_Name,s_Tel) values('" + model.S_gyName + "','" + model.S_jName + "','" + model.S_Area + "','" + model.S_cpName + "','" + model.S_name + "','" + model.S_tel + "')";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {
                
                throw EX;
            }            
        
        }

        /// <summary>
        /// 返回供应商信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_Supplier()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select s_ID,s_gyName,s_jName from HY_Supplier";
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
