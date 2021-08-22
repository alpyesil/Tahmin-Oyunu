
using System;

namespace Çalışma
{
    class Program
    {
        static void Main(string[] args)
        {

            //0 ile 100 arasında önceden sabit olarak girilmiş bir sayıyı, kullanıcının kaç kerede tahmin ettiğini gösteren tahmin oyununu C# konsol uygulaması ile yazın.
            //7 tahminde sayıyı bilemezse oyun bitsin.
            //Kullanıcı, tutulan sayıyı bulması için yönlendirilsin;
            //Tutulan sayıdan daha büyük bir sayı girilmişse “Daha küçük bir sayı girin” yazsın.
            //Tutulan sayıdan daha küçük bir sayı girilmişse “Daha büyük bir sayı girin” yazsın.


            Random rnd = new Random();
            int sayi = rnd.Next(1, 100);
            int hak = 0;
            int sayac = 0;
            int tahmin = 0;
            int yeter = 7;

            do
            {
                yeter = yeter - 1;
                sayac = sayac + 1;
                hak = hak + 1 ;
                Console.Write("1-100 arası tahminini gir: ");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin < sayi && hak < 7)
                {
                    Console.Write("Kalan Hak: " + yeter + "\n" + "Daha büyük bir sayı girin!" + "\n\n");
                }
                else if (tahmin > sayi && hak < 7)
                {
                    Console.Write("Kalan Hak: " + yeter + "\n" + "Daha küçük bir sayı girin!" + "\n\n");
                }

            } while (tahmin != sayi && hak < 7);

            if (tahmin == sayi)
            {
                Console.Write("KAZANDIN");
            }
            else if (hak <= 7)
            {
                Console.Write("Game Over");
            }


            Console.ReadKey();

        }




    }
}
