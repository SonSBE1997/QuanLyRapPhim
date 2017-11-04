using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class PhongChieuDAO
    {
        public string TenRap { get; set; }

        public string MaPhong { get; set; }

        public string TenPhong { get; set; }

        public int SoGhe { get; set; }

        public PhongChieuDAO()
        {
        }

        public PhongChieuDAO(string tenrap, string maphong, string tenphong, int soghe)
        {
            this.TenRap = tenrap;
            this.MaPhong = maphong;
            this.TenPhong = tenphong;
            this.SoGhe = soghe;
        }
    }
}
