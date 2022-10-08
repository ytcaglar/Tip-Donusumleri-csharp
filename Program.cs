using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)

            Console.WriteLine("**** Implicit Concersion ****");

            byte a = 5;
            sbyte b = 30;
            short c = 10;
                        
            int d = a+b+c;
         
            Console.WriteLine("d: "+d);

            long h = d;
            Console.WriteLine("h: "+h);

            float i = h;
            Console.WriteLine("i: "+i);

            string e = "tolunay";
            char f = 'k';
            object g = e+f+d; // tolunayk45 olur.

            Console.WriteLine(g);

            // Explicit Concersion (Bilinçli Dönüşüm)

            Console.WriteLine("**** Explicit Concersion ****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:"+y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:"+t);

            float w =10.3f;
            byte v = (byte)w; // Veri kaybı olur.
            Console.WriteLine("v:"+v);

            // **** ToString Metodu ****
            Console.WriteLine("**** ToString Metodu ****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            // System.Convert

            Console.WriteLine("**** System.Convert **** ");
            string s1 = "10", s2 ="20";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+toplam);

            // **** Parse ****
            Console.WriteLine("**** Parse Methodu **** ");

            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;

            double double1;

            rakam1 = Int32.Parse(metin1); // Her zaman String bir değişkeni 
                                          // parse kullanarak int'a dönüştürmek için kullanılır.

            double1 = double.Parse(metin2);

            Console.WriteLine("rakam1 : "+rakam1);
            Console.WriteLine("double1 : "+double1);
            Console.ReadLine();
        }
    }
}

