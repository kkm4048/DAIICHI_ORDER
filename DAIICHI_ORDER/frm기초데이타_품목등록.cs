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
    public partial class frm기초데이타_품목등록 : Form
    {

        string sql = "";
        bool r시작 = true;
        public frm기초데이타_품목등록()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_품목등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";

            // 수평/수직 스크롤시 팝업을 표시한다.
          //   spr.ScrollTipPolicy = FarPoint.Win.Spread.ScrollTipPolicy.Both;

            // 수평/수직 스크롤시 시트도 모두 스크롤한다.
         //   spr.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;

            // spr.ScrollTipFetch += spr_ScrollTipFetch;
        //    spr.VerticalScrollBar.Move += spr_MoveTipFetch;


            초기화();
            Add품목구분0();
            Add품목구분();
            r시작 = false;
            조회();
        }
        private void Add품목구분0()
        {
            sql = "exec s_a101_품목구분_조회 '2','','' " ;
            DataSet ds = cls_com.Select_Query(sql);
            cmb품목구분0.Items.Clear();
            cmb품목구분0.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i ++ )
            {
                cmb품목구분0.Items.Add(ds.Tables[0].Rows[i]["품목구분"].ToString());
            }
            cmb품목구분0.Text = cmb품목구분0.Items[1].ToString();
        }
        private void Add품목구분()
        {
            sql = "exec s_a101_품목구분_조회 '1','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            cmb품목구분.Items.Clear();
            cmb품목구분.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb품목구분.Items.Add(ds.Tables[0].Rows[i]["품목구분"].ToString());
            }
        }


        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 조회()
        {

            if (r시작) return;
            sql = " exec s_a101_품목_조회 '1','','','" + cmb품목구분0.Text + "','','" + txt조회.Text + "' ";
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



        //        spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).CellType = tc;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.Sheets[0].Cells.Get(0, spr.Sheets[0].ColumnCount - 1, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;

            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
    //         cls_com.높이자동조절(spr);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            Cursor.Current = Cursors.Default;
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
      //      cls_com.높이자동조절(spr);
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void 등록()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_품목_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + cmb품목구분.Text  + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
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
        private void 수정()
        {

            DialogResult dr = MessageBox.Show("수정 하시겠습니까 ?", "데이타 수정", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품목_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + cmb품목구분.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
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

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "사용자 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품목_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + cmb품목구분.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            sql = sql + "   ,'" + txt4.Text + "' ";
            sql = sql + "   ,'" + txt5.Text + "' ";
            sql = sql + "   ,'" + txt6.Text + "' ";
            sql = sql + "   ,'" + txt7.Text + "' ";
            sql = sql + "   ,'" + txt8.Text + "' ";
            sql = sql + "   ,'" + txt9.Text + "' ";
            sql = sql + "   ,'" + txt10.Text + "' ";
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
            cmb품목구분.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt4.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            txt5.Text = spr.ActiveSheet.Cells[e.Row, 5].Text;
            txt6.Text = spr.ActiveSheet.Cells[e.Row, 6].Text;
            txt7.Text = spr.ActiveSheet.Cells[e.Row, 7].Text;
            txt8.Text = spr.ActiveSheet.Cells[e.Row, 8].Text;
            txt9.Text = spr.ActiveSheet.Cells[e.Row, 9].Text;
            txt10.Text = spr.ActiveSheet.Cells[e.Row, 10].Text;

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
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
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

                    frm기타_품목_엑셀불러오기 frm기타_품목_엑셀불러오기 = new frm기타_품목_엑셀불러오기(openFileDialog.FileName);
                    frm기타_품목_엑셀불러오기.ShowDialog();
                    조회();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("File Open Error : " + ex.Message);
            }
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }


        private void spr_LeaveCell(object sender, FarPoint.Win.Spread.LeaveCellEventArgs e)
        {
         //   cls_com.높이자동조절(spr );
        }

        private void frm기초데이타_품목등록_Resize(object sender, EventArgs e)
        {
         //   cls_com.높이자동조절(spr);
        }

        private void cmb품목구분0_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }
    }
}
