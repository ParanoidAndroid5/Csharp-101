using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = DateTime.Now.Month;
            switch(month)
            {
                case 1:
                    Console.WriteLine("ocak ayindasiniz!");
                    break;
                case 2:
                    Console.WriteLine("subat ayindasiniz!");
                    break;
                case 9:
                    Console.WriteLine("eylül ayindasiniz!");
                    break;
                default:
                    Console.WriteLine("hatali veri girisi!");
                    break;

            }

            // birden fazla kosulda ayni ifadenin calısmasını istiyorsak 

            switch(month)
            {

                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis aylarındasınız.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz aylarindasiniz.");
                    break;
                default:
                    break;
            }

        }
    }
}