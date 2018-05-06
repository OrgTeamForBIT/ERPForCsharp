namespace HYWJ.HY_System
{
    partial class HY_Department
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
            this.d_Name = new System.Windows.Forms.TextBox();
            this.dnADD = new System.Windows.Forms.Button();
            this.dnCEL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHY = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // d_Name
            // 
            this.d_Name.Location = new System.Drawing.Point(28, 27);
            this.d_Name.Name = "d_Name";
            this.d_Name.Size = new System.Drawing.Size(161, 21);
            this.d_Name.TabIndex = 0;
            // 
            // dnADD
            // 
            this.dnADD.Location = new System.Drawing.Point(39, 66);
            this.dnADD.Name = "dnADD";
            this.dnADD.Size = new System.Drawing.Size(64, 23);
            this.dnADD.TabIndex = 1;
            this.dnADD.Text = "添加部门";
            this.dnADD.UseVisualStyleBackColor = true;
            this.dnADD.Click += new System.EventHandler(this.dnADD_Click);
            // 
            // dnCEL
            // 
            this.dnCEL.Location = new System.Drawing.Point(116, 66);
            this.dnCEL.Name = "dnCEL";
            this.dnCEL.Size = new System.Drawing.Size(62, 23);
            this.dnCEL.TabIndex = 2;
            this.dnCEL.Text = "取    消";
            this.dnCEL.UseVisualStyleBackColor = true;
            this.dnCEL.Click += new System.EventHandler(this.dnCEL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbHY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.d_Name);
            this.groupBox2.Controls.Add(this.dnCEL);
            this.groupBox2.Controls.Add(this.dnADD);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 145);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加部门信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "提示：部门不能重复添加";
            // 
            // lbHY
            // 
            this.lbHY.FormattingEnabled = true;
            this.lbHY.ItemHeight = 12;
            this.lbHY.Location = new System.Drawing.Point(6, 20);
            this.lbHY.Name = "lbHY";
            this.lbHY.Size = new System.Drawing.Size(188, 112);
            this.lbHY.TabIndex = 5;
            // 
            // HY_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 170);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "部门设置";
            this.Load += new System.EventHandler(this.HY_Department_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox d_Name;
        private System.Windows.Forms.Button dnADD;
        private System.Windows.Forms.Button dnCEL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHY;
    }
}