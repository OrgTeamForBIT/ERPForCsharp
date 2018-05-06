/*  
 * 作者: JOY 
 * 创建时间: 2009-11-18 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   部门信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Department
    {
        private int d_ID;//部门编号
        private string d_Name;//部门名称

        public int D_ID
        {
            get { return d_ID; }
            set { d_ID = value; }
        }

        public string D_Name
        {
            get { return d_Name; }
            set { d_Name = value; }
        }
    }
}
