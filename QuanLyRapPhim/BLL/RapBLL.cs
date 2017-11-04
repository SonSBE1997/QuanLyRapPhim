using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class RapBLL
    {
        public DataTable LayDanhSachRapDataTable()
        {
            string query = "SELECT marap AS [Mã rạp], tenrap AS [Tên rạp] , diachi AS [Địa chỉ] , dienthoai AS [Số điện thoại], sophong AS [Số phòng],tongsoghe AS [Tổng số ghế] FROM dbo.Rap";
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public List<string> LayDanhSachTenRap()
        {
            List<string> list = new List<string>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Rap");
            foreach (DataRow item in table.Rows)
            {
                list.Add(item["tenrap"].ToString());
            }

            return list;
        }

        public bool KiemTraRap(string id)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Rap WHERE marap = '" + id + "'").Rows.Count > 0;
        }

        public bool ThemRap(RapDAO rap)
        {
            string query = string.Format("INSERT INTO dbo.Rap( marap, tenrap, diachi, dienthoai, sophong,tongsoghe) VALUES( '{0}', N'{1}', N'{2}', '{3}', {4},{5})", rap.MaRap, rap.TenRap, rap.DiaChi, rap.DienThoai, 0, 0);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }


        public bool SuaRap(RapDAO rap)
        {
            string query = string.Format("UPDATE dbo.Rap SET tenrap=N'{0}',diachi=N'{1}',dienthoai='{2}' WHERE marap ='{3}'", rap.TenRap, rap.DiaChi, rap.DienThoai, rap.MaRap);
            return DataProvider.Instance.ExcuteNonQuery(query) > 0;
        }

        public bool XoaRap(string marap)
        {
            return DataProvider.Instance.ExcuteNonQuery("DELETE dbo.Rap WHERE marap = '" + marap + "'") > 0;
        }

        public RapDAO LayRapTheoMaRap(string id)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Rap WHERE marap = '" + id + "'");
            foreach (DataRow item in table.Rows)
            {
                return new RapDAO(item);
            }
            return null;
        }

        public RapDAO LayRapTheoTenRap(string name)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Rap WHERE tenrap = N'" + name + "'");
            foreach (DataRow item in table.Rows)
            {
                return new RapDAO(item);
            }
            return null;
        }
    }
}
