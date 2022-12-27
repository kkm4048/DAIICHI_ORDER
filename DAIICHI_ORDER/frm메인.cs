using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAIICHI_ORDER
{
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void m기초데이타_사용자등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_사용자등록");
        }

        private void FrmShow(String formToCall)
        {
            try
            {
                var type = Type.GetType("DAIICHI_ORDER." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {

                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }


        private void FrmShow2(String formToCall)
        {
            try
            {
                var type = Type.GetType("DAIICHI_ORDER." + formToCall);
                Form frm = Activator.CreateInstance(type) as Form;

                if (frm != null)
                {
                    bool FrmisExist = new bool();
                    FrmisExist = false;

                    foreach (Form form1 in Application.OpenForms)
                    {
                        if (form1.GetType() == frm.GetType())
                        {

                            form1.Activate();
                            form1.Focus();
                            FrmisExist = true;
                        }
                    }

                    // 폼존재여부에 따라서 생성과 파기
                    if (!FrmisExist)
                    {

                        frm.MdiParent = this;
                        frm.WindowState = FormWindowState.Maximized;
                        frm.Show();
                        frm.Activate();
                        frm.Focus();
                        frm.BringToFront();
                    }
                    else
                    {
                        frm.Dispose();
                    }
                }
            }
            catch
            {
            }


        }

        private void m기초데이타_품목등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_품목등록");
        }

        private void m기초데이타_거래처등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_거래처등록");
        }


        private void m기초데이타_엑셀양식명_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_엑셀양식명");
        }

        private void m기초데이타_거래처별품목등록_Click(object sender, EventArgs e)
        {
            FrmShow2("frm기초데이타_거래처별품목등록");
        }

        private void 발주드옭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShow2("frm발주관리_발주등록");
        }

        private void frm메인_Resize(object sender, EventArgs e)
        {
            로고위치();
        }

        private void 로고위치()
        {
            picLogo.Left = this.Width - picLogo.Width-100;
        }

        private void frm메인_Load(object sender, EventArgs e)
        {
            로고위치();
            초기화();
        }

        private void 초기화()
        {

        }


        private void m기초데이타_색상명등록_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_색상명등록");
        }

        private void m기초데이타_검색명등록_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_검색명등록");
        }

        private void m기초데이타_품목명등록_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_품목명등록");
        }

        private void m기초데이타_사이즈등록_Click(object sender, EventArgs e)
        {
            FrmShow("frm기초데이타_사이즈등록");
        }
    }
}
