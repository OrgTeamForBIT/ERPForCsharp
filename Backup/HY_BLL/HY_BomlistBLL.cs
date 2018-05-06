/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   BOM业务逻辑层BLL
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
    public class HY_BomlistBLL
    {
        private HY_BomlistDAO hybom = null;

        public HY_BomlistBLL()
        {
           hybom=new HY_BomlistDAO();
        }
        /// <summary>
        /// 返回BOM信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
          return hybom.ExecuteQuery(sql);
        }
         /// <summary>
        /// 新增BOM物料
        /// </summary>
        /// <param name="model">BOM物料MODEL实体类</param>
        /// <returns></returns>
        public int com_HY_Bomlist(HY_Model.HY_Bomlist model)
        {
            return hybom.com_HY_Bomlist(model);
        }

        /// <summary>
        /// 返回SqlDataReaderBOM表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_Bomlist(string sql)
        {
            return hybom.f_Bomlist(sql);
        }

        /// <summary>
        /// 返回选择后SqlDataReaderBOM表信息
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_BomlistSelect(string d_SKID)
        {
            return hybom.f_BomlistSelect(d_SKID);
        }
        /// <summary>
        /// 删除、更新BOM信息
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_HY_BomlistX(string sql)
        {
            return hybom.com_HY_BomlistX(sql);
        }
    }
}
