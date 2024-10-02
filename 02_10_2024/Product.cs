namespace LTH
{
    public abstract class Product{
        public string? Name {set; get;}
        public decimal Price {set; get;}
        public int Stock {set; get;}
        public abstract void DisplayProductInfo();
        public abstract void ApplyDiscount(decimal percentage);
    }
}