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
    public partial class frm기타_품목_엑셀불러오기 : Form
    {
        String sql = "";
        public string rFileName = "";
        public frm기타_품목_엑셀불러오기()
        {
            InitializeComponent();
        }
        public frm기타_품목_엑셀불러오기(string iFileName)
        {
            InitializeComponent();
            rFileName = iFileName;
        }

        private void btn엑셀_불러오기_Click(object sender, EventArgs e)
        {

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

        private void frm기타_품목_엑셀불러오기_Load(object sender, EventArgs e)
        {
            LoadExcel();
            초기화();
         }
     
        private void 초기화()
        {

            헤드();            

        }
        private void 헤드()
        {
            spr.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "품목코드";
            spr.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "품목명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "품목구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "그룹명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 4].Text = "구매처명";
            spr.ActiveSheet.ColumnHeader.Cells[0, 5].Text = "그룹명2";
            spr.ActiveSheet.ColumnHeader.Cells[0, 6].Text = "그룹명3";
            spr.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "검색창내용";
            spr.ActiveSheet.ColumnHeader.Cells[0, 8].Text = "사용구분";
            spr.ActiveSheet.ColumnHeader.Cells[0, 9].Text = "규격";
            spr.ActiveSheet.ColumnHeader.Cells[0, 10].Text = "입고단가";

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
            String[] b = new String[100];
            String[] 데이타 = new string[100];
            
            for (i = 1; i < spr.ActiveSheet.RowCount; i++)
            {
                lblCnt2.Text = i.ToString();
                Application.DoEvents();

                for (j = 0; j < 50; j++)
                {
                    b[j] = spr.ActiveSheet.Cells[i, j].Text.Trim();
                }

                if (b[0].Equals("") && b[1].Equals("") )
                {
                    MessageBox.Show(cnt.ToString() + " 건 저장 완료");
                    return;
                }
                
                if (b[1].Trim().Equals("") || b[1].Trim().Equals("품목명"))
                {
                    continue;
                } 
                sql = "";
                sql = sql + " exec s_a101_품목_저장 '1' " ;
                sql = sql + ",'" + b[0].Trim() + "' ";
                sql = sql + ",'" + b[1].Trim() + "' ";
                sql = sql + ",'" + b[2].Trim() + "' ";
                sql = sql + ",'" + b[3].Trim() + "' ";
                sql = sql + ",'" + b[4].Trim() + "' ";
                sql = sql + ",'" + b[5].Trim() + "' ";
                sql = sql + ",'" + b[6].Trim() + "' ";
                sql = sql + ",'" + b[7].Trim() + "' ";
                sql = sql + ",'" + b[8].Trim() + "' ";
                sql = sql + ",'" + b[9].Trim() + "' ";
                sql = sql + ",'" + b[10].Trim() + "' ";
                cls_com.ExcuteNonQuery(sql);
                cnt++;
               
                Application.DoEvents();
            }
        }
    
        private void btn조회_Click(object sender, EventArgs e)
        {
            
        }
    }

}
