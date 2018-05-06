namespace HYWJ.HY_Invoicing
{
    partial class HY_Purchasingstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_Purchasingstatus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listView1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.imageListStatr = new System.Windows.Forms.ImageList(this.components);
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSX = new DevComponents.DotNetBar.ButtonX();
            this.Supplier = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.key = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewCGMX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.paneStat = new DevComponents.DotNetBar.PanelEx();
            this.reflectionImage3 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.cgok = new DevComponents.DotNetBar.LabelX();
            this.Statr = new DevComponents.DotNetBar.LabelX();
            this.did = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.btnYDH = new DevComponents.DotNetBar.ButtonX();
            this.btnBHZ = new DevComponents.DotNetBar.ButtonX();
            this.btnCGZ = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.btnCG = new DevComponents.DotNetBar.ButtonX();
            this.品名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.供应商 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.热处理 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购部门 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.请购日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.需要日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用途 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCGMX)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.paneStat.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            // 
            // 
            // 
            this.listView1.Border.Class = "ListViewBorder";
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 304);
            this.listView1.SmallImageList = this.imageListStatr;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "采购单号";
            this.columnHeader2.Width = 165;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "模号";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "供应商";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "状态";
            this.columnHeader4.Width = 0;
            // 
            // imageListStatr
            // 
            this.imageListStatr.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatr.ImageStream")));
            this.imageListStatr.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatr.Images.SetKeyName(0, "CG4.png");
            this.imageListStatr.Images.SetKeyName(1, "CG1.png");
            this.imageListStatr.Images.SetKeyName(2, "CG2.png");
            this.imageListStatr.Images.SetKeyName(3, "CG3.png");
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnSX);
            this.groupPanel1.Controls.Add(this.Supplier);
            this.groupPanel1.Controls.Add(this.key);
            this.groupPanel1.Controls.Add(this.listView1);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(4, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(232, 405);
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
            this.groupPanel1.Text = "采购单列表";
            // 
            // btnSX
            // 
            this.btnSX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSX.Location = new System.Drawing.Point(179, 355);
            this.btnSX.Name = "btnSX";
            this.btnSX.Size = new System.Drawing.Size(44, 23);
            this.btnSX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSX.TabIndex = 4;
            this.btnSX.Text = "筛选";
            this.btnSX.Click += new System.EventHandler(this.btnSX_Click);
            // 
            // Supplier
            // 
            this.Supplier.DisplayMember = "Text";
            this.Supplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Supplier.FormattingEnabled = true;
            this.Supplier.ItemHeight = 15;
            this.Supplier.Location = new System.Drawing.Point(49, 356);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(124, 21);
            this.Supplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Supplier.TabIndex = 4;
            // 
            // key
            // 
            // 
            // 
            // 
            this.key.Border.Class = "TextBoxBorder";
            this.key.Location = new System.Drawing.Point(1, 326);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(223, 21);
            this.key.TabIndex = 8;
            this.key.Text = "在此输入所要查询单号.....";
            this.key.Enter += new System.EventHandler(this.key_Enter);
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(1, 359);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(54, 19);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "供应商：";
            // 
            // dataGridViewCGMX
            // 
            this.dataGridViewCGMX.AllowUserToAddRows = false;
            this.dataGridViewCGMX.AllowUserToDeleteRows = false;
            this.dataGridViewCGMX.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCGMX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCGMX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCGMX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.品名,
            this.供应商,
            this.型号,
            this.规格,
            this.热处理,
            this.单位,
            this.数量,
            this.请购人,
            this.请购部门,
            this.请购日期,
            this.需要日期,
            this.用途,
            this.备注});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCGMX.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCGMX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewCGMX.Location = new System.Drawing.Point(4, 9);
            this.dataGridViewCGMX.MultiSelect = false;
            this.dataGridViewCGMX.Name = "dataGridViewCGMX";
            this.dataGridViewCGMX.ReadOnly = true;
            this.dataGridViewCGMX.RowTemplate.Height = 23;
            this.dataGridViewCGMX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCGMX.Size = new System.Drawing.Size(670, 449);
            this.dataGridViewCGMX.TabIndex = 3;
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.paneStat);
            this.groupPanel2.Controls.Add(this.dataGridViewCGMX);
            this.groupPanel2.Location = new System.Drawing.Point(242, 5);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(677, 487);
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
            this.groupPanel2.TabIndex = 9;
            this.groupPanel2.Text = "产品列表";
            // 
            // paneStat
            // 
            this.paneStat.CanvasColor = System.Drawing.SystemColors.Control;
            this.paneStat.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.paneStat.Controls.Add(this.reflectionImage3);
            this.paneStat.Controls.Add(this.reflectionImage2);
            this.paneStat.Controls.Add(this.cgok);
            this.paneStat.Controls.Add(this.Statr);
            this.paneStat.Controls.Add(this.did);
            this.paneStat.Controls.Add(this.labelX2);
            this.paneStat.Controls.Add(this.reflectionImage1);
            this.paneStat.Controls.Add(this.btnYDH);
            this.paneStat.Controls.Add(this.btnBHZ);
            this.paneStat.Controls.Add(this.btnCGZ);
            this.paneStat.Location = new System.Drawing.Point(69, 128);
            this.paneStat.Name = "paneStat";
            this.paneStat.Size = new System.Drawing.Size(352, 159);
            this.paneStat.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.paneStat.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.paneStat.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.paneStat.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.paneStat.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.paneStat.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.paneStat.Style.GradientAngle = 90;
            this.paneStat.TabIndex = 4;
            this.paneStat.Text = "panelEx1";
            this.paneStat.Visible = false;
            // 
            // reflectionImage3
            // 
            // 
            // 
            // 
            this.reflectionImage3.BackgroundStyle.Class = "";
            this.reflectionImage3.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage3.Image")));
            this.reflectionImage3.Location = new System.Drawing.Point(217, 69);
            this.reflectionImage3.Name = "reflectionImage3";
            this.reflectionImage3.Size = new System.Drawing.Size(30, 49);
            this.reflectionImage3.TabIndex = 9;
            // 
            // reflectionImage2
            // 
            // 
            // 
            // 
            this.reflectionImage2.BackgroundStyle.Class = "";
            this.reflectionImage2.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage2.Image")));
            this.reflectionImage2.Location = new System.Drawing.Point(99, 69);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(30, 49);
            this.reflectionImage2.TabIndex = 8;
            // 
            // cgok
            // 
            // 
            // 
            // 
            this.cgok.BackgroundStyle.Class = "";
            this.cgok.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cgok.ForeColor = System.Drawing.Color.Red;
            this.cgok.Location = new System.Drawing.Point(76, 130);
            this.cgok.Name = "cgok";
            this.cgok.Size = new System.Drawing.Size(187, 23);
            this.cgok.TabIndex = 7;
            // 
            // Statr
            // 
            // 
            // 
            // 
            this.Statr.BackgroundStyle.Class = "";
            this.Statr.Location = new System.Drawing.Point(269, 13);
            this.Statr.Name = "Statr";
            this.Statr.Size = new System.Drawing.Size(75, 23);
            this.Statr.TabIndex = 6;
            this.Statr.Text = "labelX3";
            this.Statr.Visible = false;
            // 
            // did
            // 
            // 
            // 
            // 
            this.did.BackgroundStyle.Class = "";
            this.did.Location = new System.Drawing.Point(88, 12);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(175, 23);
            this.did.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(9, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(85, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "采购单号为：";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(330, 131);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(19, 25);
            this.reflectionImage1.TabIndex = 3;
            this.reflectionImage1.Click += new System.EventHandler(this.reflectionImage1_Click);
            // 
            // btnYDH
            // 
            this.btnYDH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYDH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYDH.Image = ((System.Drawing.Image)(resources.GetObject("btnYDH.Image")));
            this.btnYDH.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnYDH.Location = new System.Drawing.Point(254, 53);
            this.btnYDH.Name = "btnYDH";
            this.btnYDH.Size = new System.Drawing.Size(76, 65);
            this.btnYDH.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYDH.TabIndex = 2;
            this.btnYDH.Text = "(3)已到货";
            this.btnYDH.Click += new System.EventHandler(this.btnYDH_Click);
            // 
            // btnBHZ
            // 
            this.btnBHZ.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBHZ.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBHZ.Image = ((System.Drawing.Image)(resources.GetObject("btnBHZ.Image")));
            this.btnBHZ.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBHZ.Location = new System.Drawing.Point(135, 53);
            this.btnBHZ.Name = "btnBHZ";
            this.btnBHZ.Size = new System.Drawing.Size(76, 65);
            this.btnBHZ.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBHZ.TabIndex = 1;
            this.btnBHZ.Text = "(2)备货中";
            this.btnBHZ.Click += new System.EventHandler(this.btnBHZ_Click);
            // 
            // btnCGZ
            // 
            this.btnCGZ.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCGZ.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCGZ.Image = ((System.Drawing.Image)(resources.GetObject("btnCGZ.Image")));
            this.btnCGZ.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCGZ.Location = new System.Drawing.Point(18, 53);
            this.btnCGZ.Name = "btnCGZ";
            this.btnCGZ.Size = new System.Drawing.Size(76, 65);
            this.btnCGZ.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCGZ.TabIndex = 0;
            this.btnCGZ.Text = "(1)采购中";
            this.btnCGZ.Click += new System.EventHandler(this.btnCGZ_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.buttonX3);
            this.groupPanel3.Controls.Add(this.buttonX2);
            this.groupPanel3.Controls.Add(this.btnCG);
            this.groupPanel3.Location = new System.Drawing.Point(4, 416);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(232, 76);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.Class = "";
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.Class = "";
            this.groupPanel3.TabIndex = 4;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Image = ((System.Drawing.Image)(resources.GetObject("buttonX3.Image")));
            this.buttonX3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX3.Location = new System.Drawing.Point(3, 4);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(71, 63);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.buttonX3.TabIndex = 13;
            this.buttonX3.Text = "生成对货单";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = ((System.Drawing.Image)(resources.GetObject("buttonX2.Image")));
            this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX2.Location = new System.Drawing.Point(79, 4);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(71, 63);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.buttonX2.TabIndex = 12;
            this.buttonX2.Text = "采购状况";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btnCG
            // 
            this.btnCG.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCG.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCG.Image = ((System.Drawing.Image)(resources.GetObject("btnCG.Image")));
            this.btnCG.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCG.Location = new System.Drawing.Point(153, 4);
            this.btnCG.Name = "btnCG";
            this.btnCG.Size = new System.Drawing.Size(71, 63);
            this.btnCG.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnCG.TabIndex = 11;
            this.btnCG.Text = "生成采购单";
            this.btnCG.Click += new System.EventHandler(this.btnCG_Click);
            // 
            // 品名
            // 
            this.品名.DataPropertyName = "c_Name";
            this.品名.HeaderText = "品名";
            this.品名.Name = "品名";
            this.品名.ReadOnly = true;
            this.品名.Width = 120;
            // 
            // 供应商
            // 
            this.供应商.DataPropertyName = "c_Supplier";
            this.供应商.HeaderText = "供应商";
            this.供应商.Name = "供应商";
            this.供应商.ReadOnly = true;
            this.供应商.Width = 200;
            // 
            // 型号
            // 
            this.型号.DataPropertyName = "c_Origin";
            this.型号.HeaderText = "型号";
            this.型号.Name = "型号";
            this.型号.ReadOnly = true;
            this.型号.Width = 80;
            // 
            // 规格
            // 
            this.规格.DataPropertyName = "c_Specifications";
            this.规格.HeaderText = "规格";
            this.规格.Name = "规格";
            this.规格.ReadOnly = true;
            this.规格.Width = 120;
            // 
            // 热处理
            // 
            this.热处理.DataPropertyName = "c_Hot";
            this.热处理.HeaderText = "热处理";
            this.热处理.Name = "热处理";
            this.热处理.ReadOnly = true;
            this.热处理.Width = 80;
            // 
            // 单位
            // 
            this.单位.DataPropertyName = "c_Units";
            this.单位.HeaderText = "单位";
            this.单位.Name = "单位";
            this.单位.ReadOnly = true;
            this.单位.Width = 70;
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "c_Amount";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            this.数量.Width = 70;
            // 
            // 请购人
            // 
            this.请购人.DataPropertyName = "c_Person";
            this.请购人.HeaderText = "请购人";
            this.请购人.Name = "请购人";
            this.请购人.ReadOnly = true;
            this.请购人.Width = 70;
            // 
            // 请购部门
            // 
            this.请购部门.DataPropertyName = "c_Department";
            this.请购部门.HeaderText = "请购部门";
            this.请购部门.Name = "请购部门";
            this.请购部门.ReadOnly = true;
            this.请购部门.Width = 80;
            // 
            // 请购日期
            // 
            this.请购日期.DataPropertyName = "c_QDate";
            this.请购日期.HeaderText = "请购日期";
            this.请购日期.Name = "请购日期";
            this.请购日期.ReadOnly = true;
            this.请购日期.Width = 80;
            // 
            // 需要日期
            // 
            this.需要日期.DataPropertyName = "c_XDate";
            this.需要日期.HeaderText = "需要日期";
            this.需要日期.Name = "需要日期";
            this.需要日期.ReadOnly = true;
            this.需要日期.Width = 80;
            // 
            // 用途
            // 
            this.用途.DataPropertyName = "c_Uses";
            this.用途.HeaderText = "用途";
            this.用途.Name = "用途";
            this.用途.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "c_Notes";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // HY_Purchasingstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 497);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel2);
            this.Name = "HY_Purchasingstatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购状况明细表";
            this.Load += new System.EventHandler(this.HY_Purchasingstatus_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCGMX)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.paneStat.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX key;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewCGMX;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx Supplier;
        private DevComponents.DotNetBar.ButtonX btnSX;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX btnCG;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevComponents.DotNetBar.PanelEx paneStat;
        private DevComponents.DotNetBar.ButtonX btnYDH;
        private DevComponents.DotNetBar.ButtonX btnBHZ;
        private DevComponents.DotNetBar.ButtonX btnCGZ;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private System.Windows.Forms.ImageList imageListStatr;
        private DevComponents.DotNetBar.LabelX did;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DevComponents.DotNetBar.LabelX Statr;
        private DevComponents.DotNetBar.LabelX cgok;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage3;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 供应商;
        private System.Windows.Forms.DataGridViewTextBoxColumn 型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格;
        private System.Windows.Forms.DataGridViewTextBoxColumn 热处理;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购部门;
        private System.Windows.Forms.DataGridViewTextBoxColumn 请购日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 需要日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用途;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}