using System;

namespace ProjectEuler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0;
            int sayi2 = 0;
            int a;
            int yuzbinlik;
            int onbinlik;
            int binlik;
            int yuzluk;
            int onluk;
            int birlik;
            int sonuc1 = 0;
            int sonuc2 = 0;

            for (sayi1 = 100; sayi1 <= 999; sayi1++)
            {
                for (sayi2 = 100; sayi2 <= 999; sayi2++)
                {
                    a = sayi1 * sayi2;

                    yuzbinlik = a / 100000;
                    a = a - (100000 * yuzbinlik);
                    onbinlik = a / 10000;
                    a = a - (10000 * onbinlik);
                    binlik = a / 1000;
                    a = a - (1000 * binlik);
                    yuzluk = a / 100;
                    a = a - (100 * yuzluk);
                    onluk = a / 10;
                    a = a - (10 * onluk);
                    birlik = a / 1;

                    if (birlik == yuzbinlik && onluk == onbinlik && yuzluk == binlik)
                    {
                        sonuc1 = sayi1 * sayi2;
                        if (sonuc1 > sonuc2)
                        {

                            Console.WriteLine(sayi1 + " X " + sayi2 + " = " + sonuc1 + " > " + sonuc2);
                            sonuc2 = sonuc1;
                        }
                    }
                }
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SONUÇ : " + sonuc2);
        }
    }
}
