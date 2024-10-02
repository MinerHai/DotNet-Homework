using LTH;
namespace SanPham
{
    public class MobilePhone : Product, ISellable
    {
        public string? Brand { set; get; }
        public override void ApplyDiscount(decimal percentage)
        {
            this.Price = this.Price * percentage / 100;
            Console.WriteLine("Áp dụng voucher thành công");
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine("-----------------------------------------");
        }

        public bool IsInStock() => Stock > 0;
        public void Sell(int quanity)
        {
            if (quanity > Stock)
                Console.WriteLine("So luong k du (con {Stock} san pham)");
            else
            {
                Stock -= quanity;
                Console.WriteLine("Ban thanh cong!!");
            }
        }
    }
    public class LapTop : Product, ISellable
    {
        public decimal? Memory { set; get; }
        public override void ApplyDiscount(decimal percentage)
        {
            this.Price = this.Price * percentage / 100;
            Console.WriteLine("Áp dụng voucher thành công");
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Memory: {Memory}");
            Console.WriteLine("-----------------------------------------");
        }

        public bool IsInStock() => Stock > 0;
        public void Sell(int quanity)
        {
            if (quanity > Stock)
                Console.WriteLine("So luong k du (con {Stock} san pham)");
            else
            {
                Stock -= quanity;
                Console.WriteLine("Ban thanh cong!!");
            }
        }
    }
    public class Accessory : Product, ISellable
    {
        public int Size {set; get; }
        public override void ApplyDiscount(decimal percentage)
        {
            this.Price = this.Price * percentage / 100;
            Console.WriteLine("Áp dụng voucher thành công");
        }

        public override void DisplayProductInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Stock: {Stock}");
            Console.WriteLine($"Memory: {Size}");
            Console.WriteLine("-----------------------------------------");
        }

        public bool IsInStock() => Stock > 0;
        public void Sell(int quanity)
        {
            if (quanity > Stock)
                Console.WriteLine("So luong k du (con {Stock} san pham)");
            else
            {
                Stock -= quanity;
                Console.WriteLine("Ban thanh cong!!");
            }
        }
    }
}