/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   物料领取DAL层
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
    public  class HY_RequisitionedDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReader物料领取明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_ProductionPlanningslist(string sql)
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
        /// 返回物料领取信息列表
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
        /// 增删改领取物料信息
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_HY_ProductionPlanninglist(string sql)
        {
            try
            {
                //string sql = "insert into HY_ProductionPlanning(p_DID,p_KID,p_CID,p_Engineering,p_Design) values('"+model.P_DID+"','"+model.P_KID+"','"+model.P_CID+"','"+model.P_Engineering+"','"+model.P_Design+"')";
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
