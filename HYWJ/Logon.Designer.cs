namespace HYWJ
{
    partial class Logon
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.EXIT = new DevComponents.DotNetBar.ButtonX();
            this.DL = new DevComponents.DotNetBar.ButtonX();
            this.passWord = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.userName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 77);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panelEx2
            // 
            this.panelEx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx2.Controls.Add(this.EXIT);
            this.panelEx2.Controls.Add(this.DL);
            this.panelEx2.Controls.Add(this.passWord);
            this.panelEx2.Controls.Add(this.userName);
            this.panelEx2.Controls.Add(this.labelX2);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.MarkupUsesStyleAlignment = true;
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(310, 197);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(254)))));
            this.panelEx2.StyleMouseDown.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBorder;
            this.panelEx2.StyleMouseDown.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedText;
            this.panelEx2.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panelEx2.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(206)))), ((int)(((byte)(254)))));
            this.panelEx2.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.panelEx2.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelEx2.TabIndex = 8;
            this.panelEx2.Text = "panelEx1";
            // 
            // EXIT
            // 
            this.EXIT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.EXIT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.EXIT.Location = new System.Drawing.Point(175, 158);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 23);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "退   出";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // DL
            // 
            this.DL.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DL.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DL.Location = new System.Drawing.Point(77, 158);
            this.DL.Name = "DL";
            this.DL.Size = new System.Drawing.Size(75, 23);
            this.DL.TabIndex = 4;
            this.DL.Text = "登   陆";
            this.DL.Click += new System.EventHandler(this.DL_Click_1);
            // 
            // passWord
            // 
            // 
            // 
            // 
            this.passWord.Border.Class = "TextBoxBorder";
            this.passWord.Location = new System.Drawing.Point(75, 120);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '●';
            this.passWord.Size = new System.Drawing.Size(179, 21);
            this.passWord.TabIndex = 3;
            this.passWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passWord_KeyDown);
            // 
            // userName
            // 
            this.userName.DisplayMember = "Text";
            this.userName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.userName.FormattingEnabled = true;
            this.userName.ItemHeight = 15;
            this.userName.Location = new System.Drawing.Point(75, 90);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(179, 21);
            this.userName.TabIndex = 2;
            this.userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userName_KeyDown);
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(21, 91);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "用户名：";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(21, 122);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "密  码：";
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(310, 197);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelEx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "海益ERP";
            this.Load += new System.EventHandler(this.Logon_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logon_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx userName;
        private DevComponents.DotNetBar.Controls.TextBoxX passWord;
        private DevComponents.DotNetBar.ButtonX DL;
        private DevComponents.DotNetBar.ButtonX EXIT;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

