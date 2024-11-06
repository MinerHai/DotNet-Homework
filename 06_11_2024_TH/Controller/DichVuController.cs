using QLKH_DV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_DV.Controller
{
    internal class DichVuController
    {
        public DichVuController()
        {
            this.ds = new List<DichVu>() {
                new DichVu(1, "Dịch vụ 1", 100.0f),
                new DichVu(2, "Dịch vụ 2", 200.0f),
                new DichVu(3, "Dịch vụ 3", 300.0f),
                new DichVu(4, "Dịch vụ 4", 400.0f),
        };
        }

        public List<DichVu> ds { get; set; }
    }
}
