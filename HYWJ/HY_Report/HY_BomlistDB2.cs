using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using Microsoft.Reporting.WinForms;
using HY_BLL;

namespace HYWJ.HY_Report
{
    public partial class HY_BomlistDB2 : Office2007Form
    {       
        public HY_BomlistDB2()
        {
            InitializeComponent();
        }

        private void HY_BomlistDB2_Load(object sender, EventArgs e)
        {
            HYWJ.HY_Production.HY_BomAudit hybomaud;//实例化传值窗体
            hybomaud = (HYWJ.HY_Production.HY_BomAudit)this.Owner;
            string aa = hybomaud.B_SKID;
            string cid = hybomaud.B_CNID;
            string customer = hybomaud.B_CustomerID;
            string no = hybomaud.B_No;
            string material = hybomaud.B_Material;
            string bomSize = hybomaud.B_BomSize;
            string height = hybomaud.B_Height;
            string tonnage = hybomaud.B_Tonnage;
            string mname = hybomaud.B_Name;
            string notes = hybomaud.B_Notes;


            HY_BLL.HY_StorageBLL hystorfobll = new HY_StorageBLL();
            string sql = "select * from HY_BomDetails where d_SKID='" + aa + "' order by d_ID desc";
            DataSet ds = hystorfobll.ExecuteQueryDataSet(sql);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HYWJ.HY_Report.HY_BomlistReport.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter bid = new ReportParameter("BID", aa);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { bid });

            ReportParameter cnid = new ReportParameter("CNID", cid);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] {cnid});

            ReportParameter cust = new ReportParameter("CustomerID", customer);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { cust });

            ReportParameter gcs = new ReportParameter("GCS", no);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { gcs });

            ReportParameter cz = new ReportParameter("CZ", material);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { cz });

            ReportParameter boms = new ReportParameter("YLZC", bomSize);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { boms });

            ReportParameter bhgd = new ReportParameter("BHGD", height);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { bhgd });

            ReportParameter ccd = new ReportParameter("CCDW", tonnage);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { ccd });

            ReportParameter mjmc = new ReportParameter("MJMC", mname);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { mjmc });

            ReportParameter gznr = new ReportParameter("GZNR", notes);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { gznr });



            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("HY_BomDetails", ds.Tables[0]));
            //设置打印布局模式,显示物理页面大小
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //缩放模式为百分比,以100%方式显示
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
