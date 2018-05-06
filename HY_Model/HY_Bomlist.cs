/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   BOM信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Bomlist
    {

        private string b_SKID;//受控编号
        private string b_CID;//厂内编号
        private string b_CustomerID;//客户编号
        private string b_No;//工程数
        private string b_Material;//材质
        private string b_BomSize;//用料尺寸
        private string b_Notes;//工作内容
        private string b_Height;//闭合高度
        private string b_Tonnage;//冲床吨位
        private string b_Name;//模具名称
        private string b_ModClass;//模具类型
        private string b_SPerson;//设计人
        private string b_Department;//所属部门
        private string b_Proofreading;//校对人
        private string b_Audit;//审核人
        private DateTime b_SDate;//设计时间
        private DateTime b_XDate;//校对时间
        private DateTime b_HDate;//核对时间

        /// <summary>
        /// 受控编号
        /// </summary>
        public string B_SKID
        {
            get { return b_SKID; }
            set { b_SKID = value; }
        }
       /// <summary>
        /// 厂内编号
       /// </summary>
        public string B_CID
        {
            get { return b_CID; }
            set { b_CID = value; }
        }
        /// <summary>
        /// 客户编号
        /// </summary>
        public string B_CustomerID
        {
            get { return b_CustomerID; }
            set { b_CustomerID = value; }
        }
        /// <summary>
        /// 工程数
        /// </summary>
        public string B_No
        {
            get { return b_No; }
            set { b_No = value; }
        }
        /// <summary>
        /// 材质
        /// </summary>
        public string B_Material
        {
            get { return b_Material; }
            set { b_Material = value; }
        }
        /// <summary>
        /// 用料尺寸
        /// </summary>
        public string B_BomSize
        {
            get { return b_BomSize; }
            set { b_BomSize = value; }
        }
        /// <summary>
        /// 工作内容
        /// </summary>
        public string B_Notes
        {
            get { return b_Notes; }
            set { b_Notes = value; }
        }
        /// <summary>
        /// 闭合高度
        /// </summary>
        public string B_Height
        {
            get { return b_Height; }
            set { b_Height = value; }
        }
        /// <summary>
        /// 冲床吨位
        /// </summary>
        public string B_Tonnage
        {
            get { return b_Tonnage; }
            set { b_Tonnage = value; }
        }
        /// <summary>
        /// 模具名称
        /// </summary>
        public string B_Name
        {
            get { return b_Name; }
            set { b_Name = value; }
        }
        /// <summary>
        /// 模具类型
        /// </summary>
        public string B_ModClass
        {
            get { return b_ModClass; }
            set { b_ModClass = value; }
        }
        /// <summary>
        /// 设计人
        /// </summary>
        public string B_SPerson
        {
            get { return b_SPerson; }
            set { b_SPerson = value; }
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string B_Department
        {
            get { return b_Department; }
            set { b_Department = value; }
        }
        /// <summary>
        /// 校对人
        /// </summary>
        public string B_Proofreading
        {
            get { return b_Proofreading; }
            set { b_Proofreading = value; }
        }
        /// <summary>
        /// 审核人
        /// </summary>
        public string B_Audit
        {
            get { return b_Audit; }
            set { b_Audit = value; }
        }
        /// <summary>
        /// 设计时间
        /// </summary>
        public DateTime B_SDate
        {
            get { return b_SDate; }
            set { b_SDate = value; }
        }
         /// <summary>
        /// 校对时间
         /// </summary>
        public DateTime B_XDate
        {
            get { return b_XDate; }
            set { b_XDate = value; }
        }
        
        /// <summary>
        /// 核对时间
        /// </summary>
        public DateTime B_HDate
        {
            get { return b_HDate; }
            set { b_HDate = value; }
        }


    }
}
