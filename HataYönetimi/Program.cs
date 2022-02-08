using System;

namespace HataYönetimi
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir sayi giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi : " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally
            {
                Console.Write("işlem tamamlandi.");
            }


            /*try{ Hataya sebebiyet verme ihtimali olan kod }
            catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
            finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }*/

            try
            {
                //int a= int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-123456789456");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Cok kücük/büyük bir deger girdiniz.");
                Console.WriteLine(ex);
            }
           


        }
    }
}
