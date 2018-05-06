namespace HYWJ.HY_Production
{
    partial class HY_BomAudit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_BomAudit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripXD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSH = new System.Windows.Forms.ToolStripButton();
            this.toolStripQX = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.panelH = new System.Windows.Forms.Panel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.tabControlBOM = new DevComponents.DotNetBar.TabControl();
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
            this.groupBox1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnBOMS = new DevComponents.DotNetBar.ButtonX();
            this.b_Date = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.b_Person = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.b_CID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.b_BID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.toolStrip.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlBOM)).BeginInit();
            this.tabControlBOM.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).BeginInit();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripXD,
            this.toolStripSH,
            this.toolStripQX,
            this.toolStripExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(930, 25);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripXD
            // 
            this.toolStripXD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripXD.Image")));
            this.toolStripXD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripXD.Name = "toolStripXD";
            this.toolStripXD.Size = new System.Drawing.Size(79, 22);
            this.toolStripXD.Text = "校对确认";
            this.toolStripXD.Click += new System.EventHandler(this.toolStripXD_Click);
            // 
            // toolStripSH
            // 
            this.toolStripSH.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSH.Image")));
            this.toolStripSH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSH.Name = "toolStripSH";
            this.toolStripSH.Size = new System.Drawing.Size(79, 22);
            this.toolStripSH.Text = "审核确认";
            this.toolStripSH.Click += new System.EventHandler(this.toolStripSH_Click);
            // 
            // toolStripQX
            // 
            this.toolStripQX.Image = ((System.Drawing.Image)(resources.GetObject("toolStripQX.Image")));
            this.toolStripQX.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripQX.Name = "toolStripQX";
            this.toolStripQX.Size = new System.Drawing.Size(105, 22);
            this.toolStripQX.Text = "取消校队审核";
            this.toolStripQX.Click += new System.EventHandler(this.toolStripQX_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(53, 22);
            this.toolStripExit.Text = "退出";
            // 
            // panelH
            // 
            this.panelH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelH.BackgroundImage")));
            this.panelH.Location = new System.Drawing.Point(844, 43);
            this.panelH.Name = "panelH";
            this.panelH.Size = new System.Drawing.Size(70, 66);
            this.panelH.TabIndex = 9;
            this.panelH.Visible = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.tabControlBOM);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(930, 521);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 10;
            this.panelEx1.Text = "panelEx1";
            // 
            // tabControlBOM
            // 
            this.tabControlBOM.BackColor = System.Drawing.Color.Transparent;
            this.tabControlBOM.CanReorderTabs = true;
            this.tabControlBOM.Controls.Add(this.tabControlPanel1);
            this.tabControlBOM.Controls.Add(this.tabControlPanel2);
            this.tabControlBOM.Location = new System.Drawing.Point(6, 119);
            this.tabControlBOM.Name = "tabControlBOM";
            this.tabControlBOM.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlBOM.SelectedTabIndex = 0;
            this.tabControlBOM.Size = new System.Drawing.Size(917, 399);
            this.tabControlBOM.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControlBOM.TabIndex = 10;
            this.tabControlBOM.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControlBOM.Tabs.Add(this.tabItem1);
            this.tabControlBOM.Tabs.Add(this.tabItem2);
            this.tabControlBOM.Text = "tabControl1";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBOMDET.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBOM.DefaultCellStyle = dataGridViewCellStyle1;
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
            // groupBox1
            // 
            this.groupBox1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox1.Controls.Add(this.btnBOMS);
            this.groupBox1.Controls.Add(this.b_Date);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.b_Person);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.b_CID);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.b_BID);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(917, 81);
            // 
            // 
            // 
            this.groupBox1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupBox1.Style.BackColorGradientAngle = 90;
            this.groupBox1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupBox1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox1.Style.BorderBottomWidth = 1;
            this.groupBox1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupBox1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox1.Style.BorderLeftWidth = 1;
            this.groupBox1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox1.Style.BorderRightWidth = 1;
            this.groupBox1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox1.Style.BorderTopWidth = 1;
            this.groupBox1.Style.Class = "";
            this.groupBox1.Style.CornerDiameter = 4;
            this.groupBox1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupBox1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupBox1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupBox1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupBox1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupBox1.StyleMouseOver.Class = "";
            this.groupBox1.TabIndex = 9;
            this.groupBox1.Text = "BOM基础信息";
            // 
            // btnBOMS
            // 
            this.btnBOMS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBOMS.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBOMS.Image = ((System.Drawing.Image)(resources.GetObject("btnBOMS.Image")));
            this.btnBOMS.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBOMS.Location = new System.Drawing.Point(741, 0);
            this.btnBOMS.Name = "btnBOMS";
            this.btnBOMS.Size = new System.Drawing.Size(75, 54);
            this.btnBOMS.TabIndex = 8;
            this.btnBOMS.Text = "生成BOM清单";
            this.btnBOMS.Click += new System.EventHandler(this.btnBOMS_Click);
            // 
            // b_Date
            // 
            // 
            // 
            // 
            this.b_Date.Border.Class = "TextBoxBorder";
            this.b_Date.Location = new System.Drawing.Point(605, 17);
            this.b_Date.Name = "b_Date";
            this.b_Date.ReadOnly = true;
            this.b_Date.Size = new System.Drawing.Size(119, 21);
            this.b_Date.TabIndex = 7;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(541, 19);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(68, 19);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "设计日期：";
            // 
            // b_Person
            // 
            // 
            // 
            // 
            this.b_Person.Border.Class = "TextBoxBorder";
            this.b_Person.Location = new System.Drawing.Point(451, 17);
            this.b_Person.Name = "b_Person";
            this.b_Person.ReadOnly = true;
            this.b_Person.Size = new System.Drawing.Size(75, 21);
            this.b_Person.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(398, 21);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(56, 17);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "设  计：";
            // 
            // b_CID
            // 
            // 
            // 
            // 
            this.b_CID.Border.Class = "TextBoxBorder";
            this.b_CID.Location = new System.Drawing.Point(288, 19);
            this.b_CID.Name = "b_CID";
            this.b_CID.ReadOnly = true;
            this.b_CID.Size = new System.Drawing.Size(100, 21);
            this.b_CID.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(226, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 15);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "厂内编号：";
            // 
            // b_BID
            // 
            // 
            // 
            // 
            this.b_BID.Border.Class = "TextBoxBorder";
            this.b_BID.Location = new System.Drawing.Point(70, 21);
            this.b_BID.Name = "b_BID";
            this.b_BID.ReadOnly = true;
            this.b_BID.Size = new System.Drawing.Size(144, 21);
            this.b_BID.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(6, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "物料单号：";
            // 
            // HY_BomAudit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 521);
            this.Controls.Add(this.panelH);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_BomAudit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM物料清单校对审核";
            this.Load += new System.EventHandler(this.HY_BomAudit_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlBOM)).EndInit();
            this.tabControlBOM.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOMDET)).EndInit();
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBOM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripXD;
        private System.Windows.Forms.ToolStripButton toolStripSH;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.Panel panelH;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX b_CID;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX b_BID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX b_Date;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX b_Person;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.TabControl tabControlBOM;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBOM;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewBOMDET;
        private DevComponents.DotNetBar.ButtonX btnBOMS;
        private System.Windows.Forms.ToolStripButton toolStripQX;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn 所属BOM单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材料规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 热处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 设计人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}