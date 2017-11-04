using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class TheLoaiDAO
    {
        public string MaTheLoai { get; set; }

        public string TenTheLoai { get; set; }

        public TheLoaiDAO(DataRow row)
        {
            this.TenTheLoai = row["tentheloai"].ToString();
            this.MaTheLoai = row["matheloai"].ToString();
        }

        public TheLoaiDAO()
        {
        }

        public TheLoaiDAO(string matheloai, string tentheloai)
        {
            this.MaTheLoai = matheloai;
            this.TenTheLoai = tentheloai;
        }
    }
}
