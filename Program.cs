using System;

namespace TahminV2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rastgele = new Random();
            int tahmin, sayi = rastgele.Next(1, 100);
            int sayac = 7;
            int say = 0;

            do
            {
                sayac = sayac - 1;
                say = say + 1;
                Console.Write("Lütfen sayınızı girin: " );
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin < sayi && say < 7)
                {
                    Console.Write("Kalan Hak: " + sayac + "\n" + "Daha büyük bir sayı girin!" + "\n\n");
                }
                else if (tahmin > sayi && say < 7)
                {
                    Console.Write("Kalan Hak: " + sayac + "\n" + "Daha küçük bir sayı girin!" + "\n\n");
                }

            } while (tahmin != sayi && say < 7);

            if (tahmin == sayi)
            {
                Console.WriteLine("Kazandınız");
            }
            else
            {
                Console.WriteLine("Game Over");
            }
            Console.ReadKey();



        }
    }
}
