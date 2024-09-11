namespace HomeWork
{
    public class Baitap
    {
        public void Baitap1()
        {
            Console.Write("Nhap so luong phan tu:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }
            Console.WriteLine($"Tong cac phan tu la: {sum}");
        }
        public void Baitap2()
        {
            int cnt = 0;
            string? s = Console.ReadLine();
            foreach (var c in s)
                if (!char.IsPunctuation(c) && c != ' ')
                    cnt++;
            Console.WriteLine($"So luong ki tu chuoi la: {cnt}");
        }
        public void Baitap3()
        {
            Console.Write("Nhap so luong phan tu:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max_num = a[0];
            foreach (var i in a)
                if (max_num < i)
                    max_num = i;
            Console.WriteLine($"Phan tu lon nhat co trong mang la {max_num}");
        }
        public void Baitap4()
        {
            Console.Write("Nhap chuoi ki tu:");
            string? s = Console.ReadLine();
            char[] chuoi = s.ToCharArray();
            Array.Reverse(chuoi);
            string chuoinguoc = new string(chuoi);
            Console.Write($"Chuoi viet nguoc la: {chuoinguoc}");
        }
        public void Baitap5()
        {
            Console.Write("Nhap so luong phan tu:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool check = true;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n / 2; i++)
                if (a[i] != a[n - 1 - i])
                {
                    check = false;
                    break;
                }
            if (check)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
        public void Baitap6()
        {
            Console.Write("Nhap chuoi ki tu:");
            string? s = Console.ReadLine();
            Console.WriteLine("Nhap ki tu can dem:");
            char? kitu = Convert.ToChar(Console.Read());
            int cnt = 0;
            foreach (var c in s)
                if (c == kitu)
                    cnt++;
            Console.WriteLine($"So luong ki tu '{kitu}' co trong chuoi la: {cnt}");
        }
    }
}