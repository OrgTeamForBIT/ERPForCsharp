/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   采购单信息DAL层
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
    public class HY_ProcurementDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReader采购单信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {
            HY_DbSqlHelp.DBsqlHelp hysqlhelp = new DBsqlHelp();
            sdr = hysqlhelp.reder(sql);
            return sdr;

        }
        /// <summary>
        /// 返回采购单列表
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
        /// 采购单增删改
        /// </summary>
        /// <param name="sql">SQL语句</param>
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


        /// <summary>
        /// 新增采购单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_HY_Procurement(HY_Model.HY_Purchaseorder model)
        {
            try
            {
                string sql = "insert into HY_ProcurementInfo(c_DID,c_CID,c_Department,c_Person,c_Name,c_NameID,c_Supplier,c_Origin,c_QDate,c_XDate,c_Specifications,c_Units,c_Amount,c_Uses,c_Notes,c_Hot) values('" + model.C_DID + "','" + model.C_CID + "','" + model.C_Department + "','" + model.C_Person + "','" + model.C_Name + "','" + model.C_NameID + "','" + model.C_Supplier + "','" + model.C_Origin + "','" + model.C_QDate + "','" + model.C_XDate + "','" + model.C_Specifications + "','" + model.C_Units + "','" + model.C_Amount + "','" + model.C_Uses + "','" + model.C_Notes + "','" + model.C_Hot + "')";
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
