using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi 
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "programlamaya Başlangıç için Temel Kurs", "Java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }
            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}
