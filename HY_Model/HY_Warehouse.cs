/*  
 * 作者: JOY 
 * 创建时间: 2009-11-25 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   仓库信息实体类
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_Warehouse
    {
        private int c_ID;
        private string c_ckName;

        /// <summary>
        /// 仓库ID编号
        /// </summary>
        public int C_ID
        {
            get { return c_ID; }
            set { c_ID = value; }
        }
        
        /// <summary>
        /// 仓库名
        /// </summary>
        public string C_ckName
        {
            get { return c_ckName; }
            set { c_ckName = value; }
        }
    }
}
