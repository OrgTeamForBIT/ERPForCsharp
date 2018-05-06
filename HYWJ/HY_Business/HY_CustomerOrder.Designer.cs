namespace HYWJ.HY_Business
{
    partial class HY_CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_CustomerOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.btnCus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewDD = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupBox1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.o_JDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.o_XDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.o_Notes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.o_Person = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.o_CPName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.o_FID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.o_Name = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.o_Amount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.o_Class = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.销售单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户番号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.客户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.厂内编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模具类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.下单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交货日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录单人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录单日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.o_JDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_XDate)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripEdit,
            this.toolStripDel,
            this.toolStripCEL,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAdd.Image")));
            this.toolStripAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(53, 22);
            this.toolStripAdd.Text = "新增";
            this.toolStripAdd.Click += new System.EventHandler(this.toolStripAdd_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(53, 22);
            this.toolStripEdit.Text = "修改";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripDel
            // 
            this.toolStripDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDel.Image")));
            this.toolStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.Size = new System.Drawing.Size(53, 22);
            this.toolStripDel.Text = "删除";
            this.toolStripDel.Click += new System.EventHandler(this.toolStripDel_Click);
            // 
            // toolStripCEL
            // 
            this.toolStripCEL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCEL.Image")));
            this.toolStripCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCEL.Name = "toolStripCEL";
            this.toolStripCEL.Size = new System.Drawing.Size(53, 22);
            this.toolStripCEL.Text = "取消";
            this.toolStripCEL.Click += new System.EventHandler(this.toolStripCEL_Click);
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
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(53, 22);
            this.toolStripExit.Text = "退出";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // btnCus
            // 
            this.btnCus.Image = ((System.Drawing.Image)(resources.GetObject("btnCus.Image")));
            this.btnCus.Location = new System.Drawing.Point(266, 8);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(27, 21);
            this.btnCus.TabIndex = 9;
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.btnCus_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(679, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(473, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Controls.Add(this.groupBox1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(813, 443);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 10;
            this.panelEx1.Text = "panelEx1";
            // 
            // groupBox2
            // 
            this.groupBox2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox2.Controls.Add(this.dataGridViewDD);
            this.groupBox2.Location = new System.Drawing.Point(3, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 239);
            // 
            // 
            // 
            this.groupBox2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupBox2.Style.BackColorGradientAngle = 90;
            this.groupBox2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupBox2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox2.Style.BorderBottomWidth = 1;
            this.groupBox2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupBox2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox2.Style.BorderLeftWidth = 1;
            this.groupBox2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox2.Style.BorderRightWidth = 1;
            this.groupBox2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox2.Style.BorderTopWidth = 1;
            this.groupBox2.Style.Class = "";
            this.groupBox2.Style.CornerDiameter = 4;
            this.groupBox2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupBox2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupBox2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupBox2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupBox2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupBox2.StyleMouseOver.Class = "";
            this.groupBox2.TabIndex = 2;
            // 
            // dataGridViewDD
            // 
            this.dataGridViewDD.AllowUserToAddRows = false;
            this.dataGridViewDD.AllowUserToDeleteRows = false;
            this.dataGridViewDD.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.销售单号,
            this.客户番号,
            this.客户名称,
            this.厂内编号,
            this.数量,
            this.模具类型,
            this.下单日期,
            this.交货日期,
            this.备注说明,
            this.录单人,
            this.录单日期});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDD.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewDD.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDD.MultiSelect = false;
            this.dataGridViewDD.Name = "dataGridViewDD";
            this.dataGridViewDD.ReadOnly = true;
            this.dataGridViewDD.RowTemplate.Height = 23;
            this.dataGridViewDD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDD.Size = new System.Drawing.Size(800, 233);
            this.dataGridViewDD.TabIndex = 0;
            this.dataGridViewDD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDD_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox1.Controls.Add(this.o_Class);
            this.groupBox1.Controls.Add(this.labelX9);
            this.groupBox1.Controls.Add(this.o_Amount);
            this.groupBox1.Controls.Add(this.labelX8);
            this.groupBox1.Controls.Add(this.o_JDate);
            this.groupBox1.Controls.Add(this.labelX7);
            this.groupBox1.Controls.Add(this.o_XDate);
            this.groupBox1.Controls.Add(this.labelX6);
            this.groupBox1.Controls.Add(this.o_Notes);
            this.groupBox1.Controls.Add(this.o_Person);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.o_CPName);
            this.groupBox1.Controls.Add(this.o_FID);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.o_Name);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Controls.Add(this.btnCus);
            this.groupBox1.Location = new System.Drawing.Point(5, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 155);
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
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "基础信息";
            // 
            // o_JDate
            // 
            // 
            // 
            // 
            this.o_JDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.o_JDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.o_JDate.ButtonDropDown.Visible = true;
            this.o_JDate.Location = new System.Drawing.Point(671, 37);
            // 
            // 
            // 
            this.o_JDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.o_JDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.o_JDate.MonthCalendar.BackgroundStyle.Class = "";
            this.o_JDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.o_JDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.o_JDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 2, 1, 0, 0, 0, 0);
            this.o_JDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.o_JDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.o_JDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.o_JDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.o_JDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.o_JDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.o_JDate.MonthCalendar.TodayButtonVisible = true;
            this.o_JDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.o_JDate.Name = "o_JDate";
            this.o_JDate.Size = new System.Drawing.Size(122, 21);
            this.o_JDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.o_JDate.TabIndex = 21;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Location = new System.Drawing.Point(606, 40);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(66, 18);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "交货日期：";
            // 
            // o_XDate
            // 
            // 
            // 
            // 
            this.o_XDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.o_XDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.o_XDate.ButtonDropDown.Visible = true;
            this.o_XDate.Location = new System.Drawing.Point(477, 36);
            // 
            // 
            // 
            this.o_XDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.o_XDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.o_XDate.MonthCalendar.BackgroundStyle.Class = "";
            this.o_XDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.o_XDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.o_XDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 2, 1, 0, 0, 0, 0);
            this.o_XDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.o_XDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.o_XDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.o_XDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.o_XDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.o_XDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.o_XDate.MonthCalendar.TodayButtonVisible = true;
            this.o_XDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.o_XDate.Name = "o_XDate";
            this.o_XDate.Size = new System.Drawing.Size(121, 21);
            this.o_XDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.o_XDate.TabIndex = 19;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Location = new System.Drawing.Point(409, 39);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(67, 18);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "下单日期：";
            // 
            // o_Notes
            // 
            // 
            // 
            // 
            this.o_Notes.Border.Class = "TextBoxBorder";
            this.o_Notes.Location = new System.Drawing.Point(70, 67);
            this.o_Notes.Multiline = true;
            this.o_Notes.Name = "o_Notes";
            this.o_Notes.Size = new System.Drawing.Size(723, 60);
            this.o_Notes.TabIndex = 17;
            // 
            // o_Person
            // 
            // 
            // 
            // 
            this.o_Person.Border.Class = "TextBoxBorder";
            this.o_Person.Location = new System.Drawing.Point(570, 8);
            this.o_Person.Name = "o_Person";
            this.o_Person.Size = new System.Drawing.Size(103, 21);
            this.o_Person.TabIndex = 14;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Location = new System.Drawing.Point(502, 11);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(67, 18);
            this.labelX5.TabIndex = 13;
            this.labelX5.Text = "录 单 人：";
            // 
            // o_CPName
            // 
            // 
            // 
            // 
            this.o_CPName.Border.Class = "TextBoxBorder";
            this.o_CPName.Location = new System.Drawing.Point(70, 37);
            this.o_CPName.Name = "o_CPName";
            this.o_CPName.Size = new System.Drawing.Size(95, 21);
            this.o_CPName.TabIndex = 12;
            // 
            // o_FID
            // 
            // 
            // 
            // 
            this.o_FID.Border.Class = "TextBoxBorder";
            this.o_FID.Location = new System.Drawing.Point(380, 7);
            this.o_FID.Name = "o_FID";
            this.o_FID.ReadOnly = true;
            this.o_FID.Size = new System.Drawing.Size(107, 21);
            this.o_FID.TabIndex = 11;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(307, 11);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(67, 16);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "客户番号：";
            // 
            // o_Name
            // 
            // 
            // 
            // 
            this.o_Name.Border.Class = "TextBoxBorder";
            this.o_Name.Location = new System.Drawing.Point(70, 8);
            this.o_Name.Name = "o_Name";
            this.o_Name.ReadOnly = true;
            this.o_Name.Size = new System.Drawing.Size(181, 21);
            this.o_Name.TabIndex = 3;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(9, 79);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 41);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "产品要求\r\n (备注)";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(6, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 17);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "厂内编号：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(6, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "客户名称：";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Location = new System.Drawing.Point(170, 40);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 17);
            this.labelX8.TabIndex = 22;
            this.labelX8.Text = "数量：";
            // 
            // o_Amount
            // 
            // 
            // 
            // 
            this.o_Amount.Border.Class = "TextBoxBorder";
            this.o_Amount.Location = new System.Drawing.Point(206, 36);
            this.o_Amount.Name = "o_Amount";
            this.o_Amount.Size = new System.Drawing.Size(46, 21);
            this.o_Amount.TabIndex = 23;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Location = new System.Drawing.Point(259, 39);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(67, 17);
            this.labelX9.TabIndex = 24;
            this.labelX9.Text = "模具类型：";
            // 
            // o_Class
            // 
            this.o_Class.DisplayMember = "Text";
            this.o_Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.o_Class.FormattingEnabled = true;
            this.o_Class.ItemHeight = 15;
            this.o_Class.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.o_Class.Location = new System.Drawing.Point(322, 36);
            this.o_Class.Name = "o_Class";
            this.o_Class.Size = new System.Drawing.Size(83, 21);
            this.o_Class.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.o_Class.TabIndex = 26;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "连续模";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "顺送模";
            // 
            // 销售单号
            // 
            this.销售单号.DataPropertyName = "o_DID";
            this.销售单号.HeaderText = "销售单号";
            this.销售单号.Name = "销售单号";
            this.销售单号.ReadOnly = true;
            this.销售单号.Width = 120;
            // 
            // 客户番号
            // 
            this.客户番号.DataPropertyName = "o_FID";
            this.客户番号.HeaderText = "客户番号";
            this.客户番号.Name = "客户番号";
            this.客户番号.ReadOnly = true;
            // 
            // 客户名称
            // 
            this.客户名称.DataPropertyName = "o_Name";
            this.客户名称.HeaderText = "客户名称";
            this.客户名称.Name = "客户名称";
            this.客户名称.ReadOnly = true;
            // 
            // 厂内编号
            // 
            this.厂内编号.DataPropertyName = "o_CPName";
            this.厂内编号.HeaderText = "厂内编号";
            this.厂内编号.Name = "厂内编号";
            this.厂内编号.ReadOnly = true;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "o_Amount";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 60;
            // 
            // 模具类型
            // 
            this.模具类型.DataPropertyName = "o_Class";
            this.模具类型.HeaderText = "模具类型";
            this.模具类型.Name = "模具类型";
            this.模具类型.ReadOnly = true;
            this.模具类型.Width = 80;
            // 
            // 下单日期
            // 
            this.下单日期.DataPropertyName = "o_XDate";
            this.下单日期.HeaderText = "下单日期";
            this.下单日期.Name = "下单日期";
            this.下单日期.ReadOnly = true;
            this.下单日期.Width = 80;
            // 
            // 交货日期
            // 
            this.交货日期.DataPropertyName = "o_JDate";
            this.交货日期.HeaderText = "交货日期";
            this.交货日期.Name = "交货日期";
            this.交货日期.ReadOnly = true;
            this.交货日期.Width = 80;
            // 
            // 备注说明
            // 
            this.备注说明.DataPropertyName = "o_Notes";
            this.备注说明.HeaderText = "备注说明";
            this.备注说明.Name = "备注说明";
            this.备注说明.ReadOnly = true;
            this.备注说明.Width = 150;
            // 
            // 录单人
            // 
            this.录单人.DataPropertyName = "o_Person";
            this.录单人.HeaderText = "录单人";
            this.录单人.Name = "录单人";
            this.录单人.ReadOnly = true;
            this.录单人.Width = 80;
            // 
            // 录单日期
            // 
            this.录单日期.DataPropertyName = "o_RDate";
            this.录单日期.HeaderText = "录单日期";
            this.录单日期.Name = "录单日期";
            this.录单日期.ReadOnly = true;
            this.录单日期.Width = 80;
            // 
            // HY_CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 443);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_CustomerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户订单";
            this.Load += new System.EventHandler(this.HY_CustomerOrder_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.o_JDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o_XDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.Button btnCus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripButton toolStripCEL;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX o_CPName;
        private DevComponents.DotNetBar.Controls.TextBoxX o_FID;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX o_Name;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX o_Notes;
        private DevComponents.DotNetBar.Controls.TextBoxX o_Person;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewDD;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput o_XDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput o_JDate;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX o_Amount;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.ComboBoxEx o_Class;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户番号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 客户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 厂内编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模具类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 下单日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交货日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录单人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录单日期;
    }
}