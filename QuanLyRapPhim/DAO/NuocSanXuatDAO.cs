using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class NuocSanXuatDAO
    {
        public string MaNuoc { get; set; }

        public string TenNuoc { get; set; }

        public NuocSanXuatDAO(DataRow row)
        {
            this.MaNuoc = row["manuocsx"].ToString();
            this.TenNuoc = row["tennuocsx"].ToString();
        }

        public NuocSanXuatDAO()
        {
        }

        public NuocSanXuatDAO(string manuoc, string tennuoc)
        {
            this.MaNuoc = manuoc;
            this.TenNuoc = tennuoc;
        }
    }
}
