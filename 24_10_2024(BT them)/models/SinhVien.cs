using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_2024_BT_them_.models
{
    internal class SinhVien
    {
        public SinhVien(string? id, string? name, DateTime ngaysinh, string? diachi, string? email, string? dienThoai, string? khoa, string? gioiTinh)
        {
            this.id = id;
            this.name = name;
            this.ngaysinh = ngaysinh;
            Diachi = diachi;
            Email = email;
            DienThoai = dienThoai;
            Khoa = khoa;
            GioiTinh = gioiTinh;
        }
        [Required]
        public string? id { set; get; }
        public string? name { set; get; }
        public DateTime ngaysinh { set; get; }
        public string? Diachi { set; get; }
        public string? Email { set; get; }
        public string? DienThoai { set; get; }
        public string? Khoa { set; get; }
        public string? GioiTinh { set; get; }
    }
}
