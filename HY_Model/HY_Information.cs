/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   基本信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Information
    {
        private string s_Company;
        private string s_Range;
        private string s_Address;

        //公司名称
        public string S_Company
        {
            get { return s_Company; }
            set { s_Company = value; }
        }

        //业务范围
        public string S_Range
        {
            get { return s_Range; }
            set { s_Range = value; }
        }

        //公司地址
        public string S_Address
        {
            get { return s_Address; }
            set { s_Address = value; }
        }

    }
}
