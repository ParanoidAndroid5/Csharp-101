using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Contact : IContact
    {
        private string name;
        private string surname;
        private string number;

        public string Name 
        { 
            get => name;
            set => this.name = value; 
        }
        public string Surname
        {
            get => surname;
            set => this.surname = value;
        }
        public string Number
        { 
            get => number;
            set => this.number = value;
        }

        public Contact (string name , string surname , string number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;

        }

        public Contact ()
        {
            Console.WriteLine("Lütfen isim giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen numara giriniz: ");
            string number = Console.ReadLine();

            this.Name = name;
            this.Surname = surname;
            this.Number = number;

            Console.WriteLine("Kişi başariyla kaydedilmiştir!");
        }
        public void Yazdir()
        {
            Console.WriteLine("**************");
            Console.WriteLine("İsim{0}", this.Name);
            Console.WriteLine("Soyisim: {0}",this.Surname);
            Console.WriteLine("Numara: {0}",this.Number);
            Console.WriteLine("-");
        }

    }
}
