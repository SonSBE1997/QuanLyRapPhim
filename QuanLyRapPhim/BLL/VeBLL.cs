using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class VeBLL
    {
        BuoiChieuBLL buoichieu = new BuoiChieuBLL();

        public DataTable LayDanhSachThongTinVe()
        {
            string query = "SELECT r.tenrap [Tên rạp],p.tenphim [Tên phim],pc.tenphong [Phòng chiếu],bc.ngaychieu [Ngày chiếu],bc.magiochieu [Giờ chiếu],gc.dongia [Giá vé],v.mave [Mã vé], v.soghe [Số ghế], v.hangghe [Hàng ghế],v.trangthai [Tình trạng] FROM  dbo.Ve v JOIN dbo.BuoiChieu bc ON bc.mashow = v.mashow JOIN dbo.Phim p ON p.maphim = bc.maphim JOIN dbo.Rap r ON r.marap = bc.marap JOIN dbo.PhongChieu pc ON pc.maphong = bc.maphong JOIN dbo.GioChieu gc ON gc.magiochieu = bc.magiochieu";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable LayDanhSachThongTinVe(VeDAO ve)
        {
            string ngaychieu = ve.NgayChieu.ToString("MM-dd-yyyy");
            string query = string.Format("SELECT r.tenrap [Tên rạp],p.tenphim [Tên phim],pc.tenphong [Phòng chiếu],bc.ngaychieu [Ngày chiếu],bc.magiochieu [Giờ chiếu],gc.dongia [Giá vé],v.mave [Mã vé], v.soghe [Số ghế], v.hangghe [Hàng ghế],v.trangthai [Tình trạng] FROM  dbo.Ve v JOIN dbo.BuoiChieu bc ON bc.mashow = v.mashow JOIN dbo.Phim p ON p.maphim = bc.maphim JOIN dbo.Rap r ON r.marap = bc.marap JOIN dbo.PhongChieu pc ON pc.maphong = bc.maphong JOIN dbo.GioChieu gc ON gc.magiochieu = bc.magiochieu WHERE r.tenrap = N'{0}' AND p.tenphim = N'{1}' AND bc.magiochieu = '{2}' AND bc.ngaychieu = '{3}' AND  pc.tenphong = N'{4}'", ve.TenRap, ve.TenPhim, ve.GioChieu, ngaychieu, ve.PhongChieu);
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public DataTable LayDanhSachThongTinVeChuaBan()
        {
            string query = "SELECT r.tenrap [Tên rạp],p.tenphim [Tên phim],pc.tenphong [Phòng chiếu],bc.ngaychieu [Ngày chiếu],bc.magiochieu [Giờ chiếu],gc.dongia [Giá vé],v.mave [Mã vé], v.soghe [Số ghế], v.hangghe [Hàng ghế],v.trangthai [Tình trạng] FROM  dbo.Ve v JOIN dbo.BuoiChieu bc ON bc.mashow = v.mashow JOIN dbo.Phim p ON p.maphim = bc.maphim JOIN dbo.Rap r ON r.marap = bc.marap JOIN dbo.PhongChieu pc ON pc.maphong = bc.maphong JOIN dbo.GioChieu gc ON gc.magiochieu = bc.magiochieu WHERE v.trangthai = N'Chưa bán'";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool KiemTraVe(string mave)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Ve WHERE mave = '" + mave + "'").Rows.Count > 0;
        }
        public bool ThemVe(VeDAO ve)
        {
            string mashow = buoichieu.LayMaShowTuThongTinVe(ve);
            string query = string.Format("INSERT INTO dbo.Ve VALUES  ( '{0}' , '{1}' , '{2}' ,{3} , N'Chưa bán')", mashow, ve.MaVe, ve.HangGhe, ve.SoGhe);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool XoaVe(string mave)
        {
            return DataProvider.Instance.ExcuteNonQuery("DELETE Ve WHERE mave = '" + mave + "'") > 0;
        }

        public bool SuaVe(string mave, string hangghe, int soghe)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.Ve SET hangghe = '{0}' , soghe = {1} WHERE mave = '{2}'", hangghe, soghe, mave)) > 0;
        }

        public bool BanVe(string mave)
        {
            return DataProvider.Instance.ExcuteNonQuery("UPDATE dbo.Ve SET trangthai = N'Đã bán' WHERE mave = '" + mave + "'") > 0;
        }
    }
}
