/*  
 * 作者: JOY 
 * 创建时间: 2009-11-20 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   部门信息DAL层
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DbSqlHelp;
using HY_Model;

namespace HY_DAL
{
    public class HY_DepartmentDAO
    {
        /// <summary>
        /// 返回部门DataTable信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            //string sql = "select * from HY_Department";
            HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
            DataTable ds = new DataTable();
            ds = hy_help.ExecuteQuery(sql);
            return ds;
        }
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int com_Department(HY_Model.HY_Department model)
        {
            try
            {
                string sql = "insert into HY_Department(d_Name) values('" + model.D_Name + "')";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {

                throw EX;
            }

        }
        /// <summary>
        ///  增删改
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int com_DepartmentZSG(string sql)
        {
            try
            {
                //string sql = "insert into HY_Department(d_Name) values('" + model.D_Name + "')";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {

                throw EX;
            }

        }
        /// <summary>
        ///删除部门
        /// </summary>
        /// <param name="model">部门实体类D_ID</param>
        /// <returns></returns>
        public int del_Department(HY_Model.HY_Department model)
        {
            try
            {
                string sql = "delete from HY_Department where d_ID='"+model.D_ID+"'";
                HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
                int res = hy_help.insertEx(sql);
                return res;
            }
            catch (Exception EX)
            {

                throw EX;
            }
        
        }
    }
}
