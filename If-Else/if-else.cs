using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time <=18)
            {
                Console.WriteLine("iyi günler!");
            }
            else
            {
                Console.WriteLine("iyi geceler!");
            }

            string sonuc = time >= 6 && time < 11 ? "günaydin!" : "iyi günleré";
            Console.WriteLine(sonuc);


        }
    }
}
