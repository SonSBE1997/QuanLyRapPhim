using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class HangSXDAO
    {
        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public HangSXDAO(DataRow row)
        {
            this.MaHang = row["mahangsx"].ToString();
            this.TenHang = row["tenhangsx"].ToString();
        }

        public HangSXDAO()
        {

        }

        public HangSXDAO(string mahang, string tenhang)
        {
            this.MaHang = mahang;
            this.TenHang = tenhang;
        }
    }
}
