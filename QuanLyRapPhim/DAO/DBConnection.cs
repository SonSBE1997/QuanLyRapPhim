using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    class DBConnection
    {
        public static SqlConnection getConenction()
        {
            try
            {
                string datasource = "DESKTOP-8NS0940\\MANH";
                string database = "CinemaManagement";
                string username = "manh";
                string password = "manh";

                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                          + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

                SqlConnection conn = new SqlConnection(connString);

                return conn;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("connect database fail");
            }

        }
    }
}
