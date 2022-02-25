using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Sınıfı ve Methodlari
            // Sort

            int[] sayiDizisi = { 23, 56, 34, 15, 4, 72 };
            foreach (var item in sayiDizisi)
            {
                //sırasiz
                Console.WriteLine(item);
            }
            // sırali 
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {

                Console.WriteLine(item);

            }

            // Array.Clear -> Dizinin belirtilen elemanlarını varsayılan değerine getirir.numeric bir dizi ise 0 olarak setler.
            

            Array.Clear(sayiDizisi,2, 2);

            foreach (var item in sayiDizisi)
            {

                Console.WriteLine(item);

            }

            // Reverse 
            Array.Reverse(sayiDizisi);

            // IndexOf 

            Console.WriteLine(Array.IndexOf(sayiDizisi, 4));

            // Resize 

            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var item in sayiDizisi)
            {

                Console.WriteLine(item);

            }


        }
    }
}