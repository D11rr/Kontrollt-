using System;

using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali kujund joonistamiseks:");
            Console.WriteLine("1. Teemant");
            Console.WriteLine("2. Ruut");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");
            int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1: // teemant
                    Console.WriteLine("Sisesta teemanti kõrgus:");
                    int rombiKorgus = int.Parse(Console.ReadLine());
                    JoonistaRomb(rombiKorgus);
                    ArvutaRombiMootmed(rombiKorgus);
                    break;
                case 2: // Ruut
                    Console.WriteLine("Sisesta ruudu külg:");
                    int ruuduKulg = int.Parse(Console.ReadLine());
                    JoonistaRuut(ruuduKulg);
                    ArvutaRuuduMootmed(ruuduKulg);
                    break;
                case 3: // Ristkülik
                    Console.WriteLine("Sisesta ristküliku kõrgus:");
                    int ristkulikuKorgus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sisesta ristküliku laius:");
                    int ristkulikuLaius = int.Parse(Console.ReadLine());
                    JoonistaRistkulik(ristkulikuKorgus, ristkulikuLaius);
                    ArvutaRistkulikuMootmed(ristkulikuKorgus, ristkulikuLaius);
                    break;
                case 4: // Kolmnurk
                    Console.WriteLine("Sisesta kolmnurga kõrgus:");
                    int kolmnurgaKorgus = int.Parse(Console.ReadLine());
                    JoonistaKolmnurk(kolmnurgaKorgus);
                    ArvutaKolmnurgaMootmed(kolmnurgaKorgus);
                    break;
                default:
                    Console.WriteLine("Vigane valik.");
                    break;
            }

            Console.ReadLine();
        }

        static void JoonistaRomb(int korgus)
        {
            int keskkoht = korgus / 2 + 1;

            for (int i = 1; i <= keskkoht; i++)
            {
                for (int j = 0; j < keskkoht - i; j++)
                    Console.Write(" ");

                for (int k = 0; k < 2 * i - 1; k++)
                    Console.Write("*");

                Console.WriteLine();
            }

            for (int i = keskkoht - 1; i > 0; i--)
            {
                for (int j = 0; j < keskkoht - i; j++)
                    Console.Write(" ");

                for (int k = 0; k < 2 * i - 1; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void ArvutaRombiMootmed(int korgus)
        {
            int umbermootRomb = 4 * korgus; // Rombi ümbermõõt (ligikaudne väärtus)
            double pindalaRomb = Math.Pow(korgus, 2) - Math.Pow((korgus / 2), 2);
            Console.WriteLine("Ümbermõõt: " + umbermootRomb);
            Console.WriteLine("Pindala: " + pindalaRomb);
        }

        static void JoonistaRuut(int külg)
        {
            for (int i = 0; i < külg; i++)
            {
                for (int j = 0; j < külg; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void ArvutaRuuduMootmed(int külg)
        {
            int umbermootRuut = 4 * külg;
            int pindalaRuut = külg * külg;
            Console.WriteLine("Ümbermõõt: " + umbermootRuut);
            Console.WriteLine("Pindala: " + pindalaRuut);
        }

        static void JoonistaRistkulik(int korgus, int laius)
        {
            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j < laius; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void ArvutaRistkulikuMootmed(int korgus, int laius)
        {
            int umbermootRistkulik = 2 * (korgus + laius);
            int pindalaRistkulik = korgus * laius;
            Console.WriteLine("Ümbermõõt: " + umbermootRistkulik);
            Console.WriteLine("Pindala: " + pindalaRistkulik);
        }

        static void JoonistaKolmnurk(int korgus)
        {
            for (int i = 1; i <= korgus; i++)
            {
                for (int j = 1; j <= korgus - i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void ArvutaKolmnurgaMootmed(int korgus)
        {
            int umbermootKolmnurk = 3 * korgus; // Külgsuunurkse kolmnurga ligikaudne väärtus
            double pindalaKolmnurk = (Math.Sqrt(3) / 4) * Math.Pow(korgus, 2);
            Console.WriteLine("Ümbermõõt: " + umbermootKolmnurk);
            Console.WriteLine("Pindala: " + pindalaKolmnurk);
        }
    }
}
