namespace LTH{
    public class SinhVien{
        public string? HoTen {set; get;}
        public string? MSSV {set; get;}
        public double DTB {set; get;}
        public void NhapThongTin(){
            Console.Write("Nhap ma sinh vien:");
            MSSV = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            HoTen = Convert.ToString(Console.ReadLine());
            Console.Write("Nhap diem trung binh:");
            DTB = Convert.ToDouble(Console.ReadLine());
        }
        public void HienThongTin(){
            Console.WriteLine($"MSSV: {MSSV}");
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"DTB: {DTB}");

        }
    }
}