namespace MyProduct
{
    public class Product
    {
        public Product(string _Ten, int _Solg, string _Mota, double _Gia)
        {
            Ten = _Ten;
            Solg = _Solg;
            Mota = _Mota;
            Gia = _Gia;
        }
        public string Ten { set; get; }
        public int Solg { set; get; }
        public string Mota { set; get; }
        public double Gia { set; get; }
        public virtual void ThongTin()
        {
            Console.WriteLine($"Ten:{Ten}");
            Console.WriteLine($"Mo ta:{Mota}");
            Console.WriteLine($"So luong: {Solg}");
            Console.WriteLine($"Gia: {Gia}");
        }
    }

    public class DienTu : Product
    {
        public DienTu(string _Ten, int _Solg, string _Mota, double _Gia, int _TGBaoHanh) : base(_Ten, _Solg, _Mota, _Gia) => TGBaoHanh = _TGBaoHanh;
        public int TGBaoHanh { set; get; }
        public override void ThongTin()
        {
            base.ThongTin();
            Console.WriteLine($"Thoi gian bao hanh:{TGBaoHanh}");
        }
    }
    public class QuanAo : Product
    {
        public int size { set; get; }
        public string color { set; get; }
        public QuanAo(string _Ten, int _Solg, string _Mota, double _Gia, int _size, string _color) : base(_Ten, _Solg, _Mota, _Gia)
        {
            color = _color;
            size = _size;
        }
        public override void ThongTin()
        {
            base.ThongTin();
            Console.WriteLine($"Mau: {color}");
            Console.WriteLine($"Size: {size}");
        }
    }
    public class ThucPham : Product
    {
        public string NgayHH { set; get; }
        public ThucPham(string _Ten, int _Solg, string _Mota, double _Gia, string _NgayHH) : base(_Ten, _Solg, _Mota, _Gia)
        {
            NgayHH = _NgayHH;
        }
        public override void ThongTin()
        {
            base.ThongTin();
            Console.WriteLine($"Ngay Het Han: {NgayHH}");
        }
    }
}