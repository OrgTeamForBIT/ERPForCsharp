/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   仓库管理BLL层
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using HY_DAL;
using HY_Model;

namespace HY_BLL
{
    /// <summary>
    /// 仓库管理BLL层
    /// </summary>
    public class HY_StorageBLL
    {
        private HY_StorageDAO hystorag = null;

        public HY_StorageBLL()
        {
            hystorag = new HY_StorageDAO();
        }
        /// <summary>
        /// 返回SqlDataReader仓储明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_HY_Storagelist(string sql)
        {
            return hystorag.f_HY_Storagelist(sql);
        }
        /// <summary>
        /// 返回仓库信息
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuerySelect(string sql)
        {
            return hystorag.ExecuteQuerySelect(sql);
        }
        /// <summary>
        /// 增删改操作(仓库)
        /// </summary>
        /// <param name="model">BOM物料明细MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_HY_Storagelslist(string sql)
        {
            return hystorag.com_HY_HY_Storagelslist(sql);
        }
        /// <summary>
        /// 返DataSet数据集
        /// </summary>
        /// <returns></returns>
        public DataSet ExecuteQueryDataSet(string sql)
        {
            return hystorag.ExecuteQueryDataSet(sql);
        }
    }
}
