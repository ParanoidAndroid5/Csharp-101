using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public static class ContactOperations
    {
        // Telefon numarasi kaydet, sil , güncelle, rehber listeme, rehberde arama
        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen devam etmek için seçiminizi yapınız!");
            Console.WriteLine("(1) Yeni Numara Kaydet");
            Console.WriteLine("(2) Varolan Numarayı Sil");
            Console.WriteLine("(3) Varolan Numarayı Güncelle");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yap");
            Console.WriteLine("(6) Uygulamadan Çıkış Yap");
            Console.WriteLine("****************");
        }
        
        public static void AddContact()
        {
            Contact kisi = new Contact();
            ContactModel.contactList.Add(kisi);
            Program.StartApplication();

        }
        public static void Delete()
        {
            Console.WriteLine("Lütfen silmek istediğiniz kişinin adini ya da soyadini giriniz:");
            string check = Console.ReadLine();
            for (int i=0; i<ContactModel.contactList.Count; i++)
            {
                var kisi = ContactModel.contactList[i];
                if (kisi.Name == check || kisi.Surname == check)
                {
                    Console.WriteLine(" {0} isimli kisi rehberden silinecek.Onayliyor musunuz? (y/n)", kisi.Name);
                    string onay = Console.ReadLine();
                    if (onay == "y")
                    {
                        ContactModel.contactList.Remove(kisi);
                        Console.WriteLine("Kisi basariyla silindi.");
                        Program.StartApplication();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Silme islemi iptal edilmistir.");
                        Program.StartApplication();
                        break;
                    }
                }
                else if (i == ContactModel.contactList.Count - 1)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");

                    string karar = Console.ReadLine();
                    if(karar == "1")
                    {
                        Console.WriteLine("Silme islemi iptal edildi.");
                        Program.StartApplication();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyin.");
                        ContactOperations.Delete();
                        break;
                    }
                }
            }

        }

        public static void Update()
        {
            Console.WriteLine("Numarasini güncellemek istediginiz kisinin adini ya da soyadini giriniz:");
            string kontrol = Console.ReadLine();
            for(int i=0; i< ContactModel.contactList.Count; i ++)
            {
                var kisi = ContactModel.contactList[i];
                if(kisi.Name == kontrol || kisi.Surname == kontrol )
                {
                    Console.WriteLine("Güncellemek istediginiz numarayi giriniz:");
                    string yeniNumara = Console.ReadLine();
                    Console.WriteLine("{0} isimli kişinin güncellenmesini onaylıyor musunuz ?(y/n)", kisi.Name);
                    string uconfirmation = Console.ReadLine();
                    if (uconfirmation == "y")
                    {
                        kisi.Number = yeniNumara;
                        Console.WriteLine("Kişi güncellenmiştir!");
                        
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        break;
                    }

                }
                else if (i == ContactModel.contactList.Count - 1)
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen  seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi  sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    string uDecision = Console.ReadLine();
                    if (uDecision == "1")
                    {
                        Console.WriteLine("Program sonlandırılmıştır.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tekrar deneyiniz!");
                        Update();
                        break;
                    }
                }
            }
            
           
        }

        public static void Listing()
        {
            Console.WriteLine("*Telefon Rehberi*");
            foreach(var kisi in ContactModel.contactList)
            {
                kisi.Yazdir();
            }
            Program.StartApplication();
        }

        public static void Search()
        {

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            string karar = Console.ReadLine();
            if (karar == "1")
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                string scheck = Console.ReadLine();
                foreach (var item in ContactModel.contactList)
                {
                    if (item.Name == scheck || item.Surname == scheck)
                    {
                        item.Yazdir();
                    }
                    else
                    {
                        Console.WriteLine("kisi bulunamadı.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen aramak istediginiz kişinin telefon numarasını giriniz:");
                string snum = Console.ReadLine();
                foreach (var item in ContactModel.contactList)
                {
                    if (item.Number == snum)
                    {
                        item.Yazdir();
                    }
                    else
                    {
                        Console.WriteLine("kisi bulunamadı.");
                    }
                }
            }
            Program.StartApplication();

        }

        public static void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}
