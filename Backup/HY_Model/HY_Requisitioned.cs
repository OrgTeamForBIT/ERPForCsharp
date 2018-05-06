/*  
 * 作者: JOY 
 * 创建时间: 2009-12-30 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   物料领取实体类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Requisitioned
    {
        private string r_DID;//--领料单号
        private string r_CID;//--厂内编号
        private string r_Person;//--领料人
        private string r_Class;//--料件类别（大类）
        private string r_Warehouse;//--所在仓库
        private DateTime r_LDate;//--领料日期
        private string r_PID;//--物料品号
        private string r_Pname;// --品名
        private string r_Specifications;//--物料规格
        private int r_Amount;//--领取数量
        private string r_Price;//--物料单价
        private string r_Notes;//--领料备注

        /// <summary>
        /// 领料单号
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
        /// 领料人
        /// </summary>
        public string R_Person
        {
            get { return r_Person; }
            set { r_Person = value; }
        }

        /// <summary>
        /// 料件类别（大类）
        /// </summary>
        public string R_Class
        {
            get { return r_Class; }
            set { r_Class = value; }
        }

        /// <summary>
        /// 所在仓库
        /// </summary>
        public string R_Warehouse
        {
            get { return r_Warehouse; }
            set { r_Warehouse = value; }
        }

        /// <summary>
        /// 领料日期
        /// </summary>
        public DateTime R_LDate
        {
            get { return r_LDate; }
            set { r_LDate = value; }
        }

        /// <summary>
        /// 物料品号
        /// </summary>
        public string R_PID
        {
            get { return r_PID; }
            set { r_PID = value; }
        }

        /// <summary>
        /// 品名
        /// </summary>
        public string R_Pname
        {
            get { return r_Pname; }
            set { r_Pname = value; }
        }

        /// <summary>
        /// 物料规格
        /// </summary>
        public string R_Specifications
        {
            get { return r_Specifications; }
            set { r_Specifications = value; }
        }

        /// <summary>
        /// 领取数量
        /// </summary>
        public int R_Amount
        {
            get { return r_Amount; }
            set { r_Amount = value; }
        }

        /// <summary>
        /// 物料单价
        /// </summary>
        public string R_Price
        {
            get { return r_Price; }
            set { r_Price = value; }
        }

        /// <summary>
        /// 领料备注
        /// </summary>
        public string R_Notes
        {
            get { return r_Notes; }
            set { r_Notes = value; }
        }
    }
}
