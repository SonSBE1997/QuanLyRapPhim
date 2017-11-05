using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class PhimBLL
    {
        NuocSanXuatBLL nuocBLL = new NuocSanXuatBLL();
        TheLoaiBLL theloaiBLL = new TheLoaiBLL();
        HangSanXuatBLL hangsxBLL = new HangSanXuatBLL();

        public DataTable LayDanhSachPhim()
        {
            string query = "SELECT p.maphim [Mã phim], p.tenphim [Tên phim], n.tennuocsx [Nước sản xuất], h.tenhangsx [Hãng sản xuất], p.daodien [Đạo diễn], t.tentheloai [Thể loại], p.ngaykhoichieu [Ngày khởi chiếu], p.ngayketthuc [Ngày kết thúc], p.nudienvienchinh [Nữ chính], p.namdienvienchinh [Nam chính], p.noidungchinh [Nội dung chính], p.tongchiphi [Tổng chi phí], p.tongthu [Tổng thu] FROM dbo.Phim p JOIN dbo.NuocSanXuat n ON n.manuocsx = p.manuocsx JOIN dbo.HangSX h ON h.mahangsx = p.mahangsx JOIN dbo.TheLoai t ON t.matheloai = p.matheloai";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public bool KiemTraPhim(string maphim)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Phim WHERE maphim = '" + maphim + "'").Rows.Count > 0;
        }


        public bool XoaPhim(string maphim)
        {
            return DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_XoaPhim @maphim ", new object[] { maphim }) > 0;
        }


        public bool SuaPhim(PhimDAO phim)
        {
            string ngaykc = phim.NgayKhoiChieu.ToString("MM-dd-yyyy");
            string ngaykt = phim.NgayKetThuc.ToString("MM-dd-yyyy");
            string nuocsx = nuocBLL.LayNuocSXTheoTen(phim.NuocSX).MaNuoc;
            string hangsx = hangsxBLL.LayHangSXTheoTen(phim.HangSX).MaHang;
            string theloai = theloaiBLL.LayTheLoaiTheoTen(phim.TheLoai).MaTheLoai;

            string query = string.Format("UPDATE Phim SET tenphim = N'{0}', manuocsx = '{1}', mahangsx = '{2}', daodien =N'{3}', matheloai = '{4}', ngaykhoichieu = '{5}', ngayketthuc ='{6}', nudienvienchinh = N'{7}', namdienvienchinh = N'{8}', noidungchinh = N'{9}', tongchiphi = {10} WHERE maphim = '{11}'", phim.TenPhim, nuocsx, hangsx, phim.DaoDien, theloai, ngaykc, ngaykt, phim.NuDVChinh, phim.NamDVChinh, phim.NoiDungChinh, phim.TongChiPhi, phim.MaPhim);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool ThemPhim(PhimDAO phim)
        {
            string ngaykc = phim.NgayKhoiChieu.ToString("MM-dd-yyyy");
            string ngaykt = phim.NgayKetThuc.ToString("MM-dd-yyyy");
            string nuocsx = nuocBLL.LayNuocSXTheoTen(phim.NuocSX).MaNuoc;
            string hangsx = hangsxBLL.LayHangSXTheoTen(phim.HangSX).MaHang;
            string theloai = theloaiBLL.LayTheLoaiTheoTen(phim.TheLoai).MaTheLoai;
            string query = string.Format("INSERT INTO dbo.Phim VALUES  ( '{0}' ,N'{1}' ,'{2}' ,'{3}' ,N'{4}' ,'{5}' ,'{6}' ,'{7}' ,N'{8}' ,N'{9}' ,N'{10}' ,{11} ,0 )", phim.MaPhim, phim.TenPhim, nuocsx, hangsx, phim.DaoDien, theloai, ngaykc, ngaykt, phim.NuDVChinh, phim.NamDVChinh, phim.NoiDungChinh, phim.TongChiPhi);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public List<string> LayDanhSachTenPhim()
        {
            List<string> ls = new List<string>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT tenphim FROM dbo.Phim");
            foreach (DataRow item in table.Rows)
            {
                ls.Add(item["tenphim"].ToString());
            }
            return ls;
        }

        public string LayMaPhimTheoTenPhim(string tenphim)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT maphim FROM dbo.Phim WHERE tenphim = N'" + tenphim + "'");
            foreach (DataRow item in table.Rows)
            {
                return item["maphim"].ToString();
            }
            return null;
        }
    }
}
