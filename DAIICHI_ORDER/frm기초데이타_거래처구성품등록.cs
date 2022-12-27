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
    public partial class frm기초데이타_거래처구성품등록 : Form
    {

        string sql = "";
        string r거래처명="", r거래처_품번="", r구성품명 = "";
        public frm기초데이타_거래처구성품등록()
        {
            InitializeComponent();
        }
        public frm기초데이타_거래처구성품등록(string 거래처명,string 거래처_품번 , string 구성품명)
        {
            InitializeComponent();
            r거래처명 = 거래처명;
            r거래처_품번 = 거래처_품번;
            r구성품명 = 구성품명;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm기초데이타_거래처구성품등록_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lbl타이틀.Text = "【 " + this.Text + " 】";
            초기화();
            Add거래처명();
            txt22.Text = r거래처_품번;
            txt24.Text = r구성품명;

            조회();
            조회2();
            조회3();
            sc.SplitterDistance = cls_com.Val(cls_com.ConfigLoad(this.Name + "_sc넓이","500"));
        }
        private void Add거래처명()
        {
            sql = " exec s_a101_거래처_조회 '1' ,'','' ,''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb거래처명.Items.Clear();
            cmb거래처명.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb거래처명.Items.Add(ds.Tables[0].Rows[i]["거래처명"].ToString());
            }
            cmb거래처명.Text = r거래처명;
        }
        private void 초기화()
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
            조회3();

        }


        private void 조회()
        {
            FarPoint.Win.Spread.CellType.TextCellType tc = new FarPoint.Win.Spread.CellType.TextCellType();
            sql = "";
            sql = sql + "exec  s_a101_품목_거래처_조회  '1' ,'" + cmb거래처명.Text + "','','','' ,'" + "" + "','','','','' ,''  ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            spr.DataSource = ds;
            lblCnt.Text = spr.ActiveSheet.Rows.Count.ToString();
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
                spr.ActiveSheet.Cells.Get(0, 2, spr.ActiveSheet.RowCount - 1, spr.ActiveSheet.ColumnCount - 1).Locked = false;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.ActiveSheet);
        }

        private void 조회2()
        {
            //SPEC


            sql = " exec s_a101_품목_거래처_구성품_조회 '1','" + txt21.Text + "','" + txt22.Text + "','','','' ";
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
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            spr2.ActiveSheet.SetColumnMerge(1, FarPoint.Win.Spread.Model.MergePolicy.Always);
            spr2.ActiveSheet.SetColumnMerge(2, FarPoint.Win.Spread.Model.MergePolicy.Always);

            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }
        private void 조회3()
        {
            //SPEC


            sql = " exec s_a101_품목_거래처_필수구성품_조회 '1','" + txt21.Text + "','" + txt22.Text + "','','','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr3.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt3.Text = ds.Tables[0].Rows.Count.ToString();
            spr3.DataSource = ds;
            spr3.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            //     cls_com.Sort표시(spr.ActiveSheet);
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).Locked = true;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            spr3.ActiveSheet.SetColumnMerge(1, FarPoint.Win.Spread.Model.MergePolicy.Always);
            spr3.ActiveSheet.SetColumnMerge(2, FarPoint.Win.Spread.Model.MergePolicy.Always);

            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr3.Sheets[0]);
            lblCnt3.Text = spr3.ActiveSheet.RowCount.ToString();
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
            sql = sql + "EXEC [s_a101_품목_거래처_구성품_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt25.Text + "' ";
            sql = sql + "   ,'" + "" + "' ";
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
      
        private void 삭제()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "거래처 구성품 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품목_거래처_구성품_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            sql = sql + "   ,'" + txt25.Text + "' ";
            sql = sql + "   ,'" + "" + "' ";
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


        private void btnDelete_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            //      cmb구분.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt21.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt22.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt23.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            조회2();

            txt31.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt32.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txt33.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;
            조회3();

        }

        private void btninit_Click(object sender, EventArgs e)
        {
            txt22.Text = "";
            txt23.Text = "";
            txt24.Text = "";
            txt25.Text = "";
            txt26.Text = "";
            조회2();
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
            // txt26.Text = spr2.ActiveSheet.Cells[e.Row, 5].Text;
     
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void cmb거래처명_SelectedIndexChanged(object sender, EventArgs e)
        {
            조회();
            txt21.Text = cmb거래처명.Text;
            txt22.Text = "";
            txt23.Text = "";
            txt24.Text = "";
            txt25.Text = "";
            txt26.Text = "";
            조회2();
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString()) ;
        }

        private void txt211_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {

        }

        private void spr3_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt31.Text = spr3.ActiveSheet.Cells[e.Row, 0].Text;
            txt32.Text = spr3.ActiveSheet.Cells[e.Row, 1].Text;
            txt33.Text = spr3.ActiveSheet.Cells[e.Row, 2].Text;
            txt34.Text = spr3.ActiveSheet.Cells[e.Row, 3].Text;
            txt35.Text = spr3.ActiveSheet.Cells[e.Row, 4].Text;
        }

        private void btn등록2_Click(object sender, EventArgs e)
        {
            등록2();
        }

        private void btn삭제2_Click(object sender, EventArgs e)
        {
            삭제2();
        }

        private void 등록2()
        {

            sql = " ";
            sql = sql + "EXEC [s_a101_품목_거래처_필수구성품_저장] '1'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            sql = sql + "   ,'" + txt번호2.Text + "' ";
            sql = sql + "   ,'" + txt35.Text + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }

        private void 삭제2()
        {

            if (MessageBox.Show("삭제 하시겠습니까 ? ", "거래처 필수 구성품 삭제", MessageBoxButtons.YesNo) == DialogResult.No) return;
            sql = " ";
            sql = sql + "EXEC [s_a101_품목_거래처_필수구성품_저장] '3'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            sql = sql + "   ,'" + txt번호2.Text + "' ";
            sql = sql + "   ,'" + txt35.Text + "' ";
            sql = sql + "   ,'" + "" + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }

            }
            조회3();
        }

        private void btn품번코드2_Click(object sender, EventArgs e)
        {
            frm기타_품목조회 frm기타_품목조회 = new frm기타_품목조회(txt24.Text);
            frm기타_품목조회.ShowDialog();
            txt35.Text = frm기타_품목조회.r품목코드;
            txt36.Text = frm기타_품목조회.r품목명;
        }

        private void txt25_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn품번코드_Click(object sender, EventArgs e)
        {
            frm기타_품목조회 frm기타_품목조회 = new frm기타_품목조회(txt24.Text);
            frm기타_품목조회.ShowDialog();
            txt25.Text = frm기타_품목조회.r품목코드;
            txt26.Text = frm기타_품목조회.r품목명;

        }
    }
}
