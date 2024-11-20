using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.models
{
    internal class SanPham
    {
        public SanPham(int id, string tenSP, decimal gia, string hangSX)
        {
            Id = id;
            TenSP = tenSP;
            Gia = gia;
            HangSX = hangSX;
        }
        public SanPham(string tenSP, decimal gia, string hangSX)
        {
            TenSP = tenSP;
            Gia = gia;
            HangSX = hangSX;
        }

        public int Id { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public string HangSX { get; set; }

    }
}
