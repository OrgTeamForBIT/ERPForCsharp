/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   采购业务逻辑层BLL
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DAL;
using System.Data.SqlClient;
using HY_Model;

namespace HY_BLL
{
    public class HY_ProcurementBLL
    {
        private HY_ProcurementDAO hypro = null;

        public HY_ProcurementBLL()
        {
            hypro = new HY_ProcurementDAO();
        }

        /// <summary>
        /// 返回SqlDataReader采购单信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {
            return hypro.f_RequisitionInfo(sql);
        }
        /// <summary>
        /// 返回采购单列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            return hypro.ExecuteQuery(sql);

        }
        /// <summary>
        /// 采购单增删改
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int com_ExecuteQuery(string sql)
        {
            return hypro.com_ExecuteQuery(sql);
        }
        /// <summary>
        /// 新增采购单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_HY_Procurement(HY_Model.HY_Purchaseorder model)
        {
            return hypro.com_HY_Procurement(model);
        }
    }
}
