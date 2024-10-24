using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_2024_BT_them_.models
{
    internal class Khoa
    {
        public Khoa()
        {
        }

        public String TenKhoa { set; get; }
        public List<SinhVien> dssv { set; get; }
        public override string? ToString()
        {
            return TenKhoa;
        }

    }
}
