using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DateTime.Now); // günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString()); // 15 Mart 2022 Salı 
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 15.03.2022

            Console.WriteLine(DateTime.Now.ToLongTimeString());  // 10:55:20 AM
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 10:55 AM



            Console.WriteLine(DateTime.Now.AddDays(4));
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddYears(4));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));


            // Datetime Format 

            Console.WriteLine(DateTime.Now.ToString("dd")); // integer karsılıgını döner 15
            Console.WriteLine(DateTime.Now.ToString("ddd")); // string karsılıgını döner Sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //string karsılıgını döner Saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); // 03
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

            Console.WriteLine(DateTime.Now.ToString("yy")); // 22
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

            // Math Kütüphanesi 

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Sqrt(67));
            Console.WriteLine(Math.Log(-25)); // logaritma
            Console.WriteLine(Math.Exp(3));  // e^3



            Console.WriteLine(Math.Ceiling(22.3)); // 23 -> degerden büyük en kücük
            Console.WriteLine(Math.Round(22.3));  // 22 -> hangisine daha yakınsa
            Console.WriteLine(Math.Floor(22.7)); // 22 -> degerden kücük en büyük 
        }
    }
}