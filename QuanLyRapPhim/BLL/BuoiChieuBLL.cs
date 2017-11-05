using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class BuoiChieuBLL
    {
        PhimBLL phim = new PhimBLL();
        PhongChieuBLL phongchieu = new PhongChieuBLL();
        RapBLL rap = new RapBLL();

        public DataTable LayDanhSachBuoiChieu()
        {
            string query = "SELECT bc.mashow [Mã show], p.tenphim [Tên phim], r.tenrap [Tên rạp],pc.tenphong [Tên phòng chiếu],bc.ngaychieu [Ngày chiếu],gc.magiochieu [Giờ chiếu], bc.sovedaban [Số vé đã bán],bc.tongtien [Tổng tiền] FROM  dbo.BuoiChieu bc JOIN dbo.Rap r ON r.marap = bc.marap JOIN dbo.PhongChieu pc ON pc.maphong = bc.maphong JOIN dbo.GioChieu gc ON gc.magiochieu = bc.magiochieu JOIN dbo.Phim p ON  p.maphim = bc.maphim";
            return DataProvider.Instance.ExcuteQuery(query);
        }


        public bool KiemTraBuoiChieu(string mashow)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM  dbo.BuoiChieu WHERE mashow = '" + mashow + "'").Rows.Count > 0;
        }
        public bool ThemBuoiChieu(BuoiChieuDAO bc)
        {
            string marap = rap.LayRapTheoTenRap(bc.TenRap).MaRap;
            string maphong = phongchieu.LayMaPhongChieuTheoTen(bc.TenPhong);
            string maphim = phim.LayMaPhimTheoTenPhim(bc.TenPhim);
            string ngaychieu = bc.NgayChieu.ToString("MM-dd-yyyy");
            string query = string.Format("INSERT INTO dbo.BuoiChieu  VALUES  ( '{0}' , '{1}' ,'{2}' , '{3}' , '{4}' ,'{5}' , 0 ,0 )", bc.MaShow, maphim, marap, maphong, ngaychieu, bc.GioChieu);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool SuaBuoiChieu(BuoiChieuDAO bc)
        {
            string marap = rap.LayRapTheoTenRap(bc.TenRap).MaRap;
            string maphong = phongchieu.LayMaPhongChieuTheoTen(bc.TenPhong);
            string maphim = phim.LayMaPhimTheoTenPhim(bc.TenPhim);
            string ngaychieu = bc.NgayChieu.ToString("MM-dd-yyyy");
            string query = string.Format("UPDATE dbo.BuoiChieu SET maphim = '{0}',marap = '{1}', maphong = '{2}',ngaychieu = '{3}', magiochieu='{4}' WHERE mashow = '{5}'", maphim, marap, maphong, ngaychieu, bc.GioChieu, bc.MaShow);

            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool XoaBuoiChieu(string mashow)
        {
            DataProvider.Instance.ExcuteNonQuery("DELETE dbo.Ve WHERE mashow = '" + mashow + "'");
            return DataProvider.Instance.ExcuteNonQuery("DELETE dbo.BuoiChieu WHERE mashow = '" + mashow + "'") > 0;
        }
    }
}
