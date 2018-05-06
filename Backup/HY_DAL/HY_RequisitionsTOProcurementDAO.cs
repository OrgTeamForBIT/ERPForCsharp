/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   请购单抛转采购单DAL层
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
    public class HY_RequisitionsTOProcurementDAO
    {
        private SqlDataReader sdr = null;
        /// <summary>
        /// 返回选择后SqlDataReaderBOM表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_HY_RequisitionsTOProcurement(string d_SKID)
        {
            try
            {
                string sql = "select b_ID,b_SKID,b_CID,b_CustomerID,b_SPerson,b_SDate from HY_BomInfo where b_SKID='" + d_SKID + "'";
                HY_DbSqlHelp.DBsqlHelp hysqlhelp = new DBsqlHelp();
                sdr = hysqlhelp.reder(sql);
                return sdr;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
    }
}
