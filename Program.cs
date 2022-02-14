using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] sayilar = new int[20];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{i+1}. sayıyı giriniz: ");
                int.TryParse(Console.ReadLine(), out int sayi);
                sayilar[i] = sayi;
            }

            Array.Sort(sayilar);
            float kTop = sayilar[0] + sayilar[1] + sayilar[2];
            float bTop = sayilar[sayilar.Length - 1] + sayilar[sayilar.Length - 2] + sayilar[sayilar.Length - 3];
            float kOrt = (kTop)/3;
            float bOrt = (bTop)/3;
            Console.WriteLine("Listedeki ilk 3 kücük elemanların:\n Toplamı: {0}\n Ortalaması: {1}",kTop,kOrt);
            Console.WriteLine("Listedeki son 3 büyük elemanların:\n Toplamı: {0}\n Ortalaması: {1}",bTop,bOrt);
        }
    }
}