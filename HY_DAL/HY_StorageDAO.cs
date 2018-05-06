/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   仓库管理DAL层
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
    public class HY_StorageDAO
    {
        private static SqlDataReader sdr;
        /// <summary>
        /// 返回SqlDataReader仓储明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_HY_Storagelist(string sql)
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
        /// 返回仓库信息
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuerySelect(string sql)
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
        /// 增删改操作(仓库)
        /// </summary>
        /// <param name="model">BOM物料明细MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_HY_Storagelslist(string sql)
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
        /// 返DataSet数据集
        /// </summary>
        /// <returns></returns>
        public DataSet ExecuteQueryDataSet(string sql)
        {
            try
            {
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                DataSet ds = new DataSet();
                ds = hy_help.DataSetSearch(sql);
                return ds;
            }
            catch (Exception EX)
            {
                throw EX;
            }

        }
    }
}
