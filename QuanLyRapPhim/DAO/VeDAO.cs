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
        public string MaShow { get; set; }

        public string MaVe { get; set; }

        public string HangGhe { get; set; }

        public int SoGhe { get; set; }

        public string TrangThai { get; set; }

        public VeDAO(DataRow row)
        {
            this.MaShow = row["mashow"].ToString();
            this.MaVe = row["mave"].ToString();
            this.HangGhe = row["hangghe"].ToString();
            this.SoGhe = (int)row["soghe"];
            this.TrangThai = row["trangthai"].ToString();
        }

        public VeDAO()
        {
        }

        public VeDAO(string mashow,string mave,string hangghe,int soghe,string trangthai)
        {
            this.MaShow = mashow;
            this.MaVe = mave;
            this.HangGhe = hangghe;
            this.SoGhe = soghe;
            this.TrangThai = trangthai;
        }
    }
}
