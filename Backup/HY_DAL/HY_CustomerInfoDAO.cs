/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   客户信息DAL层
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
    public class HY_CustomerInfoDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReader表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_CustomerInfolist(string sql)
        {
            try
            {
                //string sql = "select b_ID,b_SKID,b_CID from HY_BomInfo order by b_ID desc";
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
        /// 返回DataTable信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            //string sql = "select * from HY_BomInfo order by b_ID desc";
            HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
            DataTable ds = new DataTable();
            ds = hy_help.ExecuteQuery(sql);
            return ds;
        }
        /// <summary>
        /// 增删改客户信息
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_HY_CustomerInfo(string sql)
        {
            try
            {
                //string sql = "insert into HY_BomInfo(b_SKID,b_CID,b_CustomerID,b_No,b_Material,b_BomSize,b_Notes,b_Height,b_Tonnage,b_Name,b_SPerson,b_SDate) values('" + model.B_SKID + "','" + model.B_CID + "','" + model.B_CustomerID + "','" + model.B_No + "','" + model.B_Material + "','" + model.B_BomSize + "','" + model.B_Notes + "','" + model.B_Height + "','" + model.B_Tonnage + "','" + model.B_Name + "','" + model.B_SPerson + "','" + model.B_SDate + "')";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {
                throw EX;
            }

        }
    }
}
