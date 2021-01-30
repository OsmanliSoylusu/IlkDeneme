using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class Product
    {
        //classlar tıpki string int gibi veri tipidir. Dinamik kodlardır
        //property - özellik
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int Stok { get; set; }
    }
}
