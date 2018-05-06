namespace HYWJ.HY_Invoicing
{
    partial class HY_RequisitionsWH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_RequisitionsWH));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripADD = new System.Windows.Forms.ToolStripButton();
            this.toolStripCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripOut = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewQG = new System.Windows.Forms.DataGridView();
            this.请购单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供应商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.地区 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.热处理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需要时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripADD,
            this.toolStripCEL,
            this.toolStripSave,
            this.toolStripOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripADD
            // 
            this.toolStripADD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripADD.Image")));
            this.toolStripADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripADD.Name = "toolStripADD";
            this.toolStripADD.Size = new System.Drawing.Size(49, 22);
            this.toolStripADD.Text = "修改";
            // 
            // toolStripCEL
            // 
            this.toolStripCEL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCEL.Image")));
            this.toolStripCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCEL.Name = "toolStripCEL";
            this.toolStripCEL.Size = new System.Drawing.Size(49, 22);
            this.toolStripCEL.Text = "删除";
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(49, 22);
            this.toolStripSave.Text = "保存";
            // 
            // toolStripOut
            // 
            this.toolStripOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOut.Image")));
            this.toolStripOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOut.Name = "toolStripOut";
            this.toolStripOut.Size = new System.Drawing.Size(49, 22);
            this.toolStripOut.Text = "退出";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewQG);
            this.groupBox3.Location = new System.Drawing.Point(182, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(814, 456);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "请购明细";
            // 
            // dataGridViewQG
            // 
            this.dataGridViewQG.AllowUserToAddRows = false;
            this.dataGridViewQG.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewQG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.dataGridViewQG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewQG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.请购单号,
            this.品名,
            this.供应商,
            this.地区,
            this.规格,
            this.单位,
            this.数量,
            this.热处理,
            this.请购人,
            this.请购部门,
            this.请购时间,
            this.需要时间,
            this.用途,
            this.备注});
            this.dataGridViewQG.Location = new System.Drawing.Point(7, 18);
            this.dataGridViewQG.MultiSelect = false;
            this.dataGridViewQG.Name = "dataGridViewQG";
            this.dataGridViewQG.ReadOnly = true;
            this.dataGridViewQG.RowTemplate.Height = 23;
            this.dataGridViewQG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQG.Size = new System.Drawing.Size(800, 430);
            this.dataGridViewQG.TabIndex = 0;
            // 
            // 请购单号
            // 
            this.请购单号.DataPropertyName = "r_DID";
            this.请购单号.HeaderText = "请购单号";
            this.请购单号.Name = "请购单号";
            this.请购单号.ReadOnly = true;
            this.请购单号.Width = 150;
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "r_Name";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            // 
            // 供应商
            // 
            this.供应商.DataPropertyName = "r_Supplier";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Width = 150;
            // 
            // 地区
            // 
            this.地区.DataPropertyName = "r_Origin";
            this.地区.HeaderText = "地区";
            this.地区.Name = "地区";
            this.地区.ReadOnly = true;
            this.地区.Width = 60;
            // 
            // 规格
            // 
            this.规格.DataPropertyName = "r_Specifications";
            this.规格.HeaderText = "规格";
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            this.规格.Width = 150;
            // 
            // 单位
            // 
            this.单位.DataPropertyName = "r_Units";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.ReadOnly = true;
            this.单位.Width = 40;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "r_Amount";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 40;
            // 
            // 热处理
            // 
            this.热处理.DataPropertyName = "r_Hot";
            this.热处理.HeaderText = "热处理";
            this.热处理.Name = "热处理";
            this.热处理.ReadOnly = true;
            // 
            // 请购人
            // 
            this.请购人.DataPropertyName = "r_Person";
            this.请购人.HeaderText = "请购人";
            this.请购人.Name = "请购人";
            this.请购人.ReadOnly = true;
            this.请购人.Width = 80;
            // 
            // 请购部门
            // 
            this.请购部门.DataPropertyName = "r_Department";
            this.请购部门.HeaderText = "请购部门";
            this.请购部门.Name = "请购部门";
            this.请购部门.ReadOnly = true;
            this.请购部门.Width = 80;
            // 
            // 请购时间
            // 
            this.请购时间.DataPropertyName = "r_QDate";
            this.请购时间.HeaderText = "请购时间";
            this.请购时间.Name = "请购时间";
            this.请购时间.ReadOnly = true;
            // 
            // 需要时间
            // 
            this.需要时间.DataPropertyName = "r_XDate";
            this.需要时间.HeaderText = "需要时间";
            this.需要时间.Name = "需要时间";
            this.需要时间.ReadOnly = true;
            // 
            // 用途
            // 
            this.用途.DataPropertyName = "r_Uses";
            this.用途.HeaderText = "用途";
            this.用途.Name = "用途";
            this.用途.ReadOnly = true;
            this.用途.Width = 150;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "r_Notes";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "查  找";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 21);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 455);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请购单";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "取  消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按请购单号",
            "按品名"});
            this.comboBox1.Location = new System.Drawing.Point(16, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(158, 309);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "请购单号";
            this.columnHeader1.Width = 150;
            // 
            // HY_RequisitionsWH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_RequisitionsWH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请购单信息维护";
            this.Load += new System.EventHandler(this.HY_RequisitionsWH_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripADD;
        private System.Windows.Forms.ToolStripButton toolStripCEL;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewQG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供应商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 地区;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 热处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 需要时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}