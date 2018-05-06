namespace HYWJ.HY_Invoicing
{
    partial class HY_Purchasingdetails
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.key = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.listView1 = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewCGMX = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnSO = new DevComponents.DotNetBar.ButtonX();
            this.comPName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comSup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comCID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comDID = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCGMX)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.key);
            this.groupPanel1.Controls.Add(this.listView1);
            this.groupPanel1.Location = new System.Drawing.Point(3, 8);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(215, 304);
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
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "采购单列表";
            // 
            // key
            // 
            // 
            // 
            // 
            this.key.Border.Class = "TextBoxBorder";
            this.key.Location = new System.Drawing.Point(6, 256);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(198, 21);
            this.key.TabIndex = 8;
            this.key.Text = "在此输入所要查询单号.....";
            this.key.Enter += new System.EventHandler(this.key_Enter);
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // listView1
            // 
            // 
            // 
            // 
            this.listView1.Border.Class = "ListViewBorder";
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 237);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "采购单号";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "模号";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dataGridViewCGMX);
            this.groupPanel2.Location = new System.Drawing.Point(224, 8);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(694, 487);
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
            this.groupPanel2.TabIndex = 7;
            this.groupPanel2.Text = "产品列表";
            // 
            // dataGridViewCGMX
            // 
            this.dataGridViewCGMX.AllowUserToAddRows = false;
            this.dataGridViewCGMX.AllowUserToDeleteRows = false;
            this.dataGridViewCGMX.BackgroundColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCGMX.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCGMX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewCGMX.Location = new System.Drawing.Point(4, 9);
            this.dataGridViewCGMX.MultiSelect = false;
            this.dataGridViewCGMX.Name = "dataGridViewCGMX";
            this.dataGridViewCGMX.ReadOnly = true;
            this.dataGridViewCGMX.RowTemplate.Height = 23;
            this.dataGridViewCGMX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCGMX.Size = new System.Drawing.Size(680, 449);
            this.dataGridViewCGMX.TabIndex = 3;
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
            this.供应商.Width = 120;
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
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.labelX1);
            this.groupPanel3.Controls.Add(this.btnSO);
            this.groupPanel3.Controls.Add(this.comPName);
            this.groupPanel3.Controls.Add(this.comSup);
            this.groupPanel3.Controls.Add(this.comCID);
            this.groupPanel3.Controls.Add(this.comDID);
            this.groupPanel3.Controls.Add(this.labelX4);
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Location = new System.Drawing.Point(3, 318);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(215, 177);
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
            this.groupPanel3.Text = "高级查询";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(9, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(58, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "单  号：";
            // 
            // btnSO
            // 
            this.btnSO.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSO.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSO.Location = new System.Drawing.Point(119, 127);
            this.btnSO.Name = "btnSO";
            this.btnSO.Size = new System.Drawing.Size(75, 23);
            this.btnSO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSO.TabIndex = 4;
            this.btnSO.Text = "查  询";
            this.btnSO.Click += new System.EventHandler(this.btnSO_Click);
            // 
            // comPName
            // 
            this.comPName.DisplayMember = "Text";
            this.comPName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comPName.FormattingEnabled = true;
            this.comPName.ItemHeight = 15;
            this.comPName.Location = new System.Drawing.Point(73, 95);
            this.comPName.Name = "comPName";
            this.comPName.Size = new System.Drawing.Size(121, 21);
            this.comPName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comPName.TabIndex = 10;
            // 
            // comSup
            // 
            this.comSup.DisplayMember = "Text";
            this.comSup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comSup.FormattingEnabled = true;
            this.comSup.ItemHeight = 15;
            this.comSup.Location = new System.Drawing.Point(73, 66);
            this.comSup.Name = "comSup";
            this.comSup.Size = new System.Drawing.Size(121, 21);
            this.comSup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comSup.TabIndex = 9;
            // 
            // comCID
            // 
            this.comCID.DisplayMember = "Text";
            this.comCID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comCID.FormattingEnabled = true;
            this.comCID.ItemHeight = 15;
            this.comCID.Location = new System.Drawing.Point(73, 39);
            this.comCID.Name = "comCID";
            this.comCID.Size = new System.Drawing.Size(121, 21);
            this.comCID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comCID.TabIndex = 8;
            // 
            // comDID
            // 
            this.comDID.DisplayMember = "Text";
            this.comDID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comDID.FormattingEnabled = true;
            this.comDID.ItemHeight = 15;
            this.comDID.Location = new System.Drawing.Point(73, 10);
            this.comDID.Name = "comDID";
            this.comDID.Size = new System.Drawing.Size(121, 21);
            this.comDID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comDID.TabIndex = 4;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(9, 95);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(58, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "品  名：";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(9, 39);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(58, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "模  号：";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(9, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(58, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "供应商：";
            // 
            // HY_Purchasingdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 499);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.groupPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_Purchasingdetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "采购明细表";
            this.Load += new System.EventHandler(this.HY_Purchasingdetails_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCGMX)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ListViewEx listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX key;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewCGMX;
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
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnSO;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comPName;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comSup;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comCID;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comDID;
    }
}