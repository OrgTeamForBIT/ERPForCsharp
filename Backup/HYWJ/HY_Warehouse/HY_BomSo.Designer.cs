namespace HYWJ.HY_Warehouse
{
    partial class HY_BomSo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tabControlBOM = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dataGridViewBOM = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.物料单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂内编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工程 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.dataGridViewBOMDET = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.所属BOM单 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材料规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.热处理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.设计人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.Class = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.key = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BomSO = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlBOM)).BeginInit();
            this.tabControlBOM.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.Controls.Add(this.tabControlBOM);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(928, 472);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            this.panelEx1.Text = "panelEx1";
            // 
            // tabControlBOM
            // 
            this.tabControlBOM.BackColor = System.Drawing.Color.Transparent;
            this.tabControlBOM.CanReorderTabs = true;
            this.tabControlBOM.Controls.Add(this.tabControlPanel1);
            this.tabControlBOM.Controls.Add(this.tabControlPanel2);
            this.tabControlBOM.Location = new System.Drawing.Point(6, 61);
            this.tabControlBOM.Name = "tabControlBOM";
            this.tabControlBOM.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlBOM.SelectedTabIndex = 0;
            this.tabControlBOM.Size = new System.Drawing.Size(917, 399);
            this.tabControlBOM.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControlBOM.TabIndex = 11;
            this.tabControlBOM.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControlBOM.Tabs.Add(this.tabItem1);
            this.tabControlBOM.Tabs.Add(this.tabItem2);
            this.tabControlBOM.Text = "tabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.dataGridViewBOM);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(917, 374);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // dataGridViewBOM
            // 
            this.dataGridViewBOM.AllowUserToAddRows = false;
            this.dataGridViewBOM.AllowUserToDeleteRows = false;
            this.dataGridViewBOM.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewBOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.物料单号,
            this.厂内编号,
            this.客户编号,
            this.工程,
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBOM.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOM.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewBOM.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewBOM.MultiSelect = false;
            this.dataGridViewBOM.Name = "dataGridViewBOM";
            this.dataGridViewBOM.ReadOnly = true;
            this.dataGridViewBOM.RowTemplate.Height = 23;
            this.dataGridViewBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBOM.Size = new System.Drawing.Size(915, 372);
            this.dataGridViewBOM.TabIndex = 0;
            this.dataGridViewBOM.DoubleClick += new System.EventHandler(this.dataGridViewBOM_DoubleClick);
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
            // 
            // 客户编号
            // 
            this.客户编号.DataPropertyName = "b_CustomerID";
            this.客户编号.HeaderText = "客户编号";
            this.客户编号.Name = "客户编号";
            this.客户编号.ReadOnly = true;
            // 
            // 工程
            // 
            this.工程.DataPropertyName = "b_No";
            this.工程.HeaderText = "工程";
            this.工程.Name = "工程";
            this.工程.ReadOnly = true;
            this.工程.Width = 70;
            // 
            // 材质
            // 
            this.材质.DataPropertyName = "b_Material";
            this.材质.HeaderText = "材质";
            this.材质.Name = "材质";
            this.材质.ReadOnly = true;
            // 
            // 用料尺寸
            // 
            this.用料尺寸.DataPropertyName = "b_BomSize";
            this.用料尺寸.HeaderText = "用料尺寸";
            this.用料尺寸.Name = "用料尺寸";
            this.用料尺寸.ReadOnly = true;
            this.用料尺寸.Width = 120;
            // 
            // 闭合高度
            // 
            this.闭合高度.DataPropertyName = "b_Height";
            this.闭合高度.HeaderText = "闭合高度";
            this.闭合高度.Name = "闭合高度";
            this.闭合高度.ReadOnly = true;
            // 
            // 冲床吨位
            // 
            this.冲床吨位.DataPropertyName = "b_Tonnage";
            this.冲床吨位.HeaderText = "冲床吨位";
            this.冲床吨位.Name = "冲床吨位";
            this.冲床吨位.ReadOnly = true;
            this.冲床吨位.Width = 80;
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
            this.设计.Width = 70;
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
            this.校对.Width = 70;
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
            this.审核.Width = 70;
            // 
            // 审核日期
            // 
            this.审核日期.DataPropertyName = "b_XDate";
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
            this.工作内容.Width = 120;
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "BOM单";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.dataGridViewBOMDET);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(917, 374);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // dataGridViewBOMDET
            // 
            this.dataGridViewBOMDET.AllowUserToAddRows = false;
            this.dataGridViewBOMDET.AllowUserToDeleteRows = false;
            this.dataGridViewBOMDET.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewBOMDET.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBOMDET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBOMDET.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.所属BOM单,
            this.品号,
            this.品名,
            this.材料型号,
            this.材料规格,
            this.数量,
            this.热处理,
            this.设计人,
            this.备注});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBOMDET.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBOMDET.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBOMDET.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewBOMDET.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewBOMDET.MultiSelect = false;
            this.dataGridViewBOMDET.Name = "dataGridViewBOMDET";
            this.dataGridViewBOMDET.ReadOnly = true;
            this.dataGridViewBOMDET.RowTemplate.Height = 23;
            this.dataGridViewBOMDET.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBOMDET.Size = new System.Drawing.Size(915, 372);
            this.dataGridViewBOMDET.TabIndex = 0;
            // 
            // 所属BOM单
            // 
            this.所属BOM单.DataPropertyName = "d_SKID";
            this.所属BOM单.HeaderText = "所属BOM单";
            this.所属BOM单.Name = "所属BOM单";
            this.所属BOM单.ReadOnly = true;
            this.所属BOM单.Width = 115;
            // 
            // 品号
            // 
            this.品号.DataPropertyName = "d_PID";
            this.品号.HeaderText = "品号";
            this.品号.Name = "品号";
            this.品号.ReadOnly = true;
            this.品号.Width = 115;
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "d_PName";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            this.品名.Width = 130;
            // 
            // 材料型号
            // 
            this.材料型号.DataPropertyName = "d_Model";
            this.材料型号.HeaderText = "材料型号";
            this.材料型号.Name = "材料型号";
            this.材料型号.ReadOnly = true;
            this.材料型号.Width = 130;
            // 
            // 材料规格
            // 
            this.材料规格.DataPropertyName = "d_Specifications";
            this.材料规格.HeaderText = "材料规格";
            this.材料规格.Name = "材料规格";
            this.材料规格.ReadOnly = true;
            this.材料规格.Width = 150;
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
            // 
            // 设计人
            // 
            this.设计人.DataPropertyName = "d_SPerson";
            this.设计人.HeaderText = "设计人";
            this.设计人.Name = "设计人";
            this.设计人.ReadOnly = true;
            this.设计人.Width = 80;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "d_Notes";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "BOM明细";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.BomSO);
            this.groupPanel1.Controls.Add(this.key);
            this.groupPanel1.Controls.Add(this.Class);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(6, 10);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(916, 45);
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
            this.groupPanel1.TabIndex = 12;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(5, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "检索类型：";
            // 
            // Class
            // 
            this.Class.DisplayMember = "Text";
            this.Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.FormattingEnabled = true;
            this.Class.ItemHeight = 15;
            this.Class.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.Class.Location = new System.Drawing.Point(68, 9);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 21);
            this.Class.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Class.TabIndex = 1;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "按厂内编号(模号)";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "按物料单号";
            // 
            // key
            // 
            // 
            // 
            // 
            this.key.Border.Class = "TextBoxBorder";
            this.key.Location = new System.Drawing.Point(195, 9);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(302, 21);
            this.key.TabIndex = 2;
            // 
            // BomSO
            // 
            this.BomSO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BomSO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BomSO.Location = new System.Drawing.Point(513, 7);
            this.BomSO.Name = "BomSO";
            this.BomSO.Size = new System.Drawing.Size(75, 23);
            this.BomSO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BomSO.TabIndex = 3;
            this.BomSO.Text = "检  索";
            // 
            // HY_BomSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 472);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_BomSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM物料单查询";
            this.Load += new System.EventHandler(this.HY_BomSo_Load);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlBOM)).EndInit();
            this.tabControlBOM.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.TabControl tabControlBOM;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物料单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂内编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工程;
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
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBOMDET;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属BOM单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 热处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Class;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BomSO;
        private DevComponents.DotNetBar.Controls.TextBoxX key;
    }
}