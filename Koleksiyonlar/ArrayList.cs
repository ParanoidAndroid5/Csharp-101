using System;
using System.Collections; //arrayList
using System.Collections.Generic;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            // Farklı veri tiplerini array list içerisinde saklayabiliriz.
            // eleman ekleyerek ve cıkararak boyutunu dinamik olarak değiştirebiliriz.

            ArrayList liste = new ArrayList();
            liste.Add("Mislina");
            liste.Add("235906");
            liste.Add(true);

            //verilere erişim -> index
            Console.WriteLine(liste[1]);

            foreach(var item in liste)
            {
                Console.WriteLine(item);
            }

            // AddRange
            string[] renkler = {"siyah","beyaz"};
            List<int> sayilar = new List<int>() {1,3,4,2,65};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            // Sort
            liste.Sort(); 
            liste.Clear();

            



            


        }
    }

    
}
