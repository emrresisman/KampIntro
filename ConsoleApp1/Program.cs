using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;             // DEĞER TİPİ
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1= kaçtır denirse 30                     DEĞER VE REFERANS TİPİN FARKI (STACK BELLEK HEAP BELLEK)

            int[] sayilar = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };               // REFERANS TİPİ
            sayilar = sayilar2; // BELLEKTE TUTTUĞU ADRESİ ATAMA YAPTAR İNDİSİ DEĞİL
            sayilar2[0] = 999;
            //sayilar[0] sorulursa cevap 999 

        }
    }
}
