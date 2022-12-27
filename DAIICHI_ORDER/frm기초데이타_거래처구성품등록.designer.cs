namespace DAIICHI_ORDER
{
    partial class frm기초데이타_거래처구성품등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_거래처구성품등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.cmb거래처명 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmb엑셀양식명 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sc2 = new System.Windows.Forms.SplitContainer();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn품번코드 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.txt26 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt25 = new System.Windows.Forms.TextBox();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.spr3 = new FarPoint.Win.Spread.FpSpread();
            this.spr3_Sheet2 = new FarPoint.Win.Spread.SheetView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt번호2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn삭제2 = new System.Windows.Forms.Button();
            this.btn등록2 = new System.Windows.Forms.Button();
            this.btn수정2 = new System.Windows.Forms.Button();
            this.btn초기화2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn품번코드2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt34 = new System.Windows.Forms.TextBox();
            this.txt36 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt35 = new System.Windows.Forms.TextBox();
            this.lblCnt3 = new System.Windows.Forms.Label();
            this.txt33 = new System.Windows.Forms.TextBox();
            this.txt32 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt31 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).BeginInit();
            this.sc2.Panel1.SuspendLayout();
            this.sc2.Panel2.SuspendLayout();
            this.sc2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 141);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(520, 503);
            this.spr.TabIndex = 98;
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
            this.pan데이타.Controls.Add(this.label1);
            this.pan데이타.Controls.Add(this.txt조회);
            this.pan데이타.Controls.Add(this.cmb거래처명);
            this.pan데이타.Controls.Add(this.label27);
            this.pan데이타.Controls.Add(this.cmb엑셀양식명);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 0);
            this.pan데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(520, 141);
            this.pan데이타.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 115;
            this.label1.Text = "조회";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(90, 40);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(226, 21);
            this.txt조회.TabIndex = 114;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            // 
            // cmb거래처명
            // 
            this.cmb거래처명.FormattingEnabled = true;
            this.cmb거래처명.Location = new System.Drawing.Point(90, 12);
            this.cmb거래처명.Name = "cmb거래처명";
            this.cmb거래처명.Size = new System.Drawing.Size(226, 20);
            this.cmb거래처명.TabIndex = 113;
            this.cmb거래처명.SelectedIndexChanged += new System.EventHandler(this.cmb거래처명_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(31, 16);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 112;
            this.label27.Text = "거래처명";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb엑셀양식명
            // 
            this.cmb엑셀양식명.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb엑셀양식명.FormattingEnabled = true;
            this.cmb엑셀양식명.Location = new System.Drawing.Point(596, 44);
            this.cmb엑셀양식명.Name = "cmb엑셀양식명";
            this.cmb엑셀양식명.Size = new System.Drawing.Size(153, 20);
            this.cmb엑셀양식명.TabIndex = 110;
            this.cmb엑셀양식명.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 106;
            this.label7.Text = "엑셀양식명";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Visible = false;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 71);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.lbl타이틀);
            this.pan등록.Controls.Add(this.btnSearch);
            this.pan등록.Controls.Add(this.btnClose);
            this.pan등록.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan등록.Location = new System.Drawing.Point(0, 0);
            this.pan등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan등록.Name = "pan등록";
            this.pan등록.Size = new System.Drawing.Size(1405, 50);
            this.pan등록.TabIndex = 99;
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
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(393, 9);
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
            this.btnClose.Location = new System.Drawing.Point(290, 9);
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
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(650, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "    삭 제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(472, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "    등 록";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(561, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(375, 4);
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
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 50);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.panel1);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.panel2);
            this.sc.Size = new System.Drawing.Size(1405, 646);
            this.sc.SplitterDistance = 522;
            this.sc.TabIndex = 101;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.spr);
            this.panel1.Controls.Add(this.pan데이타);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 646);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 646);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sc2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 644);
            this.panel3.TabIndex = 1;
            // 
            // sc2
            // 
            this.sc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc2.Location = new System.Drawing.Point(0, 0);
            this.sc2.Name = "sc2";
            this.sc2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc2.Panel1
            // 
            this.sc2.Panel1.Controls.Add(this.spr2);
            this.sc2.Panel1.Controls.Add(this.panel4);
            // 
            // sc2.Panel2
            // 
            this.sc2.Panel2.Controls.Add(this.spr3);
            this.sc2.Panel2.Controls.Add(this.panel5);
            this.sc2.Size = new System.Drawing.Size(875, 642);
            this.sc2.SplitterDistance = 308;
            this.sc2.TabIndex = 101;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "spr2, Sheet2, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 141);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(875, 167);
            this.spr2.TabIndex = 98;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btn품번코드);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.txt24);
            this.panel4.Controls.Add(this.btninit);
            this.panel4.Controls.Add(this.txt26);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt25);
            this.panel4.Controls.Add(this.lblCnt2);
            this.panel4.Controls.Add(this.txt23);
            this.panel4.Controls.Add(this.txt22);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt21);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(875, 141);
            this.panel4.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(14, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 114;
            this.label10.Text = "구성품";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn품번코드
            // 
            this.btn품번코드.Location = new System.Drawing.Point(25, 92);
            this.btn품번코드.Name = "btn품번코드";
            this.btn품번코드.Size = new System.Drawing.Size(77, 33);
            this.btn품번코드.TabIndex = 113;
            this.btn품번코드.Text = "품번코드";
            this.btn품번코드.UseVisualStyleBackColor = true;
            this.btn품번코드.Click += new System.EventHandler(this.btn품번코드_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 111;
            this.label8.Text = "구성품명";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt24
            // 
            this.txt24.Location = new System.Drawing.Point(109, 74);
            this.txt24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt24.MaxLength = 0;
            this.txt24.Name = "txt24";
            this.txt24.Size = new System.Drawing.Size(185, 21);
            this.txt24.TabIndex = 104;
            this.txt24.Enter += new System.EventHandler(this.txt_Enter);
            this.txt24.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt26
            // 
            this.txt26.Location = new System.Drawing.Point(375, 98);
            this.txt26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt26.MaxLength = 0;
            this.txt26.Name = "txt26";
            this.txt26.Size = new System.Drawing.Size(294, 21);
            this.txt26.TabIndex = 106;
            this.txt26.Enter += new System.EventHandler(this.txt_Enter);
            this.txt26.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 102;
            this.label11.Text = "거래처 품명";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt25
            // 
            this.txt25.Location = new System.Drawing.Point(109, 98);
            this.txt25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt25.MaxLength = 0;
            this.txt25.Name = "txt25";
            this.txt25.Size = new System.Drawing.Size(185, 21);
            this.txt25.TabIndex = 105;
            this.txt25.TextChanged += new System.EventHandler(this.txt25_TextChanged);
            this.txt25.Enter += new System.EventHandler(this.txt_Enter);
            this.txt25.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(3, 121);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // txt23
            // 
            this.txt23.Location = new System.Drawing.Point(375, 50);
            this.txt23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt23.MaxLength = 0;
            this.txt23.Name = "txt23";
            this.txt23.Size = new System.Drawing.Size(294, 21);
            this.txt23.TabIndex = 103;
            this.txt23.Enter += new System.EventHandler(this.txt_Enter);
            this.txt23.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt22
            // 
            this.txt22.Location = new System.Drawing.Point(109, 50);
            this.txt22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt22.MaxLength = 0;
            this.txt22.Name = "txt22";
            this.txt22.Size = new System.Drawing.Size(185, 21);
            this.txt22.TabIndex = 102;
            this.txt22.TextChanged += new System.EventHandler(this.txt22_TextChanged);
            this.txt22.Enter += new System.EventHandler(this.txt_Enter);
            this.txt22.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 81;
            this.label13.Text = "품명";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt21
            // 
            this.txt21.Location = new System.Drawing.Point(69, 26);
            this.txt21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt21.MaxLength = 0;
            this.txt21.Name = "txt21";
            this.txt21.Size = new System.Drawing.Size(225, 21);
            this.txt21.TabIndex = 101;
            this.txt21.Enter += new System.EventHandler(this.txt_Enter);
            this.txt21.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 70;
            this.label14.Text = "거래처명";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 60;
            this.label15.Text = "거래처품번코드";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spr3
            // 
            this.spr3.AccessibleDescription = "spr3, Sheet3, Row 0, Column 0, ";
            this.spr3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr3.Location = new System.Drawing.Point(0, 141);
            this.spr3.Name = "spr3";
            this.spr3.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr3_Sheet2});
            this.spr3.Size = new System.Drawing.Size(875, 189);
            this.spr3.TabIndex = 101;
            this.spr3.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr3_CellClick);
            // 
            // spr3_Sheet2
            // 
            this.spr3_Sheet2.Reset();
            spr3_Sheet2.SheetName = "Sheet3";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr3_Sheet2.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr3_Sheet2.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr3_Sheet2.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.Columns.Default.Resizable = false;
            this.spr3_Sheet2.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr3_Sheet2.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr3_Sheet2.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr3_Sheet2.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr3_Sheet2.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.txt번호2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btn삭제2);
            this.panel5.Controls.Add(this.btn등록2);
            this.panel5.Controls.Add(this.btn수정2);
            this.panel5.Controls.Add(this.btn초기화2);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btn품번코드2);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txt34);
            this.panel5.Controls.Add(this.txt36);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txt35);
            this.panel5.Controls.Add(this.lblCnt3);
            this.panel5.Controls.Add(this.txt33);
            this.panel5.Controls.Add(this.txt32);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt31);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(875, 141);
            this.panel5.TabIndex = 102;
            // 
            // txt번호2
            // 
            this.txt번호2.Enabled = false;
            this.txt번호2.Location = new System.Drawing.Point(109, 74);
            this.txt번호2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt번호2.MaxLength = 0;
            this.txt번호2.Name = "txt번호2";
            this.txt번호2.Size = new System.Drawing.Size(49, 21);
            this.txt번호2.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 120;
            this.label4.Text = "번호";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn삭제2
            // 
            this.btn삭제2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제2.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제2.Image")));
            this.btn삭제2.Location = new System.Drawing.Point(650, 10);
            this.btn삭제2.Name = "btn삭제2";
            this.btn삭제2.Size = new System.Drawing.Size(90, 32);
            this.btn삭제2.TabIndex = 119;
            this.btn삭제2.Text = "    삭 제";
            this.btn삭제2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제2.UseVisualStyleBackColor = true;
            this.btn삭제2.Click += new System.EventHandler(this.btn삭제2_Click);
            // 
            // btn등록2
            // 
            this.btn등록2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록2.Image = ((System.Drawing.Image)(resources.GetObject("btn등록2.Image")));
            this.btn등록2.Location = new System.Drawing.Point(472, 10);
            this.btn등록2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록2.Name = "btn등록2";
            this.btn등록2.Size = new System.Drawing.Size(90, 32);
            this.btn등록2.TabIndex = 118;
            this.btn등록2.Text = "    등 록";
            this.btn등록2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록2.UseVisualStyleBackColor = true;
            this.btn등록2.Click += new System.EventHandler(this.btn등록2_Click);
            // 
            // btn수정2
            // 
            this.btn수정2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정2.Image = ((System.Drawing.Image)(resources.GetObject("btn수정2.Image")));
            this.btn수정2.Location = new System.Drawing.Point(561, 10);
            this.btn수정2.Name = "btn수정2";
            this.btn수정2.Size = new System.Drawing.Size(90, 32);
            this.btn수정2.TabIndex = 117;
            this.btn수정2.Text = "    수 정";
            this.btn수정2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정2.UseVisualStyleBackColor = true;
            this.btn수정2.Visible = false;
            // 
            // btn초기화2
            // 
            this.btn초기화2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화2.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화2.Image")));
            this.btn초기화2.Location = new System.Drawing.Point(375, 10);
            this.btn초기화2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화2.Name = "btn초기화2";
            this.btn초기화2.Size = new System.Drawing.Size(90, 32);
            this.btn초기화2.TabIndex = 116;
            this.btn초기화2.Text = "   초기화";
            this.btn초기화2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(14, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 16);
            this.label12.TabIndex = 115;
            this.label12.Text = "필수 구성품";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn품번코드2
            // 
            this.btn품번코드2.Location = new System.Drawing.Point(25, 92);
            this.btn품번코드2.Name = "btn품번코드2";
            this.btn품번코드2.Size = new System.Drawing.Size(77, 33);
            this.btn품번코드2.TabIndex = 113;
            this.btn품번코드2.Text = "품번코드";
            this.btn품번코드2.UseVisualStyleBackColor = true;
            this.btn품번코드2.Click += new System.EventHandler(this.btn품번코드2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 111;
            this.label2.Text = "구성품명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Visible = false;
            // 
            // txt34
            // 
            this.txt34.Location = new System.Drawing.Point(561, 74);
            this.txt34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt34.MaxLength = 0;
            this.txt34.Name = "txt34";
            this.txt34.Size = new System.Drawing.Size(185, 21);
            this.txt34.TabIndex = 104;
            this.txt34.Visible = false;
            // 
            // txt36
            // 
            this.txt36.Location = new System.Drawing.Point(375, 98);
            this.txt36.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt36.MaxLength = 0;
            this.txt36.Name = "txt36";
            this.txt36.Size = new System.Drawing.Size(294, 21);
            this.txt36.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "거래처 품명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt35
            // 
            this.txt35.Location = new System.Drawing.Point(109, 98);
            this.txt35.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt35.MaxLength = 0;
            this.txt35.Name = "txt35";
            this.txt35.Size = new System.Drawing.Size(185, 21);
            this.txt35.TabIndex = 105;
            // 
            // lblCnt3
            // 
            this.lblCnt3.AutoSize = true;
            this.lblCnt3.Location = new System.Drawing.Point(3, 121);
            this.lblCnt3.Name = "lblCnt3";
            this.lblCnt3.Size = new System.Drawing.Size(11, 12);
            this.lblCnt3.TabIndex = 98;
            this.lblCnt3.Text = "0";
            // 
            // txt33
            // 
            this.txt33.Location = new System.Drawing.Point(375, 50);
            this.txt33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt33.MaxLength = 0;
            this.txt33.Name = "txt33";
            this.txt33.Size = new System.Drawing.Size(294, 21);
            this.txt33.TabIndex = 103;
            // 
            // txt32
            // 
            this.txt32.Location = new System.Drawing.Point(109, 50);
            this.txt32.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt32.MaxLength = 0;
            this.txt32.Name = "txt32";
            this.txt32.Size = new System.Drawing.Size(185, 21);
            this.txt32.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 81;
            this.label5.Text = "품명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt31
            // 
            this.txt31.Location = new System.Drawing.Point(69, 26);
            this.txt31.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt31.MaxLength = 0;
            this.txt31.Name = "txt31";
            this.txt31.Size = new System.Drawing.Size(225, 21);
            this.txt31.TabIndex = 101;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 70;
            this.label6.Text = "거래처명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "거래처품번코드";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm기초데이타_거래처구성품등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 696);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.pan등록);
            this.Name = "frm기초데이타_거래처구성품등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "거래처 구성품 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_거래처구성품등록_Load);
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sc2.Panel1.ResumeLayout(false);
            this.sc2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc2)).EndInit();
            this.sc2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr3_Sheet2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan데이타;
        private System.Windows.Forms.ComboBox cmb엑셀양식명;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt26;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt25;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb거래처명;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt조회;
        private System.Windows.Forms.Button btn품번코드;
        private System.Windows.Forms.SplitContainer sc2;
        private FarPoint.Win.Spread.FpSpread spr3;
        private FarPoint.Win.Spread.SheetView spr3_Sheet2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn품번코드2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt34;
        private System.Windows.Forms.TextBox txt36;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt35;
        private System.Windows.Forms.Label lblCnt3;
        private System.Windows.Forms.TextBox txt33;
        private System.Windows.Forms.TextBox txt32;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt31;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn삭제2;
        private System.Windows.Forms.Button btn등록2;
        private System.Windows.Forms.Button btn수정2;
        private System.Windows.Forms.Button btn초기화2;
        private System.Windows.Forms.TextBox txt번호2;
        private System.Windows.Forms.Label label4;
    }
}