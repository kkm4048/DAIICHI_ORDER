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
    public partial class frm기초데이타_거래처별품목등록 : Form
    {
        private string sql;
        public static string  r구분 ="" ;
        bool r시작 = true;
        int rrow;
        public frm기초데이타_거래처별품목등록()
        {
            InitializeComponent();
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

        private void 조회()
        {
            if (r시작) return;
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            lbl열.Text = "-1";
            lbl메세지.Text = "";
            sql = "";
            sql = sql + "exec  s_a101_품목_거래처_조회  '1' ,'" + cmb거래처명.Text + "','','','' ,'" + cmb품목구분.Text + "','','','','' ,''  ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr.DataSource = ds;
            lbl수량.Text = spr.ActiveSheet.Rows.Count.ToString();
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            cls_com.Sort표시(spr.ActiveSheet);
            if (spr.ActiveSheet.Rows.Count > 0)
            {
                spr.EditModeReplace = true;
                FarPoint.Win.Spread.InputMap im = new FarPoint.Win.Spread.InputMap();
                 im = spr.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap);
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = true;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.White;
                spr.ActiveSheet.Cells.Get(0,2, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = false;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.ActiveSheet);
        }

        private void frm기초데이타_거래처별품목등록_Load(object sender, EventArgs e)
        {
            Add거래처명();
            Add품목구분();
            초기화();
            r시작 = false;
            조회();
        }
        private void Add품목구분()
        {
            sql = "exec s_a101_품목구분_조회 '2','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb품목구분.Items.Clear();
            cmb품목구분.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb품목구분.Items.Add(ds.Tables[0].Rows[i]["품목구분"].ToString());
            }
        }


        private void Add거래처명()
        {
            sql = " exec s_a101_거래처_조회 '1' ,'','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb거래처명.Items.Clear();
            cmb거래처명.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb거래처명.Items.Add(ds.Tables[0].Rows[i]["거래처명"].ToString() );
            }
        }
        private void 초기화()
        {
        }
       

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }


        private void 저장(int irow)
        {

            string 품목코드, 품목명,거래처_품목코드;
            품목코드 = spr.ActiveSheet.Cells[irow, 1].Text;
            품목명 = spr.ActiveSheet.Cells[irow, 2].Text;
            거래처_품목코드  = spr.ActiveSheet.Cells[irow, 3].Text;

            if (품목코드.Equals(""))
            {
                return;
            }
            if (품목명.Equals(""))
            {
                return;
            }
            if (거래처_품목코드.Equals(""))
            {
                return;
            }

            sql = "";
            sql = sql + " exec s_a101_품목_거래처_저장 '1' " ;
            sql = sql + "    ,'" + cmb거래처명.Text + "' ";   // 거래처명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 1].Text + "' ";   // 품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 3].Text + "' ";   // 거래처_품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 4].Text + "' ";   // 거래처_품목코드2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 5].Text + "' ";   // 거래처_품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 6].Text + "' ";   // 거래처_품목명2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 8].Text + "' ";   // 품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 9].Text + "' ";   // 색상
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 10].Text + "' ";   // 사이즈
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 11].Text + "' ";   // 옵션1
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 12].Text + "' ";   // 옵션2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 13].Text + "' ";   // 거래처_가격
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 14].Text + "' ";   // 비고
            DataSet ds = cls_com.Select_Query (sql);
            if (ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                spr.ActiveSheet.Cells.Get(irow, 2, irow, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.White;
            }
            else
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
        }

        private void 수정(int irow)
        {

            string 품목코드, 품목명, 거래처_품목코드;
            품목코드 = spr.ActiveSheet.Cells[irow, 1].Text;

            품목명 = spr.ActiveSheet.Cells[irow, 2].Text;
            거래처_품목코드=spr.ActiveSheet.Cells[irow, 3].Text;

            if (품목코드.Equals(""))
            {
                MessageBox.Show("품목코드를 입력하세요");
                return;
            }
            if (거래처_품목코드.Equals(""))
            {
                MessageBox.Show("거래처 품목코드를 입력하세요");
                return;
            }

            sql = "";
            sql = sql + " exec s_a101_품목_거래처_저장 '2' ";
            sql = sql + "    ,'" + cmb거래처명.Text + "' ";   // 거래처명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 1].Text + "' ";   // 품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 3].Text + "' ";   // 거래처_품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 4].Text + "' ";   // 거래처_품목코드2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 5].Text + "' ";   // 거래처_품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 6].Text + "' ";   // 거래처_품목명2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 8].Text + "' ";   // 품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 9].Text + "' ";   // 색상
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 10].Text + "' ";   // 사이즈
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 11].Text + "' ";   // 옵션1
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 12].Text + "' ";   // 옵션2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 13].Text + "' ";   // 거래처_가격
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 14].Text + "' ";   // 비고
            cls_com.ExcuteNonQuery(sql);

        }
        private void 삭제(int irow)
        {

            DialogResult dr = MessageBox.Show("상품코드 : " + spr.ActiveSheet.Cells[irow, 5].Text + "\n" + spr.ActiveSheet.Cells[irow, 6].Text + "\n\n" + " 삭제하시겠습니까?", "데이타 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;
            sql = "";
            sql = sql + " exec s_a101_품목_거래처_저장 '3' ";
            sql = sql + "    ,'" + cmb거래처명.Text + "' ";   // 거래처명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 1].Text + "' ";   // 품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 3].Text + "' ";   // 거래처_품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 4].Text + "' ";   // 거래처_품목코드2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 5].Text + "' ";   // 거래처_품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 6].Text + "' ";   // 거래처_품목명2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 8].Text + "' ";   // 품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 9].Text + "' ";   // 색상
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 10].Text + "' ";   // 사이즈
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 11].Text + "' ";   // 옵션1
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 12].Text + "' ";   // 옵션2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 13].Text + "' ";   // 거래처_가격
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 14].Text + "' ";   // 비고
            cls_com.ExcuteNonQuery(sql);
            조회();
        }

        private void 삭제2(int irow)
        {

            sql = "";
            sql = sql + " exec s_a101_품목_거래처_저장 '3' ";
            sql = sql + "    ,'" + cmb거래처명.Text + "' ";   // 거래처명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 1].Text + "' ";   // 품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 3].Text + "' ";   // 거래처_품목코드
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 4].Text + "' ";   // 거래처_품목코드2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 5].Text + "' ";   // 거래처_품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 6].Text + "' ";   // 거래처_품목명2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 8].Text + "' ";   // 품목명
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 9].Text + "' ";   // 색상
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 10].Text + "' ";   // 사이즈
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 11].Text + "' ";   // 옵션1
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 12].Text + "' ";   // 옵션2
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 13].Text + "' ";   // 거래처_가격
            sql = sql + "    ,'" + spr.ActiveSheet.Cells[irow, 14].Text + "' ";   // 비고
            cls_com.ExcuteNonQuery(sql);
        }


        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void txt상품명_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                조회();
            }
        }
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = cls_color.gColor_수정;

        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            int i;

            i = cls_com.Val(lbl열.Text);

            if (i < 0)
            {
                MessageBox.Show("상품을 선택하세요");
                return;
            }
            삭제(i);
        }

        private void btn행추가_Click(object sender, EventArgs e)
        {
            행추가();
            return;
        }


        public void 행추가()
        {

            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }
            spr.ActiveSheet.Rows.Count++;
            spr.Focus();
            lbl열.Text = (spr.ActiveSheet.Rows.Count - 1).ToString();

            spr.SetViewportTopRow(0, spr.ActiveSheet.Rows.Count - 1);

            FarPoint.Win.Spread.Model.ISheetSelectionModel sel;

            sel = (FarPoint.Win.Spread.Model.ISheetSelectionModel)spr.ActiveSheet.Models.Selection;
            sel.SetSelection(spr.ActiveSheet.Rows.Count - 1, 0, 1, 1);

         //   spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = true;
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.RowCount - 1, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.White;
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.Rows.Count - 1, 4, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = false;
            spr.ActiveSheet.Cells.Get(spr.ActiveSheet.Rows.Count - 1, 2, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = cls_color.gColor_수정;
            spr.ActiveSheet.SetActiveCell(spr.ActiveSheet.Rows.Count - 1, 2);
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            lbl열.Text = e.Row.ToString();
        }


       public void spr_EditModeOff(object sender, EventArgs e)
        {
            int i;
            string 상품명,색상,옵션;
            i = spr.ActiveSheet.ActiveRow.Index;
            if (i < 0) return;

            if (cmb거래처명.Text.Equals(""))
            {
                MessageBox.Show("거래처를 선택하세요");
                return;
            }
            if (spr.ActiveSheet.ActiveCell.Column.Index == 2)  // 상품 가져오기
            {

                상품명 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, spr.ActiveSheet.ActiveCell.Column.Index].Text;
                색상 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 8].Text;
                옵션 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 9].Text;
                frm기타_거래처별_품목_조회 frm기타_거래처별_품목_조회 = new frm기타_거래처별_품목_조회(cmb거래처명.Text,상품명,색상,옵션);

                frm기타_거래처별_품목_조회.ShowDialog();
                if (!frm기타_거래처별_품목_조회.r품목코드.Equals(""))
                {
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 1].Text = frm기타_거래처별_품목_조회.r품목코드;
                    spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 2].Text = frm기타_거래처별_품목_조회.r품목명;
                    spr.ActiveSheet.SetActiveCell(i, 3);
                }

            }
            else if (spr.ActiveSheet.ActiveCell.Column.Index == 3)  
            {
                if (spr.ActiveSheet.Cells[i, 4].BackColor == cls_color.gColor_수정)
                {
                    저장(i);

                } else
                {
                    수정(i);
                }
            } else
            {
                if (spr.ActiveSheet.Cells[i, 4].BackColor != cls_color.gColor_수정)
                {
                    수정(i);

                }

            }


        }

       

        private void txt상품명_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

 

      
      

        private void cmb거래처명_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회0();
            조회();
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

                    frm기타_거래처별_품목_엑셀불러오기 frm기타_거래처별_품목_엑셀불러오기 = new frm기타_거래처별_품목_엑셀불러오기(openFileDialog.FileName);
                    frm기타_거래처별_품목_엑셀불러오기.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void spr_ClipboardPasting(object sender, FarPoint.Win.Spread.ClipboardPastingEventArgs e)
        {
            rrow = spr.ActiveSheet.ActiveRow.Index;
            t수정.Enabled = true;
        }

        private void t수정_Tick(object sender, EventArgs e)
        {
            t수정.Enabled = false;
            수정(rrow);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmb품목구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn구성품등록_Click(object sender, EventArgs e)
        {
            frm기초데이타_거래처구성품등록 frm기초데이타_거래처구성품등록 = new frm기초데이타_거래처구성품등록();
            frm기초데이타_거래처구성품등록.Show();
        }

        private void btn일괄삭제_Click(object sender, EventArgs e)
        {
            일괄삭제();
        }
        private void 일괄삭제()
        {
            int rRow1 = 0, rRow2 = 0;

            DialogResult dr = MessageBox.Show("선택 일괄 삭제 하시겠습니까 ? ", "선택 일괄 삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            FarPoint.Win.Spread.Model.CellRange[] cr;
            cr = spr.ActiveSheet.GetSelections();

            if (cr[0].RowCount < 0)
            {
                rRow1 = 0;
                rRow2 = spr.ActiveSheet.RowCount;
            }
            else
            {
                rRow1 = cr[0].Row;
                rRow2 = cr[0].Row + cr[0].RowCount;
            }
            for (int i = rRow1; i < rRow2; i++)
            {
                삭제2(i);
            }
            조회();
        }
    }
}
