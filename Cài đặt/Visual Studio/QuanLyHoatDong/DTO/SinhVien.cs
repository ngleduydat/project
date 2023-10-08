using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoatDong.DTO
{
    internal class SinhVien
    {
        public int id_sv { get; set; }
        public int mssv { get; set; }
        public string tensv { get; set; }
        public string sex { get; set; }
        public DateTime ngaysinh { get; set; }
        public string dantoc { get; set; }
        public string tongiao { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string cccd { get; set; }
        public int manh { get; set; }
        public int malsv { get; set; }
    }
}
