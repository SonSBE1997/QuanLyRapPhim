using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class BuoiChieuDAO
    {
        public string MaShow { get; set; }

        public string MaPhim { get; set; }

        public string MaRap { get; set; }

        public string MaPhong { get; set; }

        public DateTime NgayChieu { get; set; }

        public string MaGioChieu { get; set; }

        public int SoVeDaBan { get; set; }

        public long TongTien { get; set; }

        public BuoiChieuDAO(string mashow, string maphim, string marap, string maphong, DateTime ngaychieu, string magiochieu, int sove)
        {
            this.MaShow = mashow;
            this.MaPhim = maphim;
            this.MaRap = marap;
            this.MaPhong = maphong;
            this.NgayChieu = ngaychieu;
            this.MaGioChieu = magiochieu;
            this.SoVeDaBan = sove;
        }
    }
}
