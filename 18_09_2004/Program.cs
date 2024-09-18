using MyProduct;
namespace LTH_D17CNPM1
{
    public class Program
    {
        public static void Main(string[] agrs)
        {
            ShopCart shop = new ShopCart();
            Product p1 = new Product(
                "San pham 1",
                1,
                "Day la san pham 1",
                10
            );
            DienTu p2 = new DienTu(
                "Dien tu",
                2,
                "Day la do dien tu",
                5,
                10
            );
            QuanAo p3 = new QuanAo(
                "Quan ao",
                6,
                "Day la do quan ao",
                7.6,
                28,
                "Hong canh sen"
            );
            ThucPham p4 = new ThucPham(
                "Thuc pham",
                3,
                "Day la do thuc pham",
                5.5,
                "15/08/2004"
            );
            shop.AddProduct(p1);
            shop.AddProduct(p2);
            shop.AddProduct(p3);
            shop.AddProduct(p4);
            shop.HienThi();

        }
    }
}