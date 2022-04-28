using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
           // Kurucu(Yapıcı) Metotlar - Constructor
           // Kurucu Metotların isimleri class isimleri ile aynı olmak zorundadır. 
           // Erişim belirleyicileri public olmak zorundadır.
           // Geriye dönüş değerleri yoktur. 
           // Parametre alabilir. Overload edilebilirler.
           //Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında 
           //onların default değerlerini set etmektir.




            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Dilara";
            calisan1.Soyad = "Köse";
            calisan1.No = 233456;
            calisan1.Departman = "İnsan Kaynaklari";

            Calisan calisan2 = new Calisan("Hande" , "İlhan", 2357, "Satın Alma");

            Calisan calisan3 = new Calisan("Mislina" , "Cetiner");

            calisan1.CalisanBilgileri();
            calisan2.CalisanBilgileri();
            calisan3.CalisanBilgileri();


        }

        
    }
    class Calisan
    {
        
        public Calisan(string ad , string soyad , int no , string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

        }
        public Calisan(string ad , string soyad )
        {
            this.Ad = ad;
            this.Soyad = soyad;
       

        }
        public Calisan()
        {
            
        }

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