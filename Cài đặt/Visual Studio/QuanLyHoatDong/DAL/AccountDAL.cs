using QuanLyHoatDong.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoatDong.DAL
{
    public class AccountDAL
    {
        DataConnection DataConnection;
        SqlDataAdapter data;
        SqlCommand cmd;

        public AccountDAL()
        {
            DataConnection = new DataConnection();
        }

        public DataTable getAccount(string tdn, string ps, string ltk)
        {
            string sqlString = "";
            switch (ltk)
            {
                case "Sinh Viên":
                    sqlString = "select TK.TenDangNhap, TK.MatKhau, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhau = N'" + ps + "' and TK.LoaiTK = N'Sinh Viên'";
                    break;
                case "Ban Tổ Chức":
                    sqlString = "select TK.TenDangNhap, TK.MatKhau, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhau = N'" + ps + "' and TK.LoaiTK = N'Ban Tổ Chức'";
                    break;
                case "Admin":
                    sqlString = "select TK.TenDangNhap, TK.MatKhau, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhau = N'" + ps + "' and TK.LoaiTK = N'Admin'";
                    break;
                case "Đơn Vị Quản Lý":
                    sqlString = "select TK.TenDangNhap, TK.MatKhau, TK.LoaiTK  from TaiKhoan AS TK\r\nwhere TK.TenDangNhap = N'" + tdn + "' and TK.MatKhau = N'" + ps + "' and TK.LoaiTK = N'Đơn Vị Quản Lý'";
                    break;
                default:
                    break;
            }

            /*
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            data = new SqlDataAdapter(sqlString, connection);

            // B4: Mở kết nối
            connection.Open();
         

            //B5: Đổ dữ liệu SqlAdapter vào datatable
            DataTable dataTable = new DataTable();
            data.Fill(dataTable);

            //B6: Đóng kết nối
            connection.Close();
            return dataTable;*/
            //SqlConnection connection = Dataconnection.GetConnection();
            SqlConnection connection = DataConnection.getConnect();
            SqlCommand command = new SqlCommand("SELECT * FROM TaiKhoan", connection);
          
            //SqlCommand cmd = new SqlCommand();
          
           // cmd.Connection = conn;

            SqlDataAdapter data = new SqlDataAdapter(command);

            connection.Open();

            DataTable dt = new DataTable();
            data.Fill(dt);

            connection.Close();

            return dt;

        }

        //public DataTable getInformationAccount()
        //{
        //    return DataTable;
        //}
    }
}
