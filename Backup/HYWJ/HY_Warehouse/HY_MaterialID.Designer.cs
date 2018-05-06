namespace HYWJ.HY_Warehouse
{
    partial class HY_MaterialID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_MaterialID));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripClass = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripKey = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.listViewXS = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripClass,
            this.toolStripKey,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton1.Text = "检索类型:";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripClass
            // 
            this.toolStripClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripClass.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripClass.Items.AddRange(new object[] {
            "按品名查询",
            "按品号查询"});
            this.toolStripClass.Name = "toolStripClass";
            this.toolStripClass.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripKey
            // 
            this.toolStripKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripKey.Name = "toolStripKey";
            this.toolStripKey.Size = new System.Drawing.Size(200, 25);
            this.toolStripKey.TextChanged += new System.EventHandler(this.toolStripKey_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(202, 22);
            this.toolStripLabel2.Text = "提示：输入关键字后自动匹配数据";
            // 
            // listViewXS
            // 
            // 
            // 
            // 
            this.listViewXS.Border.Class = "ListViewBorder";
            this.listViewXS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.listViewXS.GridLines = true;
            this.listViewXS.Location = new System.Drawing.Point(0, 28);
            this.listViewXS.Name = "listViewXS";
            this.listViewXS.Size = new System.Drawing.Size(613, 258);
            this.listViewXS.TabIndex = 5;
            this.listViewXS.UseCompatibleStateImageBehavior = false;
            this.listViewXS.View = System.Windows.Forms.View.Details;
            this.listViewXS.DoubleClick += new System.EventHandler(this.listViewXS_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "品号";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "品名";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "规格";
            this.columnHeader10.Width = 160;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "单价";
            this.columnHeader11.Width = 50;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "类别";
            this.columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "所属仓库";
            this.columnHeader13.Width = 70;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "厂内编号";
            this.columnHeader14.Width = 70;
            // 
            // HY_MaterialID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 285);
            this.Controls.Add(this.listViewXS);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_MaterialID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料查询";
            this.Load += new System.EventHandler(this.HY_MaterialID_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripClass;
        private System.Windows.Forms.ToolStripTextBox toolStripKey;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private DevComponents.DotNetBar.Controls.ListViewEx listViewXS;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
    }
}