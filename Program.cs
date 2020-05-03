using System;

namespace ProjectEuler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int yuzbinlik;
            int onbinlik;
            int binlik;
            int yuzluk;
            int onluk;
            int birlik;

            for (int sayi1 = 100; sayi1 <= 999; sayi1++)
            {
                for (int sayi2 = 100; sayi2 <= 999; sayi2++)
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

                    if ( birlik == yuzbinlik && onluk == onbinlik && yuzluk == binlik)
                    {
                        Console.WriteLine(sayi1 + " x " + sayi2 + " = " + sayi1*sayi2);
                    }

                }

            }




        }
    }
}
