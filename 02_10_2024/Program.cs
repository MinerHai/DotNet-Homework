using SanPham;

namespace LTH
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone()
            {
                Name = "Iphone 16",
                Price = 9999,
                Stock = 1000,
                Brand = "Apple"
            };
            LapTop laptop = new LapTop()
            {
                Name = "Radion X100",
                Price = 8888,
                Stock = 20,
                Memory = 128
            };
            Accessory accessory = new Accessory()
            {
                Name = "Grillz",
                Price = 2222222,
                Stock = 5,
                Size = 20
            };
            List<Product> products = new List<Product>();
            products.Add(phone);
            products.Add(laptop);
            products.Add(accessory);
            Console.WriteLine("THONG TIN SAN PHAM:");
            foreach (var p in products)
                p.DisplayProductInfo();
            accessory.Sell(2);
            laptop.Sell(1);
            phone.Sell(3);
            laptop.ApplyDiscount(20);
            Console.WriteLine("THONG TIN SAN PHAM:");
            foreach (var p in products)
                p.DisplayProductInfo();
        }
    }
}
