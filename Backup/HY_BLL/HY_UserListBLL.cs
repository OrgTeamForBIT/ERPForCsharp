/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   用户业务逻辑层BLL
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
    public class HY_UserListBLL
    {

        private HY_UserListDAO hyul = null;
        public HY_UserListBLL()
        {
            hyul = new HY_UserListDAO();
        }

        /// <summary>
        /// 返回SqlDataReader
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_hyUserLiset(string sql)
        {
            return hyul.f_hyUserLiset(sql);
        }

        /// <summary>
        /// 返回DataTable人员信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_SupplierPrice()
        {
            return hyul.back_hyUserLiset();
        }
    }
}
