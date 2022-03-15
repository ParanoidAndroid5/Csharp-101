using System;


namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // okunabilirliği arttırır.
            // ayısal verilerı string ifadelerle saklamanızı sağlar.
            //ardısık ilerler
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Cumartesi);
            Console.WriteLine((int)Gunler.Cuma);

            int sıcaklık =70;
            if(sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("disariya cıkmak icin hava biraz daha ısınsın.");
            }
            else if(sıcaklık >=(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("disariya cıkmak icin hava cok sıcak!!");
            }


        }

        enum Gunler
        {
            Pazartesi=1,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma=23, // cumartesiyi 24 olarak getirir.
            Cumartesi,
            Pazar
        }
        
        enum HavaDurumu
        {
            Soguk = 5,
            Normal = 20,
            Sıcak = 25,
            CokSıcak = 40

        }
    }
}