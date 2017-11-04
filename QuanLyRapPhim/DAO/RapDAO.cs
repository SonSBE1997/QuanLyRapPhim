using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class RapDAO
    {
        public string MaRap { get; set; }

        public string TenRap { get; set; }

        public string DiaChi { get; set; }

        public string DienThoai { get; set; }

        public int SoPhong { get; set; }

        public int TongSoGhe { get; set; }

        public RapDAO(DataRow row)
        {
            this.MaRap = row["marap"].ToString();
            this.TenRap = row["tenrap"].ToString();
            this.DiaChi = row["diachi"].ToString();
            this.DienThoai = row["dienthoai"].ToString();
            this.SoPhong = (int)row["sophong"];
            this.TongSoGhe = (int)row["tongsoghe"];
        }

        public RapDAO(string marap, string tenrap, string diachi, string dienthoai)
        {
            this.MaRap = marap;
            this.TenRap = tenrap;
            this.DiaChi = diachi;
            this.DienThoai = dienthoai;
        }

        public RapDAO() { }
    }
}
