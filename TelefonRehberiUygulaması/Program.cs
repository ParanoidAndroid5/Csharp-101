using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            //kisiler - veritabani yok cünkü
            ContactModel.contactList.Add(new Contact("Mislina", "ÇETİNER", "4564737"));
            ContactModel.contactList.Add(new Contact("Dilar", "KÖSE", "45678737"));
            ContactModel.contactList.Add(new Contact("Hande", "İLHAN", "1364737"));
            ContactModel.contactList.Add(new Contact("Melis", "BOZDAĞ", "44637097"));
            ContactModel.contactList.Add(new Contact("Aydın", "CESUR", "243667"));

            StartApplication();
        }
        public static void StartApplication()
        {
            ContactOperations.Menu();
            string secim = Console.ReadLine();
            switch(secim)
            {
                case "1":
                    ContactOperations.AddContact();
                    break;
                case "2":
                    ContactOperations.Delete();
                    break;
                case "3":
                    ContactOperations.Update();
                    break;
                case "4":
                    ContactOperations.Listing();
                    break;
                case "5":
                    ContactOperations.Search();
                    break;
                case "6":
                    ContactOperations.Exit();
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    ContactOperations.Menu();
                    break;
            }
        }


    }
}
