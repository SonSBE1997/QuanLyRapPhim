using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class NuocSanXuatBLL
    {
        public DataTable LayDanhSachNuocSanXuat()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT manuocsx AS [Mã nước sản xuất],tennuocsx AS [Tên nước sản xuất] FROM dbo.NuocSanXuat");
        }


        public bool KiemTraNuocSanXuat(string manuoc)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.NuocSanXuat WHERE manuocsx = '" + manuoc + "'").Rows.Count > 0;
        }

        public bool XoaNuocSanXuat(string manuoc)
        {
            return DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_XoaNuocSX @manuocsx", new object[] { manuoc }) > 0;
        }


        public bool SuaNuocSanXuat(NuocSanXuatDAO nuocsx)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.NuocSanXuat SET tennuocsx = N'{0}' WHERE manuocsx = '{1}'", nuocsx.TenNuoc, nuocsx.MaNuoc)) > 0;
        }

        public bool ThemNuocSanXuat(NuocSanXuatDAO nuocsx)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("INSERT INTO dbo.NuocSanXuat ( manuocsx, tennuocsx )VALUES( '{0}', N'{1}')", nuocsx.MaNuoc, nuocsx.TenNuoc)) > 0;
        }

        public NuocSanXuatDAO LayNuocSXTheoTen(string tennuoc)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.NuocSanXuat WHERE tennuocsx = N'" + tennuoc + "'");
            foreach (DataRow item in table.Rows)
            {
                return new NuocSanXuatDAO(item);
            }
            return null;
        }

        public List<string> LayDanhSachTenNuocSX()
        {
            List<string> ls = new List<string>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.NuocSanXuat");
            foreach (DataRow item in table.Rows)
            {
                ls.Add(item["tennuocsx"].ToString());
            }
            return ls;
        }
    }
}
