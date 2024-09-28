using System.Data.SqlTypes;
using Microsoft.VisualBasic;

namespace LTH{
    public class DSSV{
        private readonly List<SinhVien> ds;
        public DSSV(){
            ds = new List<SinhVien>();
        }
        public void ThemSinhVien(){
            SinhVien tmp = new SinhVien(); 
            tmp.NhapThongTin();
            ds.Add(tmp);
        }
        public void TimSinhVienTheoMSSV(string? MSSV){
            if (String.IsNullOrEmpty(MSSV))
            {
                Console.WriteLine("Khong ton tai sinh vien");
                return; 
            }
            SinhVien? tmp = ds.Where(sv => sv.MSSV == MSSV).FirstOrDefault();
            if (tmp == null)
            {
                Console.WriteLine("Khong ton tai sinh vien");
                return; 
            }
            
            tmp.HienThongTin();

        }
        public void HienThiDS(){
            foreach(var sv in ds)
            {
                sv.HienThongTin();
                Console.WriteLine("------------------------------------------------");
            }
        }
        public SinhVien? DTBCaoNhat(){
            double diemtb = ds.Max(sv => sv.DTB);
            SinhVien? sv = ds.Where(sv => sv.DTB == diemtb).FirstOrDefault();
            return sv;
        }
    }
}