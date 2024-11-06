using QLKH_DV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH_DV.Controller
{
    internal class KhachHangController
    {
        public KhachHangController()
        {
            this.ds = new List<KhachHang>() {
                new KhachHang("Lê Tiến Hải", "0377586361", "Vĩnh Phúc"),
                new KhachHang("Kiều Minh Thái", "0494294921", "Hà Nội"),
                new KhachHang("Nam Tào", "0377586361", "Nghệ An"),
                new KhachHang("Hoàng Minh Quân", "0377586361", "Hà Nội"),
        };
        }

        public List<KhachHang> ds { get; set; }
        public void AddKhachHang(string _name, string _sdt, string _diachi)
        {
            ds.Add(new KhachHang(_name, _sdt, _diachi));
        }
        public void RemoveKhachHang(int _id)
        {
            KhachHang _KHACH = ds.Where(k => k.ID == _id).FirstOrDefault();
            if (_KHACH == null)
                return;
            ds.Remove(_KHACH);
        }
        public void EditKhachHang(int _id, string _name, string _sdt, string _diachi)
        {
            KhachHang _KHACH = ds.Where(k => k.ID == _id ).FirstOrDefault();
            if (_KHACH == null)
                return;
            _KHACH.Name = _name;
            _KHACH.SDT = _sdt;
            _KHACH.DiaChi = _diachi;
        }

    }
}
