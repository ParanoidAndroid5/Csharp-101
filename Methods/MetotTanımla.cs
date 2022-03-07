using System;

namespace c101
{
    class Program
    {
        static async void Main(string[] args)
        {
            
            //erisim_belirtici geri_donustipi metot_adi(parametreListesi/arguman)
            //{
                //komutlar;
            //}
            int a = 46;
            int b = 32;
            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));

            int sonuc2 = ornek.ArttırveTopla(ref a, ref b);
            ornek.EkranaYazdir(sonuc2);
            

            // ref -> bellek karsılıgını veriyor yani tanımladığım değerin kopyası değil kendisi isleme giriyor.
            static int Topla(ref int deger1, ref int deger2) 
            {
                return (deger1+deger2);
            }

        }
    }

    class Metotlar 
    {
       public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        
        public int ArttırveTopla(int deger1, int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1+deger2;
        }


    }
}