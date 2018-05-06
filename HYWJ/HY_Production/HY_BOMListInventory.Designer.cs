namespace HYWJ.HY_Production
{
    partial class HY_BOMListInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_BOMListInventory));
            this.tabControlBOM = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewBOM = new System.Windows.Forms.DataGridView();
            this.物料单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂内编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工程数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材质 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用料尺寸 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.闭合高度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.冲床吨位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模具名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.校对 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.校对日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.审核日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工作内容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBOMDET = new System.Windows.Forms.DataGridView();
            this.所属BOM单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.热处理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBomlist = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tabControlBOM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBOM
            // 
            this.tabControlBOM.Controls.Add(this.tabPage1);
            this.tabControlBOM.Controls.Add(this.tabPage2);
            this.tabControlBOM.Location = new System.Drawing.Point(3, 3);
            this.tabControlBOM.Name = "tabControlBOM";
            this.tabControlBOM.SelectedIndex = 0;
            this.tabControlBOM.Size = new System.Drawing.Size(920, 471);
            this.tabControlBOM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewBOM);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(912, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "1";
            this.tabPage1.Text = "BOM单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBOM
            // 
            this.dataGridViewBOM.AllowUserToAddRows = false;
            this.dataGridViewBOM.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBOM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBOM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物料单号,
            this.厂内编号,
            this.客户编号,
            this.工程数,
            this.材质,
            this.用料尺寸,
            this.闭合高度,
            this.冲床吨位,
            this.模具名称,
            this.设计,
            this.设计日期,
            this.校对,
            this.校对日期,
            this.审核,
            this.审核日期,
            this.工作内容});
            this.dataGridViewBOM.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewBOM.Name = "dataGridViewBOM";
            this.dataGridViewBOM.ReadOnly = true;
            this.dataGridViewBOM.RowTemplate.Height = 23;
            this.dataGridViewBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBOM.Size = new System.Drawing.Size(897, 456);
            this.dataGridViewBOM.TabIndex = 0;
            this.dataGridViewBOM.DoubleClick += new System.EventHandler(this.dataGridViewBOM_DoubleClick);
            this.dataGridViewBOM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBOM_CellClick);
            // 
            // 物料单号
            // 
            this.物料单号.DataPropertyName = "b_SKID";
            this.物料单号.HeaderText = "物料单号";
            this.物料单号.Name = "物料单号";
            this.物料单号.ReadOnly = true;
            this.物料单号.Width = 120;
            // 
            // 厂内编号
            // 
            this.厂内编号.DataPropertyName = "b_CID";
            this.厂内编号.HeaderText = "厂内编号";
            this.厂内编号.Name = "厂内编号";
            this.厂内编号.ReadOnly = true;
            this.厂内编号.Width = 120;
            // 
            // 客户编号
            // 
            this.客户编号.DataPropertyName = "b_CustomerID";
            this.客户编号.HeaderText = "客户编号";
            this.客户编号.Name = "客户编号";
            this.客户编号.ReadOnly = true;
            this.客户编号.Width = 120;
            // 
            // 工程数
            // 
            this.工程数.DataPropertyName = "b_No";
            this.工程数.HeaderText = "工程数";
            this.工程数.Name = "工程数";
            this.工程数.ReadOnly = true;
            this.工程数.Width = 80;
            // 
            // 材质
            // 
            this.材质.DataPropertyName = "b_Material";
            this.材质.HeaderText = "材质";
            this.材质.Name = "材质";
            this.材质.ReadOnly = true;
            this.材质.Width = 80;
            // 
            // 用料尺寸
            // 
            this.用料尺寸.DataPropertyName = "b_BomSize";
            this.用料尺寸.HeaderText = "用料尺寸";
            this.用料尺寸.Name = "用料尺寸";
            this.用料尺寸.ReadOnly = true;
            this.用料尺寸.Width = 150;
            // 
            // 闭合高度
            // 
            this.闭合高度.DataPropertyName = "b_Height";
            this.闭合高度.HeaderText = "闭合高度";
            this.闭合高度.Name = "闭合高度";
            this.闭合高度.ReadOnly = true;
            this.闭合高度.Width = 80;
            // 
            // 冲床吨位
            // 
            this.冲床吨位.DataPropertyName = "b_Tonnage";
            this.冲床吨位.HeaderText = "冲床吨位";
            this.冲床吨位.Name = "冲床吨位";
            this.冲床吨位.ReadOnly = true;
            // 
            // 模具名称
            // 
            this.模具名称.DataPropertyName = "b_Name";
            this.模具名称.HeaderText = "模具名称";
            this.模具名称.Name = "模具名称";
            this.模具名称.ReadOnly = true;
            // 
            // 设计
            // 
            this.设计.DataPropertyName = "b_SPerson";
            this.设计.HeaderText = "设计";
            this.设计.Name = "设计";
            this.设计.ReadOnly = true;
            // 
            // 设计日期
            // 
            this.设计日期.DataPropertyName = "b_SDate";
            this.设计日期.HeaderText = "设计日期";
            this.设计日期.Name = "设计日期";
            this.设计日期.ReadOnly = true;
            // 
            // 校对
            // 
            this.校对.DataPropertyName = "b_Proofreading";
            this.校对.HeaderText = "校对";
            this.校对.Name = "校对";
            this.校对.ReadOnly = true;
            // 
            // 校对日期
            // 
            this.校对日期.DataPropertyName = "b_XDate";
            this.校对日期.HeaderText = "校对日期";
            this.校对日期.Name = "校对日期";
            this.校对日期.ReadOnly = true;
            // 
            // 审核
            // 
            this.审核.DataPropertyName = "b_Audit";
            this.审核.HeaderText = "审核";
            this.审核.Name = "审核";
            this.审核.ReadOnly = true;
            // 
            // 审核日期
            // 
            this.审核日期.DataPropertyName = "b_HDate";
            this.审核日期.HeaderText = "审核日期";
            this.审核日期.Name = "审核日期";
            this.审核日期.ReadOnly = true;
            // 
            // 工作内容
            // 
            this.工作内容.DataPropertyName = "b_Notes";
            this.工作内容.HeaderText = "工作内容";
            this.工作内容.Name = "工作内容";
            this.工作内容.ReadOnly = true;
            this.工作内容.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewBOMDET);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "2";
            this.tabPage2.Text = "BOM明细";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBOMDET
            // 
            this.dataGridViewBOMDET.AllowUserToAddRows = false;
            this.dataGridViewBOMDET.AllowUserToDeleteRows = false;
            this.dataGridViewBOMDET.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBOMDET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBOMDET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOMDET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.所属BOM单号,
            this.品号,
            this.品名,
            this.材料型号,
            this.材料规格,
            this.数量,
            this.热处理,
            this.设计人,
            this.备注});
            this.dataGridViewBOMDET.Location = new System.Drawing.Point(4, 5);
            this.dataGridViewBOMDET.Name = "dataGridViewBOMDET";
            this.dataGridViewBOMDET.ReadOnly = true;
            this.dataGridViewBOMDET.RowTemplate.Height = 23;
            this.dataGridViewBOMDET.Size = new System.Drawing.Size(899, 457);
            this.dataGridViewBOMDET.TabIndex = 0;
            // 
            // 所属BOM单号
            // 
            this.所属BOM单号.DataPropertyName = "d_SKID";
            this.所属BOM单号.HeaderText = "所属BOM单号";
            this.所属BOM单号.Name = "所属BOM单号";
            this.所属BOM单号.ReadOnly = true;
            this.所属BOM单号.Width = 150;
            // 
            // 品号
            // 
            this.品号.DataPropertyName = "d_PID";
            this.品号.HeaderText = "品号";
            this.品号.Name = "品号";
            this.品号.ReadOnly = true;
            this.品号.Width = 150;
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "d_PName";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            // 
            // 材料型号
            // 
            this.材料型号.DataPropertyName = "d_Model";
            this.材料型号.HeaderText = "材料型号";
            this.材料型号.Name = "材料型号";
            this.材料型号.ReadOnly = true;
            // 
            // 材料规格
            // 
            this.材料规格.DataPropertyName = "d_Specifications";
            this.材料规格.HeaderText = "材料规格";
            this.材料规格.Name = "材料规格";
            this.材料规格.ReadOnly = true;
            this.材料规格.Width = 180;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "d_Amount";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 80;
            // 
            // 热处理
            // 
            this.热处理.DataPropertyName = "d_Heat";
            this.热处理.HeaderText = "热处理";
            this.热处理.Name = "热处理";
            this.热处理.ReadOnly = true;
            this.热处理.Width = 80;
            // 
            // 设计人
            // 
            this.设计人.DataPropertyName = "d_SPerson";
            this.设计人.HeaderText = "设计人";
            this.设计人.Name = "设计人";
            this.设计人.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "d_Notes";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "关键字";
            // 
            // btnBomlist
            // 
            this.btnBomlist.Image = ((System.Drawing.Image)(resources.GetObject("btnBomlist.Image")));
            this.btnBomlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBomlist.Location = new System.Drawing.Point(518, 13);
            this.btnBomlist.Name = "btnBomlist";
            this.btnBomlist.Size = new System.Drawing.Size(125, 27);
            this.btnBomlist.TabIndex = 4;
            this.btnBomlist.Text = "  按单号生成清单";
            this.btnBomlist.UseVisualStyleBackColor = true;
            this.btnBomlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(431, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "  查  询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(233, 16);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(189, 21);
            this.key.TabIndex = 2;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "按物料单号检索",
            "按厂内编号检索",
            "按客户编号检索"});
            this.comboBoxClass.Location = new System.Drawing.Point(66, 17);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(118, 20);
            this.comboBoxClass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "检索类型";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.btnBomlist);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.btnSelect);
            this.groupPanel1.Controls.Add(this.comboBoxClass);
            this.groupPanel1.Controls.Add(this.key);
            this.groupPanel1.Location = new System.Drawing.Point(7, 10);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(932, 57);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.TabIndex = 8;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(949, 578);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 9;
            this.panelEx1.Text = "panelEx1";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.tabControlBOM);
            this.groupPanel2.Location = new System.Drawing.Point(7, 73);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(932, 502);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.TabIndex = 0;
            this.groupPanel2.Text = "BOM明细表";
            // 
            // HY_BOMListInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 578);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_BOMListInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM物料清单盘点";
            this.Load += new System.EventHandler(this.HY_BOMListInventory_Load);
            this.tabControlBOM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBOM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewBOM;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewBOMDET;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂内编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材质;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用料尺寸;
        private System.Windows.Forms.DataGridViewTextBoxColumn 闭合高度;
        private System.Windows.Forms.DataGridViewTextBoxColumn 冲床吨位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模具名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 校对;
        private System.Windows.Forms.DataGridViewTextBoxColumn 校对日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核;
        private System.Windows.Forms.DataGridViewTextBoxColumn 审核日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工作内容;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属BOM单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 热处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.Button btnBomlist;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    }
}