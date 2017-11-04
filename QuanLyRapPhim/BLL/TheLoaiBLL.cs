using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class TheLoaiBLL
    {
        public DataTable LayDanhSachTheLoai()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT matheloai AS [Mã thể loại], tentheloai AS [Tên thể loại] FROM dbo.TheLoai");
        }


        public bool KiemTraTheLoai(string matheloai)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.TheLoai WHERE matheloai = '" + matheloai + "'").Rows.Count > 0;
        }

        public bool XoaTheLoai(string matheloai)
        {
            return DataProvider.Instance.ExcuteNonQuery("DELETE dbo.TheLoai WHERE matheloai = '" + matheloai + "'") > 0;
        }


        public bool SuaTheLoai(TheLoaiDAO tl)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.TheLoai SET tentheloai = N'{0}' WHERE matheloai = '{1}'", tl.TenTheLoai, tl.MaTheLoai)) > 0;
        }

        public bool ThemTheLoai(TheLoaiDAO tl)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("INSERT INTO dbo.TheLoai ( matheloai, tentheloai )VALUES( '{0}', N'{1}')", tl.MaTheLoai, tl.TenTheLoai)) > 0;
        }
    }
}
