using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kapsülleme 
            //Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur.
            //Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekirse Property Kavramı ile yaparız.
            //Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.

            Ogrenci ogrenci1 = new Ogrenci("Ece Melis", "Bozdağ" , 1055 , 4);
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();
            
       


        }

        
    }

    class Ogrenci 
    {
        private string isim;
        private string soyad;
        private int ogrenciNo;
        private int sinif;
        public string Isim { get => isim ; set => isim = value; }
        public string Soyad { get => soyad ; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo ; set => ogrenciNo = value; }
        public int Sinif { get => sinif ; set => sinif = value; }

        public Ogrenci()
        {

        }
        public Ogrenci(string isim, string soyad , int ogrenciNo , int sinif)
        {
            Isim = isim;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;


        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci adi: {0}", this.Isim);
            Console.WriteLine("Öğrenci soyadi: {0}", this.Soyad);
            Console.WriteLine("Öğrenci  no: {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci sinifi: {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }
    }
}

    