/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商物料信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    /// <summary>
    /// 供应商物料价格实体类
    /// </summary>
    public class HY_SupplierPrice
    {
        private string p_DID;
        private string p_PID;
        private string p_gyName;
        private DateTime p_Date;
        private string p_PName;
        private int p_Price;
        private string p_Weight;
        private string p_Vray;
        private string p_SM;
        private string p_rPerson;

       

        /// <summary>
        /// 单号
        /// </summary>
        public string P_DID
        {
            get { return p_DID; }
            set { p_DID = value; }
        }

        /// <summary>
        /// 品号
        /// </summary>
        public string P_PID
        {
            get { return p_PID; }
            set { p_PID = value; }
        }
        /// <summary>
        /// 供应商名
        /// </summary>
        public string P_gyName
        {
            get { return p_gyName; }
            set { p_gyName = value; }
        }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime P_Date
        {
            get { return p_Date; }
            set { p_Date = value; }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string P_PName
        {
            get { return p_PName; }
            set { p_PName = value; }
        }
        /// <summary>
        /// 价格
        /// </summary>
        public int P_Price
        {
            get { return p_Price; }
            set { p_Price = value; }
        }
        /// <summary>
        /// 重量
        /// </summary>
        public string P_Weight
        {
            get { return p_Weight; }
            set { p_Weight = value; }
        }
        /// <summary>
        /// 材质
        /// </summary>
        public string P_Vray
        {
            get { return p_Vray; }
            set { p_Vray = value; }
        }
        /// <summary>
        /// 规格说明
        /// </summary>
        public string P_SM
        {
            get { return p_SM; }
            set { p_SM = value; }
        }
        /// <summary>
        /// 录入人
        /// </summary>
        public string P_rPerson
        {
            get { return p_rPerson; }
            set { p_rPerson = value; }
        }
    }
}
