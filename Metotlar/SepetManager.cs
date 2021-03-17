using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            
        Console.WriteLine("Sepete Eklendi : "+ urun.Adi);

        }
        public void Ekle2(string urunAdi,double fiyat,string aciklama, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+urunAdi);

        }
    }
}
