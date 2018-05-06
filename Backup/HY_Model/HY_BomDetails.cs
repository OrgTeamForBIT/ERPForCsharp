/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   BOM明细实体类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_BomDetails
    {
        private string d_SKID;//受控编号
        private string d_CID;//厂内编号
        private string d_PID;//品号
        private string d_PName;//品名
        private string d_Model;//材料型号
        private string d_Specifications;//材料规格 
        private string d_Amount;//数量
        private string d_Heat;//热处理
        private string d_Notes;//备注
        private string d_SPerson;//设计人
        private string modClass;//模具类型(新模 修模)

        /// <summary>
        /// 受控编号
        /// </summary>
        public string D_SKID
        {
            get { return d_SKID; }
            set { d_SKID = value; }
        }
        /// <summary>
        /// 厂内编号
        /// </summary>
        public string D_CID
        {
            get { return d_CID; }
            set { d_CID = value; }
        }
        /// <summary>
        /// 品号
        /// </summary>
        public string D_PID
        {
            get { return d_PID; }
            set { d_PID = value; }
        }
        /// <summary>
        /// 品名
        /// </summary>
        public string D_PName
        {
            get { return d_PName; }
            set { d_PName = value; }
        }
        /// <summary>
        /// 材料型号
        /// </summary>
        public string D_Model
        {
            get { return d_Model; }
            set { d_Model = value; }
        }
        /// <summary>
        /// 材料规格
        /// </summary>
        public string D_Specifications
        {
            get { return d_Specifications; }
            set { d_Specifications = value; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public string D_Amount
        {
            get { return d_Amount; }
            set { d_Amount = value; }
        }
        /// <summary>
        /// 热处理
        /// </summary>
        public string D_Heat
        {
            get { return d_Heat; }
            set { d_Heat = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string D_Notes
        {
            get { return d_Notes; }
            set { d_Notes = value; }
        }
        
        /// <summary>
        /// 设计人
        /// </summary>
        public string D_SPerson
        {
            get { return d_SPerson; }
            set { d_SPerson = value; }
        }

        /// <summary>
        /// 模具类型
        /// </summary>
        public string ModClass
        {
            get { return modClass; }
            set { modClass = value; }
        }
    }
}
