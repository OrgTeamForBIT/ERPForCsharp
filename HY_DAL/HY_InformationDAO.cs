/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统DAL层
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
   public class HY_InformationDAO
    {
       /// <summary>
       /// 系统信息基础设置
       /// </summary>
        /// <param name="model">Information实体类</param>
       /// <param name="I_ID">ID值</param>
       /// <returns></returns>
       public int com_Information(HY_Model.HY_Information model, int I_ID)
       {
           try
           {
               string sql = "update HY_Information set I_CompanyName='" + model.S_Company + "',I_Range='" + model.S_Range + "',I_Address='" + model.S_Address + "' where I_ID='" + I_ID + "'";
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
       /// 返回一条公司基本信息记录
       /// </summary>
       /// <param name="I_ID">ID编号</param>
       /// <returns></returns>
       public DataTable comf_Information(int I_ID)
       {
           try
           {
               DataTable dt = new DataTable();
               string sql = "select * from HY_Information where I_ID='" + I_ID + "'";
               HY_DbSqlHelp.DBsqlHelp hy_help = new DBsqlHelp();
               dt = hy_help.ExecuteQuery(sql);
               return dt;
           }
           catch (Exception EX)
           {
               
               throw EX;
           }
           
       }
       
    }
}
