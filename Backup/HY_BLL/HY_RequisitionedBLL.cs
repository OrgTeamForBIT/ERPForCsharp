/*  
 * 作者: JOY 
 * 创建时间: 2009-12-22 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   物料领取业务逻辑层BLL
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
    public class HY_RequisitionedBLL
    {
        private HY_RequisitionedDAO hyreq = null;//实例化
        //构造函数
        public HY_RequisitionedBLL()
        {
            hyreq = new HY_RequisitionedDAO();       
        }
        /// <summary>
        /// 返回SqlDataReader物料领取明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_ProductionPlanningslist(string sql)
        {
            return hyreq.f_ProductionPlanningslist(sql);
        }
        /// <summary>
        /// 返回物料领取信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            return hyreq.ExecuteQuery(sql);
        }
        /// <summary>
        /// 增删改领取物料信息
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_HY_ProductionPlanninglist(string sql)
        {
            return hyreq.com_HY_ProductionPlanninglist(sql);
        }
    }
}
