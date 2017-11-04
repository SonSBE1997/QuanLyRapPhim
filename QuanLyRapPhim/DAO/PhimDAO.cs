using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class PhimDAO
    {
        public string MaPhim { get; set; }

        public string TenPhim { get; set; }

        public string MaNuoc { get; set; }

        public string MaHang { get; set; }

        public string DaoDien { get; set; }

        public string MaTheLoai { get; set; }

        public DateTime NgayKhoiChieu { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public string NuDVChinh { get; set; }

        public string NamDVChinh { get; set; }

        public string NoiDungChinh { get; set; }

        public long TongChiPhi { get; set; }

        public long TongThu { get; set; }

        public PhimDAO(string maphim, string tenphim, string manuoc, string mahang, string daodien, string theloai, DateTime ngaykhoichieu, DateTime ngayketthuc, string namchinh, string nuchinh, string ndchinh, long tongchiphi)
        {
            this.MaPhim = maphim;
            this.TenPhim = tenphim;
            this.MaNuoc = manuoc;
            this.MaHang = mahang;
            this.DaoDien = daodien;
            this.MaTheLoai = theloai;
            this.NgayKhoiChieu = ngaykhoichieu;
            this.NgayKetThuc = ngayketthuc;
            this.NamDVChinh = namchinh;
            this.NuDVChinh = nuchinh;
            this.NoiDungChinh = ndchinh;
            this.TongChiPhi = tongchiphi;
        }
    }
}
