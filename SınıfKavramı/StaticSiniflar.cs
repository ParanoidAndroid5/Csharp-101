using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static Sinif ve Üyeler 
            //Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz.
            // Sınıfın static üyelerinin başlangıç değerlerini static kurucular aracılığıyla yapabiliriz.
            // Parametre almazlar ve erişim belirleyicileri yoktur.


            //Bir sınıfın static olamayan üyelerine nesne olusturup erişirken
            // static olan metotlara ve özelliklere ise nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz. (. ile)

            Console.WriteLine("calisan sayisi:{0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Aydın", "Cesur", "IK");

            Console.WriteLine("calisan sayisi:{0}", Calisan.CalisanSayisi);
            
            // static classların metotlarına direkt . ile erişiriz.
            Console.WriteLine(Islemler.Topla(200,757));
            Console.WriteLine(Islemler.Cikar(200,757));




        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Depatman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Depatman = departman;
            this.Isim = isim;
            this.Soyisim = soyisim;
            calisanSayisi++;
        }


    }
     // Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.
     
    static class Islemler 
    {
        public static long Topla(int sayi1 , int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1 , int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}