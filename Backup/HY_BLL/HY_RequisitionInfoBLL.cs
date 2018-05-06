/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   请购信息业务逻辑层BLL
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
    /// <summary>
    /// 请购单信息BLL
    /// </summary>
    public class HY_RequisitionInfoBLL
    {
        private HY_RequisitionInfoDAO hyrepinfo = null;

        public HY_RequisitionInfoBLL()
        {
            hyrepinfo = new HY_RequisitionInfoDAO();
        }

        /// <summary>
        /// 返回SqlDataReader请购单信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {
            return hyrepinfo.f_RequisitionInfo(sql);
        }
        /// <summary>
        /// 返回信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            return hyrepinfo.ExecuteQuery(sql);
        }

        /// <summary>
        /// 新增请购单信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_RequisitionInfo(HY_Model.HY_RequisitionInfo model)
        {
            return hyrepinfo.com_RequisitionInfo(model);
        }

        /// <summary>
        /// 请购单抛转采购单
        /// </summary>
        /// <returns></returns>
        public int com_ExecuteQuery(string sql)
        {
            return hyrepinfo.com_ExecuteQuery(sql);
        }
    }
}
