namespace HYWJ.HY_Report
{
    partial class HY_BomlistDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HY_BomDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new HYWJ.HY_Report.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HY_BomDetailsTableAdapter = new HYWJ.HY_Report.DataSet1TableAdapters.HY_BomDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HY_BomDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // HY_BomDetailsBindingSource
            // 
            this.HY_BomDetailsBindingSource.DataMember = "HY_BomDetails";
            this.HY_BomDetailsBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1_HY_BomDetails";
            reportDataSource2.Value = this.HY_BomDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HYWJ.HY_Report.HY_BomlistReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(921, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // HY_BomDetailsTableAdapter
            // 
            this.HY_BomDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // HY_BomlistDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 538);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HY_BomlistDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料清单明细";
            this.Load += new System.EventHandler(this.HY_BomlistDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HY_BomDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HY_BomDetailsBindingSource;
        private DataSet1 DataSet1;
        private HYWJ.HY_Report.DataSet1TableAdapters.HY_BomDetailsTableAdapter HY_BomDetailsTableAdapter;
    }
}