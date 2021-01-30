using System;

namespace ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] kurslar = new string[]
            {"matematik","Türkce","Sosyal Bilgiler","Pyhton"};
            // for (int i = 0; i < kurslar.Length; i++)
            //{ 
            //    Console.WriteLine(kurslar[i]);     

            //}

            foreach (string kursadi in kurslar) 
            {
                Console.WriteLine(kursadi);
            }
        }
    }
}
