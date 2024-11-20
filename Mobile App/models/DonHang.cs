using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_App.models
{
    internal class DonHang
    {
        public DonHang(int id, int khachHangId, int sanPhamId, int soLuong, DateTime ngayMua)
        {
            Id = id;
            KhachHangId = khachHangId;
            SanPhamId = sanPhamId;
            SoLuong = soLuong;
            NgayMua = ngayMua;
        }
        public DonHang(int khachHangId, int sanPhamId, int soLuong, DateTime ngayMua)
        {
            KhachHangId = khachHangId;
            SanPhamId = sanPhamId;
            SoLuong = soLuong;
            NgayMua = ngayMua;
        }

        public int Id { get; set; }
        public int KhachHangId { get; set; }
        public int SanPhamId { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMua { get; set; }
    }
}
