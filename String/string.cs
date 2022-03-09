using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Eskisehir Osmangazi Universitesi";
            string degisken2 = "Anadolu Universitesi";
            // Length 
            Console.WriteLine(degisken.Length);

            // ToUpper - ToLower
            Console.WriteLine(degisken.ToUpper);
            Console.WriteLine(degisken.ToLower);

            // Concat -> birleştirme

            Console.WriteLine(String.Concat(degisken,"Bilgisayar Mühendisliği"));

            // Compare - CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // -> 0,1,-1 dönebilir
            Console.WriteLine(String.Compare(degisken,degisken2,true)); // ingoneCase -> büyük kücük harf duyarlılığı
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            // Contains - EndsWith - StartsWith

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("mislina"));
            Console.WriteLine(degisken.StartsWith("Eskisehir"));

            // IndexOf -> ilk buldugu index döner olumsuzsa -1 döner

            Console.WriteLine(degisken.IndexOf("Eskisehir"));
            Console.WriteLine(degisken.LastIndexOf("i"));


            // Insert 
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            // PadLeft - PadRight 

            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            Console.WriteLine(degisken + degisken2.PadLeft(20,'*')); 
            Console.WriteLine(degisken.PadRight(50) + degisken2); 
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2); 

            // Remove 

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            // Replace 

            Console.WriteLine(degisken2.Replace("Anadolu","Hacettepe"));

            // Split 

            Console.WriteLine(degisken.Split(' ')[1]);

            // Substring 

            Console.WriteLine(degisken.Substring(4,6));
            Console.WriteLine(degisken.Substring(4));






















            










        }
    }
}