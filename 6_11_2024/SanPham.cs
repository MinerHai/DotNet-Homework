using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11_2024
{
    internal class SanPham
    {
        public SanPham(string? name, string? desc, decimal price)
        {
            Name = name;
            Desc = desc;
            Price = price;
        }

        public SanPham(int iD, string? name, string? desc, decimal price)
        {
            ID = iD;
            Name = name;
            Desc = desc;
            Price = price;
        }

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Desc { set; get; }
        public decimal Price { set; get; }
        
    }
}
