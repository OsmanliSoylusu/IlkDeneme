using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {// COnvention isimlendirme kuralı Syntax yazım değişimleri
        public void Ekle(Product urun) //Ekle kodu yazıldığıında sepete eklendi ekrana yansır. Basit bir fonksiyon
        { // product veri tipi urun de daha sonra çağıracağımız isim
            Console.WriteLine("Sepete Eklendi! :" + urun.UrunAdi); // yüzlerce satırda olabilirdi Yarın birgün kod değişse de yalnızca burada texti değiştirmek yeterli olacak bu sebeple dinamik kod elde edeceğiz
            Console.WriteLine("Sepete Eklendi! :" + urun.Stok);


        }
        public void Ekle2(string urunAdi, string Acıklama, double Fiyat, int Stok) // uzun uzun yazmak yerine bunu bir ürün kapsülü içine koyuyorsunuz urun mesela
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi: " + urunAdi);
        }
    }
}
