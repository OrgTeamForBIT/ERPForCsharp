/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   部门信息业务逻辑层BLL
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DAL;

namespace HY_BLL
{
    public class HY_DepartmentBLL
    {
        private HY_DepartmentDAO hydep = null;

        public HY_DepartmentBLL()
        {
            hydep = new HY_DepartmentDAO();
        }

        /// <summary>
        /// 返回部门DataTable信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {

            return hydep.ExecuteQuery(sql);
        }
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="model">HY_Department部门实体类</param>
        /// <returns></returns>
        public int com_Department(HY_Model.HY_Department model)
        {
            return hydep.com_Department(model);
        }
        /// <summary>
        ///删除部门
        /// </summary>
        /// <param name="model">部门实体类D_ID</param>
        /// <returns></returns>
        public int del_Department(HY_Model.HY_Department model)
        {
            return hydep.del_Department(model);
        }
        /// <summary>
        ///  增删改
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_DepartmentZSG(string sql)
        {
            return hydep.com_DepartmentZSG(sql);
        }
    }
}
