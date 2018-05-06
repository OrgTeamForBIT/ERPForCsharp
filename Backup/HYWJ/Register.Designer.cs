namespace HYWJ
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPName = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.License = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCEL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "公司名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "授权用户：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "注 册 码：";
            // 
            // CPName
            // 
            this.CPName.Location = new System.Drawing.Point(88, 67);
            this.CPName.Name = "CPName";
            this.CPName.Size = new System.Drawing.Size(247, 21);
            this.CPName.TabIndex = 3;
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(88, 100);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(247, 21);
            this.User.TabIndex = 4;
            // 
            // License
            // 
            this.License.Location = new System.Drawing.Point(88, 134);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(247, 21);
            this.License.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(188, 171);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "   注 册";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCEL
            // 
            this.btnCEL.Image = ((System.Drawing.Image)(resources.GetObject("btnCEL.Image")));
            this.btnCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCEL.Location = new System.Drawing.Point(268, 171);
            this.btnCEL.Name = "btnCEL";
            this.btnCEL.Size = new System.Drawing.Size(65, 23);
            this.btnCEL.TabIndex = 7;
            this.btnCEL.Text = "   取 消";
            this.btnCEL.UseVisualStyleBackColor = true;
            this.btnCEL.Click += new System.EventHandler(this.btnCEL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 204);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCEL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.License);
            this.Controls.Add(this.User);
            this.Controls.Add(this.CPName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "软件注册";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CPName;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox License;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCEL;
        private System.Windows.Forms.Label label4;
    }
}