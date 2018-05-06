/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商业务逻辑层BLL
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
    public class HY_SupplierBLL
    {
        private HY_SupplierDAO hysp = null;

        public HY_SupplierBLL()
        {
            hysp = new HY_SupplierDAO();
        }

        /// <summary>
        /// 新增供应商信息
        /// </summary>
        /// <param name="model">供应商信息实体层</param>
        /// <returns></returns>
        public int com_Supplier(HY_Model.HY_Supplier model)
        {
            return hysp.com_Supplier(model);
        }

        /// <summary>
        /// 返回供应商信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_Supplier()
        {
            return hysp.back_Supplier();
        }

        /// <summary>
        /// 返回SqlDataReader人员信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_SupplierLiset(string sql)
        {
            return hysp.f_SupplierLiset(sql);

        }
    }
}
