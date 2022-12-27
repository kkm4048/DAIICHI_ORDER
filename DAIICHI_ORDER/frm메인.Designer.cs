namespace DAIICHI_ORDER
{
    partial class frm메인
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm메인));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기초데이타ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_거래처별품목등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_품목등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.m기초데이타_검색명등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.m기초데이타_품목명등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_색상명등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_사이즈등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.m기초데이타_사용자등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초데이타_거래처등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.발주관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.발주드옭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ss = new System.Windows.Forms.StatusStrip();
            this.tss = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.ss.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.기초데이타ToolStripMenuItem,
            this.발주관리ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일_설정,
            this.toolStripMenuItem1,
            this.종료ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.파일ToolStripMenuItem.Text = "파 일";
            // 
            // m파일_설정
            // 
            this.m파일_설정.Name = "m파일_설정";
            this.m파일_설정.Size = new System.Drawing.Size(102, 22);
            this.m파일_설정.Text = "설 정";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.종료ToolStripMenuItem.Text = "종 료";
            // 
            // 기초데이타ToolStripMenuItem
            // 
            this.기초데이타ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m기초데이타_거래처별품목등록,
            this.m기초데이타_품목등록,
            this.toolStripMenuItem5,
            this.m기초데이타_검색명등록,
            this.toolStripMenuItem4,
            this.m기초데이타_품목명등록,
            this.m기초데이타_색상명등록,
            this.m기초데이타_사이즈등록,
            this.toolStripMenuItem2,
            this.m기초데이타_사용자등록,
            this.m기초데이타_거래처등록});
            this.기초데이타ToolStripMenuItem.Name = "기초데이타ToolStripMenuItem";
            this.기초데이타ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.기초데이타ToolStripMenuItem.Text = "기초 데이타";
            // 
            // m기초데이타_거래처별품목등록
            // 
            this.m기초데이타_거래처별품목등록.Name = "m기초데이타_거래처별품목등록";
            this.m기초데이타_거래처별품목등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_거래처별품목등록.Text = "거래처별 품목 등록";
            this.m기초데이타_거래처별품목등록.Click += new System.EventHandler(this.m기초데이타_거래처별품목등록_Click);
            // 
            // m기초데이타_품목등록
            // 
            this.m기초데이타_품목등록.Name = "m기초데이타_품목등록";
            this.m기초데이타_품목등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_품목등록.Text = "품목 등록";
            this.m기초데이타_품목등록.Click += new System.EventHandler(this.m기초데이타_품목등록_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(175, 6);
            // 
            // m기초데이타_검색명등록
            // 
            this.m기초데이타_검색명등록.Name = "m기초데이타_검색명등록";
            this.m기초데이타_검색명등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_검색명등록.Text = "검색명 등록";
            this.m기초데이타_검색명등록.Click += new System.EventHandler(this.m기초데이타_검색명등록_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(175, 6);
            // 
            // m기초데이타_품목명등록
            // 
            this.m기초데이타_품목명등록.Name = "m기초데이타_품목명등록";
            this.m기초데이타_품목명등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_품목명등록.Text = "품목명 등록";
            this.m기초데이타_품목명등록.Click += new System.EventHandler(this.m기초데이타_품목명등록_Click);
            // 
            // m기초데이타_색상명등록
            // 
            this.m기초데이타_색상명등록.Name = "m기초데이타_색상명등록";
            this.m기초데이타_색상명등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_색상명등록.Text = "색상명 등록";
            this.m기초데이타_색상명등록.Click += new System.EventHandler(this.m기초데이타_색상명등록_Click);
            // 
            // m기초데이타_사이즈등록
            // 
            this.m기초데이타_사이즈등록.Name = "m기초데이타_사이즈등록";
            this.m기초데이타_사이즈등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_사이즈등록.Text = "사이즈 등록";
            this.m기초데이타_사이즈등록.Click += new System.EventHandler(this.m기초데이타_사이즈등록_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(175, 6);
            // 
            // m기초데이타_사용자등록
            // 
            this.m기초데이타_사용자등록.Name = "m기초데이타_사용자등록";
            this.m기초데이타_사용자등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_사용자등록.Text = "사용자 등록";
            this.m기초데이타_사용자등록.Click += new System.EventHandler(this.m기초데이타_사용자등록_Click);
            // 
            // m기초데이타_거래처등록
            // 
            this.m기초데이타_거래처등록.Name = "m기초데이타_거래처등록";
            this.m기초데이타_거래처등록.Size = new System.Drawing.Size(178, 22);
            this.m기초데이타_거래처등록.Text = "거래처 등록";
            this.m기초데이타_거래처등록.Click += new System.EventHandler(this.m기초데이타_거래처등록_Click);
            // 
            // 발주관리ToolStripMenuItem
            // 
            this.발주관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.발주드옭ToolStripMenuItem});
            this.발주관리ToolStripMenuItem.Name = "발주관리ToolStripMenuItem";
            this.발주관리ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.발주관리ToolStripMenuItem.Text = "발주 관리";
            // 
            // 발주드옭ToolStripMenuItem
            // 
            this.발주드옭ToolStripMenuItem.Name = "발주드옭ToolStripMenuItem";
            this.발주드옭ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.발주드옭ToolStripMenuItem.Text = "발주 등록";
            this.발주드옭ToolStripMenuItem.Click += new System.EventHandler(this.발주드옭ToolStripMenuItem_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(451, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(109, 24);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // ss
            // 
            this.ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss});
            this.ss.Location = new System.Drawing.Point(0, 697);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(1315, 22);
            this.ss.TabIndex = 5;
            this.ss.Text = "statusStrip1";
            // 
            // tss
            // 
            this.tss.Name = "tss";
            this.tss.Size = new System.Drawing.Size(31, 17);
            this.tss.Text = "알림";
            // 
            // frm메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 719);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "다이치 v1.1 221224";
            this.Load += new System.EventHandler(this.frm메인_Load);
            this.Resize += new System.EventHandler(this.frm메인_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ss.ResumeLayout(false);
            this.ss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m파일_설정;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기초데이타ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_품목등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_사용자등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_거래처등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_거래처별품목등록;
        private System.Windows.Forms.ToolStripMenuItem 발주관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 발주드옭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_검색명등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_색상명등록;
        private System.Windows.Forms.StatusStrip ss;
        private System.Windows.Forms.ToolStripStatusLabel tss;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_품목명등록;
        private System.Windows.Forms.ToolStripMenuItem m기초데이타_사이즈등록;
    }
}

