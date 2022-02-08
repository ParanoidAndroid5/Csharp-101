using System;

namespace patikaCsharp
{
    class typeConversion
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            //Bir değişkenin kendinden daha yüksek kapasiteli bir değişkene atanmasıdır. 
            //Veri kaybı olmaz.

            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine(d);

            string s = "mislina";
            char f = 's';
            object g = s + f;
            Console.WriteLine(g);




            //Explicit Conversion

            float x = 4.40f;
            byte y = (byte)x;
            Console.WriteLine(y);

            // ToString Methodu 
            int m = 6;
            string k = m.ToString();
            Console.WriteLine(k);

            // System.Convert Sınıfı
            string s1 = "10", s2 = "20";
            int sayi1, sayi2,toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi2 + sayi1;
            Console.WriteLine("toplam:" + toplam);

            // Parse Method (stringe dönüstürmek icin)
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);
            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + double1);







        }
    }
}
