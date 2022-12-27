namespace DAIICHI_ORDER
{
    partial class frm기타_거래처별_품목_엑셀불러오기
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기타_거래처별_품목_엑셀불러오기));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl메세지2 = new System.Windows.Forms.Label();
            this.lbl메세지 = new System.Windows.Forms.Label();
            this.btn엑셀_불러오기 = new System.Windows.Forms.Button();
            this.btn검증 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb거래처명 = new System.Windows.Forms.ComboBox();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.btn저장 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.gb품목검색조건 = new System.Windows.Forms.GroupBox();
            this.cb사이즈 = new System.Windows.Forms.CheckBox();
            this.cb색상 = new System.Windows.Forms.CheckBox();
            this.cb품목명 = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.gb품목검색조건.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gb품목검색조건);
            this.panel2.Controls.Add(this.lbl메세지2);
            this.panel2.Controls.Add(this.lbl메세지);
            this.panel2.Controls.Add(this.btn엑셀_불러오기);
            this.panel2.Controls.Add(this.btn검증);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb거래처명);
            this.panel2.Controls.Add(this.lblCnt2);
            this.panel2.Controls.Add(this.lblCnt);
            this.panel2.Controls.Add(this.btn저장);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 70);
            this.panel2.TabIndex = 97;
            // 
            // lbl메세지2
            // 
            this.lbl메세지2.AutoSize = true;
            this.lbl메세지2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl메세지2.ForeColor = System.Drawing.Color.Blue;
            this.lbl메세지2.Location = new System.Drawing.Point(560, 54);
            this.lbl메세지2.Name = "lbl메세지2";
            this.lbl메세지2.Size = new System.Drawing.Size(44, 12);
            this.lbl메세지2.TabIndex = 155;
            this.lbl메세지2.Text = "메세지";
            this.lbl메세지2.Click += new System.EventHandler(this.lbl메세지2_Click);
            // 
            // lbl메세지
            // 
            this.lbl메세지.AutoSize = true;
            this.lbl메세지.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl메세지.ForeColor = System.Drawing.Color.Red;
            this.lbl메세지.Location = new System.Drawing.Point(465, 54);
            this.lbl메세지.Name = "lbl메세지";
            this.lbl메세지.Size = new System.Drawing.Size(44, 12);
            this.lbl메세지.TabIndex = 154;
            this.lbl메세지.Text = "메세지";
            this.lbl메세지.Click += new System.EventHandler(this.lbl메세지_Click);
            // 
            // btn엑셀_불러오기
            // 
            this.btn엑셀_불러오기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn엑셀_불러오기.Image = ((System.Drawing.Image)(resources.GetObject("btn엑셀_불러오기.Image")));
            this.btn엑셀_불러오기.Location = new System.Drawing.Point(944, 5);
            this.btn엑셀_불러오기.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.btn엑셀_불러오기.Name = "btn엑셀_불러오기";
            this.btn엑셀_불러오기.Size = new System.Drawing.Size(120, 40);
            this.btn엑셀_불러오기.TabIndex = 153;
            this.btn엑셀_불러오기.Text = " 엑셀불러오기";
            this.btn엑셀_불러오기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn엑셀_불러오기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn엑셀_불러오기.UseVisualStyleBackColor = true;
            this.btn엑셀_불러오기.Click += new System.EventHandler(this.btn엑셀_불러오기_Click);
            // 
            // btn검증
            // 
            this.btn검증.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn검증.Image = ((System.Drawing.Image)(resources.GetObject("btn검증.Image")));
            this.btn검증.Location = new System.Drawing.Point(467, 9);
            this.btn검증.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn검증.Name = "btn검증";
            this.btn검증.Size = new System.Drawing.Size(90, 32);
            this.btn검증.TabIndex = 80;
            this.btn검증.Text = "    검 증";
            this.btn검증.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn검증.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn검증.UseVisualStyleBackColor = true;
            this.btn검증.Click += new System.EventHandler(this.btn검증_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 79;
            this.label2.Text = "거래처명";
            // 
            // cmb거래처명
            // 
            this.cmb거래처명.FormattingEnabled = true;
            this.cmb거래처명.Location = new System.Drawing.Point(276, 16);
            this.cmb거래처명.Name = "cmb거래처명";
            this.cmb거래처명.Size = new System.Drawing.Size(185, 20);
            this.cmb거래처명.TabIndex = 78;
            this.cmb거래처명.SelectedIndexChanged += new System.EventHandler(this.cmb거래처명_SelectedIndexChanged);
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(671, 28);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 44;
            this.lblCnt2.Text = "0";
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(671, 8);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 43;
            this.lblCnt.Text = "0";
            // 
            // btn저장
            // 
            this.btn저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn저장.Image = ((System.Drawing.Image)(resources.GetObject("btn저장.Image")));
            this.btn저장.Location = new System.Drawing.Point(575, 9);
            this.btn저장.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn저장.Name = "btn저장";
            this.btn저장.Size = new System.Drawing.Size(90, 32);
            this.btn저장.TabIndex = 42;
            this.btn저장.Text = "    저 장";
            this.btn저장.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn저장.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn저장.UseVisualStyleBackColor = true;
            this.btn저장.Click += new System.EventHandler(this.btn저장_Click);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(114, 9);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(90, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "    조 회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Visible = false;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(11, 9);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(90, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "    닫 기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "sprList, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 70);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1083, 683);
            this.spr.TabIndex = 98;
            this.spr.EditModeOff += new System.EventHandler(this.spr_EditModeOff);
            this.spr.SheetTabClick += new FarPoint.Win.Spread.SheetTabClickEventHandler(this.spr_SheetTabClick);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            this.spr.TabIndexChanged += new System.EventHandler(this.spr_TabIndexChanged);
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
            // gb품목검색조건
            // 
            this.gb품목검색조건.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gb품목검색조건.Controls.Add(this.cb사이즈);
            this.gb품목검색조건.Controls.Add(this.cb색상);
            this.gb품목검색조건.Controls.Add(this.cb품목명);
            this.gb품목검색조건.Enabled = false;
            this.gb품목검색조건.Location = new System.Drawing.Point(713, 5);
            this.gb품목검색조건.Name = "gb품목검색조건";
            this.gb품목검색조건.Size = new System.Drawing.Size(192, 40);
            this.gb품목검색조건.TabIndex = 157;
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
            // frm기타_거래처별_품목_엑셀불러오기
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 753);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.panel2);
            this.Name = "frm기타_거래처별_품목_엑셀불러오기";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "거래처별 품목 엑셀 불러오기";
            this.Load += new System.EventHandler(this.frm기타_거래처별_품목_엑셀불러오기_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.gb품목검색조건.ResumeLayout(false);
            this.gb품목검색조건.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn저장;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb거래처명;
        private System.Windows.Forms.Button btn검증;
        private System.Windows.Forms.Button btn엑셀_불러오기;
        private System.Windows.Forms.Label lbl메세지;
        private System.Windows.Forms.Label lbl메세지2;
        private System.Windows.Forms.GroupBox gb품목검색조건;
        private System.Windows.Forms.CheckBox cb사이즈;
        private System.Windows.Forms.CheckBox cb색상;
        private System.Windows.Forms.CheckBox cb품목명;
    }
}