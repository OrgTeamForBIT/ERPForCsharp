namespace HYWJ.HY_Invoicing
{
    partial class HY_SupplierPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_SupplierPrice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripDEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripExit = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupC = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewSupplierPrice = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupB = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.p_Vray = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.p_Weight = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.p_PID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.p_SM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.p_Date = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.p_Price = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.p_PName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.p_rPerson = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.p_gyName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.p_ID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.重量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.材质 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供应商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.录入人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.groupC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierPrice)).BeginInit();
            this.groupB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_Date)).BeginInit();
            this.groupA.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAdd,
            this.toolStripEdit,
            this.toolStripDEL,
            this.toolStripCEL,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(679, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.groupC);
            this.panelEx1.Controls.Add(this.groupB);
            this.panelEx1.Controls.Add(this.groupA);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(679, 506);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            this.panelEx1.Text = "panelEx1";
            // 
            // groupC
            // 
            this.groupC.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupC.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupC.Controls.Add(this.dataGridViewSupplierPrice);
            this.groupC.Location = new System.Drawing.Point(6, 215);
            this.groupC.Name = "groupC";
            this.groupC.Size = new System.Drawing.Size(666, 283);
            // 
            // 
            // 
            this.groupC.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupC.Style.BackColorGradientAngle = 90;
            this.groupC.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupC.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupC.Style.BorderBottomWidth = 1;
            this.groupC.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupC.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupC.Style.BorderLeftWidth = 1;
            this.groupC.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupC.Style.BorderRightWidth = 1;
            this.groupC.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupC.Style.BorderTopWidth = 1;
            this.groupC.Style.Class = "";
            this.groupC.Style.CornerDiameter = 4;
            this.groupC.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupC.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupC.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupC.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupC.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupC.StyleMouseOver.Class = "";
            this.groupC.TabIndex = 2;
            // 
            // dataGridViewSupplierPrice
            // 
            this.dataGridViewSupplierPrice.AllowUserToAddRows = false;
            this.dataGridViewSupplierPrice.AllowUserToDeleteRows = false;
            this.dataGridViewSupplierPrice.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewSupplierPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSupplierPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSupplierPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.单号,
            this.模号,
            this.品名,
            this.单价,
            this.重量,
            this.材质,
            this.供应商,
            this.规格说明,
            this.录入日期,
            this.录入人});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSupplierPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSupplierPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSupplierPrice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewSupplierPrice.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSupplierPrice.MultiSelect = false;
            this.dataGridViewSupplierPrice.Name = "dataGridViewSupplierPrice";
            this.dataGridViewSupplierPrice.ReadOnly = true;
            this.dataGridViewSupplierPrice.RowTemplate.Height = 23;
            this.dataGridViewSupplierPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSupplierPrice.Size = new System.Drawing.Size(660, 277);
            this.dataGridViewSupplierPrice.TabIndex = 0;
            this.dataGridViewSupplierPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSupplierPrice_CellClick);
            // 
            // groupB
            // 
            this.groupB.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupB.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupB.Controls.Add(this.p_Vray);
            this.groupB.Controls.Add(this.labelX10);
            this.groupB.Controls.Add(this.p_Weight);
            this.groupB.Controls.Add(this.labelX9);
            this.groupB.Controls.Add(this.p_PID);
            this.groupB.Controls.Add(this.labelX8);
            this.groupB.Controls.Add(this.p_SM);
            this.groupB.Controls.Add(this.labelX7);
            this.groupB.Controls.Add(this.p_Date);
            this.groupB.Controls.Add(this.p_Price);
            this.groupB.Controls.Add(this.p_PName);
            this.groupB.Controls.Add(this.labelX6);
            this.groupB.Controls.Add(this.labelX5);
            this.groupB.Controls.Add(this.labelX4);
            this.groupB.Location = new System.Drawing.Point(6, 98);
            this.groupB.Name = "groupB";
            this.groupB.Size = new System.Drawing.Size(666, 110);
            // 
            // 
            // 
            this.groupB.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupB.Style.BackColorGradientAngle = 90;
            this.groupB.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupB.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupB.Style.BorderBottomWidth = 1;
            this.groupB.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupB.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupB.Style.BorderLeftWidth = 1;
            this.groupB.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupB.Style.BorderRightWidth = 1;
            this.groupB.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupB.Style.BorderTopWidth = 1;
            this.groupB.Style.Class = "";
            this.groupB.Style.CornerDiameter = 4;
            this.groupB.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupB.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupB.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupB.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupB.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupB.StyleMouseOver.Class = "";
            this.groupB.TabIndex = 1;
            // 
            // p_Vray
            // 
            // 
            // 
            // 
            this.p_Vray.Border.Class = "TextBoxBorder";
            this.p_Vray.Location = new System.Drawing.Point(412, 43);
            this.p_Vray.Name = "p_Vray";
            this.p_Vray.Size = new System.Drawing.Size(110, 21);
            this.p_Vray.TabIndex = 19;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.Class = "";
            this.labelX10.Location = new System.Drawing.Point(349, 46);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(67, 18);
            this.labelX10.TabIndex = 18;
            this.labelX10.Text = "材    质：";
            // 
            // p_Weight
            // 
            // 
            // 
            // 
            this.p_Weight.Border.Class = "TextBoxBorder";
            this.p_Weight.Location = new System.Drawing.Point(243, 44);
            this.p_Weight.Name = "p_Weight";
            this.p_Weight.Size = new System.Drawing.Size(92, 21);
            this.p_Weight.TabIndex = 17;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.Class = "";
            this.labelX9.Location = new System.Drawing.Point(189, 47);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(57, 16);
            this.labelX9.TabIndex = 16;
            this.labelX9.Text = "重  量：";
            // 
            // p_PID
            // 
            // 
            // 
            // 
            this.p_PID.Border.Class = "TextBoxBorder";
            this.p_PID.Location = new System.Drawing.Point(75, 13);
            this.p_PID.Name = "p_PID";
            this.p_PID.Size = new System.Drawing.Size(104, 21);
            this.p_PID.TabIndex = 15;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.Class = "";
            this.labelX8.Location = new System.Drawing.Point(188, 14);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(55, 18);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "品  名：";
            // 
            // p_SM
            // 
            // 
            // 
            // 
            this.p_SM.Border.Class = "TextBoxBorder";
            this.p_SM.Location = new System.Drawing.Point(75, 73);
            this.p_SM.Name = "p_SM";
            this.p_SM.Size = new System.Drawing.Size(579, 21);
            this.p_SM.TabIndex = 13;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Location = new System.Drawing.Point(11, 74);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(73, 20);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "规格说明：";
            // 
            // p_Date
            // 
            // 
            // 
            // 
            this.p_Date.BackgroundStyle.Class = "DateTimeInputBackground";
            this.p_Date.ButtonDropDown.Visible = true;
            this.p_Date.Location = new System.Drawing.Point(412, 10);
            // 
            // 
            // 
            this.p_Date.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.p_Date.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.p_Date.MonthCalendar.BackgroundStyle.Class = "";
            this.p_Date.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.p_Date.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.p_Date.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.p_Date.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.p_Date.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.p_Date.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.p_Date.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.p_Date.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.p_Date.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.p_Date.MonthCalendar.TodayButtonVisible = true;
            this.p_Date.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.p_Date.Name = "p_Date";
            this.p_Date.Size = new System.Drawing.Size(110, 21);
            this.p_Date.TabIndex = 11;
            // 
            // p_Price
            // 
            // 
            // 
            // 
            this.p_Price.Border.Class = "TextBoxBorder";
            this.p_Price.Location = new System.Drawing.Point(75, 44);
            this.p_Price.Name = "p_Price";
            this.p_Price.Size = new System.Drawing.Size(104, 21);
            this.p_Price.TabIndex = 10;
            // 
            // p_PName
            // 
            // 
            // 
            // 
            this.p_PName.Border.Class = "TextBoxBorder";
            this.p_PName.Location = new System.Drawing.Point(243, 12);
            this.p_PName.Name = "p_PName";
            this.p_PName.Size = new System.Drawing.Size(92, 21);
            this.p_PName.TabIndex = 9;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Location = new System.Drawing.Point(349, 14);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(76, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "录入日期：";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Location = new System.Drawing.Point(11, 47);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(73, 16);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "单    价：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(11, 17);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(73, 16);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "模    号：";
            // 
            // groupA
            // 
            this.groupA.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupA.Controls.Add(this.p_rPerson);
            this.groupA.Controls.Add(this.labelX3);
            this.groupA.Controls.Add(this.p_gyName);
            this.groupA.Controls.Add(this.labelX2);
            this.groupA.Controls.Add(this.p_ID);
            this.groupA.Controls.Add(this.labelX1);
            this.groupA.Location = new System.Drawing.Point(6, 32);
            this.groupA.Name = "groupA";
            this.groupA.Size = new System.Drawing.Size(666, 58);
            // 
            // 
            // 
            this.groupA.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupA.Style.BackColorGradientAngle = 90;
            this.groupA.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupA.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupA.Style.BorderBottomWidth = 1;
            this.groupA.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupA.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupA.Style.BorderLeftWidth = 1;
            this.groupA.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupA.Style.BorderRightWidth = 1;
            this.groupA.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupA.Style.BorderTopWidth = 1;
            this.groupA.Style.Class = "";
            this.groupA.Style.CornerDiameter = 4;
            this.groupA.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupA.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupA.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupA.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupA.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupA.StyleMouseOver.Class = "";
            this.groupA.TabIndex = 0;
            this.groupA.Text = "基本信息";
            // 
            // p_rPerson
            // 
            this.p_rPerson.DisplayMember = "Text";
            this.p_rPerson.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.p_rPerson.FormattingEnabled = true;
            this.p_rPerson.ItemHeight = 15;
            this.p_rPerson.Location = new System.Drawing.Point(545, 3);
            this.p_rPerson.Name = "p_rPerson";
            this.p_rPerson.Size = new System.Drawing.Size(109, 21);
            this.p_rPerson.TabIndex = 5;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(492, 8);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(59, 18);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "录入人：";
            // 
            // p_gyName
            // 
            this.p_gyName.DisplayMember = "Text";
            this.p_gyName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.p_gyName.FormattingEnabled = true;
            this.p_gyName.ItemHeight = 15;
            this.p_gyName.Location = new System.Drawing.Point(257, 5);
            this.p_gyName.Name = "p_gyName";
            this.p_gyName.Size = new System.Drawing.Size(223, 21);
            this.p_gyName.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(204, 8);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 19);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "供应商：";
            // 
            // p_ID
            // 
            // 
            // 
            // 
            this.p_ID.Border.Class = "TextBoxBorder";
            this.p_ID.Location = new System.Drawing.Point(56, 7);
            this.p_ID.Name = "p_ID";
            this.p_ID.Size = new System.Drawing.Size(137, 21);
            this.p_ID.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(4, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 17);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "单  号：";
            // 
            // 单号
            // 
            this.单号.DataPropertyName = "p_DID";
            this.单号.FillWeight = 120F;
            this.单号.HeaderText = "单号";
            this.单号.Name = "单号";
            this.单号.ReadOnly = true;
            this.单号.Width = 120;
            // 
            // 模号
            // 
            this.模号.DataPropertyName = "p_PID";
            this.模号.HeaderText = "模号";
            this.模号.Name = "模号";
            this.模号.ReadOnly = true;
            this.模号.Width = 80;
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "p_PName";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "p_Price";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.单价.DefaultCellStyle = dataGridViewCellStyle3;
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            this.单价.Width = 70;
            // 
            // 重量
            // 
            this.重量.DataPropertyName = "p_Weight";
            this.重量.HeaderText = "重量";
            this.重量.Name = "重量";
            this.重量.ReadOnly = true;
            this.重量.Width = 80;
            // 
            // 材质
            // 
            this.材质.DataPropertyName = "p_Vray";
            this.材质.HeaderText = "材质";
            this.材质.Name = "材质";
            this.材质.ReadOnly = true;
            this.材质.Width = 80;
            // 
            // 供应商
            // 
            this.供应商.DataPropertyName = "p_gyName";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Width = 200;
            // 
            // 规格说明
            // 
            this.规格说明.DataPropertyName = "p_SM";
            this.规格说明.HeaderText = "规格说明";
            this.规格说明.Name = "规格说明";
            this.规格说明.ReadOnly = true;
            // 
            // 录入日期
            // 
            this.录入日期.DataPropertyName = "p_Date";
            this.录入日期.HeaderText = "录入日期";
            this.录入日期.Name = "录入日期";
            this.录入日期.ReadOnly = true;
            this.录入日期.Width = 80;
            // 
            // 录入人
            // 
            this.录入人.DataPropertyName = "p_rPerson";
            this.录入人.HeaderText = "录入人";
            this.录入人.Name = "录入人";
            this.录入人.ReadOnly = true;
            this.录入人.Width = 80;
            // 
            // HY_SupplierPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 506);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_SupplierPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供应商物料价格表";
            this.Load += new System.EventHandler(this.HY_SupplierPrice_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelEx1.ResumeLayout(false);
            this.groupC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSupplierPrice)).EndInit();
            this.groupB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_Date)).EndInit();
            this.groupA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripAdd;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripButton toolStripExit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton toolStripDEL;
        private System.Windows.Forms.ToolStripButton toolStripCEL;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupA;
        private DevComponents.DotNetBar.Controls.ComboBoxEx p_rPerson;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx p_gyName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX p_ID;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupB;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput p_Date;
        private DevComponents.DotNetBar.Controls.TextBoxX p_Price;
        private DevComponents.DotNetBar.Controls.TextBoxX p_PName;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX p_SM;
        private DevComponents.DotNetBar.Controls.GroupPanel groupC;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewSupplierPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX p_PID;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX p_Vray;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX p_Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 重量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 材质;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供应商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 录入人;

    }
}