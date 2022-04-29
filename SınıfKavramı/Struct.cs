using System;

namespace c101
{
    class Program
    {
        static void Main(string[] args)
        {
           // Struct -> Ne zaman kullalım
           // Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa,
           //  verileri kapsüllemek işinizi görecekse yapıları tercih edebilirsiniz. 
           //16byte kadar veri saklamak icin struct kullanıp 16dan büyükse sınıf tanımlamak performans acısından daha iyi olabilir.
           // Struct için parametresi olmayan constructor tanımlayamayız.
           // Class lar referans tipli özellikler gösterirken Structlar ise değer tipli özellikler gösterirler. En temel fark budur.
           // Diger struct ya da sınıflardan kalıtım almazlar.
           // Interfacelerden kalıtım alabilirler.

           Dikdörtgen dikdörtgen = new Dikdörtgen();
           dikdörtgen.kisaKenar = 3;
           dikdörtgen.uzunKenar = 4;
           Console.WriteLine("class alan hesabi: {0}", dikdörtgen.AlanHesapla());

           //Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct();
           Dikdörtgen_Struct dikdörtgen_Struct; // new anahtar kelimesini kullanmadan olusturabildik.
           dikdörtgen_Struct.kisaKenar = 3;
           dikdörtgen_Struct.uzunKenar = 4;
           Console.WriteLine("struct alan hesabi: {0}", dikdörtgen_Struct.AlanHesapla());



        }
    }

    class Dikdörtgen 
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;

        }
    }

    struct Dikdörtgen_Struct 
    {
        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;

        }
    }
}