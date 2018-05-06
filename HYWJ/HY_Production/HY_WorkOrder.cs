/*  
 * 作者: JOY 
 * 创建时间: 2010-01-7 20:49:36  
 * Email: zhuoyue03007@qq.com  
 * 说明: 工单信息主窗体
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HYWJ.HY_Production
{
    public partial class HY_WorkOrder : Form
    {
        public HY_WorkOrder()
        {
            InitializeComponent();
        }

        private void HY_WorkOrder_Load(object sender, EventArgs e)
        {
            this.w_orderClass.SelectedIndex = 0;
            this.groupBoxA.Enabled = false;
            this.groupBoxB.Enabled = false;
        }
    }
}
