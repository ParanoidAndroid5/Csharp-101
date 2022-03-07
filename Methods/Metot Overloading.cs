using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler 
            string sayi = "999";
            int outSayi; // bunun yerine bool sonuc = int.TryParse(sayi , out int outSayi); seklinde tanımlayabilirsin.

            bool sonuc = int.TryParse(sayi , out outSayi);
            if(sonuc)
            {
                Console.WriteLine("basarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("basarisiz");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,3 , out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Metot Aşırı Yükleme - Overloading 

            int ifade  = 999;
            //instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);


            // metot imzasi 
            // metotAdi + parametre sayisi + parametre

            instance.ekranaYazdir("Mislina" , "CETİNER");



        }
    }

    class Metotlar
    {
        public void Topla(int a , int b , out int Toplam)
        {
            Toplam = a+b;
        }

        public void ekranaYazdir(string veri )
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(int veri )
        {
            Console.WriteLine(veri);
        }
        public void ekranaYazdir(string veri1 , string veri2 )
        {
            Console.WriteLine(veri1 + veri2);
        }


    }
}