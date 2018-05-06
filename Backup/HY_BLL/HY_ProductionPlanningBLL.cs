/*  
 * 作者: JOY 
 * 创建时间: 2009-12-22 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   生产计划指令排程逻辑层BLL
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
    public class HY_ProductionPlanningBLL
    {
        private HY_ProductionPlanningDAO hyprodou = null;//实例化

        //构造函数
        public HY_ProductionPlanningBLL()
        {
            hyprodou = new HY_ProductionPlanningDAO();
        }
        /// <summary>
        /// 返回SqlDataReader生产排程明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_ProductionPlanningslist(string sql)
        {
            return hyprodou.f_ProductionPlanningslist(sql);
        }

        /// <summary>
        /// 返回生产排程明细信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            return hyprodou.ExecuteQuery(sql);
        }

        /// <summary>
        /// 增删改排程生产计划
        /// </summary>
        /// <param name="model">排程生产计划MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_ProductionPlanninglist(string sql)
        {
            return hyprodou.com_HY_ProductionPlanninglist(sql);
        }
    }
}
