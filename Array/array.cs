using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //dizi tanımlama
            string[] renkler = new string[3];

            string[] hayvanlar = { "cita", "timsah", "koala" };

            int[] dizi;
            dizi = new int[10];

            //dizi değer atama ve erişim

            renkler[0] = "turkuaz";
            Console.WriteLine(hayvanlar[2]);

            dizi[3] = 14;
            Console.WriteLine(dizi[3]);

            // Döngülerle dizi kullanımı 
            // klavyeden girilen n tane sayinin ortalamasini alan program

            Console.WriteLine("Lütfen kac sayi kullanacağinizi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int[] sayilar = new int[sayi];

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Lütfen {0}. sayiyi girin  ", (i + 1));
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;

            }
            Console.WriteLine("Girdiğiniz sayilarin ortalamasi:" + toplam / sayi);



            

        }
    }
}