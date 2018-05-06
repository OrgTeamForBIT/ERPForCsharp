/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   仓库信息业务逻辑层BLL
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DAL;

namespace HY_BLL
{
    public class HY_WarehouseBLL
    {
        private HY_DAL.HY_WarehouseDAO hywar = null;
        public HY_WarehouseBLL()
        {
            hywar = new HY_WarehouseDAO();
        }
        /// <summary>
        /// 返回仓库列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery()
        {
            return hywar.ExecuteQuery();
        }

        /// <summary>
        /// 新增仓库
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_Warehouse(HY_Model.HY_Warehouse model)
        {
            return hywar.com_Warehouse(model);
        }

        /// <summary>
        ///删除仓库
        /// </summary>
        /// <param name="model">仓库实体类c_ID</param>
        /// <returns></returns>
        public int del_Warehouse(HY_Model.HY_Warehouse model)
        {
            return hywar.del_Warehouse(model);
        }
    }
}
