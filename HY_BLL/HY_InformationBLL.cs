/*  
 * 作者: JOY 
 * 创建时间: 2009-10-10 19:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   海益数据信息系统业务逻辑层BLL
 */  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using HY_DAL;
using HY_Model;

namespace HY_BLL
{
    public class HY_InformationBLL
    {
        private HY_InformationDAO hyinfo = null;

        public HY_InformationBLL()
        {
            hyinfo = new HY_InformationDAO();
        }

        /// <summary>
        /// 更新公司基本信息设置
        /// </summary>
        /// <param name="model">Information实体类</param>
        /// <param name="I_ID">ID值</param>
        /// <returns></returns>
        public int com_Information(HY_Model.HY_Information model, int I_ID)
        {
            return hyinfo.com_Information(model, I_ID);
        }

        /// <summary>
        /// 返回一条公司基本信息记录
        /// </summary>
        /// <param name="I_ID">ID编号</param>
        /// <returns></returns>
        public DataTable comf_Information(int I_ID)
        {
            return hyinfo.comf_Information(I_ID);
        }
    }
}
