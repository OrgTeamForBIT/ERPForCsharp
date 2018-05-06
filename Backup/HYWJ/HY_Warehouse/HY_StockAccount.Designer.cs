namespace HYWJ.HY_Warehouse
{
    partial class HY_StockAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HY_StockAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.key = new System.Windows.Forms.TextBox();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.label3 = new DevComponents.DotNetBar.LabelX();
            this.label4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupBox3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.btnMX = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboBoxClass = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.groupBox2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewCK = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.合计 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.到货日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCK)).BeginInit();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(203, 19);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(337, 21);
            this.key.TabIndex = 3;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.label3);
            this.panelEx1.Controls.Add(this.label4);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.groupBox3);
            this.panelEx1.Controls.Add(this.groupBox2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(750, 519);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 7;
            // 
            // label3
            // 
            // 
            // 
            // 
            this.label3.BackgroundStyle.Class = "";
            this.label3.Location = new System.Drawing.Point(588, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "labelX4";
            // 
            // label4
            // 
            // 
            // 
            // 
            this.label4.BackgroundStyle.Class = "";
            this.label4.Location = new System.Drawing.Point(407, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "labelX3";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(524, 497);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "金额总计：";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(342, 498);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(68, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "库存总计：";
            // 
            // groupBox3
            // 
            this.groupBox3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox3.Controls.Add(this.buttonX1);
            this.groupBox3.Controls.Add(this.btnMX);
            this.groupBox3.Controls.Add(this.labelX3);
            this.groupBox3.Controls.Add(this.comboBoxClass);
            this.groupBox3.Controls.Add(this.key);
            this.groupBox3.Location = new System.Drawing.Point(6, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 65);
            // 
            // 
            // 
            this.groupBox3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupBox3.Style.BackColorGradientAngle = 90;
            this.groupBox3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupBox3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox3.Style.BorderBottomWidth = 1;
            this.groupBox3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupBox3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox3.Style.BorderLeftWidth = 1;
            this.groupBox3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox3.Style.BorderRightWidth = 1;
            this.groupBox3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupBox3.Style.BorderTopWidth = 1;
            this.groupBox3.Style.Class = "";
            this.groupBox3.Style.CornerDiameter = 4;
            this.groupBox3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupBox3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupBox3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupBox3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupBox3.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupBox3.StyleMouseOver.Class = "";
            this.groupBox3.TabIndex = 1;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonX1.Location = new System.Drawing.Point(646, 3);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(77, 53);
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "打  印";
            // 
            // btnMX
            // 
            this.btnMX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMX.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnMX.Image = ((System.Drawing.Image)(resources.GetObject("btnMX.Image")));
            this.btnMX.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnMX.Location = new System.Drawing.Point(563, 3);
            this.btnMX.Name = "btnMX";
            this.btnMX.Size = new System.Drawing.Size(77, 53);
            this.btnMX.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.btnMX.TabIndex = 6;
            this.btnMX.Text = "生成报表";
            this.btnMX.Click += new System.EventHandler(this.btnMX_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(7, 20);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "检索类型：";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DisplayMember = "Text";
            this.comboBoxClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.ItemHeight = 15;
            this.comboBoxClass.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.comboBoxClass.Location = new System.Drawing.Point(75, 19);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClass.TabIndex = 4;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "按单号检索";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "按品号检索";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "按品名检索";
            // 
            // groupBox2
            // 
            this.groupBox2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupBox2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupBox2.Controls.Add(this.dataGridViewCK);
            this.groupBox2.Location = new System.Drawing.Point(6, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 408);
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
            this.groupBox2.TabIndex = 0;
            // 
            // dataGridViewCK
            // 
            this.dataGridViewCK.AllowUserToAddRows = false;
            this.dataGridViewCK.AllowUserToDeleteRows = false;
            this.dataGridViewCK.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.合计,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.到货日期,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewCK.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCK.MultiSelect = false;
            this.dataGridViewCK.Name = "dataGridViewCK";
            this.dataGridViewCK.ReadOnly = true;
            this.dataGridViewCK.RowTemplate.Height = 23;
            this.dataGridViewCK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCK.Size = new System.Drawing.Size(733, 402);
            this.dataGridViewCK.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "s_DID";
            this.dataGridViewTextBoxColumn1.HeaderText = "单号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "s_PID";
            this.dataGridViewTextBoxColumn2.HeaderText = "品号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "s_Pname";
            this.dataGridViewTextBoxColumn3.HeaderText = "品名";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "s_Specifications";
            this.dataGridViewTextBoxColumn4.HeaderText = "规格";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "s_Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "数量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "s_Price";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "单价";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // 合计
            // 
            this.合计.DataPropertyName = "HJ";
            this.合计.HeaderText = "合计";
            this.合计.Name = "合计";
            this.合计.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "s_Class";
            this.dataGridViewTextBoxColumn7.HeaderText = "所属类别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "s_Person";
            this.dataGridViewTextBoxColumn8.HeaderText = "入库人";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // 到货日期
            // 
            this.到货日期.DataPropertyName = "s_DDate";
            this.到货日期.HeaderText = "到货日期";
            this.到货日期.Name = "到货日期";
            this.到货日期.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "s_XDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "入库日期";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "s_Warehouse";
            this.dataGridViewTextBoxColumn10.HeaderText = "仓库";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "s_Notes";
            this.dataGridViewTextBoxColumn11.HeaderText = "备注";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // HY_StockAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 519);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HY_StockAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存明细账";
            this.Load += new System.EventHandler(this.HY_StockAccount_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox key;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewCK;
        private DevComponents.DotNetBar.Controls.GroupPanel groupBox3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX label3;
        private DevComponents.DotNetBar.LabelX label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxClass;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnMX;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 合计;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 到货日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}