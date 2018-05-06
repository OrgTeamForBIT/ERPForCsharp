using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HYWJ.HY_System
{
    public  class OperateAndValidate
    {
        #region  验证数字
        /// <summary>
        /// 验证数字
        /// </summary>
        /// <param name="P_str_num"></param>
        /// <returns></returns>
        public bool validateNum(string P_str_num)
        {
            return Regex.IsMatch(P_str_num, "^[0-9]*$");
        }
        #endregion
        #region  验证传真
        /// <summary>
        /// 验证传真
        /// </summary>
        /// <param name="P_str_fax"></param>
        /// <returns></returns>
        public bool validateFax(string P_str_fax)
        {
            return Regex.IsMatch(P_str_fax, @"86-\d{3,4}-\d{7,8}");
        }
        #endregion
        #region  验证邮政编码
        /// <summary>
        /// 验证邮政编码
        /// </summary>
        /// <param name="P_str_postcode"></param>
        /// <returns></returns>
        public bool validatePostCode(string P_str_postcode)
        {
            return Regex.IsMatch(P_str_postcode, @"\d{6}");
        }
        #endregion
        #region  验证电子邮件
        /// <summary>
        /// 验证电子邮件
        /// </summary>
        /// <param name="P_str_email"></param>
        /// <returns></returns>
        public bool validateEmail(string P_str_email)
        {
            return Regex.IsMatch(P_str_email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }
        #endregion
        #region  验证网址
        /// <summary>
        /// 验证网址
        /// </summary>
        /// <param name="P_str_naddress"></param>
        /// <returns></returns>
        public bool validateNAddress(string P_str_naddress)
        {
            return Regex.IsMatch(P_str_naddress, @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        #endregion
        #region  验证是否为空
        /// <summary>
        /// 验证是否为空
        /// </summary>
        /// <param name="P_str_null"></param>
        /// <returns></returns>
        public bool validateNull(string P_str_null)
        {
            bool falg = false;
            if (P_str_null == string.Empty)
            {
                falg = false;
            }
            else
            {
                falg = true;
            }
            return falg;
        }
        #endregion
    }
}
