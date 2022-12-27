using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAIICHI_ORDER
{
    class cls_엑셀
    {

        public  static  string  sql = "";
        public struct s엑셀위치
        {
            public static string 구분문자 = "" ;
            public static int 메세지 =0;
            public static int 발주서번호 = 0;
            public static int 출고일자 = 0;
            public static int 품목코드 = 0;
            public static int 품목명 = 0;
            public static int 색상 = 0;
            public static int 옵션 = 0;
            public static int 수량 = 0;
            public static int 금액= 0 ;
            public static int 고객명 = 0;
            public static int 이동전화 = 0;
            public static int 전화번호 = 0;
            public static int 주소 = 0;
            public static int 단가 = 0;
            public static int 공급가액 = 0;
            public static int 부가세 = 0;
        }

        public struct s거래처명
        {
            public static string CJ = "CJ";
            public static string 네이버스마트스토어 = "네이버스마트스토어";
            public static string 위메프 = "위메프";
            public static string 자사몰 = "자사몰";
        }



        public static void 엑셀양식_타이틀( string 거래처명,FarPoint.Win.Spread.FpSpread  spr)
        {

      //      spr.Reset();
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 50;
            for (int i = 0; i < 100 ; i++)
            {
                spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = "";
            }


            if (거래처명.Equals(s거래처명.자사몰))
            {
                String d = "";
                String[] arr;
                d = "주문번호\t주문일자\t거래상태\t주문자\t수령인\t수령인전화번호\t수령인휴대전화\t주문자휴대전화\t수령인주소\t수령인우편번호\t상품명\t옵션\t수량\t판매가(옵션포함)\t결제한 배송료\t결제금액\t상품가\t배송료\t즉시할인가\t회원할인가\t쿠폰할인\t적립금\tOK캐시백\t두툼\t결제수단\t요구사항\t송장번호\t상품코드\t무통장 입금자명\t모바일주문여부\t주문자ID";
                arr = d.Split('\t');
                for (int i = 0; i < arr.Length; i++)
                {
                    spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[i];
                }
            } else if (거래처명.Equals(s거래처명.네이버스마트스토어))
            {
                String d = "";
                String[] arr;
                d = "상품주문번호\t주문번호\t풀필먼트사(주문 기준)\t배송방법(구매자 요청)\t배송방법\t택배사\t송장번호\t발송일\t판매채널\t구매자명\t구매자ID\t수취인명\t주문상태\t주문세부상태\t결제위치\t결제일\t상품번호\t상품명\t상품종류\t반품안심케어\t옵션정보\t옵션관리코드\t수량\t옵션가격\t상품가격\t상품별 할인액\t판매자부담 할인액\t상품별 총 주문금액\t사은품\t발주확인일\t발송기한\t발송처리일\t송장출력일\t배송비 형태\t배송비 묶음번호\t배송비 유형\t배송비 합계\t제주/도서 추가배송비\t배송비 할인액\t판매자 상품코드\t판매자 내부코드1\t판매자 내부코드2\t수취인연락처1\t수취인연락처2\t통합배송지\t기본배송지\t상세배송지\t구매자연락처\t우편번호\t배송메세지\t출고지\t결제수단\t수수료 과금구분\t수수료결제방식\t네이버페이 주문관리 수수료\t매출연동 수수료\t매출연동 수수료 구분\t정산예정금액\t매출연동수수료 유입경로\t개인통관고유부호\t주문일시\t구독신청회차\t구독진행회차\t배송속성\t배송희망일";

                arr = d.Split('\t');
                for (int i = 0; i < arr.Length; i++)
                {
                    spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[i];
                }
            }
            else if (거래처명.Equals(s거래처명.CJ))
            {
                String d = "";
                String[] arr;
                d = "취소예정\t취소상세\t주문상태\t주문구분\t출하지시일자\t제휴채널명\t주문번호\t인수자\t0\t택배사\t운송장번호\t해외배송\t출고수량\t배송예정일자\t출고예정일자\t \t배송약속일자\t인수자Tel\t인수자Hp\t우편번호\t구주소\t신주소\t배송참고\t주문자\t운송장식별번호\t \t \t지시수량\t판매가\t고객결제가\t공급가(VAT제외)\t상품코드\t단품코드\t판매 상품명\t단품상세\t세트상품명\t세트여부\t조회유무\t웹상품명\t사은품 내역\tB2B주문여부";																			
                arr = d.Split('\t');
                for (int i = 0; i < arr.Length; i++)
                {
                    spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[i];
                }
            }
            else if (거래처명.Equals(s거래처명.위메프))
            {
                String d = "";
                String[] arr;
                d = "배송번호\t주문번호\t옵션주문번호\t주문일\t주문상태\t발송기한\t구매번호\t상품번호\t상품명\t옵션\t수량\t상품금액\t총상품금액\t판매대행수수료\t위메프 지원할인\t위메프 제휴채널 수수료\t구매자\t구매자 휴대폰\t받는사람\t받는사람 연락처\t배송방법\t택배사\t송장번호\t배송예정일\t우편번호\t주소\t배송메세지\t배송비지급\t배송비\t도서산간 배송비\t결제일\t주문확인일\t2차발송기한\t업체상품코드\t업체옵션코드\t개인통관고유번호";
                arr = d.Split('\t');
                for (int i = 0; i < arr.Length; i++)
                {
                    spr.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[i];
                }
            }
        }
        public static void 엑셀위치(string 거래처명)
        {
            sql = " exec s_a101_엑셀위치_조회 '2','" + 거래처명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            cls_엑셀.s엑셀위치.구분문자 = "";
            cls_엑셀.s엑셀위치.메세지 = -1;
            cls_엑셀.s엑셀위치.금액 = -1;
            cls_엑셀.s엑셀위치.발주서번호 = -1;
            cls_엑셀.s엑셀위치.수량 = -1;
            cls_엑셀.s엑셀위치.출고일자 = -1;
            cls_엑셀.s엑셀위치.품목명 = -1;
            cls_엑셀.s엑셀위치.품목코드 = -1;
            cls_엑셀.s엑셀위치.색상 = -1;
            cls_엑셀.s엑셀위치.옵션 = -1;
            cls_엑셀.s엑셀위치.고객명 = -1;
            cls_엑셀.s엑셀위치.이동전화 = -1;
            cls_엑셀.s엑셀위치.전화번호 = -1;
            cls_엑셀.s엑셀위치.주소 = -1;
            cls_엑셀.s엑셀위치.단가 = -1;
            cls_엑셀.s엑셀위치.공급가액 = -1;
            cls_엑셀.s엑셀위치.부가세 = -1;



            if (ds.Tables[0].Rows.Count > 0 )
            {
                cls_엑셀.s엑셀위치.구분문자 = ds.Tables[0].Rows[0]["구분문자"].ToString();
                cls_엑셀.s엑셀위치.메세지 = cls_com.Val(ds.Tables[0].Rows[0]["메세지"].ToString()) ;
                cls_엑셀.s엑셀위치.금액 = cls_com.Val(ds.Tables[0].Rows[0]["금액"].ToString());
                cls_엑셀.s엑셀위치.발주서번호 = cls_com.Val(ds.Tables[0].Rows[0]["발주서번호"].ToString());
                cls_엑셀.s엑셀위치.수량 = cls_com.Val(ds.Tables[0].Rows[0]["수량"].ToString());
                cls_엑셀.s엑셀위치.출고일자 = cls_com.Val(ds.Tables[0].Rows[0]["출고일자"].ToString());
                cls_엑셀.s엑셀위치.품목명 = cls_com.Val(ds.Tables[0].Rows[0]["품목명"].ToString());
                cls_엑셀.s엑셀위치.품목코드 = cls_com.Val(ds.Tables[0].Rows[0]["품목코드"].ToString());
                cls_엑셀.s엑셀위치.색상 = cls_com.Val(ds.Tables[0].Rows[0]["색상"].ToString());
                cls_엑셀.s엑셀위치.옵션 = cls_com.Val(ds.Tables[0].Rows[0]["옵션"].ToString());
                cls_엑셀.s엑셀위치.고객명 = cls_com.Val(ds.Tables[0].Rows[0]["고객명"].ToString());
                cls_엑셀.s엑셀위치.이동전화 = cls_com.Val(ds.Tables[0].Rows[0]["이동전화"].ToString());
                cls_엑셀.s엑셀위치.전화번호 = cls_com.Val(ds.Tables[0].Rows[0]["전화번호"].ToString());
                cls_엑셀.s엑셀위치.주소 = cls_com.Val(ds.Tables[0].Rows[0]["주소"].ToString());
                cls_엑셀.s엑셀위치.단가 = cls_com.Val(ds.Tables[0].Rows[0]["단가"].ToString());
                cls_엑셀.s엑셀위치.공급가액 = cls_com.Val(ds.Tables[0].Rows[0]["공급가액"].ToString());
                cls_엑셀.s엑셀위치.부가세 = cls_com.Val(ds.Tables[0].Rows[0]["부가세"].ToString());
            }

        }
        public static string 품목명가져오기(string d,char 분리구분)
        {
            string d2 = "";
            string[] arr;
            arr = d.Split(분리구분);
            d2 = arr[0];
            return d2;

        }
        public static string 값가져오기(FarPoint.Win.Spread.FpSpread spr,int col)
        {
            if (col < 0) return "";
            return spr.ActiveSheet.Cells[spr.ActiveSheet.ActiveRow.Index, col].Text.Trim();

        }
        public static string 값가져오기(FarPoint.Win.Spread.FpSpread spr, int row,int col)
        {
            if (col < 0) return "";
            return spr.ActiveSheet.Cells[row, col].Text.Trim();

        }
        public static string 값가져오기(string 거래처명,string 색상0,string 옵션0,string 구분)
        {
            string d = "";
            if (거래처명.Equals(s거래처명.CJ))
            {
                d = 값가져오기_CJ(색상0, 옵션0, 구분);
                return d;
            } else if (거래처명.Equals(s거래처명.네이버스마트스토어))
            {
                d = 값가져오기_네이버스마트스토어( 색상0,  옵션0,  구분);
                return d;
            }
            else if (거래처명.Equals(s거래처명.위메프))
            {
                d = 값가져오기_위메프(색상0, 옵션0, 구분);
                return d;
            }
            else 
            {

                if (구분.Equals("색상"))
                {
                    d = 색상0;
                    return d;
                }
                else
                {
                    return d;
                }
            }
        }


        #region 거래처별 값 가져오기 

        private static string 값가져오기_CJ(string 색상0, string 옵션0, string 구분)
        {
            string d = "" ;
            if (구분.Equals("색상"))
            {
                d = 색상0;
                return d;
            }
            else
            {
                return d;
            }
        }
        private static string 값가져오기_네이버스마트스토어(string 색상0, string 옵션0, string 구분)
        {
            string d = "" ;
            if (구분.Equals("색상"))
            {
                string[] arr;
                arr = 옵션0.Split('/');
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] arr2;
                    arr2 = arr[i].Split(':');

                    if (arr2[0].ToString().IndexOf("색상") >= 0 || arr2[0].ToString().IndexOf("컬러") >= 0)
                    {
                        if (arr2.Length > 1)
                        {
                            d = arr2[1].ToString().Trim();
                            return d;
                        }
                    }

                }
                return d;
            }
            else if (구분.Equals("사이즈"))
            {
                string[] arr;
                arr = 옵션0.Split('/');
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] arr2;
                    arr2 = arr[i].Split(':');

                    if (arr2[0].ToString().IndexOf("사이즈") >= 0)
                    {
                        if (arr2.Length > 1)
                        {
                            d = arr2[1].ToString().Trim();
                            return d;
                        }
                    }

                }
                return d;
            }
            else
            {
                return d;
            }
        }

        private static string 값가져오기_위메프(string 색상0, string 옵션0, string 구분)
        {
            string d = "";
            string d2 = 옵션0.Replace(" ","") ;
            string d3 = "";
            if (구분.Equals("색상"))
            {
                sql = " s_a101_색상명_조회 '1','' ";
                DataSet ds = cls_com.Select_Query(sql);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i ++)
                {
                    d3 = ds.Tables[0].Rows[i]["색상명"].ToString().Replace(" ", "");
                    if (d2.IndexOf(d3) >= 0 ) 
                    {
                        d = ds.Tables[0].Rows[i]["색상명"].ToString();
                        return d;
                    }
                }
                
                return d;
            }
            else if (구분.Equals("사이즈"))
            {
                return d;
            }
            else
            {
                return d;
            }
        }

        #endregion 거래처별 값가져오기

        public static void 상품명2Arr(string d , ref string[][] arr,string 색상,string 옵션 )
        {
            int pos; 
            d = d.ToUpper();
            sql = "select * from a101_검색명";
            DataSet ds = cls_com.Select_Query(sql);
            for (int i = 0; i  < ds.Tables[0].Rows.Count; i ++)
            {
                pos = d.IndexOf(ds.Tables[0].Rows[i]["검색명"].ToString().Trim().ToUpper()) ;
                if (pos   >= 0 ) 
                {
                    if (arr is null)
                    {
                        Array.Resize(ref arr, 1);
                        Array.Resize(ref arr[0], 2);

                        arr[arr.Length - 1][0] = ds.Tables[0].Rows[i]["검색명"].ToString().Trim();
                        arr[arr.Length - 1][1] = pos.ToString();

                    }
                    else
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        Array.Resize(ref arr[arr.Length-1],2);

                        arr[arr.Length - 1][0] = ds.Tables[0].Rows[i]["검색명"].ToString().Trim();
                        arr[arr.Length - 1][1] = pos.ToString();
                    }

                } 
            }

            if (arr == null) return;
            string d1, d2;

            for (int i = 0;i < arr.Length-1; i ++ )
            {
                for (int j = i + 1; j < arr.Length; j++)
                { 
                    if (cls_com.Val(arr[i][1]) > cls_com.Val(arr[j][1]))
                    {
                        d1 = arr[i][0];
                        d2 = arr[i][1];
                        arr[i][0] = arr[j][0];
                        arr[i][1] = arr[j][1];
                        arr[j][0] = d1;
                        arr[j][1] = d2;
                    }
                }
            }

            if ( !색상.Equals("") ){
                 if (arr.Length > 4 )
                {
                    arr[5][0] = 색상;
                    arr[5][1] = "100";
                }  else
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    Array.Resize(ref arr[arr.Length - 1], 2);

                    arr[arr.Length - 1][0] = 색상;
                    arr[arr.Length - 1][1] = "100";

                }

            }

        }

        public static void 옵션2Arr(string 거래처명, string 옵션 ,ref string[][] arr)
        {
            string[] arr2,arr3 ;

            if  (거래처명.Equals(s거래처명.네이버스마트스토어))
            {
                arr2 = 옵션.Split('/');
                for (int i = 0; i < arr2.Length; i++)
                {
                    Array.Resize(ref arr, i+1);
                    Array.Resize(ref arr[i], 2);
                    arr3 = arr2[i].Split(':');
                    if (arr3.Length == 0)
                    {
                        arr[i][0] = "";
                        arr[i][1] = "";
                    } else if (arr3.Length == 1 )
                    {
                        arr[i][0] = arr3[0];
                        arr[i][1] = "";

                    } else if (arr3.Length == 2)
                    {
                        arr[i][0] = arr3[0];
                        arr[i][1] = arr3[1];

                    }
                }
            } else
            {

            }
        }
        public static string 품목명(string 옵션)
        {
            string 색상 = "";
            sql = " SELECT DBO.F_품목명('" + 옵션 + "' ) 색상 ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                색상 = ds.Tables[0].Rows[0]["색상"].ToString();
            }
            return 색상;

        }
        public static string 색상(string 옵션)
        {
            string 색상 = "";
            sql = " SELECT DBO.F_색상('" + 옵션 + "' ) 색상 ";
            DataSet ds = cls_com.Select_Query(sql);
            
            if (ds.Tables[0].Rows.Count > 0 )
            {
                색상 = ds.Tables[0].Rows[0]["색상"].ToString();
            }
            return 색상;

        }
        public static string 사이즈(string 옵션)
        {
            string 사이즈 = "";
            sql = " SELECT DBO.F_사이즈('" + 옵션 + "' ) 사이즈 ";
            DataSet ds = cls_com.Select_Query(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                사이즈 = ds.Tables[0].Rows[0]["사이즈"].ToString();
            }
            return 사이즈;

        }

    }
}
