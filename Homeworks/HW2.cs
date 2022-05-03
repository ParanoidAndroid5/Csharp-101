
//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
//(ArrayList sınıfını kullanara yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList Sayilar = new ArrayList();
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            Console.WriteLine("20 adet pozitif sayi giriniz:");

           
           
                for (int i = 1; i < 21; i++)
                {
                    Console.Write("{0}.pozitif sayı :", i);
                    int number = int.Parse(Console.ReadLine());
                    if (number < 0)
                    {
                        Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                        break;
                    }
                    Sayilar.Add(number);
                }
            
           
            Console.WriteLine("----------------------------------------------------------");
          

            foreach ( int sayi in Sayilar)
            {
                if (sayi == 1)
                {
                    asalOlmayan.Add(sayi);
                }
                else if (sayi == 2)
                {
                    asal.Add(sayi);
                }
                else
                {
                    int flag = 0;
                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            flag++;
                        }
                    }
                    if (flag == 0)
                    {
                        asal.Add(sayi);
                    }
                    else
                    {
                        asalOlmayan.Add(sayi);
                    }
                }
            }
            Console.WriteLine("----------------------------------------------------------");
            asal.Sort();
            asal.Reverse();


            int asalToplam = 0;
            foreach (int item in asal)
            {
                Console.WriteLine(item);
                asalToplam = asalToplam + item;
               
            }
            int y = asal.Count;
            Console.WriteLine("eleman sayisi: {0}", asal.Count);
            Console.WriteLine("asal dizinin elemanların ortalamalari: {0}", (asalToplam)/(y));

            Console.WriteLine("----------------------------------------------------------");
            asalOlmayan.Sort();
            asalOlmayan.Reverse();


            int asalOlmayanToplam = 0;
            foreach (int item in asalOlmayan)
            {
                Console.WriteLine(item);
                asalOlmayanToplam = asalOlmayanToplam + item;
            }
            int x = asalOlmayan.Count;
            Console.WriteLine("eleman sayisi: {0}", asalOlmayan.Count );
            Console.WriteLine("asal olmayan dizinin elemanlarinin ortalamalari: {0}", (asalOlmayanToplam)/(x));



// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
//console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

 int[] arrNumber = new int[20];
            Console.WriteLine("Please enter 20 number");

            // Add Array
            for (int i = 0; i < arrNumber.Length; i++)
            {
                Console.WriteLine(i + 1 + ". Number Enter: ");
                arrNumber[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arrNumber);

            int[] minNumbers = new int[3];
            int minSum = 0;
            int[] maxNumbers = new int[3];
            int maxSum = 0;

            for (int i = 0; i < 3; i++)
            {
                minNumbers[i] = arrNumber[i];
                minSum += arrNumber[i];
            }

            int j = 0;
            for (int i = 20; i > 17; i--)
            {
                maxNumbers[j] = arrNumber[i - 1];
                maxSum += arrNumber[i - 1];
                j++;
            }

            
            foreach (var item in minNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Min Numbers Avg : " + minSum / 3);

            foreach (var item in maxNumbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Min Numbers Avg : " + maxSum / 3);


            Console.WriteLine("Min - Max Numbers Avg Sum : " + minSum + minSum);
        


    





// Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
//ve dizinin elemanlarını sıralayan programı yazınız.

Console.WriteLine("cümle giriniz.");
            string cümle = Console.ReadLine();
            ArrayList sesli = new ArrayList();
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' }; 

            for(int i=0; i <cümle.Length; i++)
            {
                for(int j=0; j < sesliHarfler.Length; j++)
                {
                    if(cümle[i].Equals(sesliHarfler[j]))
                    {
                        sesli.Add(cümle[i]);
                        Console.WriteLine(cümle[i]);
                      
                    }
                }
            }

            sesli.Sort();
            foreach(char c in sesli)
            {
                Console.WriteLine(c);
            }


        

