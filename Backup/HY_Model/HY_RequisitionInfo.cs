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
    public class HY_RequisitionInfo
    {
        private string r_DID;
        private string r_CID;
        private string r_Department;
        private string r_Person;
        private string r_Name;
        private string r_NameID;
        private string r_Supplier;
        private string r_Origin;
        private DateTime r_QDate;
        private DateTime r_XDate;
        private string r_Specifications;
        private string r_Units;
        private int r_Amount;
        private string r_Uses;
        private string r_Notes;
        private string r_Hot;


        /// <summary>
        /// 请购单号
        /// </summary>
        public string R_DID
        {
            get { return r_DID; }
            set { r_DID = value; }
        }
        /// <summary>
        /// 厂内编号
        /// </summary>
        public string R_CID
        {
            get { return r_CID; }
            set { r_CID = value; }
        }
        /// <summary>
        /// 品号
        /// </summary>
        public string R_NameID
        {
            get { return r_NameID; }
            set { r_NameID = value; }
        }
        /// <summary>
        /// 请购部门
        /// </summary>
        public string R_Department
        {
            get { return r_Department; }
            set { r_Department = value; }
        }
  
        /// <summary>
        /// 请购人
        /// </summary>
        public string R_Person
        {
            get { return r_Person; }
            set { r_Person = value; }
        }

        /// <summary>
        /// 请购品名
        /// </summary>
        public string R_Name
        {
            get { return r_Name; }
            set { r_Name = value; }
        }
  
        /// <summary>
        /// 供应商
        /// </summary>
        public string R_Supplier
        {
            get { return r_Supplier; }
            set { r_Supplier = value; }
        }
    
        /// <summary>
        /// 地区
        /// </summary>
        public string R_Origin
        {
            get { return r_Origin; }
            set { r_Origin = value; }
        }
 
        /// <summary>
        /// 请购日期
        /// </summary>
        public DateTime R_QDate
        {
            get { return r_QDate; }
            set { r_QDate = value; }
        }
    
        /// <summary>
        /// 需要日期
        /// </summary>
        public DateTime R_XDate
        {
            get { return r_XDate; }
            set { r_XDate = value; }
        }
        
        /// <summary>
        /// 产品规格说明
        /// </summary>
        public string R_Specifications
        {
            get { return r_Specifications; }
            set { r_Specifications = value; }
        }
      
        /// <summary>
        /// 单位
        /// </summary>
        public string R_Units
        {
            get { return r_Units; }
            set { r_Units = value; }
        }
     
        /// <summary>
        /// 数量
        /// </summary>
        public int R_Amount
        {
            get { return r_Amount; }
            set { r_Amount = value; }
        }
      
        /// <summary>
        /// 用途
        /// </summary>
        public string R_Uses
        {
            get { return r_Uses; }
            set { r_Uses = value; }
        }
        
        /// <summary>
        /// 备注信息
        /// </summary>
        public string R_Notes
        {
            get { return r_Notes; }
            set { r_Notes = value; }
        }
        /// <summary>
        /// 热处理
        /// </summary>
        public string R_Hot
        {
            get { return r_Hot; }
            set { r_Hot = value; }
        }

    }
}
