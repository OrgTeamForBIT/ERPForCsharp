/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统数据库助手类
 */  
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace HY_DbSqlHelp
{
    public class DBsqlHelp
    {

        private static SqlDataAdapter da;
        private static SqlDataReader sdr;
        private static SqlConnection StrConn;
        private static SqlCommand cmd;
        private static DataSet ds;
        private static string sqlcon = ConfigurationManager.AppSettings["hyConnectionString"].ToString();

        public DBsqlHelp()
        {
            //构造函数
            StrConn = new SqlConnection(sqlcon);
        }

        #region 数据库连接
        /// <summary>
        /// 数据库连接
        /// </summary>
        /// <returns>返回</returns>
        public SqlConnection GetConn()
        {
            if (StrConn.State == ConnectionState.Closed)
            {
                StrConn.Open();
            }
            else if (StrConn.State == ConnectionState.Open)
            {
                StrConn.Close();
            }

            return StrConn;
        }
        #endregion

        /// <summary>
        /// 该方法传入SQL查询语句返回DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet DataSetSearch(string sql)
        {
            using (ds = new DataSet())
            {
                da = new SqlDataAdapter(sql, StrConn);
                da.Fill(ds);
                return ds;
            }
        }


        /// <summary>
        /// 该方法传入SQL查询语句返回DataTable
        /// </summary>
        /// <param name="sql">要执行的SQL</param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd = new SqlCommand(sql, GetConn());
                using (sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    dt.Load(sdr);
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 该方法传入SQL查询语句返回SqlDataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader reder(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, GetConn());
                sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        /// <summary>
        /// 数据增删改操作返回INT类型
        /// </summary>
        /// <param name="sql">要执行的SQL语句</param>
        /// <returns>返回</returns>
        public int insertEx(string sql)
        {
            try
            {
                cmd = new SqlCommand(sql, GetConn());
                int res = cmd.ExecuteNonQuery();
                return res;
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }
    }

}
