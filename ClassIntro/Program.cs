using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.kursEgitmeni = "Emre Şişman";
            kurs2.izlenmeOrani = 20;
            
            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.kursEgitmeni = "Ece Demir";
            kurs3.izlenmeOrani = 25;

            // Console.WriteLine(kurs1.kursAdi+" : "+kurs1.kursEgitmeni);
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }
        }
    }
}
    class Kurs
    {
    public string kursAdi { get; set; }
    public string kursEgitmeni { get; set; }
    public int izlenmeOrani { get; set; }
}
