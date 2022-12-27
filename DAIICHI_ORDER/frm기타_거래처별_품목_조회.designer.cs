namespace DAIICHI_ORDER
{
    partial class frm기타_거래처별_품목_조회
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
            FarPoint.Win.Spread.NamedStyle namedStyle1 = new FarPoint.Win.Spread.NamedStyle("HeaderDefault");
            FarPoint.Win.Spread.NamedStyle namedStyle2 = new FarPoint.Win.Spread.NamedStyle("RowHeaderDefault");
            FarPoint.Win.Spread.NamedStyle namedStyle3 = new FarPoint.Win.Spread.NamedStyle("CornerDefault");
            FarPoint.Win.Spread.CellType.CornerRenderer cornerRenderer1 = new FarPoint.Win.Spread.CellType.CornerRenderer();
            FarPoint.Win.Spread.NamedStyle namedStyle4 = new FarPoint.Win.Spread.NamedStyle("ColumnHeaderEnhanced");
            FarPoint.Win.Spread.NamedStyle namedStyle5 = new FarPoint.Win.Spread.NamedStyle("RowHeaderEnhanced");
            FarPoint.Win.Spread.NamedStyle namedStyle6 = new FarPoint.Win.Spread.NamedStyle("CornerEnhanced");
            FarPoint.Win.Spread.CellType.EnhancedCornerRenderer enhancedCornerRenderer1 = new FarPoint.Win.Spread.CellType.EnhancedCornerRenderer();
            FarPoint.Win.Spread.NamedStyle namedStyle7 = new FarPoint.Win.Spread.NamedStyle("DataAreaDefault");
            FarPoint.Win.Spread.CellType.GeneralCellType generalCellType1 = new FarPoint.Win.Spread.CellType.GeneralCellType();
            FarPoint.Win.Spread.SpreadSkin spreadSkin1 = new FarPoint.Win.Spread.SpreadSkin();
            FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer enhancedFocusIndicatorRenderer1 = new FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer();
            FarPoint.Win.Spread.EnhancedInterfaceRenderer enhancedInterfaceRenderer1 = new FarPoint.Win.Spread.EnhancedInterfaceRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer1 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt조회5 = new System.Windows.Forms.TextBox();
            this.txt조회4 = new System.Windows.Forms.TextBox();
            this.txt조회3 = new System.Windows.Forms.TextBox();
            this.txt조회2 = new System.Windows.Forms.TextBox();
            this.cmb품목구분 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt거래처명 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl수량 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t조회 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt조회5);
            this.panel2.Controls.Add(this.txt조회4);
            this.panel2.Controls.Add(this.txt조회3);
            this.panel2.Controls.Add(this.txt조회2);
            this.panel2.Controls.Add(this.cmb품목구분);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txt거래처명);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl수량);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt조회);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 66);
            this.panel2.TabIndex = 2;
            // 
            // txt조회5
            // 
            this.txt조회5.Location = new System.Drawing.Point(570, 30);
            this.txt조회5.Name = "txt조회5";
            this.txt조회5.Size = new System.Drawing.Size(107, 21);
            this.txt조회5.TabIndex = 4;
            this.txt조회5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회5.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt조회4
            // 
            this.txt조회4.Location = new System.Drawing.Point(457, 30);
            this.txt조회4.Name = "txt조회4";
            this.txt조회4.Size = new System.Drawing.Size(107, 21);
            this.txt조회4.TabIndex = 3;
            this.txt조회4.TextChanged += new System.EventHandler(this.txt조회4_TextChanged);
            this.txt조회4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt조회3
            // 
            this.txt조회3.Location = new System.Drawing.Point(348, 30);
            this.txt조회3.Name = "txt조회3";
            this.txt조회3.Size = new System.Drawing.Size(101, 21);
            this.txt조회3.TabIndex = 2;
            this.txt조회3.TextChanged += new System.EventHandler(this.txt조회3_TextChanged);
            this.txt조회3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt조회2
            // 
            this.txt조회2.Location = new System.Drawing.Point(236, 30);
            this.txt조회2.Name = "txt조회2";
            this.txt조회2.Size = new System.Drawing.Size(106, 21);
            this.txt조회2.TabIndex = 1;
            this.txt조회2.TextChanged += new System.EventHandler(this.txt조회2_TextChanged);
            this.txt조회2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // cmb품목구분
            // 
            this.cmb품목구분.FormattingEnabled = true;
            this.cmb품목구분.Location = new System.Drawing.Point(455, 7);
            this.cmb품목구분.Name = "cmb품목구분";
            this.cmb품목구분.Size = new System.Drawing.Size(130, 20);
            this.cmb품목구분.TabIndex = 156;
            this.cmb품목구분.SelectedIndexChanged += new System.EventHandler(this.cmb품목구분_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 155;
            this.label12.Text = "품목구분";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt거래처명
            // 
            this.txt거래처명.Enabled = false;
            this.txt거래처명.Location = new System.Drawing.Point(121, 6);
            this.txt거래처명.Name = "txt거래처명";
            this.txt거래처명.Size = new System.Drawing.Size(255, 21);
            this.txt거래처명.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 70;
            this.label2.Text = "거래처명";
            // 
            // lbl수량
            // 
            this.lbl수량.AutoSize = true;
            this.lbl수량.Location = new System.Drawing.Point(12, 39);
            this.lbl수량.Name = "lbl수량";
            this.lbl수량.Size = new System.Drawing.Size(11, 12);
            this.lbl수량.TabIndex = 69;
            this.lbl수량.Text = "0";
            // 
            // btn조회
            // 
            this.btn조회.Location = new System.Drawing.Point(805, 11);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(129, 42);
            this.btn조회.TabIndex = 60;
            this.btn조회.Text = "조 회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "조회";
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(121, 30);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(109, 21);
            this.txt조회.TabIndex = 0;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 66);
            this.spr.Name = "spr";
            namedStyle1.BackColor = System.Drawing.SystemColors.Control;
            namedStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle1.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle2.BackColor = System.Drawing.SystemColors.Control;
            namedStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle2.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle3.BackColor = System.Drawing.SystemColors.Control;
            namedStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle3.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle3.Renderer = cornerRenderer1;
            namedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            namedStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle4.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            namedStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle5.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle5.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle5.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            namedStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle6.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle6.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle6.Renderer = enhancedCornerRenderer1;
            namedStyle6.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle7.BackColor = System.Drawing.SystemColors.Window;
            namedStyle7.CellType = generalCellType1;
            namedStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            namedStyle7.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle7.Renderer = generalCellType1;
            this.spr.NamedStyles.AddRange(new FarPoint.Win.Spread.NamedStyle[] {
            namedStyle1,
            namedStyle2,
            namedStyle3,
            namedStyle4,
            namedStyle5,
            namedStyle6,
            namedStyle7});
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1215, 599);
            spreadSkin1.ColumnHeaderDefaultStyle = namedStyle4;
            spreadSkin1.CornerDefaultStyle = namedStyle6;
            spreadSkin1.DefaultStyle = namedStyle7;
            spreadSkin1.FocusRenderer = enhancedFocusIndicatorRenderer1;
            enhancedInterfaceRenderer1.GrayAreaColor = System.Drawing.SystemColors.Control;
            enhancedInterfaceRenderer1.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            enhancedInterfaceRenderer1.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            enhancedInterfaceRenderer1.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            enhancedInterfaceRenderer1.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            enhancedInterfaceRenderer1.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            enhancedInterfaceRenderer1.TabStripBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            spreadSkin1.InterfaceRenderer = enhancedInterfaceRenderer1;
            spreadSkin1.Name = "CustomSkin1";
            spreadSkin1.RowHeaderDefaultStyle = namedStyle5;
            spreadSkin1.ScrollBarRenderer = enhancedScrollBarRenderer1;
            spreadSkin1.SelectionRenderer = new FarPoint.Win.Spread.DefaultSelectionRenderer();
            this.spr.Skin = spreadSkin1;
            this.spr.TabIndex = 3;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            this.spr.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellDoubleClick);
            this.spr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.spr_KeyDown);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // t조회
            // 
            this.t조회.Enabled = true;
            this.t조회.Interval = 1000;
            this.t조회.Tick += new System.EventHandler(this.t조회_Tick);
            // 
            // frm기타_거래처별_품목_조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.panel2);
            this.Name = "frm기타_거래처별_품목_조회";
            this.Text = "거래처별 품목코드 조회";
            this.Activated += new System.EventHandler(this.frm기타_상품코드_조회_Activated);
            this.Load += new System.EventHandler(this.frm기타_거래처별_품목_조회_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn조회;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Label lbl수량;
        public System.Windows.Forms.TextBox txt조회;
        public FarPoint.Win.Spread.FpSpread spr;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox txt거래처명;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb품목구분;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer t조회;
        public System.Windows.Forms.TextBox txt조회4;
        public System.Windows.Forms.TextBox txt조회3;
        public System.Windows.Forms.TextBox txt조회2;
        public System.Windows.Forms.TextBox txt조회5;
    }
}