using System;
using System.Collections.Generic; //

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generic Koleksiyonlar
            //Generic list System.Colections.Generic isim uzayı altında bulunan bit list sınıfı koleksiyonudur.
            // Generic olmasını sağlayan da burdaki T veri tipidir. T listenin hangi türden veri tutacağını belirler
            //tanımlamadan sonra  farklı veri tipi tutmaya izin vermez.


            // List<T> class T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(263);
            sayiListesi.Add(243);
            sayiListesi.Add(83);
            sayiListesi.Add(3);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("turuncu");
            renkListesi.Add("mor");
            renkListesi.Add("mavi");
            renkListesi.Add("yesil");

            // Count 
            Console.WriteLine(renkListesi.Count);

            // Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);

            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));

            // listeden eleman cıkarma 
            renkListesi.Remove("turuncu");

            renkListesi.RemoveAt(0);

            // liste icinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste icerisinde bulundu.");

            // eleman ile indexe erişme

            renkListesi.BinarySearch("sari");

            // diziyi list e cevirme

            string[] hayvanlar = { "kedi", "köpek", "kaplumbağa" };

            List<string> hayvanlarListesi = new List<string>(hayvanlar);

            // list içinde nesne tutmak 
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanıcı1 = new Kullanicilar();
            kullanıcı1.Isim = "Mislina";
            kullanıcı1.Soyisim = "Cetiner";
            kullanıcı1.Yas = 23;

            Kullanicilar kullanıcı2 = new Kullanicilar();
            kullanıcı2.Isim = "beril";
            kullanıcı2.Soyisim = "külahli";
            kullanıcı2.Yas = 24;

            kullaniciListesi.Add(kullanıcı1);
            kullaniciListesi.Add(kullanıcı2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 25
            });

            foreach(Kullanicilar kullanici in kullaniciListesi)
            {
                Console.WriteLine(kullanici.Isim);
                Console.WriteLine(kullanici.Soyisim);
                Console.WriteLine(kullanici.Yas);

            }

            yeniListe.Clear();


        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyisim;
        int yas;
        public string Isim { get=>isim; set => isim = value ; }
        public string Soyisim {get=>soyisim; set => soyisim = value ; }
        public int Yas  { get=>yas; set => yas = value ; }
    }
}
