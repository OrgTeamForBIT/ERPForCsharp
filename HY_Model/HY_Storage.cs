/*  
 * 作者: JOY 
 * 创建时间: 2009-12-18 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   入库信息实体类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Storage
    {
        private string s_DID;//单号
        private string s_CID;//厂内编号
        private string s_Person;//入库人
        private string s_Class;//产品类别（大类）
        private string s_Warehouse;//仓库
        private DateTime s_XDate;//入库时间
        private DateTime s_DDate;//到货时间
        private string s_PID;//品号
        private string s_Pname;//品名
        private string s_Origin;//型号
        private string s_Specifications;//规格
        private string s_Supplier;//供应商
        private string s_Units;//单位
        private int s_Amount;//数量
        private float s_Price;//单价
        private string s_Notes;//备注

        /// <summary>
        /// 厂内编号
        /// </summary>
        public string S_CID
        {
            get { return s_CID; }
            set { s_CID = value; }
        }
        /// <summary>
        /// 单号
        /// </summary>
        public string S_DID
        {
            get { return s_DID; }
            set { s_DID = value; }
        }
        /// <summary>
        /// 入库人
        /// </summary>
        public string S_Person
        {
            get { return s_Person; }
            set { s_Person = value; }
        }
        /// <summary>
        /// 产品类别（大类）
        /// </summary>
        public string S_Class
        {
            get { return s_Class; }
            set { s_Class = value; }
        }
        /// <summary>
        /// 仓库
        /// </summary>
        public string S_Warehouse
        {
            get { return s_Warehouse; }
            set { s_Warehouse = value; }
        }
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime S_XDate
        {
            get { return s_XDate; }
            set { s_XDate = value; }
        }
        /// <summary>
        /// 到货时间
        /// </summary>
        public DateTime S_DDate
        {
            get { return s_DDate; }
            set { s_DDate = value; }
        }
        /// <summary>
        /// 品号
        /// </summary>
        public string S_PID
        {
            get { return s_PID; }
            set { s_PID = value; }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string S_Pname
        {
            get { return s_Pname; }
            set { s_Pname = value; }
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public string S_Supplier
        {
            get { return s_Supplier; }
            set { s_Supplier = value; }
        }
        /// <summary>
        /// 型号
        /// </summary>
        public string S_Origin
        {
            get { return s_Origin; }
            set { s_Origin = value; }
        }
        /// <summary>
        /// 规格
        /// </summary>
        public string S_Specifications
        {
            get { return s_Specifications; }
            set { s_Specifications = value; }
        }
        //单位
        public string S_Units
        {
            get { return s_Units; }
            set { s_Units = value; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int S_Amount
        {
            get { return s_Amount; }
            set { s_Amount = value; }
        }
        /// <summary>
        /// 单价
       /// </summary>
        public float S_Price
        {
            get { return s_Price; }
            set { s_Price = value; }
        }       
        /// <summary>
        /// 备注
        /// </summary>
        public string S_Notes
        {
            get { return s_Notes; }
            set { s_Notes = value; }
        }

    }
}
