using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_DV.Model
{
    internal class KhachHang
    {
        private static int cnt_ID = 1;

        public KhachHang(string? name, string? sDT, string? diaChi)
        {
            ID =  cnt_ID++;
            Name = name;
            SDT = sDT;
            DiaChi = diaChi;
        }

        public KhachHang(int iD, string? name, string? sDT, string? diaChi)
        {
            ID = iD;
            Name = name;
            SDT = sDT;
            DiaChi = diaChi;
        }

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
    }
}
