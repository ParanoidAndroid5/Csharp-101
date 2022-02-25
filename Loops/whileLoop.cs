using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den baslayarak konsoldan girilen sayiya kadar(sayi dahil) aritmetik ort. hesaplayip yazdir

            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            float toplam = 0;
            float ortalama;
            

            while(sayac <= sayi)
            {
                toplam = toplam + sayac;
                sayac++;
            }
            ortalama = toplam/ sayi;
            Console.WriteLine(ortalama);

            // a'dan z'ye kadar tüm harfleri konsola yazdir
            char harf = 'a';
            while(harf <= 'z')
            {
                Console.WriteLine(harf);
                harf++;
            }

            //foreach --> koleksiyonlarda islemler icin

            string[] arabalar = { "Toyata", "Ford", "Nissan", "Volvo" };
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }


        }
    }
}
