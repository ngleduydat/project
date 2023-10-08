using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHoatDong.DTO

{
    public class DataConnection
    {
        string connectionString;
        public DataConnection()
        {
            connectionString = @"Data Source=DESKTOP-2OHH8I0\DUYDAT;Initial Catalog=DB_QuanLyHoatDong;Integrated Security=True";
        }

        public SqlConnection getConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
/*
    public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-2OHH8I0\DUYDAT;Initial Catalog=DB_QuanLyHoatDong;Integrated Security=True");
            return Conn;
        }
*/
