namespace LTH{
    class XeHoi : PhuongTien, IThongTinThem
    {
        public override void DiChuyen()
        {
            Console.WriteLine("Xe hoi dang di chuyen!!");
        }

        public void MucTieuThu()
        {
            Console.WriteLine("Muc tieu thu toi da la 50l");
        }

        public double TocDoToiDa()
        {
            Console.WriteLine("Toc do toi da la: 500km/h");
            return 500;
        }
    }
}