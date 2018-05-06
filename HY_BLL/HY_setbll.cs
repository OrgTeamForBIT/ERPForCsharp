/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统业务逻辑层BLL
 */  
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using HY_DAL;
using HY_Model;

namespace HY_BLL
{
    public class HY_setbll
    {
        
        private HY_Set hyset=null;
        public HY_setbll()
        {
            //构造函数初始化
            hyset = new HY_Set();
        }
        /// <summary>
        /// DataTable信息
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable userSecurity(string sql)
        {
            return hyset.userSecurity(sql);
        }
        /// <summary>
        /// 返回SqlDataReader信息列表
        /// </summary>
        /// <returns></returns>
        public SqlDataReader f_RequisitionInfo(string sql)
        {
            return hyset.f_RequisitionInfo(sql);
        }
        /// <summary>
        /// 返回添加用户操作
        /// </summary>
        /// <param name="model">Moldel实体对象</param>
        /// <returns></returns>
        public int userOperation(HY_Model.User model)
        {
            return hyset.userOperation(model);
        }
        /// <summary>
        /// 更新权限
        /// </summary>
        /// <param name="model">用户权限实体类</param>
        /// <param name="user">用户</param>
        /// <returns></returns>
        public int userSecurityUpdate(HY_Model.User model, string user)
        {
            return hyset.userSecurityUpdate(model, user);

        }
        /// <summary>
        /// 返回修改更新用户操作
        /// </summary>
        /// <param name="model">用户表实体</param>
        /// <param name="h_ID">需要修改用户编号(唯一)</param>
        /// <returns></returns>
        public int userOperationUpdate(HY_Model.User model, int h_ID)
        {
            return hyset.userOperationUpdate(model, h_ID);
            
        }
        /// <summary>
        /// 查询后返回DataTable
        /// </summary>
        /// <param name="model">登陆用户实体类</param>
        /// <returns></returns>
        public DataTable userAuthentication(HY_Model.User model)
        {
            return hyset.userAuthentication(model);
        }
    }
}
