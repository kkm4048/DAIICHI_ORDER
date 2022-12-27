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
    public partial class frm기타_거래처별_품목_조회 : Form
    {
        string sql;
        bool r시작 = true;
        public string r품목코드 = "", r품목명, r품목코드2, r거래처_품목명;
        public string r거래처명 = "";
        public static string r사업자코드 = "";
        string[][] rarr;
        public frm기타_거래처별_품목_조회()
        {
            InitializeComponent();
        }
        public frm기타_거래처별_품목_조회(string 거래처명,string 상품명,string 색상,string 옵션)
        {
            InitializeComponent();
            r거래처명 = 거래처명;
            txt거래처명.Text = r거래처명;
            cls_엑셀.상품명2Arr(상품명, ref rarr,색상,옵션);
        }
        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }
        private void 조회()
        {
            if (r시작) return;
            sql = "";
            sql = sql + " exec s_a101_품목_거래처_조회 '2','" + txt거래처명.Text  +"','','','','" + cmb품목구분.Text + "','" + txt조회.Text + "','" 
                + txt조회2.Text  +"','" + txt조회3.Text  +"','" + txt조회4.Text + "','" + txt조회5.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr.DataSource = ds;
            lbl수량.Text = spr.ActiveSheet.Rows.Count.ToString();
            if (spr.ActiveSheet.Rows.Count > 0)
            {
                spr.EditModeReplace = true;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = true;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
                spr.ActiveSheet.Cells.Get(0, 0, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).BackColor = Color.White;



            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.ActiveSheet);
        }

        private void frm기타_거래처별_품목_조회_Load(object sender, EventArgs e)
        {
            r품목코드 = "";
            r품목명 = "";
            r품목코드2 = "";
            r거래처_품목명 = "";
            Add품목구분();

            배열지정();
            r시작 = false;

            조회();
            if (!txt조회.Text.Equals(""))
            {
                t조회.Enabled = true;
            }
        }

        private void 배열지정()
        {
            try
            {
                txt조회.Text = rarr[0][0];
            }
            catch
            {
            }
            try
            {
                txt조회2.Text = rarr[1][0];
            }
            catch
            {
            }
            try
            {
                txt조회3.Text = rarr[2][0];
            }
            catch
            {
            }
            try
            {
                txt조회4.Text = rarr[3][0];
            }
            catch
            {
            }
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

        private void spr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                선택();
            }
        }

        private void 선택()
        {

            try
            {
                int irow;
                irow = spr.ActiveSheet.ActiveCell.Row.Index;
                if (irow >= 0)
                {
                    if (spr.ActiveSheet.Cells.Get(irow, 0, irow, spr.ActiveSheet.ColumnCount - 1).BackColor == Color.Tomato)
                    {

                        DialogResult d = MessageBox.Show("등록되 있는 품목코드 입니다. 선택 불가 \n\r 그래도등록하시겠습니까?", "상품등록", MessageBoxButtons.YesNo);
                        if (d == DialogResult.No) return;
                    }
                    r품목코드 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 1].Text;
                    r품목명 = spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveCell.Row.Index, 2].Text;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row >= 0)
            {
                if (spr.ActiveSheet.Cells.Get(e.Row, 0, e.Row, spr.ActiveSheet.ColumnCount - 1).BackColor == Color.Tomato)
                {
                    
                    DialogResult d = MessageBox.Show("등록되 있는 상품코드 입니다. 선택 불가 \n\r 그래도등록하시겠습니까?","상품등록",MessageBoxButtons.YesNo);
                    if (d == DialogResult.No) return;
 
                }
                r품목코드 = spr.ActiveSheet.Cells[e.Row, 1].Text;
                r품목명 = spr.ActiveSheet.Cells[e.Row, 2].Text;
                this.Close();
            }

        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void chk입고_CheckedChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            spr.Focus();
            spr.ActiveSheet.SetActiveCell(0, 2);
        }

        private void cmb품목구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

        private void t조회_Tick(object sender, EventArgs e)
        {
            t조회.Enabled = false;
            txt조회.Focus();

        }

        private void txt조회2_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회3_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회4_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void frm기타_상품코드_조회_Activated(object sender, EventArgs e)
        {
            txt조회.Focus();
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


    }
}
