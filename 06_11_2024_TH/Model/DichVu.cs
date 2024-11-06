using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_DV.Model
{
    internal class DichVu
    {
        public DichVu(int iD, string name, float price)
        {
            ID = iD;
            Name = name;
            Price = price;
        }

        public int ID { set; get; }
        public string Name { set; get; }
        public float Price { set; get; }
    }
}
