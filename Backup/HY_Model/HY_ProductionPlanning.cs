/*  
 * 作者: JOY 
 * 创建时间: 2009-12-22 12:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明:   生产进度指令明细实体类
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HY_Model
{
    public class HY_ProductionPlanning
    {
        private string p_DID;//销售单号
        private string p_KID;//客户番号
        private string p_CID;//厂内编号
        private string p_Engineering;//工程
        private string p_Design;//设计担当
        private DateTime p_YKDate;//营业确认开始时间
        private DateTime p_YWDate;//营业确认完成时间
        private DateTime p_SKDate;//设计开始时间
        private DateTime p_SWDate;//设计完成时间
        private DateTime p_STKDate;//审图开始时间
        private DateTime p_STWDate;//审图完成时间
        private DateTime p_CLKDate;//材料要求到货时间
        private DateTime p_CLWDate;//材料实际到货时间
        private DateTime p_CNCKDate;//CNC加工开始时间
        private DateTime p_CNCWDate;//CNC加工完成时间
        private DateTime p_JJKDate;//机加工开始时间
        private DateTime p_JJWDate;//机加工完成时间
        private DateTime p_HKDate;//热处理开始时间
        private DateTime p_HWDate;//热处理完成时间
        private DateTime p_MKDate;//磨加工开始时间
        private DateTime p_MWDate;//磨加工完成时间
        private DateTime p_XKDate;//线切割开始时间
        private DateTime p_XWDate;//线切割完成时间
        private DateTime p_ZLKDate;//组立开始时间
        private DateTime p_ZLWDate;//组立完成时间
        private DateTime p_SZKDate;//试作开始时间
        private DateTime p_SZWDate;//试作完成时间
        private DateTime p_XJWDate;//型检完成时间
        private DateTime p_OKWDate;//OK样提交完成时间
        private DateTime p_YDWDate;//模具移交完成时间
        /// <summary>
        /// 销售单号
        /// </summary>
        public string P_DID
        {
            get { return p_DID; }
            set { p_DID = value; }
        }

        /// <summary>
        /// 客户番号
        /// </summary>
        public string P_KID
        {
            get { return p_KID; }
            set { p_KID = value; }
        }

        /// <summary>
        /// 厂内编号
        /// </summary>
        public string P_CID
        {
            get { return p_CID; }
            set { p_CID = value; }
        }

        /// <summary>
        /// 工程
        /// </summary>
        public string P_Engineering
        {
            get { return p_Engineering; }
            set { p_Engineering = value; }
        }
   
        /// <summary>
        /// 设计担当
        /// </summary>
        public string P_Design
        {
            get { return p_Design; }
            set { p_Design = value; }
        }
     
        /// <summary>
        /// 营业确认开始时间
        /// </summary>
        public DateTime P_YKDate
        {
            get { return p_YKDate; }
            set { p_YKDate = value; }
        }

        /// <summary>
        /// 营业确认完成时间
        /// </summary>
        public DateTime P_YWDate
        {
            get { return p_YWDate; }
            set { p_YWDate = value; }
        }

        /// <summary>
        /// 设计开始时间
        /// </summary>
        public DateTime P_SKDate
        {
            get { return p_SKDate; }
            set { p_SKDate = value; }
        }

        /// <summary>
        /// 设计完成时间
        /// </summary>
        public DateTime P_SWDate
        {
            get { return p_SWDate; }
            set { p_SWDate = value; }
        }

        /// <summary>
        /// 审图开始时间
        /// </summary>
        public DateTime P_STKDate
        {
            get { return p_STKDate; }
            set { p_STKDate = value; }
        }

        /// <summary>
        /// 审图完成时间
        /// </summary>
        public DateTime P_STWDate
        {
            get { return p_STWDate; }
            set { p_STWDate = value; }
        }

        /// <summary>
        /// 材料要求到货时间
        /// </summary>
        public DateTime P_CLKDate
        {
            get { return p_CLKDate; }
            set { p_CLKDate = value; }
        }

        /// <summary>
        /// 材料实际到货时间
        /// </summary>
        public DateTime P_CLWDate
        {
            get { return p_CLWDate; }
            set { p_CLWDate = value; }
        }

        /// <summary>
        /// CNC加工开始时间
        /// </summary>
        public DateTime P_CNCKDate
        {
            get { return p_CNCKDate; }
            set { p_CNCKDate = value; }
        }

        /// <summary>
        /// CNC加工完成时间
        /// </summary>
        public DateTime P_CNCWDate
        {
            get { return p_CNCWDate; }
            set { p_CNCWDate = value; }
        }

        /// <summary>
        /// 机加工开始时间
        /// </summary>
        public DateTime P_JJKDate
        {
            get { return p_JJKDate; }
            set { p_JJKDate = value; }
        }

        /// <summary>
        /// 机加工完成时间
        /// </summary>
        public DateTime P_JJWDate
        {
            get { return p_JJWDate; }
            set { p_JJWDate = value; }
        }

        /// <summary>
        /// 热处理开始时间
        /// </summary>
        public DateTime P_HKDate
        {
            get { return p_HKDate; }
            set { p_HKDate = value; }
        }

        /// <summary>
        /// 而处理完成时间
        /// </summary>
        public DateTime P_HWDate
        {
            get { return p_HWDate; }
            set { p_HWDate = value; }
        }

        /// <summary>
        /// 磨加工开始时间
        /// </summary>
        public DateTime P_MKDate
        {
            get { return p_MKDate; }
            set { p_MKDate = value; }
        }

        /// <summary>
        /// 磨加工完成时间
        /// </summary>
        public DateTime P_MWDate
        {
            get { return p_MWDate; }
            set { p_MWDate = value; }
        }

        /// <summary>
        /// 线切割开始时间
        /// </summary>
        public DateTime P_XKDate
        {
            get { return p_XKDate; }
            set { p_XKDate = value; }
        }

        /// <summary>
        /// 线切割完成时间
        /// </summary>
        public DateTime P_XWDate
        {
            get { return p_XWDate; }
            set { p_XWDate = value; }
        }

        /// <summary>
        /// 组立开始时间
        /// </summary>
        public DateTime P_ZLKDate
        {
            get { return p_ZLKDate; }
            set { p_ZLKDate = value; }
        }
        /// <summary>
        ///  组立完成时间
        /// </summary>
        public DateTime P_ZLWDate
        {
            get { return p_ZLWDate; }
            set { p_ZLWDate = value; }
        }
        /// <summary>
        /// 试作开始时间
        /// </summary>
        public DateTime P_SZKDate
        {
            get { return p_SZKDate; }
            set { p_SZKDate = value; }
        }
        /// <summary>
        /// 试作完成时间
        /// </summary>
        public DateTime P_SZWDate
        {
            get { return p_SZWDate; }
            set { p_SZWDate = value; }
        }
        /// <summary>
        /// 型检完成时间
        /// </summary>
        public DateTime P_XJWDate
        {
            get { return p_XJWDate; }
            set { p_XJWDate = value; }
        }
        /// <summary>
        /// OK样提交完成时间
        /// </summary>
        public DateTime P_OKWDate
        {
            get { return p_OKWDate; }
            set { p_OKWDate = value; }
        }

        /// <summary>
        /// 模具移交完成时间
        /// </summary>
        public DateTime P_YDWDate
        {
            get { return p_YDWDate; }
            set { p_YDWDate = value; }
        }

    }
}
