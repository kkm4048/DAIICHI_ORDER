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
    public partial class frm기타_품목조회 : Form
    {

        public string r품목코드 = "", r품목명 = "";
        string sql = "";
        bool r시작 = true;
        public frm기타_품목조회()
        {
            InitializeComponent();
        }
        public frm기타_품목조회(string 조회)
        {
            InitializeComponent();
            txt조회.Text = 조회;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기타_품목조회_Load(object sender, EventArgs e)
        {
            lbl타이틀.Text = "【 " + this.Text + " 】";

            초기화();
            Add품목구분();
            r시작 = false;
            조회();
        }
        private void Add품목구분()
        {
            sql = "exec s_a101_품목구분_조회 '2','','' " ;
            DataSet ds = cls_com.Select_Query(sql);
            cmb품목구분.Items.Clear();
            cmb품목구분.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i ++ )
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
            //SPEC

            if (r시작) return;
            sql = " exec s_a101_품목_조회 '1','','','" + cmb품목구분.Text + "','','" + txt조회.Text + "' ";
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

      

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
 //           txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
   //         txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
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


        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            r품목코드 = spr.ActiveSheet.Cells[e.Row, 0].Text;
            r품목명 = spr.ActiveSheet.Cells[e.Row, 1].Text;
            Close();
        }

        private void cmb품목구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void spr_KeyDown(object sender, KeyEventArgs e)
        {
            int i;
            i = spr.ActiveSheet.ActiveRow.Index;
            if (e.KeyCode == Keys.Enter)
            {
                if (i >= 0)
                {
                    r품목코드 = spr.ActiveSheet.Cells[i, 0].Text;
                    r품목명 = spr.ActiveSheet.Cells[i, 1].Text;
                    Close();
                }

            }
        }

  
    }
}
