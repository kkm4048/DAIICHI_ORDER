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
    public partial class frm기초데이타_거래처등록 : Form
    {

        string sql = "";
        public frm기초데이타_거래처등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_거래처등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            조회();
            조회2();
        }
        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
        }

        private void 조회()
        {
            //SPEC


            sql = " exec s_a101_거래처_조회 '1','','' ,''";
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

//                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left ;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }
        private void 조회2()
        {
            //SPEC


            sql = " exec s_a101_엑셀위치_조회 '1','' ";
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

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt2.Text = spr.ActiveSheet.RowCount.ToString();
        }

        // 품목명 검색조건
        private void 조회3()
        {
            //SPEC

            cb품목명.Checked = false;
            cb색상.Checked = false;
            cb사이즈.Checked = false;

            sql = " exec s_a101_엑셀_품목명검색조건_조회 '1','" + txt21.Text  +"' ";
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

            sql = " ";
            sql = sql + "EXEC [s_a101_거래처_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds == null) return;
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 등록2()
        {

            if (txt21.Text.Equals("")) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_엑셀위치_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt25.Text + "' ";
            sql = sql + "   ,'" + txt26.Text + "' ";
            sql = sql + "   ,'" + txt27.Text + "' ";
            sql = sql + "   ,'" + txt28.Text + "' ";
            sql = sql + "   ,'" + txt29.Text + "' ";
            sql = sql + "   ,'" + txt210.Text + "' ";
            sql = sql + "   ,'" + txt211.Text + "' ";
            sql = sql + "   ,'" + txt212.Text + "' ";
            sql = sql + "   ,'" + txt213.Text + "' ";
            sql = sql + "   ,'" + txt214.Text + "' ";
            sql = sql + "   ,'" + txt215.Text + "' ";
            sql = sql + "   ,'" + txt216.Text + "' ";
            sql = sql + "   ,'" + txt217.Text + "' ";
            sql = sql + "   ,'" + txt218.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }
        private void 등록3()
        {
            string 품목명 = "", 색상 = "", 사이즈 = "";

            if (txt21.Text.Equals("")) return;
            if (cb품목명.Checked)
            {
                품목명 = cb품목명.Checked.ToString();
            }
            if (cb색상.Checked)
            {
                색상 = cb색상.Checked.ToString();
            }
            if (cb사이즈.Checked)
            {
                사이즈 = cb사이즈.Checked.ToString();
            }

            sql = " ";
            sql = sql + "EXEC [s_a101_엑셀_품목명검색조건_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + 품목명 + "' ";
            sql = sql + "   ,'" + 색상 + "' ";
            sql = sql + "   ,'" + 사이즈 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }
        private void 수정()
        {

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
            sql = sql + "   ,'" + txt7.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "거래처 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_거래처_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회();
        }
        private void 삭제2()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "거래처 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_엑셀위치_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt25.Text + "' ";
            sql = sql + "   ,'" + txt26.Text + "' ";
            sql = sql + "   ,'" + txt27.Text + "' ";
            sql = sql + "   ,'" + txt28.Text + "' ";
            sql = sql + "   ,'" + txt29.Text + "' ";
            sql = sql + "   ,'" + txt210.Text + "' ";
            sql = sql + "   ,'" + txt211.Text + "' ";
            sql = sql + "   ,'" + txt212.Text + "' ";
            sql = sql + "   ,'" + txt213.Text + "' ";
            sql = sql + "   ,'" + txt214.Text + "' ";
            sql = sql + "   ,'" + txt215.Text + "' ";
            sql = sql + "   ,'" + txt216.Text + "' ";
            sql = sql + "   ,'" + txt217.Text + "' ";
            sql = sql + "   ,'" + txt218.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
        }

        private void 삭제3()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_엑셀_품목명검색조건_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,''  ";
            sql = sql + "   ,''  ";
            sql = sql + "   ,''  ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회2();
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

            
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt7.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txt21.Text = txt1.Text;



            txt22.Text = "";
            txt23.Text = "";
            txt24.Text = "";
            txt25.Text = "";
            txt26.Text = "";
            txt27.Text = "";
            txt28.Text = "";
            txt29.Text = "";
            txt210.Text = "";
            txt211.Text = "";
            txt212.Text = "";
            txt213.Text = "";
            txt214.Text = "";
            txt215.Text = "";
            txt216.Text = "";
            txt217.Text = "";
            txt218.Text = "";


            for (int i = 0; i < spr2.ActiveSheet.RowCount; i++)
            {
                if(spr2.ActiveSheet.Cells[i,0].Text.Equals(txt21.Text))
                {

                    FarPoint.Win.Spread.CellClickEventArgs aa = new  FarPoint.Win.Spread.CellClickEventArgs(null,i,0,0,0,MouseButtons,true,true)   ;
                    spr2.ActiveSheet.SetActiveCell(i, 0);
                    spr2_CellClick(null, aa);
                }
            }
            조회3();
        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";


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

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0 ) return;
            txt21.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;
            txt24.Text = spr2.ActiveSheet.Cells[e.Row, 3].Text;
            txt25.Text = spr2.ActiveSheet.Cells[e.Row, 4].Text;
            txt26.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
            txt27.Text = spr2.ActiveSheet.Cells[e.Row, 6].Text;
            txt28.Text = spr2.ActiveSheet.Cells[e.Row, 7].Text;
            txt29.Text = spr2.ActiveSheet.Cells[e.Row, 8].Text;
            txt210.Text = spr2.ActiveSheet.Cells[e.Row, 9].Text;
            txt211.Text = spr2.ActiveSheet.Cells[e.Row, 10].Text;
            txt212.Text = spr2.ActiveSheet.Cells[e.Row, 11].Text;
            txt213.Text = spr2.ActiveSheet.Cells[e.Row, 12].Text;
            txt214.Text = spr2.ActiveSheet.Cells[e.Row, 13].Text;
            txt215.Text = spr2.ActiveSheet.Cells[e.Row, 14].Text;
            txt216.Text = spr2.ActiveSheet.Cells[e.Row, 15].Text;
            txt217.Text = spr2.ActiveSheet.Cells[e.Row, 16].Text;
            txt218.Text = spr2.ActiveSheet.Cells[e.Row, 17].Text;
            조회3();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn저장2_Click(object sender, EventArgs e)
        {
            등록2();
            등록3();
        }

        private void btn삭제2_Click(object sender, EventArgs e)
        {
            삭제2();
            삭제3();
        }
    }
}
