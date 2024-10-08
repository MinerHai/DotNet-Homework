namespace LTH
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            XeDap xedap = new XeDap()
            {
                TenPT = "Fix Gear 5000",
                LoatNhienLieu = "Suc Nguoi",
            };
            XeHoi xehoi = new XeHoi()
            {
                TenPT = "VinFast",
                LoatNhienLieu = "Dien"
            };
            Console.WriteLine("-------------------------");
            Console.WriteLine(xedap.TenPT);
            Console.WriteLine(xedap.LoatNhienLieu);
            xedap.DiChuyen();
            xedap.TocDoToiDa();
            Console.WriteLine("-------------------------");
            Console.WriteLine(xehoi.TenPT);
            Console.WriteLine(xehoi.LoatNhienLieu);
            xehoi.DiChuyen();
            xehoi.TocDoToiDa();
            xehoi.MucTieuThu();

        }
    }

}