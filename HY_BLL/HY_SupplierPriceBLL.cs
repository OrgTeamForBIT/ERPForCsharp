using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HY_DAL;
using System.Data;
using HY_Model;

namespace HY_BLL
{
    public class HY_SupplierPriceBLL
    {
        HY_DAL.HY_SupplierPriceDAO hysup = null;
        public HY_SupplierPriceBLL()
        {
            hysup = new HY_SupplierPriceDAO();
        }

        /// <summary>
        /// 新增物料价格信息
        /// </summary>
        /// <param name="model">物料信息实体层</param>
        /// <returns></returns>
        public int com_SupplierPrice(HY_Model.HY_SupplierPrice model)
        {

            return hysup.com_SupplierPrice(model);
        }
        /// <summary>
        /// 增删该物料价格
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <returns></returns>
        public int f_SupplierPrice(string sql)
        {
            return hysup.f_SupplierPrice(sql);
        }
        /// <summary>
        /// 返回供应商物料价格信息列表
        /// </summary>
        /// <returns></returns>
        public DataTable back_SupplierPrice()
        {

            return hysup.back_SupplierPrice();
        }

    }
}
