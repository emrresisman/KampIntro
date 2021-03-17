using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMİ = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }


            if (sistemeGirisYapmisMİ == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu.");

            }
            else
            {
                Console.WriteLine("Giriş Yap Ekranı");
            }

           
           Console.WriteLine(kategoriEtiketi);

            
           
        }
    }
}
