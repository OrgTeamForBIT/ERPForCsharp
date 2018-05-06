namespace HYWJ.HY_Warehouse
{
    partial class HY_Requisitioned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_Requisitioned));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripADD = new System.Windows.Forms.ToolStripButton();
            this.toolStripUPD = new System.Windows.Forms.ToolStripButton();
            this.toolStripDEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripOut = new System.Windows.Forms.ToolStripButton();
            this.s_CID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s_Warehouse = new System.Windows.Forms.Label();
            this.s_Class = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.s_Person = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPN = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.s_Price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.s_Notes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.s_Amount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.s_Specifications = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.s_Pname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.s_PID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.s_DDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupBox1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewL = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.领料单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领料数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领料人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领料日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.领料备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_DDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripADD,
            this.toolStripUPD,
            this.toolStripDEL,
            this.toolStripCEL,
            this.toolStripSave,
            this.toolStripOut});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(805, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripADD
            // 
            this.toolStripADD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripADD.Image")));
            this.toolStripADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripADD.Name = "toolStripADD";
            this.toolStripADD.Size = new System.Drawing.Size(53, 22);
            this.toolStripADD.Text = "新增";
            this.toolStripADD.Click += new System.EventHandler(this.toolStripADD_Click);
            // 
            // toolStripUPD
            // 
            this.toolStripUPD.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUPD.Image")));
            this.toolStripUPD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUPD.Name = "toolStripUPD";
            this.toolStripUPD.Size = new System.Drawing.Size(53, 22);
            this.toolStripUPD.Text = "修改";
            this.toolStripUPD.Click += new System.EventHandler(this.toolStripUPD_Click);
            // 
            // toolStripDEL
            // 
            this.toolStripDEL.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDEL.Image")));
            this.toolStripDEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDEL.Name = "toolStripDEL";
            this.toolStripDEL.Size = new System.Drawing.Size(53, 22);
            this.toolStripDEL.Text = "删除";
            this.toolStripDEL.Click += new System.EventHandler(this.toolStripDEL_Click);
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
            // toolStripSave
            // 
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(53, 22);
            this.toolStripSave.Text = "保存";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripOut
            // 
            this.toolStripOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOut.Image")));
            this.toolStripOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOut.Name = "toolStripOut";
            this.toolStripOut.Size = new System.Drawing.Size(53, 22);
            this.toolStripOut.Text = "退出";
            this.toolStripOut.Click += new System.EventHandler(this.toolStripOut_Click);
            // 
            // s_CID
            // 
            this.s_CID.Enabled = false;
            this.s_CID.Location = new System.Drawing.Point(261, 5);
            this.s_CID.Name = "s_CID";
            this.s_CID.Size = new System.Drawing.Size(72, 21);
            this.s_CID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "厂内编号";
            // 
            // s_Warehouse
            // 
            this.s_Warehouse.AutoSize = true;
            this.s_Warehouse.Location = new System.Drawing.Point(5, 119);
            this.s_Warehouse.Name = "s_Warehouse";
            this.s_Warehouse.Size = new System.Drawing.Size(41, 12);
            this.s_Warehouse.TabIndex = 31;
            this.s_Warehouse.Text = "label2";
            this.s_Warehouse.Visible = false;
            // 
            // s_Class
            // 
            this.s_Class.AutoSize = true;
            this.s_Class.Location = new System.Drawing.Point(7, 75);
            this.s_Class.Name = "s_Class";
            this.s_Class.Size = new System.Drawing.Size(41, 12);
            this.s_Class.TabIndex = 30;
            this.s_Class.Text = "label2";
            this.s_Class.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 29;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(743, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 28;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // s_Person
            // 
            this.s_Person.Location = new System.Drawing.Point(653, 2);
            this.s_Person.Name = "s_Person";
            this.s_Person.Size = new System.Drawing.Size(83, 21);
            this.s_Person.TabIndex = 27;
            this.s_Person.Leave += new System.EventHandler(this.s_Person_Leave);
            this.s_Person.Enter += new System.EventHandler(this.s_Person_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "领 料 人";
            // 
            // btnPN
            // 
            this.btnPN.Image = ((System.Drawing.Image)(resources.GetObject("btnPN.Image")));
            this.btnPN.Location = new System.Drawing.Point(555, 3);
            this.btnPN.Name = "btnPN";
            this.btnPN.Size = new System.Drawing.Size(27, 23);
            this.btnPN.TabIndex = 25;
            this.btnPN.UseVisualStyleBackColor = true;
            this.btnPN.Click += new System.EventHandler(this.btnPN_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(610, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "领料时间";
            // 
            // s_Price
            // 
            this.s_Price.Enabled = false;
            this.s_Price.Location = new System.Drawing.Point(62, 36);
            this.s_Price.Name = "s_Price";
            this.s_Price.Size = new System.Drawing.Size(81, 21);
            this.s_Price.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "单    价";
            // 
            // s_Notes
            // 
            this.s_Notes.Location = new System.Drawing.Point(62, 68);
            this.s_Notes.Multiline = true;
            this.s_Notes.Name = "s_Notes";
            this.s_Notes.Size = new System.Drawing.Size(710, 72);
            this.s_Notes.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "领用备注";
            // 
            // s_Amount
            // 
            this.s_Amount.Location = new System.Drawing.Point(557, 34);
            this.s_Amount.Name = "s_Amount";
            this.s_Amount.Size = new System.Drawing.Size(47, 21);
            this.s_Amount.TabIndex = 18;
            this.s_Amount.Leave += new System.EventHandler(this.s_Amount_Leave);
            this.s_Amount.Enter += new System.EventHandler(this.s_Amount_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "领用数量";
            // 
            // s_Specifications
            // 
            this.s_Specifications.Enabled = false;
            this.s_Specifications.Location = new System.Drawing.Point(213, 34);
            this.s_Specifications.Name = "s_Specifications";
            this.s_Specifications.Size = new System.Drawing.Size(277, 21);
            this.s_Specifications.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "规    格";
            // 
            // s_Pname
            // 
            this.s_Pname.Enabled = false;
            this.s_Pname.Location = new System.Drawing.Point(385, 4);
            this.s_Pname.Name = "s_Pname";
            this.s_Pname.Size = new System.Drawing.Size(163, 21);
            this.s_Pname.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "品  名";
            // 
            // s_PID
            // 
            this.s_PID.Enabled = false;
            this.s_PID.Location = new System.Drawing.Point(62, 6);
            this.s_PID.Name = "s_PID";
            this.s_PID.Size = new System.Drawing.Size(130, 21);
            this.s_PID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "品    号";
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
            this.panelEx1.Size = new System.Drawing.Size(805, 543);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 9;
            this.panelEx1.Text = "panelEx1";
            // 
            // groupBox2
            // 
            this.groupBox2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox2.Controls.Add(this.s_DDate);
            this.groupBox2.Controls.Add(this.s_CID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.s_PID);
            this.groupBox2.Controls.Add(this.s_Warehouse);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.s_Class);
            this.groupBox2.Controls.Add(this.s_Pname);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.s_Specifications);
            this.groupBox2.Controls.Add(this.s_Person);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.s_Amount);
            this.groupBox2.Controls.Add(this.btnPN);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.s_Notes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.s_Price);
            this.groupBox2.Location = new System.Drawing.Point(7, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 170);
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
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "领用产品信息";
            // 
            // s_DDate
            // 
            // 
            // 
            // 
            this.s_DDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.s_DDate.ButtonDropDown.Visible = true;
            this.s_DDate.Location = new System.Drawing.Point(665, 34);
            // 
            // 
            // 
            this.s_DDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.s_DDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.s_DDate.MonthCalendar.BackgroundStyle.Class = "";
            this.s_DDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.s_DDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.s_DDate.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.s_DDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.s_DDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.s_DDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.s_DDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.s_DDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.s_DDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.s_DDate.MonthCalendar.TodayButtonVisible = true;
            this.s_DDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.s_DDate.Name = "s_DDate";
            this.s_DDate.Size = new System.Drawing.Size(105, 21);
            this.s_DDate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox1.Controls.Add(this.dataGridViewL);
            this.groupBox1.Location = new System.Drawing.Point(7, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 325);
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
            // 
            // dataGridViewL
            // 
            this.dataGridViewL.AllowUserToAddRows = false;
            this.dataGridViewL.AllowUserToDeleteRows = false;
            this.dataGridViewL.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.领料单号,
            this.品号,
            this.品名,
            this.产品类别,
            this.规格,
            this.单价,
            this.领料数量,
            this.领料人,
            this.领料日期,
            this.领料备注});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewL.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewL.MultiSelect = false;
            this.dataGridViewL.Name = "dataGridViewL";
            this.dataGridViewL.ReadOnly = true;
            this.dataGridViewL.RowTemplate.Height = 23;
            this.dataGridViewL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewL.Size = new System.Drawing.Size(786, 319);
            this.dataGridViewL.TabIndex = 0;
            this.dataGridViewL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewL_CellClick);
            // 
            // 领料单号
            // 
            this.领料单号.DataPropertyName = "r_DID";
            this.领料单号.HeaderText = "领料单号";
            this.领料单号.Name = "领料单号";
            this.领料单号.ReadOnly = true;
            this.领料单号.Width = 120;
            // 
            // 品号
            // 
            this.品号.DataPropertyName = "r_PID";
            this.品号.HeaderText = "品号";
            this.品号.Name = "品号";
            this.品号.ReadOnly = true;
            this.品号.Width = 120;
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "r_Pname";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            // 
            // 产品类别
            // 
            this.产品类别.DataPropertyName = "r_Class";
            this.产品类别.HeaderText = "产品类别";
            this.产品类别.Name = "产品类别";
            this.产品类别.ReadOnly = true;
            // 
            // 规格
            // 
            this.规格.DataPropertyName = "r_Specifications";
            this.规格.HeaderText = "规格";
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "r_Price";
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            this.单价.Width = 80;
            // 
            // 领料数量
            // 
            this.领料数量.DataPropertyName = "r_Amount";
            this.领料数量.HeaderText = "领料数量";
            this.领料数量.Name = "领料数量";
            this.领料数量.ReadOnly = true;
            // 
            // 领料人
            // 
            this.领料人.DataPropertyName = "r_Person";
            this.领料人.HeaderText = "领料人";
            this.领料人.Name = "领料人";
            this.领料人.ReadOnly = true;
            this.领料人.Width = 70;
            // 
            // 领料日期
            // 
            this.领料日期.DataPropertyName = "r_LDate";
            this.领料日期.HeaderText = "领料日期";
            this.领料日期.Name = "领料日期";
            this.领料日期.ReadOnly = true;
            // 
            // 领料备注
            // 
            this.领料备注.DataPropertyName = "r_Notes";
            this.领料备注.HeaderText = "领料备注";
            this.领料备注.Name = "领料备注";
            this.领料备注.ReadOnly = true;
            // 
            // HY_Requisitioned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(805, 543);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_Requisitioned";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料领用";
            this.Load += new System.EventHandler(this.HY_Requisitioned_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.s_DDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripADD;
        private System.Windows.Forms.ToolStripButton toolStripCEL;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripOut;
        private System.Windows.Forms.TextBox s_Price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox s_Notes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox s_Amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox s_Specifications;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox s_Pname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox s_PID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox s_Person;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton toolStripDEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s_Warehouse;
        private System.Windows.Forms.Label s_Class;
        private System.Windows.Forms.ToolStripButton toolStripUPD;
        private System.Windows.Forms.TextBox s_CID;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewL;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox2;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput s_DDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领料单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领料数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领料人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领料日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 领料备注;
    }
}