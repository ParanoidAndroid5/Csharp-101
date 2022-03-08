

// 1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
//  Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("pozitif bir sayi giriniz.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n + " adet pozitif sayi giriniz.");
            int[] sayiDizisi = new int[n];


            for (int i=0;i<=n-1;i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
               
            }
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz pozitif sayi : " + sayiDizisi[i]);
                }
            }


// 2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
// Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.


            Console.WriteLine("iki pozitif sayi giriniz:");
            int n = (Int32.Parse(Console.ReadLine()));
            int m = (Int32.Parse(Console.ReadLine()));
            Console.WriteLine(" {0} pozitif sayi giriniz:", n);
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. Sayıyı Giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] == m || sayiDizisi[i] % m == 0)
                    Console.WriteLine(sayiDizisi[i]);


            }


// 3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
//  Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
//  Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("pozitif bir sayi giriniz.");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} adet kelime giriniz:",n);
                    string[] kelimeler = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("{0}. Kelimeyi Giriniz.", i + 1);
                        kelimeler[i] = (Console.ReadLine());
                    }
                    Array.Reverse(kelimeler);
                    foreach (var kelime in kelimeler)
                    {
                        Console.WriteLine(kelime);
                    }


// 4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
// Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

        Console.WriteLine("Bir cümle giriniz:");
                    string cumle = Console.ReadLine();
                    string[] kelimeler = cumle.Split(' ');
                    char[] harfler = cumle.ToCharArray();
                    int harfSayisi = cumle.Length - ((kelimeler.Length)-1);

                    Console.WriteLine("Cümledeki toplam kelime sayisi: " +kelimeler.Length);
                    Console.WriteLine("Cümledeki toplam harf sayisi:" + harfSayisi); 


