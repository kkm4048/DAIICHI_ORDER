﻿namespace DAIICHI_ORDER
{
    partial class frm기초데이타_품목등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초데이타_품목등록));
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb품목구분 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pan등록 = new System.Windows.Forms.Panel();
            this.cmb품목구분0 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt조회 = new System.Windows.Forms.TextBox();
            this.btn엑셀_불러오기 = new System.Windows.Forms.Button();
            this.lbl타이틀 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btninit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan데이타.SuspendLayout();
            this.pan등록.SuspendLayout();
            this.SuspendLayout();
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 155);
            this.spr.Name = "spr";
            this.spr.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Vertical;
            this.spr.ScrollTipPolicy = FarPoint.Win.Spread.ScrollTipPolicy.Vertical;
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1334, 460);
            this.spr.TabIndex = 98;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
            this.spr.LeaveCell += new FarPoint.Win.Spread.LeaveCellEventHandler(this.spr_LeaveCell);
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
            this.pan데이타.Controls.Add(this.txt10);
            this.pan데이타.Controls.Add(this.label10);
            this.pan데이타.Controls.Add(this.txt9);
            this.pan데이타.Controls.Add(this.label11);
            this.pan데이타.Controls.Add(this.cmb품목구분);
            this.pan데이타.Controls.Add(this.label8);
            this.pan데이타.Controls.Add(this.txt8);
            this.pan데이타.Controls.Add(this.label4);
            this.pan데이타.Controls.Add(this.txt7);
            this.pan데이타.Controls.Add(this.label9);
            this.pan데이타.Controls.Add(this.label7);
            this.pan데이타.Controls.Add(this.txt6);
            this.pan데이타.Controls.Add(this.label6);
            this.pan데이타.Controls.Add(this.txt5);
            this.pan데이타.Controls.Add(this.label5);
            this.pan데이타.Controls.Add(this.txt4);
            this.pan데이타.Controls.Add(this.lblCnt);
            this.pan데이타.Controls.Add(this.txt3);
            this.pan데이타.Controls.Add(this.txt2);
            this.pan데이타.Controls.Add(this.label2);
            this.pan데이타.Controls.Add(this.txt1);
            this.pan데이타.Controls.Add(this.label1);
            this.pan데이타.Controls.Add(this.label3);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan데이타.Location = new System.Drawing.Point(0, 50);
            this.pan데이타.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(1334, 105);
            this.pan데이타.TabIndex = 100;
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(898, 62);
            this.txt10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt10.MaxLength = 0;
            this.txt10.Name = "txt10";
            this.txt10.Size = new System.Drawing.Size(117, 21);
            this.txt10.TabIndex = 116;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(835, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 118;
            this.label10.Text = "입고단가";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(607, 62);
            this.txt9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt9.MaxLength = 0;
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(222, 21);
            this.txt9.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(568, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 117;
            this.label11.Text = "규격";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb품목구분
            // 
            this.cmb품목구분.FormattingEnabled = true;
            this.cmb품목구분.Location = new System.Drawing.Point(863, 8);
            this.cmb품목구분.Name = "cmb품목구분";
            this.cmb품목구분.Size = new System.Drawing.Size(152, 20);
            this.cmb품목구분.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(782, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 113;
            this.label8.Text = "품목구분";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(450, 62);
            this.txt8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt8.MaxLength = 0;
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(98, 21);
            this.txt8.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 112;
            this.label4.Text = "사용구분";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(87, 62);
            this.txt7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt7.MaxLength = 0;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(298, 21);
            this.txt7.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(782, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 12);
            this.label9.TabIndex = 109;
            this.label9.Text = "그룹명3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 106;
            this.label7.Text = "검색창내용";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(863, 35);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt6.MaxLength = 0;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(152, 21);
            this.txt6.TabIndex = 5;
            this.txt6.Enter += new System.EventHandler(this.txt_Enter);
            this.txt6.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 104;
            this.label6.Text = "구매처명";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(607, 35);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.MaxLength = 0;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(153, 21);
            this.txt5.TabIndex = 4;
            this.txt5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt5.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "그룹명";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(317, 35);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(231, 21);
            this.txt4.TabIndex = 3;
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(12, 89);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(87, 35);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.MaxLength = 0;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(153, 21);
            this.txt3.TabIndex = 2;
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(317, 8);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(443, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "그룹명2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(87, 8);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(153, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "품목코드";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "품목명";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pan등록
            // 
            this.pan등록.BackColor = System.Drawing.Color.White;
            this.pan등록.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan등록.Controls.Add(this.cmb품목구분0);
            this.pan등록.Controls.Add(this.label12);
            this.pan등록.Controls.Add(this.txt조회);
            this.pan등록.Controls.Add(this.btn엑셀_불러오기);
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
            this.pan등록.Size = new System.Drawing.Size(1334, 50);
            this.pan등록.TabIndex = 99;
            // 
            // cmb품목구분0
            // 
            this.cmb품목구분0.FormattingEnabled = true;
            this.cmb품목구분0.Location = new System.Drawing.Point(643, 13);
            this.cmb품목구분0.Name = "cmb품목구분0";
            this.cmb품목구분0.Size = new System.Drawing.Size(116, 20);
            this.cmb품목구분0.TabIndex = 154;
            this.cmb품목구분0.SelectedIndexChanged += new System.EventHandler(this.cmb품목구분0_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(584, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 153;
            this.label12.Text = "품목구분";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt조회
            // 
            this.txt조회.Location = new System.Drawing.Point(380, 13);
            this.txt조회.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회.MaxLength = 0;
            this.txt조회.Name = "txt조회";
            this.txt조회.Size = new System.Drawing.Size(198, 21);
            this.txt조회.TabIndex = 152;
            this.txt조회.TextChanged += new System.EventHandler(this.txt조회_TextChanged);
            // 
            // btn엑셀_불러오기
            // 
            this.btn엑셀_불러오기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_불러오기.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_불러오기.Image")));
            this.btn엑셀_불러오기.Location = new System.Drawing.Point(1169, 3);
            this.btn엑셀_불러오기.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_불러오기.Name = "btn엑셀_불러오기";
            this.btn엑셀_불러오기.Size = new System.Drawing.Size(120, 40);
            this.btn엑셀_불러오기.TabIndex = 151;
            this.btn엑셀_불러오기.Text = " 엑셀불러오기";
            this.btn엑셀_불러오기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_불러오기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_불러오기.UseVisualStyleBackColor = true;
            this.btn엑셀_불러오기.Click += new System.EventHandler(this.btn엑셀_불러오기_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(1046, 7);
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
            this.btnAdd.Location = new System.Drawing.Point(868, 7);
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
            this.btnEdit.Location = new System.Drawing.Point(957, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.Text = "    수 정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btninit
            // 
            this.btninit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninit.Image = ((System.Drawing.Image)(resources.GetObject("btninit.Image")));
            this.btninit.Location = new System.Drawing.Point(771, 7);
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
            // frm기초데이타_품목등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 615);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.pan데이타);
            this.Controls.Add(this.pan등록);
            this.Name = "frm기초데이타_품목등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frm기초데이타_품목등록";
            this.Text = "품목 등록";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm기초데이타_품목등록_Load);
            this.Resize += new System.EventHandler(this.frm기초데이타_품목등록_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan데이타.ResumeLayout(false);
            this.pan데이타.PerformLayout();
            this.pan등록.ResumeLayout(false);
            this.pan등록.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan데이타;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan등록;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btninit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl타이틀;
        private System.Windows.Forms.TextBox txt8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb품목구분;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn엑셀_불러오기;
        private System.Windows.Forms.ComboBox cmb품목구분0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt조회;
    }
}