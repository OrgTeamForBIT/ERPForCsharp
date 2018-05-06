/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   仓库信息DAL层
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using HY_DbSqlHelp;
using HY_Model;

namespace HY_DAL
{
    public class HY_WarehouseDAO
    {
        /// <summary>
        /// 返回仓库列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery()
        {
            string sql = "select * from HY_Warehouse";
            HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
            DataTable ds = new DataTable();
            ds = hy_help.ExecuteQuery(sql);
            return ds;
        }

        /// <summary>
        /// 新增仓库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_Warehouse(HY_Model.HY_Warehouse model)
        {
            try
            {
                string sql = "insert into HY_Warehouse(c_ckName) values('" +model.C_ckName + "')";
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
        ///删除仓库
        /// </summary>
        /// <param name="model">仓库实体类c_ID</param>
        /// <returns></returns>
        public int del_Warehouse(HY_Model.HY_Warehouse model)
        {
            try
            {
                string sql = "delete from HY_Warehouse where c_ID='" + model.C_ID+ "'";
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
