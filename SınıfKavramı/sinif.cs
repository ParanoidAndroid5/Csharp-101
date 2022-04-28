using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi

            // class SinifAdi
            //{
            //   [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //   [Erisim Belirleyici] [Geri Dönüs Tipi] MetotAdi([Parametre Listesi])
            //   {
            //Metot Kuralları
            //   }

            //Erisim Belirleyiciler
            // Public -> her yerden erisilebilir.
            // Private -> sadece tanımlandıgı sınıf icerisinde erisilebilir.
            // Internal -> kendi bulundugu proje icerisinde erisilebilir.
            // Protected -> tanımlandıgı sınıf veya o sınıftan miras alan sınıflardan erisilebilir.

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Dilara";
            calisan1.Soyad = "Köse";
            calisan1.No = 233456;
            calisan1.Departman = "İnsan Kaynaklari";

            calisan1.CalisanBilgileri();

        }

        
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan adi: {0}", Ad);
            Console.WriteLine("Calisan soyadi: {0}", Soyad);
            Console.WriteLine("Calisan no: {0}", No);
            Console.WriteLine("Calisan departmani: {0}", Departman);

        }

    }


}