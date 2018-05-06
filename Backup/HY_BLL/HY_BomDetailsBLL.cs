/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   BOM明细业务逻辑层BLL
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
    public class HY_BomDetailsBLL
    {
        private HY_BomDetailsDAO hybomdetal = null;

        public HY_BomDetailsBLL()
        {
            hybomdetal = new HY_BomDetailsDAO();
        }
        /// <summary>
        /// 增删改BOM明细
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int f_HYBomDetailslist(string sql)
        {
            return hybomdetal.f_HYBomDetailslist(sql);
        }
        /// <summary>
        /// 新增BOM物料明细
        /// </summary>
        /// <param name="model">BOM物料明细MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_BomDetailslist(HY_Model.HY_BomDetails model)
        {
            return hybomdetal.com_HY_BomDetailslist(model);
        }
        /// <summary>
        /// 返回BOM明细信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery()
        {
            return hybomdetal.ExecuteQuery();
        }

        /// <summary>
        /// 返回检索后BOM明细信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuerySelect(string d_SKID)
        {
            return hybomdetal.ExecuteQuerySelect(d_SKID);
        }

        /// <summary>
        /// SQL返回SqlDataReader明细表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_SQLBom(string sql)
        {
            return hybomdetal.f_SQLBom(sql);
        }
    }
}
