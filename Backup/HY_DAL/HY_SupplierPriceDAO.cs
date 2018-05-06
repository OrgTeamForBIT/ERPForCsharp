/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商物料价格信息DAL层
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DbSqlHelp;
using HY_Model;

namespace HY_DAL
{
    /// <summary>
    /// 供应商物料价格信息DAL层
    /// </summary>
    public class HY_SupplierPriceDAO
    {
        /// <summary>
        /// 新增物料价格信息
        /// </summary>
        /// <param name="model">物料信息实体层</param>
        /// <returns></returns>
        public int com_SupplierPrice(HY_Model.HY_SupplierPrice model)
        {
            try
            {
                string sql = "insert into HY_SupplierPrice(p_DID,p_PID,p_gyName,p_Date,p_PName,p_Price,p_Weight,p_Vray,p_SM,p_rPerson) values('" + model.P_DID + "','" + model.P_PID + "','" + model.P_gyName + "','" + model.P_Date + "','" + model.P_PName + "','" + model.P_Price + "','" + model.P_Weight + "','" + model.P_Vray + "','" + model.P_SM + "','" + model.P_rPerson + "')";
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
        /// 增删该物料价格
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int f_SupplierPrice(string sql)
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
        /// 返回供应商物料价格信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_SupplierPrice()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from HY_SupplierPrice order by p_ID desc";
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
