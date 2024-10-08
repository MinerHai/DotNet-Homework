namespace LTH{
    class XeDap : PhuongTien, IThongTinThem
    {
        public override void DiChuyen()
        {
            Console.WriteLine("Xe dap dang di chuyen!!");
        }

        public void MucTieuThu()
        {
            throw new NotImplementedException();
        }

        public double TocDoToiDa()
        {
            Console.WriteLine("Toc do toi la: 25km/h");
            return 25.0f;
        }
    }
}