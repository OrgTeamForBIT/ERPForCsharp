/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   请购单信息DAL层
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DbSqlHelp;
using System.Data.SqlClient;
using HY_Model;

namespace HY_DAL
{
    /// <summary>
    /// 请购单信息DAO
    /// </summary>
    public class HY_RequisitionInfoDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReader请购单信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {            
            HY_DbSqlHelp.DBsqlHelp hysqlhelp = new DBsqlHelp();
            sdr = hysqlhelp.reder(sql);
            return sdr;

        }
        /// <summary>
        /// 返回信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                DataTable ds = new DataTable();
                ds = hy_help.ExecuteQuery(sql);
                return ds;
            }
            catch (Exception EX)
            {
                
                throw EX;
            }
     
        }
        /// <summary>
        /// 新增请购单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_RequisitionInfo(HY_Model.HY_RequisitionInfo model)
        {
            try
            {
                string sql = "insert into HY_RequisitionInfo(r_DID,r_CID,r_NameID,r_Department,r_Person,r_Name,r_Supplier,r_Origin,r_QDate,r_XDate,r_Specifications,r_Units,r_Amount,r_Uses,r_Notes,r_Hot) values('" + model.R_DID + "','" + model.R_CID + "','" + model.R_NameID + "','" + model.R_Department + "','" + model.R_Person + "','" + model.R_Name + "','" + model.R_Supplier + "','" + model.R_Origin + "','" + model.R_QDate + "','" + model.R_XDate + "','" + model.R_Specifications + "','" + model.R_Units + "','" + model.R_Amount + "','" + model.R_Uses + "','" + model.R_Notes + "','" + model.R_Hot + "')";
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
        /// 请购单抛转采购单
        /// </summary>
        /// <returns></returns>
        public int com_ExecuteQuery(string sql)
        {
            try
            {
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
