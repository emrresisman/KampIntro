using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("----------Metotlar---------");
            SepetManager sepetManager = new SepetManager();
            // encapsulation 
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            // tavsiye edilmeyen kullanım sekli
            sepetManager.Ekle2("Armut", 12, "Yeşil Armut",15);
            sepetManager.Ekle2("Elma", 12, "Yeşil elma",25);
            
        }
    }
}
// Don't repeat yourself -- DRY -- Clean Code