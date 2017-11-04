using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class PhongChieuBLL
    {
        RapBLL rap = new RapBLL();
        public DataTable LayDanhSachPhongChieu()
        {
            string query = "SELECT r.tenrap AS [Tên rạp],pc.maphong AS [Mã phòng], pc.tenphong AS [Tên phòng],pc.soghe AS [Số ghế] FROM dbo.Rap AS r JOIN dbo.PhongChieu AS pc ON pc.marap = r.marap";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool KiemTraPhongChieu(string id)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.PhongChieu WHERE maphong = '" + id + "'").Rows.Count > 0;
        }

        public bool XoaPhong(PhongChieuDAO phong)
        {
            string marap = rap.LayRapTheoTenRap(phong.TenRap).MaRap;
            int r1 = DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_XoaPhongChieu @maphongchieu", new object[] { phong.MaPhong });
            int r2 = DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.Rap SET sophong = sophong - 1, tongsoghe = tongsoghe - {0} WHERE marap = '{1}'", phong.SoGhe, marap));
            return r1 > 0 && r2 > 0;
        }

        public bool ThemPhong(PhongChieuDAO phong)
        {
            string marap = rap.LayRapTheoTenRap(phong.TenRap).MaRap;
            string query = String.Format("INSERT INTO dbo.PhongChieu( marap, maphong, tenphong, soghe ) VALUES  ( '{0}', '{1}', N'{2}', {3})", marap, phong.MaPhong, phong.TenPhong, phong.SoGhe);
            int r1 = DataProvider.Instance.ExcuteNonQuery(query);
            int r2 = DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.Rap SET sophong = sophong + 1, tongsoghe = tongsoghe + {0} WHERE marap = '{1}'", phong.SoGhe, marap));
            return r1 > 0 && r2 > 0;
        }

        public bool SuaPhongChieu(PhongChieuDAO phong, int soghecu)
        {
            string marap = rap.LayRapTheoTenRap(phong.TenRap).MaRap;
            string query = String.Format("UPDATE dbo.PhongChieu SET marap = '{0}',tenphong='{1}',soghe ={2} WHERE maphong = '{3}'", marap, phong.TenPhong, phong.SoGhe, phong.MaPhong);

            int r1 = DataProvider.Instance.ExcuteNonQuery(query);
            int r2 = DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.Rap SET tongsoghe = tongsoghe - {0} + {1} WHERE marap = '{2}'", soghecu, phong.SoGhe, marap));
            return r1 > 0 && r2 > 0;
        }

        public int LaySoGheCuaPhongTheoMaPhong(string maphong)
        {
            string query = "SELECT soghe FROM dbo.PhongChieu WHERE maphong = '" + maphong + "'";
            int soghe = (int)DataProvider.Instance.ExcuteQuery(query).Rows[0]["soghe"];
            return soghe;
        }
    }
}
