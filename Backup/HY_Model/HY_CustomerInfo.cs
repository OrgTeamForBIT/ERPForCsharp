/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   客户信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_CustomerInfo
    {
        private string o_Name;//客户名称
        private string c_FID;//客户番号
        private string o_CPName;//产品名称
        private string o_Person;//录单人
        private DateTime o_RDate;//入单日期
        private DateTime o_XDate;//下单日期
        private DateTime o_JDate;//交货日期
        private string o_Notes;// 备注
        private string o_DID;// 销售订单号
        private string o_Amount;// 模具数量(套)
        private string o_Class;// 模具类型
        
        /// <summary>
        /// 销售订单号
        /// </summary>
        public string O_DID
        {
            get { return o_DID; }
            set { o_DID = value; }
        }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string O_CPName
        {
            get { return o_CPName; }
            set { o_CPName = value; }
        }
        /// <summary>
        /// 录单人
        /// </summary>
        public string O_Person
        {
            get { return o_Person; }
            set { o_Person = value; }
        }
        /// <summary>
        /// 录单时间
        /// </summary>
        public DateTime O_RDate
        {
            get { return o_RDate; }
            set { o_RDate = value; }
        }
        /// <summary>
        /// 下单日期
        /// </summary>
        public DateTime O_XDate
        {
            get { return o_XDate; }
            set { o_XDate = value; }
        }
        /// <summary>
        /// 交货日期
        /// </summary>
        public DateTime O_JDate
        {
            get { return o_JDate; }
            set { o_JDate = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string O_Notes
        {
            get { return o_Notes; }
            set { o_Notes = value; }
        }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string O_Name
        {
            get { return o_Name; }
            set { o_Name = value; }
        }
        /// <summary>
        /// 客户番号
        /// </summary>
        public string C_FID
        {
            get { return c_FID; }
            set { c_FID = value; }
        }
        /// <summary>
        /// 模具数量(套)
        /// </summary>
        public string O_Amount
        {
            get { return o_Amount; }
            set { o_Amount = value; }
        }
        /// <summary>
        /// 模具类型
        /// </summary>
        public string O_Class
        {
            get { return o_Class; }
            set { o_Class = value; }
        }
    }
}
