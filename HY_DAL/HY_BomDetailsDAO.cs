/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   BOM明细DAL层
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
    public class HY_BomDetailsDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReaderBOM明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_BomDetailslist()
        {
            try
            {
                string sql = "select b_ID,b_SKID,b_CID from HY_BomInfo order by b_ID desc";
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
        /// SQL返回SqlDataReader明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_SQLBom(string sql)
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
        /// 返回BOM明细信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery()
        {
            try
            {
                string sql = "select * from HY_BomDetails order by d_ID desc";
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
        /// 返回检索后BOM明细信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuerySelect(string d_SKID)
        {
            try
            {
                string sql = "select * from HY_BomDetails where d_SKID='"+d_SKID+"'";
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
        /// 新增BOM物料明细
        /// </summary>
        /// <param name="model">BOM物料明细MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_BomDetailslist(HY_Model.HY_BomDetails model)
        {
            try
            {
                string sql = "insert into HY_BomDetails(d_SKID,d_CID,d_PID,d_PName,d_Model,d_Specifications,d_Amount,d_Heat,d_Notes,d_SPerson,d_ModClass) values('" + model.D_SKID + "','" + model.D_CID + "','" + model.D_PID + "','" + model.D_PName + "','" + model.D_Model + "','" + model.D_Specifications + "','" + model.D_Amount + "','" + model.D_Heat + "','" + model.D_Notes + "','" + model.D_SPerson + "','" + model.ModClass+ "')";
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
        /// 增删改BOM明细
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int f_HYBomDetailslist(string sql)
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
