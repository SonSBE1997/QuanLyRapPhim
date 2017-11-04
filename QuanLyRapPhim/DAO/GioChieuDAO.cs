using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class GioChieuDAO
    {
        public string MaGioChieu { get; set; }

        public int DonGia { get; set; }

        public GioChieuDAO(DataRow row)
        {
            this.MaGioChieu = row["magiochieu"].ToString();
            this.DonGia = (int)row["dongia"];
        }

        public GioChieuDAO()
        {
        }

        public GioChieuDAO(string magiochieu,int dongia)
        {
            this.MaGioChieu = magiochieu;
            this.DonGia = dongia;
        }
    }
}
