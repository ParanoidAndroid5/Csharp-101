using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ekrandan girilen sayıya kadar olan tek sayilari yazdir

            
            Console.WriteLine("sayiyi giriniz:");
            int sayi = int.Parse( Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);


            }

                 // 1-1000 arasindaki tek ve çift sayilari toplayalım.En son çıktımızı yazdiralim

            int teksayiToplam = 0;
            int ciftsayiToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    teksayiToplam = teksayiToplam + i;
                }
                else
                    ciftsayiToplam = ciftsayiToplam +i;

            }
            Console.WriteLine("tek sayilarin toplami:" +teksayiToplam);
            Console.WriteLine("cift sayilarin toplami:" + ciftsayiToplam);


            //sonsuz döngü 
            for(;;)
            {
                //

            }


        }
    }
}