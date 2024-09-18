namespace MyProduct{
    public class ShopCart{
        private List<Product> products = new List<Product>();
        public void AddProduct(Product product){
            products.Add(product);
        }
        public void RemoveProduct(string _Ten){
            var removeP = products.Where(p => p.Ten == _Ten).FirstOrDefault();
            products.Remove(removeP);
        }
        public double TongTien(){
            double tien = 0.0f;
            foreach(var p in products){
                tien += p.Gia;
            }
            return tien;
        }
        public void HienThi(){

            foreach(var p in products){
                p.ThongTin();
                Console.WriteLine("--------------------------------------------");
            }
            Console.WriteLine($"Tong thanh toan: {TongTien()}");
        }

    }
}