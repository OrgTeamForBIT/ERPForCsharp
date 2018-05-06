/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   客户信息辑层BLL
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
    public class HY_CustomerInfoBLL
    {
        private HY_CustomerInfoDAO hycoustom;
        public HY_CustomerInfoBLL()
        {
            hycoustom = new HY_CustomerInfoDAO();
        }
        /// <summary>
        /// 返回SqlDataReader表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_CustomerInfolist(string sql)
        {
            return hycoustom.f_CustomerInfolist(sql);
        }

        /// <summary>
        /// 返回DataTable信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {

            return hycoustom.ExecuteQuery(sql);
        }
         /// <summary>
        /// 增删改客户信息
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_HY_CustomerInfo(string sql)
        {
            return hycoustom.com_HY_CustomerInfo(sql);
        }
    }
}
