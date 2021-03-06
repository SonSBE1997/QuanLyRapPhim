﻿using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.BLL
{
    public class HangSanXuatBLL
    {
        public DataTable LayDanhSachHangSanXuat()
        {
            return DataProvider.Instance.ExcuteQuery("SELECT mahangsx as [Mã hãng sản xuất], tenhangsx as [Tên hãng sản xuất] FROM dbo.HangSX");
        }

        public bool KiemTraHangSanXuat(string mahang)
        {
            return DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.HangSX WHERE mahangsx = '" + mahang + "'").Rows.Count > 0;
        }

        public bool XoaHangSanXuat(string mahang)
        {
            return DataProvider.Instance.ExcuteNonQuery("EXEC dbo.USP_XoaHangSX  @mahangsx", new object[] { mahang }) > 0;
        }


        public bool SuaHangSanXuat(HangSXDAO hang)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("UPDATE dbo.HangSX SET tenhangsx = N'{0}' WHERE mahangsx = '{1}'", hang.TenHang, hang.MaHang)) > 0;
        }

        public bool ThemHangSanXuat(HangSXDAO hang)
        {
            return DataProvider.Instance.ExcuteNonQuery(string.Format("INSERT INTO dbo.HangSX ( mahangsx, tenhangsx )VALUES( '{0}', N'{1}')", hang.MaHang, hang.TenHang)) > 0;
        }

        public HangSXDAO LayHangSXTheoTen(string tenhang)
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.HangSX WHERE tenhangsx = N'" + tenhang + "'");
            foreach (DataRow row in table.Rows)
            {
                return new HangSXDAO(row);
            }
            return null;
        }

        public List<string> LayDanhSachTenHangSX()
        {
            List<string> list = new List<string>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.HangSX");
            foreach (DataRow row in table.Rows)
            {
                list.Add(row["tenhangsx"].ToString());
            }
            return list;
        }

    }
}
