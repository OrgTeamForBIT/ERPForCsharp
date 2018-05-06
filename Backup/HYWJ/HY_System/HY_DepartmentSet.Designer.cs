namespace HYWJ.HY_System
{
    partial class HY_DepartmentSet
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.OK = new DevComponents.DotNetBar.ButtonX();
            this.lbHY = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.s_Person = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(10, 46);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "部  门：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(10, 17);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "用  户：";
            // 
            // OK
            // 
            this.OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OK.Location = new System.Drawing.Point(130, 79);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(59, 23);
            this.OK.TabIndex = 9;
            this.OK.Text = "确  定";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // lbHY
            // 
            this.lbHY.DisplayMember = "Text";
            this.lbHY.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbHY.FormattingEnabled = true;
            this.lbHY.ItemHeight = 15;
            this.lbHY.Location = new System.Drawing.Point(69, 45);
            this.lbHY.Name = "lbHY";
            this.lbHY.Size = new System.Drawing.Size(121, 21);
            this.lbHY.TabIndex = 8;
            // 
            // s_Person
            // 
            this.s_Person.DisplayMember = "Text";
            this.s_Person.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.s_Person.FormattingEnabled = true;
            this.s_Person.ItemHeight = 15;
            this.s_Person.Location = new System.Drawing.Point(68, 16);
            this.s_Person.Name = "s_Person";
            this.s_Person.Size = new System.Drawing.Size(121, 21);
            this.s_Person.TabIndex = 7;
            // 
            // HY_DepartmentSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 111);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.lbHY);
            this.Controls.Add(this.s_Person);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_DepartmentSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户部门设置";
            this.Load += new System.EventHandler(this.HY_DepartmentSet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX OK;
        private DevComponents.DotNetBar.Controls.ComboBoxEx lbHY;
        private DevComponents.DotNetBar.Controls.ComboBoxEx s_Person;


    }
}