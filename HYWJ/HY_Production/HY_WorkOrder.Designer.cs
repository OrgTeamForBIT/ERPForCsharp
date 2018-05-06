namespace HYWJ.HY_Production
{
    partial class HY_WorkOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_WorkOrder));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.groupBoxA = new System.Windows.Forms.GroupBox();
            this.w_RDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.w_orderClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSKID = new System.Windows.Forms.Button();
            this.w_CID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.w_DID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxC = new System.Windows.Forms.GroupBox();
            this.groupBoxB = new System.Windows.Forms.GroupBox();
            this.w_Notes = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.w_Heat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.w_Amount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.w_Specifications = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.w_Model = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.w_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.w_PID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip.SuspendLayout();
            this.groupBoxA.SuspendLayout();
            this.groupBoxC.SuspendLayout();
            this.groupBoxB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripEdit,
            this.toolStripDel,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(845, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(53, 22);
            this.toolStripAdd.Text = "新增";
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(53, 22);
            this.toolStripEdit.Text = "修改";
            // 
            // toolStripDel
            // 
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.Size = new System.Drawing.Size(53, 22);
            this.toolStripDel.Text = "删除";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(53, 22);
            this.toolStripSave.Text = "保存";
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(53, 22);
            this.toolStripExit.Text = "退出";
            // 
            // groupBoxA
            // 
            this.groupBoxA.Controls.Add(this.w_RDate);
            this.groupBoxA.Controls.Add(this.label4);
            this.groupBoxA.Controls.Add(this.w_orderClass);
            this.groupBoxA.Controls.Add(this.label3);
            this.groupBoxA.Controls.Add(this.btnSKID);
            this.groupBoxA.Controls.Add(this.w_CID);
            this.groupBoxA.Controls.Add(this.label2);
            this.groupBoxA.Controls.Add(this.w_DID);
            this.groupBoxA.Controls.Add(this.label1);
            this.groupBoxA.Location = new System.Drawing.Point(5, 28);
            this.groupBoxA.Name = "groupBoxA";
            this.groupBoxA.Size = new System.Drawing.Size(836, 51);
            this.groupBoxA.TabIndex = 8;
            this.groupBoxA.TabStop = false;
            this.groupBoxA.Text = "基础信息";
            // 
            // w_RDate
            // 
            this.w_RDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.w_RDate.Location = new System.Drawing.Point(697, 17);
            this.w_RDate.Name = "w_RDate";
            this.w_RDate.Size = new System.Drawing.Size(120, 21);
            this.w_RDate.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 32;
            this.label4.Text = "录单日期";
            // 
            // w_orderClass
            // 
            this.w_orderClass.FormattingEnabled = true;
            this.w_orderClass.Items.AddRange(new object[] {
            "厂内加工",
            "委外加工"});
            this.w_orderClass.Location = new System.Drawing.Point(498, 18);
            this.w_orderClass.Name = "w_orderClass";
            this.w_orderClass.Size = new System.Drawing.Size(124, 20);
            this.w_orderClass.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "工单类型";
            // 
            // btnSKID
            // 
            this.btnSKID.Image = ((System.Drawing.Image)(resources.GetObject("btnSKID.Image")));
            this.btnSKID.Location = new System.Drawing.Point(397, 17);
            this.btnSKID.Name = "btnSKID";
            this.btnSKID.Size = new System.Drawing.Size(27, 23);
            this.btnSKID.TabIndex = 29;
            this.btnSKID.UseVisualStyleBackColor = true;
            // 
            // w_CID
            // 
            this.w_CID.Location = new System.Drawing.Point(297, 18);
            this.w_CID.Name = "w_CID";
            this.w_CID.Size = new System.Drawing.Size(94, 21);
            this.w_CID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "厂内编号";
            // 
            // w_DID
            // 
            this.w_DID.Location = new System.Drawing.Point(69, 20);
            this.w_DID.Name = "w_DID";
            this.w_DID.Size = new System.Drawing.Size(154, 21);
            this.w_DID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "单    号";
            // 
            // groupBoxC
            // 
            this.groupBoxC.Controls.Add(this.dataGridView1);
            this.groupBoxC.Location = new System.Drawing.Point(5, 173);
            this.groupBoxC.Name = "groupBoxC";
            this.groupBoxC.Size = new System.Drawing.Size(836, 354);
            this.groupBoxC.TabIndex = 10;
            this.groupBoxC.TabStop = false;
            this.groupBoxC.Text = "工单信息列表";
            // 
            // groupBoxB
            // 
            this.groupBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxB.Controls.Add(this.w_Notes);
            this.groupBoxB.Controls.Add(this.label16);
            this.groupBoxB.Controls.Add(this.w_Heat);
            this.groupBoxB.Controls.Add(this.label15);
            this.groupBoxB.Controls.Add(this.w_Amount);
            this.groupBoxB.Controls.Add(this.label14);
            this.groupBoxB.Controls.Add(this.w_Specifications);
            this.groupBoxB.Controls.Add(this.label13);
            this.groupBoxB.Controls.Add(this.w_Model);
            this.groupBoxB.Controls.Add(this.label12);
            this.groupBoxB.Controls.Add(this.w_Name);
            this.groupBoxB.Controls.Add(this.label11);
            this.groupBoxB.Controls.Add(this.w_PID);
            this.groupBoxB.Controls.Add(this.label10);
            this.groupBoxB.Location = new System.Drawing.Point(5, 82);
            this.groupBoxB.Name = "groupBoxB";
            this.groupBoxB.Size = new System.Drawing.Size(949, 85);
            this.groupBoxB.TabIndex = 11;
            this.groupBoxB.TabStop = false;
            this.groupBoxB.Text = "产品信息";
            // 
            // w_Notes
            // 
            this.w_Notes.Location = new System.Drawing.Point(331, 50);
            this.w_Notes.Name = "w_Notes";
            this.w_Notes.Size = new System.Drawing.Size(497, 21);
            this.w_Notes.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 12;
            this.label16.Text = "备    注";
            // 
            // w_Heat
            // 
            this.w_Heat.Location = new System.Drawing.Point(191, 52);
            this.w_Heat.Name = "w_Heat";
            this.w_Heat.Size = new System.Drawing.Size(70, 21);
            this.w_Heat.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(128, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "热 处 理";
            // 
            // w_Amount
            // 
            this.w_Amount.Location = new System.Drawing.Point(69, 53);
            this.w_Amount.Name = "w_Amount";
            this.w_Amount.Size = new System.Drawing.Size(44, 21);
            this.w_Amount.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "数    量";
            // 
            // w_Specifications
            // 
            this.w_Specifications.Location = new System.Drawing.Point(669, 18);
            this.w_Specifications.Name = "w_Specifications";
            this.w_Specifications.Size = new System.Drawing.Size(159, 21);
            this.w_Specifications.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(611, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "材料规格";
            // 
            // w_Model
            // 
            this.w_Model.Location = new System.Drawing.Point(490, 19);
            this.w_Model.Name = "w_Model";
            this.w_Model.Size = new System.Drawing.Size(113, 21);
            this.w_Model.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(433, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "材料型号";
            // 
            // w_Name
            // 
            this.w_Name.Location = new System.Drawing.Point(251, 21);
            this.w_Name.Name = "w_Name";
            this.w_Name.Size = new System.Drawing.Size(171, 21);
            this.w_Name.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "品    名";
            // 
            // w_PID
            // 
            this.w_PID.Enabled = false;
            this.w_PID.Location = new System.Drawing.Point(69, 22);
            this.w_PID.Name = "w_PID";
            this.w_PID.Size = new System.Drawing.Size(112, 21);
            this.w_PID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "品    号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(830, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // HY_WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 544);
            this.Controls.Add(this.groupBoxB);
            this.Controls.Add(this.groupBoxC);
            this.Controls.Add(this.groupBoxA);
            this.Controls.Add(this.toolStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_WorkOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工单信息";
            this.Load += new System.EventHandler(this.HY_WorkOrder_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBoxA.ResumeLayout(false);
            this.groupBoxA.PerformLayout();
            this.groupBoxC.ResumeLayout(false);
            this.groupBoxB.ResumeLayout(false);
            this.groupBoxB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.GroupBox groupBoxA;
        private System.Windows.Forms.TextBox w_CID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox w_DID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox w_orderClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSKID;
        private System.Windows.Forms.DateTimePicker w_RDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxC;
        private System.Windows.Forms.GroupBox groupBoxB;
        private System.Windows.Forms.TextBox w_Notes;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox w_Heat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox w_Amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox w_Specifications;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox w_Model;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox w_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox w_PID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}