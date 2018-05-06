/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   供应商信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Supplier
    {
        private string s_gyName;//供应商名称
        private string s_jName;//简称
        private string s_Area;//地区
        private string s_cpName;//产品名称
        private string s_name;//联系人姓名
        private string s_tel;//联系人电话

        /// <summary>
        /// 供应商名称
        /// </summary>
        public string S_gyName
        {
            get { return s_gyName; }
            set { s_gyName = value; }
        }
        /// <summary>
        /// 简称
        /// </summary>
        public string S_jName
        {
            get { return s_jName; }
            set { s_jName = value; }
        }
        /// <summary>
        /// 城市
        /// </summary>
        public string S_Area
        {
            get { return s_Area; }
            set { s_Area = value; }
        }

        /// <summary>
        /// 业务范围
        /// </summary>
        public string S_cpName
        {
            get { return s_cpName; }
            set { s_cpName = value; }
        }
        
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string S_name
        {
            get { return s_name; }
            set { s_name = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string S_tel
        {
            get { return s_tel; }
            set { s_tel = value; }
        }
    }
}
