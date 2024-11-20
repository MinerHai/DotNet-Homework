using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.models
{
    internal class KhachHang
    {
        public KhachHang(int id, string tenKH, string diaChi, string sDT)
        {
            Id = id;
            TenKH = tenKH;
            DiaChi = diaChi;
            SDT = sDT;
        }
        public int Id { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }
}
