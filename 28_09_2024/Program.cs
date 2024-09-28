namespace LTH{
    public class Program{
        public static void Main(){
            Console.WriteLine("Nhap so luong sinh vien:");
            int n = Convert.ToInt32(Console.ReadLine());
            DSSV dssv = new DSSV();
            for(int i = 0; i < n; i++)
                dssv.ThemSinhVien();
            Console.WriteLine("DANH SACH VUA NHAP:");
            dssv.HienThiDS();
            Console.WriteLine("Sinh vien co diem trung binh cao nhat la:");
            SinhVien? sv = dssv.DTBCaoNhat();
            sv.HienThongTin();
        }
    }
}