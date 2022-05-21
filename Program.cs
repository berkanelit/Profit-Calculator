using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ayı Giriniz");
            int aylik = int.Parse(Console.ReadLine());
            Console.WriteLine("Paranızı Giriniz");
            int para = int.Parse(Console.ReadLine());
            Console.WriteLine("Karı Yüzdesini Giriniz");
            int kar = int.Parse(Console.ReadLine());
            int toplam;
            for (int i = 0; i <= aylik; i++)
            {
                toplam = para * kar / 100;
                para = toplam + para;
            }
            Console.WriteLine("Yıl Sonu Kar Marjınız : " + para);
            Console.ReadLine();
        }
    }
    
}
