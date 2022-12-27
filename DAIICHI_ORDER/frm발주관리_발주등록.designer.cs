namespace DAIICHI_ORDER
{
    partial class frm발주관리_발주등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm발주관리_발주등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.lbl정상 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lbl에러 = new System.Windows.Forms.Label();
            this.btn저장 = new System.Windows.Forms.Button();
            this.btn검증 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb거래처명 = new System.Windows.Forms.ComboBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.btn엑셀_발주서불러오기 = new System.Windows.Forms.Button();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.pan발주 = new System.Windows.Forms.Panel();
            this.pan결과 = new System.Windows.Forms.Panel();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl에러2 = new System.Windows.Forms.Label();
            this.btn전체삭제 = new System.Windows.Forms.Button();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txt조회2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tMost = new System.Windows.Forms.Timer(this.components);
            this.btn추가 = new System.Windows.Forms.Button();
            this.btn삭제 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.pan발주.SuspendLayout();
            this.pan결과.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 64);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(698, 574);
            this.spr.TabIndex = 98;
            this.spr.EditModeOn += new System.EventHandler(this.spr_EditModeOn);
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // pan데이타
            // 
            this.pan데이타.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan데이타.Controls.Add(this.lbl정상);
            this.pan데이타.Controls.Add(this.dtp);
            this.pan데이타.Controls.Add(this.lbl에러);
            this.pan데이타.Controls.Add(this.btn저장);
            this.pan데이타.Controls.Add(this.btn검증);
            this.pan데이타.Controls.Add(this.label2);
            this.pan데이타.Controls.Add(this.cmb거래처명);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 0);
            this.pan데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(698, 64);
            this.pan데이타.TabIndex = 100;
            this.pan데이타.Paint += new System.Windows.Forms.PaintEventHandler(this.pan데이타_Paint);
            // 
            // lbl정상
            // 
            this.lbl정상.AutoSize = true;
            this.lbl정상.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl정상.ForeColor = System.Drawing.Color.Blue;
            this.lbl정상.Location = new System.Drawing.Point(463, 44);
            this.lbl정상.Name = "lbl정상";
            this.lbl정상.Size = new System.Drawing.Size(35, 13);
            this.lbl정상.TabIndex = 105;
            this.lbl정상.Text = "에러";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(298, 16);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(156, 21);
            this.dtp.TabIndex = 104;
            this.dtp.CloseUp += new System.EventHandler(this.dtp_CloseUp);
            // 
            // lbl에러
            // 
            this.lbl에러.AutoSize = true;
            this.lbl에러.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl에러.ForeColor = System.Drawing.Color.Red;
            this.lbl에러.Location = new System.Drawing.Point(405, 44);
            this.lbl에러.Name = "lbl에러";
            this.lbl에러.Size = new System.Drawing.Size(35, 13);
            this.lbl에러.TabIndex = 103;
            this.lbl에러.Text = "에러";
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(562, 7);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(90, 32);
            this.btn저장.TabIndex = 102;
            this.btn저장.Text = "    저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // btn검증
            // 
            this.btn검증.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn검증.Image = ((System.Drawing.Image)(resources.GetObject("btn검증.Image")));
            this.btn검증.Location = new System.Drawing.Point(466, 7);
            this.btn검증.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn검증.Name = "btn검증";
            this.btn검증.Size = new System.Drawing.Size(90, 32);
            this.btn검증.TabIndex = 101;
            this.btn검증.Text = "    검 증";
            this.btn검증.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn검증.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn검증.UseVisualStyleBackColor = true;
            this.btn검증.Click += new System.EventHandler(this.btn검증_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 100;
            this.label2.Text = "거래처명";
            // 
            // cmb거래처명
            // 
            this.cmb거래처명.FormattingEnabled = true;
            this.cmb거래처명.Location = new System.Drawing.Point(94, 16);
            this.cmb거래처명.Name = "cmb거래처명";
            this.cmb거래처명.Size = new System.Drawing.Size(185, 20);
            this.cmb거래처명.TabIndex = 99;
            this.cmb거래처명.SelectedIndexChanged += new System.EventHandler(this.cmb거래처명_SelectedIndexChanged);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 38);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.btn엑셀_발주서불러오기);
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnDelete);
            this.pan등록.Controls.Add(this.btnAdd);
            this.pan등록.Controls.Add(this.btnEdit);
            this.pan등록.Controls.Add(this.btninit);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1388, 50);
            this.pan등록.TabIndex = 99;
            // 
            // btn엑셀_발주서불러오기
            // 
            this.btn엑셀_발주서불러오기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_발주서불러오기.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_발주서불러오기.Image")));
            this.btn엑셀_발주서불러오기.Location = new System.Drawing.Point(500, 3);
            this.btn엑셀_발주서불러오기.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_발주서불러오기.Name = "btn엑셀_발주서불러오기";
            this.btn엑셀_발주서불러오기.Size = new System.Drawing.Size(140, 40);
            this.btn엑셀_발주서불러오기.TabIndex = 154;
            this.btn엑셀_발주서불러오기.Text = "  발주서 불러오기";
            this.btn엑셀_발주서불러오기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_발주서불러오기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_발주서불러오기.UseVisualStyleBackColor = true;
            this.btn엑셀_발주서불러오기.Click += new System.EventHandler(this.btn엑셀_발주서불러오기_Click);
            // 
            // lbl타이틀
            // 
            this.lbl타이틀.AutoSize = true;
            this.lbl타이틀.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀.Location = new System.Drawing.Point(11, 15);
            this.lbl타이틀.Name = "lbl타이틀";
            this.lbl타이틀.Size = new System.Drawing.Size(59, 16);
            this.lbl타이틀.TabIndex = 44;
            this.lbl타이틀.Text = "타이틀";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(1223, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1045, 7);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "    등 록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(1134, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(384, 7);
            this.btninit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninit.Name = "btninit";
            this.btninit.Size = new System.Drawing.Size(90, 32);
            this.btninit.TabIndex = 40;
            this.btninit.Text = "   초기화";
            this.btninit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninit.UseVisualStyleBackColor = true;
            this.btninit.Click += new System.EventHandler(this.btninit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(277, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 32);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "    조 회";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(174, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 32);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "    닫 기";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.pan발주);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.pan결과);
            this.sc.Size = new System.Drawing.Size(1388, 640);
            this.sc.SplitterDistance = 700;
            this.sc.TabIndex = 101;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // pan발주
            // 
            this.pan발주.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan발주.Controls.Add(this.spr);
            this.pan발주.Controls.Add(this.pan데이타);
            this.pan발주.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan발주.Location = new System.Drawing.Point(0, 0);
            this.pan발주.Name = "pan발주";
            this.pan발주.Size = new System.Drawing.Size(700, 640);
            this.pan발주.TabIndex = 101;
            // 
            // pan결과
            // 
            this.pan결과.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan결과.Controls.Add(this.spr2);
            this.pan결과.Controls.Add(this.panel1);
            this.pan결과.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan결과.Location = new System.Drawing.Point(0, 0);
            this.pan결과.Name = "pan결과";
            this.pan결과.Size = new System.Drawing.Size(684, 640);
            this.pan결과.TabIndex = 0;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 64);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(682, 574);
            this.spr2.TabIndex = 102;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
            this.spr2.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellDoubleClick);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn삭제);
            this.panel1.Controls.Add(this.btn추가);
            this.panel1.Controls.Add(this.lbl에러2);
            this.panel1.Controls.Add(this.btn전체삭제);
            this.panel1.Controls.Add(this.lblCnt2);
            this.panel1.Controls.Add(this.txt조회2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 64);
            this.panel1.TabIndex = 101;
            // 
            // lbl에러2
            // 
            this.lbl에러2.AutoSize = true;
            this.lbl에러2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl에러2.ForeColor = System.Drawing.Color.Red;
            this.lbl에러2.Location = new System.Drawing.Point(106, 48);
            this.lbl에러2.Name = "lbl에러2";
            this.lbl에러2.Size = new System.Drawing.Size(35, 13);
            this.lbl에러2.TabIndex = 103;
            this.lbl에러2.Text = "에러";
            // 
            // btn전체삭제
            // 
            this.btn전체삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn전체삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn전체삭제.Image")));
            this.btn전체삭제.Location = new System.Drawing.Point(218, 13);
            this.btn전체삭제.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn전체삭제.Name = "btn전체삭제";
            this.btn전체삭제.Size = new System.Drawing.Size(90, 32);
            this.btn전체삭제.TabIndex = 101;
            this.btn전체삭제.Text = "  전체삭제";
            this.btn전체삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn전체삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn전체삭제.UseVisualStyleBackColor = true;
            this.btn전체삭제.Click += new System.EventHandler(this.btn전체삭제_Click);
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(12, 38);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // txt조회2
            // 
            this.txt조회2.Location = new System.Drawing.Point(42, 9);
            this.txt조회2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회2.MaxLength = 0;
            this.txt조회2.Name = "txt조회2";
            this.txt조회2.Size = new System.Drawing.Size(155, 21);
            this.txt조회2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "조회";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tMost
            // 
            this.tMost.Interval = 500;
            this.tMost.Tick += new System.EventHandler(this.tMost_Tick);
            // 
            // btn추가
            // 
            this.btn추가.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn추가.Image = ((System.Drawing.Image)(resources.GetObject("btn추가.Image")));
            this.btn추가.Location = new System.Drawing.Point(368, 12);
            this.btn추가.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn추가.Name = "btn추가";
            this.btn추가.Size = new System.Drawing.Size(90, 32);
            this.btn추가.TabIndex = 104;
            this.btn추가.Text = "   추 가";
            this.btn추가.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn추가.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn추가.UseVisualStyleBackColor = true;
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(464, 12);
            this.btn삭제.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(90, 32);
            this.btn삭제.TabIndex = 105;
            this.btn삭제.Text = "  삭 제";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // frm발주관리_발주등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 690);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pan등록);
            this.Name = "frm발주관리_발주등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "발주 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm발주관리_발주등록_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan데이타.ResumeLayout(false);
            this.pan데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.pan발주.ResumeLayout(false);
            this.pan결과.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan데이타;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.Button btn엑셀_발주서불러오기;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb거래처명;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btn검증;
        private System.Windows.Forms.Label lbl에러;
        private System.Windows.Forms.Panel pan발주;
        private System.Windows.Forms.Timer tMost;
        private System.Windows.Forms.Panel pan결과;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl에러2;
        private System.Windows.Forms.Button btn전체삭제;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txt조회2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lbl정상;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn추가;
    }
}