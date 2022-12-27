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
    public partial class frm발주관리_발주등록 : Form
    {

        string sql = "";
        frm기초데이타_거래처별품목등록 frm기초데이타_거래처별품목등록;
        public frm발주관리_발주등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm발주관리_발주등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            dtp.Value = cls_com.GetDate();
            Add거래처명();
            초기화();
            lbl에러.Text = "";
            lbl정상.Text = "";
            lbl에러2.Text = "";
            조회2();

            string d;
            d = cls_com.ConfigLoad(this.Name + "_sc넓이","500");
            sc.SplitterDistance = cls_com.Val(d);
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회2();
        }

        private void 조회()
        {
            //SPEC


            sql = " exec s_a101_거래처_조회 '1','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            cls_com.Sort표시(spr.ActiveSheet);
            if (ds.Tables[0].Rows.Count > 0)
            {
                FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
                tc.Multiline = true;
                tc.WordWrap = true;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {
            /*
            sql = " ";
            sql = sql + "EXEC [s_a101_거래처_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + cmb엑셀양식명.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            */
            조회();
        }
        private void 수정()
        {
            /*
            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "거래처 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_거래처_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + cmb엑셀양식명.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
            */
        }
        private void 삭제()
        {
            /*
            if (MessageBox.Show("삭제 하시겠습니까 ? ", "거래처 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_거래처_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + cmb엑셀양식명.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
            */
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            /*
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            cmb엑셀양식명.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            */
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            
            

        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.Yellow;

        }

        private void btn엑셀_발주서불러오기_Click(object sender, EventArgs e)
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
        private void 헤드()
        {
            cls_엑셀.엑셀양식_타이틀(cmb거래처명.Text, spr);
        }

        private void cmb거래처명_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_엑셀.엑셀양식_타이틀(cmb거래처명.Text, spr);
            cls_엑셀.엑셀위치(cmb거래처명.Text);
            조회2();
        }

        private void btn검증_Click(object sender, EventArgs e)
        {
            검증();
        }
        private void 검증()
        {
            int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt_정상 = 0, cnt_에러 = 0; ;
            
            string  발주서번호 = "", 출고일자 = "", 품목코드 = "", 품목명 = "", 수량 = "", 금액 = "",색상="",사이즈="",옵션1="",옵션2="";
            string 색상0 = "", 옵션0 = "";
            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }
            for (int i = 0;i < spr.ActiveSheet.RowCount; i++)
            {
                발주서번호 =  cls_엑셀.값가져오기(spr,i, cls_엑셀.s엑셀위치.발주서번호);
                출고일자 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.출고일자);
                품목코드 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.품목코드);
                품목명 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.품목명);
                수량 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.수량);
                금액 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.금액);

                색상0 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.색상);
                옵션0 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.옵션);

                색상 = cls_엑셀.값가져오기(cmb거래처명.Text ,색상0,옵션0,"색상");
                사이즈 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "사이즈");
                옵션1 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션1");
                옵션2 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션2");

                if (cls_com.한글여부(발주서번호)  || 발주서번호.Equals("") || 품목코드.Equals("") )
                {
                    cnt2++;
                    if (cnt2 > 20)
                    {
                        MessageBox.Show("검증 완료");
                        spr.Focus();
                        return;
                    }
                    continue;
                }
                cnt2 = 0;
                cnt1++;

                sql = " exec s_a301_발주_품목_거래처_조회 '1','" + cmb거래처명.Text + "','','" + 품목코드 + "','','','" + 색상 + "','" + 사이즈 + "','" + 옵션1 + "','" + 옵션2 + "'   ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].Text = "";
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].BackColor = Color.White;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.품목코드].BackColor = Color.White;
                    cnt_정상++;
                }
                else
                {
                    cnt3++;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].Text = "미등록";
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].BackColor = Color.Pink;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.품목코드].BackColor = Color.Pink;
                    cnt_에러++;
                    if (cnt_에러==1)
                    {
                        spr.ActiveSheet.SetActiveCell(i, cls_엑셀.s엑셀위치.품목명);
                        spr.ShowActiveCell(FarPoint.Win.Spread.VerticalPosition.Center, FarPoint.Win.Spread.HorizontalPosition.Center);
                    }
                }
                lblCnt.Text = cnt1.ToString();
                if (cnt_에러 > 0)
                {
                    lbl에러.Text = cnt_에러.ToString();
                }
                else
                {
                    lbl에러.Text = "";
                }

                if (cnt_정상 > 0)
                {
                    lbl정상.Text = cnt_정상.ToString();
                }
                else
                {
                    lbl정상.Text = "";
                }

            }
        }

        private void spr_EditModeOn(object sender, EventArgs e)
        {
            string 거래처_품목코드 = "",거래처_품목명="",색상0="",옵션0="";
            string 색상 = "", 사이즈 = "", 옵션1 = "", 옵션2 = "";
            int i;
            char[] arr2;
            i = spr.ActiveSheet.ActiveRow.Index;
            if (i < 0) return;

            if (spr.ActiveSheet.ActiveCell.Column.Index == cls_엑셀.s엑셀위치.품목명)  // 상품 가져오기
            {
                거래처_품목코드 = cls_엑셀.값가져오기(spr, cls_엑셀.s엑셀위치.품목코드);
                거래처_품목명 = cls_엑셀.값가져오기(spr, cls_엑셀.s엑셀위치.품목명);
                색상0 = cls_엑셀.값가져오기(spr, cls_엑셀.s엑셀위치.색상);
                옵션0 = cls_엑셀.값가져오기(spr, cls_엑셀.s엑셀위치.옵션);

                색상 = cls_엑셀.값가져오기(cmb거래처명.Text ,색상0,옵션0,"색상");
                사이즈 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "사이즈");
                옵션1 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션1");
                옵션2= cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션2");


                arr2 = cls_엑셀.s엑셀위치.구분문자.ToCharArray();
                if (arr2.Length > 0)
                {
                    거래처_품목명 = cls_엑셀.품목명가져오기(거래처_품목명, arr2[0]);
                }

                frm기초데이타_거래처별품목등록 = new frm기초데이타_거래처별품목등록();
                frm기초데이타_거래처별품목등록.r구분 = "발주등록";
                frm기초데이타_거래처별품목등록.cmb거래처명.Text = cmb거래처명.Text;


                frm기초데이타_거래처별품목등록.Show();
                frm기초데이타_거래처별품목등록.행추가();
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 3].Text = 거래처_품목코드;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 4].Text = 거래처_품목명;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 2].Text = 거래처_품목명;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 8].Text = 색상;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 9].Text = 사이즈;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 10].Text = 옵션1;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.Cells[frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 11].Text = 옵션2;
                frm기초데이타_거래처별품목등록.spr.ActiveSheet.SetActiveCell(frm기초데이타_거래처별품목등록.spr.ActiveSheet.RowCount - 1, 2);
                tMost.Enabled = true;
                ;



                /*
                if (!frm기초데이타_거래처별품목등록.r품목코드.Equals(""))
                {
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 2].Text = frm기초데이타_거래처별품목등록.r품목코드;
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 3].Text = frm기초데이타_거래처별품목등록.r품목명;
                    spr.ActiveSheet.Cells.Get(spr.ActiveSheet.ActiveCell.Row.Index, 2, spr.ActiveSheet.ActiveCell.Row.Index, 3).BackColor = cls_color.gColor_수정;
                }
                */
            }
        }

        private void tMost_Tick(object sender, EventArgs e)
        {
            tMost.Enabled = false;
            frm기초데이타_거래처별품목등록.TopMost = true;
            frm기초데이타_거래처별품목등록.TopMost = false;
            frm기초데이타_거래처별품목등록.spr_EditModeOff(null, null);

        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString());
        }

        private void btn저장_Click(object sender, EventArgs e)
        {
            저장();
        }
        private void 저장()
        {
            int cnt1 = 0, cnt2 = 0, cnt3 = 0, cnt_정상 = 0, cnt_에러 = 0; ;
            string 발주서번호 = "", 출고일자 = "", 품목코드2 = "", 품목명2 = "", 수량 = "", 금액 = "", 색상 = "", 사이즈="",옵션1 = "",옵션2="";
            string 고객명 = "", 이동전화 = "", 전화번호 = "", 송장번호="",주소 = "", 단가 = "", 공급가액 = "", 부가세 = "" ,사은품구분="";
            string 색상0 = "", 옵션0 = "";
            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }
            for (int i = 0; i < spr.ActiveSheet.RowCount; i++)
            {
                발주서번호 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.발주서번호);
                출고일자 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.출고일자);
                품목코드2 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.품목코드);
                품목명2 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.품목명);
                수량 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.수량);
                금액 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.금액);
                고객명 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.고객명);
                이동전화 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.이동전화);
                전화번호 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.전화번호);
                송장번호 = "";
                주소 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.주소);
                단가 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.단가);
                공급가액 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.공급가액);
                부가세 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.부가세);
                사은품구분 = "";


                색상0 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.색상);
                옵션0 = cls_엑셀.값가져오기(spr, i, cls_엑셀.s엑셀위치.옵션);

                색상 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "색상");
                사이즈 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "사이즈");
                옵션1 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션1");
                옵션2 = cls_엑셀.값가져오기(cmb거래처명.Text, 색상0, 옵션0, "옵션2");

                if (cls_com.한글여부(발주서번호) || 발주서번호.Equals("") || 품목코드2.Equals(""))
                {
                    cnt2++;
                    if (cnt2 > 20)
                    {
                        조회2();
                        MessageBox.Show("저장 완료");
                        spr.Focus();
                        return;
                    }
                    continue;
                }
                cnt2 = 0;
                cnt1++;

                sql = " exec s_a301_발주_품목_거래처_조회 '1','" + cmb거래처명.Text + "','','" + 품목코드2 + "','','','" + 색상 + "','" + 사이즈 + "','" + 옵션1 + "','" + 옵션2 + "'  ";
                DataSet ds = cls_com.Select_Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].Text = "";
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].BackColor = Color.White;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.품목코드].BackColor = Color.White;
                    저장(cmb거래처명.Text ,출고일자,발주서번호,품목코드2,품목명2,색상,사이즈,옵션1,옵션2,수량,금액,고객명,이동전화,전화번호,송장번호,주소,단가,공급가액,부가세,사은품구분);
                    cnt_정상++;
                }
                else
                {
                    cnt3++;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].Text = "미등록";
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.메세지].BackColor = Color.Pink;
                    spr.ActiveSheet.Cells[i, cls_엑셀.s엑셀위치.품목코드].BackColor = Color.Pink;
                    cnt_에러++;
                    if (cnt_에러 == 1)
                    {
                        spr.ActiveSheet.SetActiveCell(i, cls_엑셀.s엑셀위치.품목명);
                        spr.ShowActiveCell(FarPoint.Win.Spread.VerticalPosition.Center, FarPoint.Win.Spread.HorizontalPosition.Center);
                    }
                }
                lblCnt.Text = cnt1.ToString();
                if (cnt_에러 > 0)
                {
                    lbl에러.Text = cnt_에러.ToString();
                }
                else
                {
                    lbl에러.Text = "";
                }

                if (cnt_정상 > 0)
                {
                    lbl정상.Text = cnt_정상.ToString();
                }
                else
                {
                    lbl정상.Text = "";
                }


            }


        }
        private void 저장(string 거래처명,string 출고일자,string 발주번호, string 품목코드2, string 품목명2,  string 색상, string 사이즈,string 옵션1,string 옵션2, string 수량, string 금액, string 고객명, string 이동전화
            , string 전화번호, string 송장번호 , string 주소, string 단가, string 공급가액, string 부가세, string 사은품구분)
        {
            string[] arr = null;
            string[][] arr_옵션 = null;
            char[] arr2;
            string 품목코드 = "";
            string 품목명22 = "";
            금액 = cls_com.숫자만(금액);
            cls_엑셀.옵션2Arr(거래처명, 옵션1, ref arr_옵션);

            sql = "exec s_a301_발주_데이타_저장  '3','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + 거래처명 + "','" + 출고일자 + "' "
                + ",'" + 발주번호 + "','','','','" + 품목코드2 + "','','" + 품목명2 + "','" + 색상 + "','" + 사이즈 + "','" + 옵션1 + "','" + 옵션2 + "','" + 수량 + "','" + 금액 + "' "
                +",'" + 고객명 + "','" + 이동전화 + "','" + 전화번호 + "','" + 송장번호 + "','" + 주소 + "','" +단가 + "','" + 공급가액 + "','" + 부가세 + "','" + 사은품구분 + "' ";
            cls_com.ExcuteNonQuery(sql);


            arr2 = cls_엑셀.s엑셀위치.구분문자.ToCharArray();
            if (arr2.Length > 0)
            {
                arr = 품목명2.Split(arr2[0]);
            } else
            {

                Array.Resize(ref arr, 1);

            }
            for (int i = 0; i < arr.Length;i++)
            {
                품목코드 = "";
                품목명22 = arr[i];
                if (i == 0)
                {
                   
                } else
                {
                    sql = " exec s_a101_품목_거래처_구성품_조회 '3','" + 거래처명 + "','" + 품목코드2 + "','" + 품목명22 + "','','' ";
                    DataSet ds0 = cls_com.Select_Query(sql);
                    if (ds0.Tables[0].Rows.Count > 0)
                    {
                        품목코드2 = "";
                        품목코드 = ds0.Tables[0].Rows[0]["품목코드"].ToString();
                    }
                    else
                    {
                        품목코드2 = "";
                        품목코드 = "";

                    }
                }
                if (i > 0)
                {
                    if (!품목코드.Equals(""))
                    {
                        sql = "exec s_a301_발주_데이타_저장 '1','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + 거래처명 + "','" + 출고일자 + "' "
                            + ",'" + 발주번호 + "','','','" + 품목코드 + "','" + 품목코드2 + "','','" + 품목명22 + "','" + 색상 + "','" + 사이즈 + "','" + 옵션1 + "','" + 옵션2 +  "','" + 수량 + "','" + 금액 + "' "
                            + ",'" + 고객명 + "','" + 이동전화 + "','" + 전화번호 + "','" + 송장번호 + "','" + 주소 + "','" + 단가 + "','" + 공급가액 + "','" + 부가세 + "','" + 사은품구분 + "' ";
                        DataSet ds = cls_com.Select_Query(sql);
                        if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                        {
                            MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                        }
                    }
                } else
                {
                    sql = "exec s_a301_발주_데이타_저장 '1','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + 거래처명 + "','" + 출고일자 + "' "
                        + ",'" + 발주번호 + "','','','" + 품목코드 + "','" + 품목코드2 + "','','" + 품목명2 + "','" + 색상 + "','" + 사이즈 + "','" + 옵션1  +"','" +  옵션2 + "','" + 수량 + "','" + 금액 + "' "
                        + ",'" + 고객명 + "','" + 이동전화 + "','" + 전화번호 + "','" + 송장번호 + "','" + 주소 + "','" + 단가 + "','" + 공급가액 + "','" + 부가세 + "','" + 사은품구분 + "' ";
                    DataSet ds = cls_com.Select_Query(sql);
                    if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                    {
                        MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    }


                    sql = "exec s_a301_발주_데이타_필수구성품_저장  '1','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + 거래처명 + "','" + 출고일자 + "' "
                     + ",'" + 발주번호 + "','','','','" + 품목코드2 + "','','" + 품목명2 + "','" + 색상 + "','" + 사이즈 + "','" + 옵션1 + "','" + 옵션2 + "','" + 수량 + "','" + 금액 + "' "
                     + ",'" + 고객명 + "','" + 이동전화 + "','" + 전화번호 + "','" + 송장번호 + "','" + 주소 + "','" + 단가 + "','" + 공급가액 + "','" + 부가세 + "','" + 사은품구분 + "' ";
                    cls_com.ExcuteNonQuery(sql);


                }

            }
            
        }

        private void 조회2()
        {
            sql = " exec s_a301_발주_데이타_조회 '1','" + cmb거래처명.Text + "','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp.Value) + "','','','','','','',''";
            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            spr2.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
       //     cls_com.Sort표시(spr.ActiveSheet);
            if (ds.Tables[0].Rows.Count > 0)
            {

                //                FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
                //              tc.Multiline = true;
                //            tc.WordWrap = true;



                //        spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
           //     spr2.Sheets[0].Cells.Get(0, spr.Sheets[0].ColumnCount - 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;

            }
            spr2.ActiveSheet.SetColumnMerge(4, FarPoint.Win.Spread.Model.MergePolicy.Always);
            spr2.ActiveSheet.SetColumnMerge(5, FarPoint.Win.Spread.Model.MergePolicy.Always);

            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
            Cursor.Current = Cursors.Default;

        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            조회2();
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }


        private void 전체삭제()
        {

            DialogResult dr = MessageBox.Show("발주데이타를 전체 삭제 하시겠습니까?", "전체삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            sql = "exec s_a301_발주_데이타_저장  '32','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + cmb거래처명.Text + "','" + cls_com.GetDate(dtp.Value) + "' "
                + ",'','','','','','','','','','','','','','','','','','','','','','' ";
            cls_com.ExcuteNonQuery(sql);
            조회2();
        }

        private void pan데이타_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn저장2_Click(object sender, EventArgs e)
        {

        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
        }

        private void spr2_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            string 번호2 = "", 거래처_품번 = "",구성품명;
            if (e.Column ==10 )
            {
                번호2 = spr2.ActiveSheet.Cells[e.Row, 6].Text;
                구성품명  = spr2.ActiveSheet.Cells[e.Row, 10].Text;
                for (int i = e.Row; i >=0; i-- )
                {
                    if (spr2.ActiveSheet.Cells[i,6].Text.Equals("1"))
                    {
                        거래처_품번 = spr2.ActiveSheet.Cells[i,9].Text;

                        frm기초데이타_거래처구성품등록 frm기초데이타_거래처구성품등록 = new frm기초데이타_거래처구성품등록(cmb거래처명.Text ,거래처_품번,구성품명);
                        frm기초데이타_거래처구성품등록.ShowDialog();


                        break;
                    }
                }

            }

        }

        private void btn전체삭제_Click(object sender, EventArgs e)
        {
            전체삭제();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            int irow;
            string 발주번호,번호,번호2,품목명;
            irow = spr2.ActiveSheet.ActiveRow.Index;
            if (irow < 0) return;
            발주번호 = spr2.ActiveSheet.Cells[irow, 4].Text;
            번호 = spr2.ActiveSheet.Cells[irow, 5].Text;
            번호2 = spr2.ActiveSheet.Cells[irow, 6].Text;
            품목명 = spr2.ActiveSheet.Cells[irow, 8].Text;


            DialogResult dr = MessageBox.Show(발주번호 + "\n" + 번호2 + " " + 품목명  + "\n\n 삭제 하시겠습니까 ?", "선택 삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            sql = "exec s_a301_발주_데이타_저장 '3','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetTime() + "','" + cmb거래처명.Text + "',''"
                       + ",'" + 발주번호 + "','" + 번호 + "','" + 번호2 + "','','','','','','','','','','','','','','','','','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회2();

        }
    }
}
