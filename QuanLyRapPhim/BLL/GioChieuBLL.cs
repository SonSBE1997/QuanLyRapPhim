using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class GioChieuBLL
    {
        public DataTable LayDanhSachGioChieu()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT magiochieu as [Mã giờ chiếu], dongia as [Đơn giá] FROM dbo.GioChieu");
        }

        public bool KiemTraGioChieu(string magiochieu)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.GioChieu WHERE magiochieu = '" + magiochieu + "'").Rows.Count > 0;
        }

        public bool XoaGioChieu(string magiochieu)
        {
            return DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_XoaGioChieu @magiochieu", new object[] { magiochieu }) > 0;
        }


        public bool SuaGioChieu(GioChieuDAO gio)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.GioChieu SET dongia = {0} WHERE magiochieu = '{1}'", gio.DonGia, gio.MaGioChieu)) > 0;
        }

        public bool ThemGioChieu(GioChieuDAO gio)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("INSERT INTO dbo.GioChieu ( magiochieu, dongia )VALUES( '{0}', {1})", gio.MaGioChieu, gio.DonGia)) > 0;
        }

    }
}
