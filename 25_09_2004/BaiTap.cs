using System.Collections;
using System;
namespace BaiTap
{
    public class BTVN
    {
        public void BaiTap1()
        {
            int n;
            Console.Write("Nhap n:");
            n = Convert.ToInt16(Console.ReadLine());
            ArrayList array = new ArrayList();
            Console.WriteLine("Nhap so:");
            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt16(Console.ReadLine());
                array.Add(num);
            }
            Console.WriteLine("---------------------------------");
            array.Sort();
            foreach (int num in array)
                Console.Write($"{num}, ");
        }
        public void BaiTap2()
        {
            Hashtable hash = new Hashtable();
            int n;
            Console.Write("Nhap n:");
            n = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ten:");
                string ten = Console.ReadLine();
                int age = Convert.ToInt16(Console.ReadLine());
                hash[ten] = age;
            }
            foreach (DictionaryEntry h in hash)
            {
                Console.WriteLine($"{h.Key}-{h.Value}");
            }
        }
        public void BaiTap3()
        {
            int n;
            Console.Write("Nhap n:");
            n = Convert.ToInt16(Console.ReadLine());
            Dictionary<string, int> students = new Dictionary<string, int>();
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap ten:");
                string name = Console.ReadLine();
                Console.Write("Diem:");
                int score = Convert.ToInt16(Console.ReadLine());
                students[name] = score;
            }
            Console.WriteLine("----------------------------------------");
            foreach(var s in students){
                Console.WriteLine($"{s.Key} - {s.Value}");
            }
        }

    }
}