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
    public partial class frm기타_거래처별_품목_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_거래처별_품목_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_거래처별_품목_엑셀불러오기(string iFileName)
        {
            InitializeComponent();
            rFileName = iFileName;
        }
        private void LoadExcel()
        {

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // sprList.ActiveSheet.OpenExcel(rfileName, 0);
                spr.OpenExcel(rFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Cursor.Current = Cursors.Default;

        }

        private void frm기타_거래처별_품목_엑셀불러오기_Load(object sender, EventArgs e)
        {
            lbl메세지.Text = "";
            lbl메세지2.Text = "";
            Add거래처명();
            LoadExcel();
            초기화();
         }
        private void Add거래처명()
        {
            sql = " exec s_a101_거래처_조회 '1' ,'','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb거래처명.Items.Clear();
            cmb거래처명.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb거래처명.Items.Add(ds.Tables[0].Rows[i]["거래처명"].ToString());
            }
        }
        private void 초기화()
        {

            헤드();            

        }
        private void 헤드()
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "거래처 품목코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "거래처 품목명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "거래처 옵션";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "품목코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "품목묭";
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 40;
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }

        private void 저장()
        {

            int i, j,cnt=0;
            int cnt2 = 0;
            String[] b = new String[100];
            String[] 데이타 = new string[100];
            string 거래처명 = "";
            String 품목명="",색상 = "", 사이즈 = "";
            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }

            거래처명 = spr.ActiveSheet.SheetName.ToString().Trim();

            if (!cmb거래처명.Text.Equals(거래처명))
            {
                DialogResult dr = MessageBox.Show("선택한 거래처하고 Sheet 거래처가 다릅니다. \n" + cmb거래처명.Text + "   " + 거래처명 + "\n그래도 저장 하시겠습니까 ?", "거래처확인",MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return;
            }
            
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                for (j = 0; j < 10; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                }

                
                if (b[0].Trim().Equals("") || b[2].Trim().Equals(""))
                {
                    cnt2++;
                    if (cnt2 > 50 )
                    {
                        MessageBox.Show(cnt.ToString() + " 건 저장완료 ");
                        return;
                    }
                    continue;
                }
                if (cb품목명.Checked)
                {
                    품목명 = cls_엑셀.품목명(b[2]);
                }
                if (cb색상.Checked)
                {
                    색상 = cls_엑셀.색상(b[2]);
                }
                if (cb사이즈.Checked)
                {
                    사이즈 = cls_엑셀.사이즈(b[2]);
                }
                cnt2 = 0;
                sql = "";
                sql = sql + " exec s_a101_품목_거래처_엑셀_저장 '1' " ;
                sql = sql + ",'" + cmb거래처명.Text  + "' ";
                sql = sql + ",'" + b[3].Trim() + "' ";
                sql = sql + ",'" + b[0].Trim() + "' ";
                sql = sql + ",'" + b[2].Trim() + "' ";
                sql = sql + ",'" + 품목명 + "' ";
                sql = sql + ",'" + 색상  + "' ";
                sql = sql + ",'" + 사이즈  + "' ";

                cls_com.ExcuteNonQuery(sql);
                cnt++;
               
                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }

        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.FilterIndex = 1;     // FilterIndex는 1부터 시작 (여기서는 *.txt)
            openFileDialog.RestoreDirectory = true;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    spr.OpenExcel(openFileDialog.FileName);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
            헤드();
        }

        private void spr_SheetTabClick(object sender, FarPoint.Win.Spread.SheetTabClickEventArgs e)
        {
            헤드();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

        private void spr_TabIndexChanged(object sender, EventArgs e)
        {
            헤드();
        }

        private void cmb거래처명_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회0();
        }
        private void 조회0()
        {
            //SPEC

            cb품목명.Checked = false;
            cb색상.Checked = false;
            cb사이즈.Checked = false;

            sql = " exec s_a101_엑셀_품목명검색조건_조회 '1','" + cmb거래처명.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["품목명"].ToString().Equals(""))
                {
                    cb품목명.Checked = true;
                }
                if (!ds.Tables[0].Rows[0]["색상"].ToString().Equals(""))
                {
                    cb색상.Checked = true;
                }
                if (!ds.Tables[0].Rows[0]["사이즈"].ToString().Equals(""))
                {
                    cb사이즈.Checked = true;
                }

            }
        }
        private void 검증()
        {

            int j;
            int icnt = 0,icnt2= 0,icnt3 = 0  ;
            string 품목명 = "", 색상 = "", 사이즈 = "";
            String[] b = new String[100];
            lbl메세지.Text = "";
            lbl메세지2.Text = "";
            string 거래처_품목코드 = "";
            string 거래처명 = "";
            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }

            거래처명 = spr.ActiveSheet.SheetName.ToString().Trim();

            if (!cmb거래처명.Text.Equals(거래처명))
            {
                DialogResult dr = MessageBox.Show("선택한 거래처하고 Sheet 거래처가 다릅니다. \n" + cmb거래처명.Text + "   " + 거래처명 + "\n그래도 저장 하시겠습니까 ?", "거래처확인",MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return;
            }



            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                거래처_품목코드 = spr.ActiveSheet.Cells[i, 0].Text.Trim();
                if (거래처_품목코드.Equals("") || cls_com.한글여부(거래처_품목코드)) {
                    icnt++;
                } else
                {
                    spr.ActiveSheet.Cells[i, 5].Text = "";
                    spr.ActiveSheet.Cells[i, 0].BackColor = Color.White;
                    for (j = 0; j < 10; j++)
                    {
                        b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                    }

                    if (b[0].Equals("") )
                    {
                        icnt3++;
                        spr.ActiveSheet.Cells[i, 0].BackColor = Color.Pink;
                        spr.ActiveSheet.Cells[i, 5].Text = "거래처코드 에러";
                        continue;
                    }

                    if (cb품목명.Checked)
                    {
                        품목명 = cls_엑셀.품목명(b[2]);
                    }
                    if (cb색상.Checked)
                    {
                        색상 = cls_엑셀.색상(b[2]);
                    }
                    if (cb사이즈.Checked)
                    {
                        사이즈 = cls_엑셀.사이즈(b[2]);
                    }



                    sql = " exec s_a101_품목_조회 '1','" + b[3] +"','','','',''  ";
                    DataSet ds = cls_com.Select_Query(sql);
                    if (ds.Tables[0].Rows.Count > 0 )
                    {
                        spr.ActiveSheet.Cells[i, 0].BackColor = Color.White;
                        icnt2++;
                        lbl메세지2.Text = "등록: " + icnt2.ToString();
                    }
                    else
                    {
                        spr.ActiveSheet.Cells[i, 0].BackColor = Color.Pink;
                        icnt3++;
                        spr.ActiveSheet.Cells[i, 5].Text = "미등록 품목코드 ";
                    }
                    icnt = 0; 
                }

                if  ( icnt > 50 )
                {
                    if (icnt2 > 0 )
                    {
                        lbl메세지2.Text = "등록: " + icnt2.ToString();
                    }
                    if (icnt3 > 0)
                    {
                        lbl메세지2.Text = "미등록: " + icnt3.ToString();
                    }
                    MessageBox.Show("검증 완료");
                    return;
                }
                Application.DoEvents();
            }
            
        }

        private void lbl메세지_Click(object sender, EventArgs e)
        {

        }

        private void lbl메세지2_Click(object sender, EventArgs e)
        {

        }

        private void btn검증_Click(object sender, EventArgs e)
        {
            검증();
        }

        private void spr_EditModeOff(object sender, EventArgs e)
        {
            /*
            string 상품명;
            int i; 
            i = spr.ActiveSheet.ActiveRow.Index;
            if (i < 0) return;

            if (spr.ActiveSheet.ActiveCell.Column.Index == 3)  // 상품 가져오기
            {
                상품명 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, spr.ActiveSheet.ActiveCell.Column.Index].Text;
                frm기타_품목조회 frm기타_품목조회 = new frm기타_품목조회();
                frm기타_품목조회.txt조회.Text = 상품명;

                frm기타_품목조회.ShowDialog();
                if (!frm기타_품목조회.r품목코드.Equals(""))
                {
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 2].Text = frm기타_품목조회.r품목코드;
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 3].Text = frm기타_품목조회.r품목명;
                    spr.ActiveSheet.Cells.Get(spr.ActiveSheet.ActiveCell.Row.Index, 2, spr.ActiveSheet.ActiveCell.Row.Index, 3).BackColor = cls_color.gColor_수정;
                }
            }
            */
        }
    }

}
