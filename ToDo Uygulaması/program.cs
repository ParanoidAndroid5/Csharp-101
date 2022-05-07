using System;

namespace ToDoUygulaması
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] secenekler = { "Board Listelemek", "Board a Kart Eklemek ", "Board dan kart silmek", "Kart Taşımak" };
        anaSecim:
            int sayac = 0;
            Console.WriteLine("Lütfen yapmak istediginiz islemi seciniz:");
            Console.WriteLine("*****************************************");

            foreach(string secenek in secenekler)
            {
                sayac++;
                Console.WriteLine($"({sayac}) {secenek}");
            }
            int secim;
            int.TryParse(Console.ReadLine(), out secim);
            ToDoUygulaması.toDoOperations todo = new ToDoUygulaması.toDoOperations(); // ?

            switch(secim)
            {
                case 1:
                    Console.Clear();
                    todo.BoardListele();
                    break;
                case 2:
                    Console.Clear();
                    todo.BoardaKartEkle();
                    break;
                case 3:
                    Console.Clear();
                    todo.BoarddanKartSil();
                    break;
                case 4:
                    Console.Clear();
                    todo.KartTasi();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Menüden secim yapiniz.");
                    goto anaSecim;


            }
            Console.ReadLine();

            

            

        }
    }
}
