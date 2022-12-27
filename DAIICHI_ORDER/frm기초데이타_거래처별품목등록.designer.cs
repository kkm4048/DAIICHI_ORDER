namespace DAIICHI_ORDER
{
    partial class frm기초데이타_거래처별품목등록
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
            FarPoint.Win.Spread.NamedStyle namedStyle8 = new FarPoint.Win.Spread.NamedStyle("HeaderDefault");
            FarPoint.Win.Spread.NamedStyle namedStyle9 = new FarPoint.Win.Spread.NamedStyle("RowHeaderDefault");
            FarPoint.Win.Spread.NamedStyle namedStyle10 = new FarPoint.Win.Spread.NamedStyle("CornerDefault");
            FarPoint.Win.Spread.CellType.CornerRenderer cornerRenderer2 = new FarPoint.Win.Spread.CellType.CornerRenderer();
            FarPoint.Win.Spread.NamedStyle namedStyle11 = new FarPoint.Win.Spread.NamedStyle("ColumnHeaderEnhanced");
            FarPoint.Win.Spread.NamedStyle namedStyle12 = new FarPoint.Win.Spread.NamedStyle("RowHeaderEnhanced");
            FarPoint.Win.Spread.NamedStyle namedStyle13 = new FarPoint.Win.Spread.NamedStyle("CornerEnhanced");
            FarPoint.Win.Spread.CellType.EnhancedCornerRenderer enhancedCornerRenderer2 = new FarPoint.Win.Spread.CellType.EnhancedCornerRenderer();
            FarPoint.Win.Spread.NamedStyle namedStyle14 = new FarPoint.Win.Spread.NamedStyle("DataAreaDefault");
            FarPoint.Win.Spread.CellType.GeneralCellType generalCellType2 = new FarPoint.Win.Spread.CellType.GeneralCellType();
            FarPoint.Win.Spread.SpreadSkin spreadSkin2 = new FarPoint.Win.Spread.SpreadSkin();
            FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer enhancedFocusIndicatorRenderer2 = new FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer();
            FarPoint.Win.Spread.EnhancedInterfaceRenderer enhancedInterfaceRenderer2 = new FarPoint.Win.Spread.EnhancedInterfaceRenderer();
            FarPoint.Win.Spread.EnhancedScrollBarRenderer enhancedScrollBarRenderer2 = new FarPoint.Win.Spread.EnhancedScrollBarRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_거래처별품목등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn구성품등록 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb품목구분 = new System.Windows.Forms.ComboBox();
            this.btn엑셀_불러오기 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb거래처명 = new System.Windows.Forms.ComboBox();
            this.lbl열 = new System.Windows.Forms.Label();
            this.lbl메세지 = new System.Windows.Forms.Label();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.lbl수량 = new System.Windows.Forms.Label();
            this.btn행추가 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.t수정 = new System.Windows.Forms.Timer(this.components);
            this.gb품목검색조건 = new System.Windows.Forms.GroupBox();
            this.cb사이즈 = new System.Windows.Forms.CheckBox();
            this.cb색상 = new System.Windows.Forms.CheckBox();
            this.cb품목명 = new System.Windows.Forms.CheckBox();
            this.btn일괄삭제 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gb품목검색조건.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 90);
            this.spr.Name = "spr";
            namedStyle8.BackColor = System.Drawing.SystemColors.Control;
            namedStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle8.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle8.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle8.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle9.BackColor = System.Drawing.SystemColors.Control;
            namedStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle9.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle9.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle9.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle10.BackColor = System.Drawing.SystemColors.Control;
            namedStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle10.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle10.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle10.Renderer = cornerRenderer2;
            namedStyle10.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(233)))));
            namedStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle11.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle11.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle11.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            namedStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle12.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle12.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle12.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            namedStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            namedStyle13.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            namedStyle13.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle13.Renderer = enhancedCornerRenderer2;
            namedStyle13.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            namedStyle14.BackColor = System.Drawing.SystemColors.Window;
            namedStyle14.CellType = generalCellType2;
            namedStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            namedStyle14.NoteIndicatorColor = System.Drawing.Color.Red;
            namedStyle14.Renderer = generalCellType2;
            this.spr.NamedStyles.AddRange(new FarPoint.Win.Spread.NamedStyle[] {
            namedStyle8,
            namedStyle9,
            namedStyle10,
            namedStyle11,
            namedStyle12,
            namedStyle13,
            namedStyle14});
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1206, 566);
            spreadSkin2.ColumnHeaderDefaultStyle = namedStyle11;
            spreadSkin2.CornerDefaultStyle = namedStyle13;
            spreadSkin2.DefaultStyle = namedStyle14;
            spreadSkin2.FocusRenderer = enhancedFocusIndicatorRenderer2;
            enhancedInterfaceRenderer2.GrayAreaColor = System.Drawing.SystemColors.Control;
            enhancedInterfaceRenderer2.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            enhancedInterfaceRenderer2.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(210)))), ((int)(((byte)(244)))));
            enhancedInterfaceRenderer2.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            enhancedInterfaceRenderer2.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            enhancedInterfaceRenderer2.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            enhancedInterfaceRenderer2.TabStripBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(186)))), ((int)(((byte)(221)))));
            spreadSkin2.InterfaceRenderer = enhancedInterfaceRenderer2;
            spreadSkin2.Name = "CustomSkin1";
            spreadSkin2.RowHeaderDefaultStyle = namedStyle12;
            spreadSkin2.ScrollBarRenderer = enhancedScrollBarRenderer2;
            spreadSkin2.SelectionRenderer = new FarPoint.Win.Spread.DefaultSelectionRenderer();
            this.spr.Skin = spreadSkin2;
            this.spr.TabIndex = 4;
            this.spr.EditModeOff += new System.EventHandler(this.spr_EditModeOff);
            this.spr.ClipboardPasting += new FarPoint.Win.Spread.ClipboardPastingEventHandler(this.spr_ClipboardPasting);
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.btn일괄삭제);
            this.panel2.Controls.Add(this.gb품목검색조건);
            this.panel2.Controls.Add(this.btn구성품등록);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmb품목구분);
            this.panel2.Controls.Add(this.btn엑셀_불러오기);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb거래처명);
            this.panel2.Controls.Add(this.lbl열);
            this.panel2.Controls.Add(this.lbl메세지);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn삭제);
            this.panel2.Controls.Add(this.lbl수량);
            this.panel2.Controls.Add(this.btn행추가);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt조회);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 90);
            this.panel2.TabIndex = 3;
            // 
            // btn구성품등록
            // 
            this.btn구성품등록.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn구성품등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn구성품등록.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn구성품등록.Location = new System.Drawing.Point(980, 10);
            this.btn구성품등록.Name = "btn구성품등록";
            this.btn구성품등록.Size = new System.Drawing.Size(94, 40);
            this.btn구성품등록.TabIndex = 155;
            this.btn구성품등록.Text = "구성품등록";
            this.btn구성품등록.UseVisualStyleBackColor = true;
            this.btn구성품등록.Click += new System.EventHandler(this.btn구성품등록_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 154;
            this.label3.Text = "품목구분";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmb품목구분
            // 
            this.cmb품목구분.FormattingEnabled = true;
            this.cmb품목구분.Location = new System.Drawing.Point(313, 6);
            this.cmb품목구분.Name = "cmb품목구분";
            this.cmb품목구분.Size = new System.Drawing.Size(128, 20);
            this.cmb품목구분.TabIndex = 153;
            this.cmb품목구분.SelectedIndexChanged += new System.EventHandler(this.cmb품목구분_SelectedIndexChanged);
            // 
            // btn엑셀_불러오기
            // 
            this.btn엑셀_불러오기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_불러오기.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_불러오기.Image")));
            this.btn엑셀_불러오기.Location = new System.Drawing.Point(1086, 8);
            this.btn엑셀_불러오기.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_불러오기.Name = "btn엑셀_불러오기";
            this.btn엑셀_불러오기.Size = new System.Drawing.Size(120, 40);
            this.btn엑셀_불러오기.TabIndex = 152;
            this.btn엑셀_불러오기.Text = " 엑셀불러오기";
            this.btn엑셀_불러오기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_불러오기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_불러오기.UseVisualStyleBackColor = true;
            this.btn엑셀_불러오기.Click += new System.EventHandler(this.btn엑셀_불러오기_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 77;
            this.label2.Text = "거래처명";
            // 
            // cmb거래처명
            // 
            this.cmb거래처명.FormattingEnabled = true;
            this.cmb거래처명.Location = new System.Drawing.Point(84, 6);
            this.cmb거래처명.Name = "cmb거래처명";
            this.cmb거래처명.Size = new System.Drawing.Size(164, 20);
            this.cmb거래처명.TabIndex = 76;
            this.cmb거래처명.SelectedIndexChanged += new System.EventHandler(this.cmb거래처명_SelectedIndexChanged);
            // 
            // lbl열
            // 
            this.lbl열.AutoSize = true;
            this.lbl열.Location = new System.Drawing.Point(148, 70);
            this.lbl열.Name = "lbl열";
            this.lbl열.Size = new System.Drawing.Size(11, 12);
            this.lbl열.TabIndex = 73;
            this.lbl열.Text = "0";
            // 
            // lbl메세지
            // 
            this.lbl메세지.AutoSize = true;
            this.lbl메세지.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl메세지.ForeColor = System.Drawing.Color.Red;
            this.lbl메세지.Location = new System.Drawing.Point(190, 69);
            this.lbl메세지.Name = "lbl메세지";
            this.lbl메세지.Size = new System.Drawing.Size(49, 13);
            this.lbl메세지.TabIndex = 72;
            this.lbl메세지.Text = "메세지";
            // 
            // btn조회
            // 
            this.btn조회.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn조회.Location = new System.Drawing.Point(456, 9);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(94, 39);
            this.btn조회.TabIndex = 71;
            this.btn조회.Text = "조 회";
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn삭제
            // 
            this.btn삭제.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn삭제.Location = new System.Drawing.Point(669, 5);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(94, 23);
            this.btn삭제.TabIndex = 70;
            this.btn삭제.Text = "삭 제";
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // lbl수량
            // 
            this.lbl수량.AutoSize = true;
            this.lbl수량.Location = new System.Drawing.Point(13, 70);
            this.lbl수량.Name = "lbl수량";
            this.lbl수량.Size = new System.Drawing.Size(11, 12);
            this.lbl수량.TabIndex = 68;
            this.lbl수량.Text = "0";
            // 
            // btn행추가
            // 
            this.btn행추가.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn행추가.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn행추가.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn행추가.Location = new System.Drawing.Point(556, 8);
            this.btn행추가.Name = "btn행추가";
            this.btn행추가.Size = new System.Drawing.Size(94, 40);
            this.btn행추가.TabIndex = 67;
            this.btn행추가.Text = "행추가";
            this.btn행추가.UseVisualStyleBackColor = true;
            this.btn행추가.Click += new System.EventHandler(this.btn행추가_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "조회";
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(84, 32);
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(357, 21);
            this.txt조회.TabIndex = 59;
            this.txt조회.TextChanged += new System.EventHandler(this.txt상품명_TextChanged);
            this.txt조회.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // t수정
            // 
            this.t수정.Interval = 500;
            this.t수정.Tick += new System.EventHandler(this.t수정_Tick);
            // 
            // gb품목검색조건
            // 
            this.gb품목검색조건.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gb품목검색조건.Controls.Add(this.cb사이즈);
            this.gb품목검색조건.Controls.Add(this.cb색상);
            this.gb품목검색조건.Controls.Add(this.cb품목명);
            this.gb품목검색조건.Enabled = false;
            this.gb품목검색조건.Location = new System.Drawing.Point(769, 9);
            this.gb품목검색조건.Name = "gb품목검색조건";
            this.gb품목검색조건.Size = new System.Drawing.Size(192, 40);
            this.gb품목검색조건.TabIndex = 156;
            this.gb품목검색조건.TabStop = false;
            this.gb품목검색조건.Text = "[ 품목검색조건 ]";
            // 
            // cb사이즈
            // 
            this.cb사이즈.AutoSize = true;
            this.cb사이즈.Location = new System.Drawing.Point(126, 20);
            this.cb사이즈.Name = "cb사이즈";
            this.cb사이즈.Size = new System.Drawing.Size(60, 16);
            this.cb사이즈.TabIndex = 2;
            this.cb사이즈.Text = "사이즈";
            this.cb사이즈.UseVisualStyleBackColor = true;
            // 
            // cb색상
            // 
            this.cb색상.AutoSize = true;
            this.cb색상.Location = new System.Drawing.Point(72, 20);
            this.cb색상.Name = "cb색상";
            this.cb색상.Size = new System.Drawing.Size(48, 16);
            this.cb색상.TabIndex = 1;
            this.cb색상.Text = "색상";
            this.cb색상.UseVisualStyleBackColor = true;
            // 
            // cb품목명
            // 
            this.cb품목명.AutoSize = true;
            this.cb품목명.Location = new System.Drawing.Point(6, 20);
            this.cb품목명.Name = "cb품목명";
            this.cb품목명.Size = new System.Drawing.Size(60, 16);
            this.cb품목명.TabIndex = 0;
            this.cb품목명.Text = "품목명";
            this.cb품목명.UseVisualStyleBackColor = true;
            // 
            // btn일괄삭제
            // 
            this.btn일괄삭제.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn일괄삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn일괄삭제.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn일괄삭제.Location = new System.Drawing.Point(669, 34);
            this.btn일괄삭제.Name = "btn일괄삭제";
            this.btn일괄삭제.Size = new System.Drawing.Size(94, 23);
            this.btn일괄삭제.TabIndex = 157;
            this.btn일괄삭제.Text = "일괄삭제";
            this.btn일괄삭제.UseVisualStyleBackColor = true;
            this.btn일괄삭제.Click += new System.EventHandler(this.btn일괄삭제_Click);
            // 
            // frm기초데이타_거래처별품목등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 656);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.panel2);
            this.Name = "frm기초데이타_거래처별품목등록";
            this.Text = "거래처별 품목등록";
            this.Load += new System.EventHandler(this.frm기초데이타_거래처별품목등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gb품목검색조건.ResumeLayout(false);
            this.gb품목검색조건.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl열;
        private System.Windows.Forms.Label lbl메세지;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Label lbl수량;
        private System.Windows.Forms.Button btn행추가;
        private System.Windows.Forms.Label label1;
        public FarPoint.Win.Spread.FpSpread spr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer t수정;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn엑셀_불러오기;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb품목구분;
        public System.Windows.Forms.ComboBox cmb거래처명;
        public System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn구성품등록;
        private System.Windows.Forms.GroupBox gb품목검색조건;
        private System.Windows.Forms.CheckBox cb사이즈;
        private System.Windows.Forms.CheckBox cb색상;
        private System.Windows.Forms.CheckBox cb품목명;
        private System.Windows.Forms.Button btn일괄삭제;
    }
}