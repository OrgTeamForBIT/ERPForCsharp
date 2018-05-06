/*  
 * 作者: JOY 
 * 创建时间: 2009-12-3 14:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   采购信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Purchaseorder
    {
        private string c_DID;//采购单号
        private string c_CID;//厂内单号
        private string c_Department;//请购部门
        private string c_Person;//请购人
        private string c_Name;//请购产品名称
        private string c_NameID;//品号
        private string c_Supplier;//供应商
        private string c_Origin;//地区
        private DateTime c_QDate;//请购日期
        private DateTime c_XDate;//需要日期
        private string c_Specifications;//材料规格
        private string c_Units;//单位
        private int c_Amount;//数量
        private string c_Uses;//用途
        private string c_Notes;//备注
        private string c_Hot;//热处理

        /// <summary>
        /// 采购单号
        /// </summary>
        public string C_DID
        {
            get { return c_DID; }
            set { c_DID = value; }
        }

        /// <summary>
        /// 厂内单号
        /// </summary>
        public string C_CID
        {
            get { return c_CID; }
            set { c_CID = value; }
        }

        /// <summary>
        /// 请购部门
        /// </summary>
        public string C_Department
        {
            get { return c_Department; }
            set { c_Department = value; }
        }

        /// <summary>
        /// 请购人
        /// </summary>
        public string C_Person
        {
            get { return c_Person; }
            set { c_Person = value; }
        }

        /// <summary>
        /// 请购产品名称
        /// </summary>
        public string C_Name
        {
            get { return c_Name; }
            set { c_Name = value; }
        }
        /// <summary>
        /// 品号
        /// </summary>
        public string C_NameID
        {
            get { return c_NameID; }
            set { c_NameID = value; }
        }
        /// <summary>
        /// 供应商
        /// </summary>
        public string C_Supplier
        {
            get { return c_Supplier; }
            set { c_Supplier = value; }
        }

        /// <summary>
        /// 地区
        /// </summary>
        public string C_Origin
        {
            get { return c_Origin; }
            set { c_Origin = value; }
        }

        /// <summary>
        /// 请购日期
        /// </summary>
        public DateTime C_QDate
        {
            get { return c_QDate; }
            set { c_QDate = value; }
        }

        /// <summary>
        /// 需要日期
        /// </summary>
        public DateTime C_XDate
        {
            get { return c_XDate; }
            set { c_XDate = value; }
        }

        /// <summary>
        /// 材料规格
        /// </summary>
        public string C_Specifications
        {
            get { return c_Specifications; }
            set { c_Specifications = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string C_Units
        {
            get { return c_Units; }
            set { c_Units = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        public int C_Amount
        {
            get { return c_Amount; }
            set { c_Amount = value; }
        }

        /// <summary>
        /// 用途
        /// </summary>
        public string C_Uses
        {
            get { return c_Uses; }
            set { c_Uses = value; }
        }

        /// <summary>
        /// 备注
        /// </summary>
        public string C_Notes
        {
            get { return c_Notes; }
            set { c_Notes = value; }
        }


        /// <summary>
        /// 热处理
        /// </summary>
        public string C_Hot
        {
            get { return c_Hot; }
            set { c_Hot = value; }
        }

    }
}
