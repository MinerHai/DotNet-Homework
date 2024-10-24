namespace _24_10_2024_BT_them_.models
{
    internal class QuanLySV
    {
        public List<Khoa> ds;
        public QuanLySV()
        {
            ds = new List<Khoa>()
            {
                new Khoa(){
                    TenKhoa = "Công nghệ thông tin",
                    dssv = new List<SinhVien>
                    {
                        new SinhVien("SV01", "Lê Tiến Hải", DateTime.Today, "Vĩnh Phúc", "haiminer45@gmail.com","0377586361","Công nghệ thông tin", "Nam")
                    }
                },
                new Khoa()
                {
                    TenKhoa = "Cơ khí",
                    dssv = new List<SinhVien> { }
                },
                new Khoa()
                {
                    TenKhoa = "Điện tử viễn thông",
                    dssv =new List<SinhVien> { new SinhVien("SV02", "Lế Tiến Hòn", DateTime.Today, "Vĩnh Phúc", "haiminer45@gmail.com", "0377586361", "Công nghệ thông tin", "Nam") }
                },
                new Khoa()
                {
                    TenKhoa = "Năng lượng",
                    dssv = new List<SinhVien>{}
                }
            };
        }
        public void ThemSinhVien(String Tenkhoa, SinhVien sv)
        {
            Khoa khoa = ds.Where(k => k.TenKhoa.Equals(Tenkhoa)).FirstOrDefault();
            khoa.dssv.Add(sv);
        }
        public void XoaSinhVien(String Tenkhoa, String id_sv)
        {
            Khoa khoa = ds.Where(k => k.TenKhoa.Equals(Tenkhoa)).FirstOrDefault();
            SinhVien sv = khoa.dssv.Where(sv => sv.id.Equals(id_sv)).FirstOrDefault();
            khoa.dssv.Remove(sv);
        }
        public void SuaSinhVien(String Tenkhoa, SinhVien _sv)
        {
            Khoa khoa = ds.Where(k => k.TenKhoa.Equals(Tenkhoa)).FirstOrDefault();
            SinhVien sv = khoa.dssv.Where(sv => sv.id.Equals(_sv.id)).FirstOrDefault();
            sv.name = _sv.name;
            sv.GioiTinh = _sv.GioiTinh;
            sv.Diachi = _sv.Diachi;
            sv.DienThoai = _sv.DienThoai;
            sv.Khoa = _sv.Khoa;
            sv.GioiTinh = _sv.GioiTinh;
            sv.Email = _sv.Email;
        }

    }
}
