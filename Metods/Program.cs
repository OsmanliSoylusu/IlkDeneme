using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            // encapsulation tamamını kapsamak
            // Metodlar tekrar tekrar kullanmaya imkan sunuyor. Dont repeat yourself!
            Product urun1 = new Product(); // Liste açmak için örnek verirsin
            urun1.UrunAdi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";
            urun1.Stok = 8;

            Product urun2 = new Product();
            urun2.UrunAdi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Stok = 7;

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi); //urun ekrana yazdırması için takma at
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Stok);
             


            }

            Console.WriteLine("--------Metodlar----------");

            SepetManager sepetManager = new SepetManager(); // metodu tanıtmamız gerekiyor.
            sepetManager.Ekle(urun1); // Ekle kodunu çağırdık
            sepetManager.Ekle(urun2);
            
   

        }
    }
}
