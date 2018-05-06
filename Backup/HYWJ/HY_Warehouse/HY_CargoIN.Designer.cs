namespace HYWJ.HY_Warehouse
{
    partial class HY_CargoIN
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDEL = new System.Windows.Forms.Button();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.c_Class = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仓库设置";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(418, 150);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(410, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "库存报警";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDEL);
            this.tabPage2.Controls.Add(this.listBoxClass);
            this.tabPage2.Controls.Add(this.c_Class);
            this.tabPage2.Controls.Add(this.btnADD);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 125);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "产品类别";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDEL
            // 
            this.btnDEL.Location = new System.Drawing.Point(301, 61);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(50, 23);
            this.btnDEL.TabIndex = 3;
            this.btnDEL.Text = "删除";
            this.btnDEL.UseVisualStyleBackColor = true;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // listBoxClass
            // 
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 12;
            this.listBoxClass.Location = new System.Drawing.Point(6, 6);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(164, 112);
            this.listBoxClass.TabIndex = 2;
            // 
            // c_Class
            // 
            this.c_Class.Location = new System.Drawing.Point(203, 23);
            this.c_Class.Name = "c_Class";
            this.c_Class.Size = new System.Drawing.Size(178, 21);
            this.c_Class.TabIndex = 1;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(232, 61);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(50, 23);
            this.btnADD.TabIndex = 0;
            this.btnADD.Text = "添加";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(211, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "提示：产品类别请勿重复添加";
            // 
            // HY_CargoIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 180);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_CargoIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.HY_CargoIN_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox c_Class;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.Label label1;
    }
}