using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    class ReportBLL
    {
        public DataTable GetDoanhThuTheoGio()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T4.magiochieu, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" GROUP BY T4.magiochieu");


            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }
        public DataTable GetDoanhThuTheoLoaiPhim()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T5.matheloai, T5.tentheloai, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" GROUP BY T5.matheloai, T5.tentheloai");
            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }
        public DataTable GetDoanhThuTheoRap()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T6.marap, T6.tenrap, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" INNER JOIN Rap T6");
            sb.Append("     ON T2.marap = T6.marap");
            sb.Append(" GROUP BY T6.marap, T6.tenrap");
            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }



        public DataTable GetDoanhThuTheoPhim(string maphim)
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T6.marap, T6.tenrap, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" INNER JOIN Rap T6");
            sb.Append("     ON T2.marap = T6.marap");
            sb.Append(" GROUP BY T6.marap, T6.tenrap");
            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }
        public DataTable GetDoanhThuTheoNuoc()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T7.manuocsx, T7.tennuocsx, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" INNER JOIN Rap T6");
            sb.Append("     ON T2.marap = T6.marap");
            sb.Append(" INNER JOIN NuocSanXuat T7");
            sb.Append("     ON T3.manuocsx = T7.manuocsx");
            sb.Append(" GROUP BY T7.manuocsx, T7.tennuocsx");

            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }

        public DataTable GetDoanhThuTheoHangSX()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT T7.mahangsx, T7.tenhangsx, SUM(T4.dongia) AS TongTien");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" INNER JOIN Rap T6");
            sb.Append("     ON T2.marap = T6.marap");
            sb.Append(" INNER JOIN HangSX T7");
            sb.Append("     ON T3.mahangsx = T7.mahangsx");
            sb.Append(" GROUP BY T7.mahangsx, T7.tenhangsx");

            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }
        public DataTable GetDoanhThuTheoNam()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(" SELECT YEAR(T2.ngaychieu) AS nam, SUM(T4.dongia) AS DoanhThu");
            sb.Append(" FROM Ve T1");
            sb.Append(" INNER JOIN BuoiChieu T2");
            sb.Append("     ON T1.mashow = T2.mashow");
            sb.Append(" INNER JOIN Phim T3");
            sb.Append("     ON T2.maphim = T3.maphim");
            sb.Append(" INNER JOIN GioChieu T4");
            sb.Append("     ON T2.magiochieu = T4.magiochieu");
            sb.Append(" INNER JOIN TheLoai T5");
            sb.Append("     ON T3.matheloai = T5.matheloai");
            sb.Append(" INNER JOIN Rap T6");
            sb.Append("     ON T2.marap = T6.marap");
            sb.Append(" INNER JOIN NuocSanXuat T7");
            sb.Append("     ON T3.manuocsx = T7.manuocsx");
            sb.Append(" GROUP BY YEAR(T2.ngaychieu)");
            return DataProvider.Instance.ExcuteQuery(sb.ToString());
        }

    }
}
