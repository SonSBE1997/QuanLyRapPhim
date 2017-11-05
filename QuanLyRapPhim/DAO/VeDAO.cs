using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class VeDAO
    {
        public string TenRap { get; set; }

        public string TenPhim { get; set; }

        public string PhongChieu { get; set; }

        public DateTime NgayChieu { get; set; }

        public string  GioChieu { get; set; }

        public int GiaVe { get; set; }

        public string  MaVe { get; set; }

        public int  SoGhe { get; set; }

        public string HangGhe { get; set; }

        public string TinhTrang { get; set; }
    }
}
