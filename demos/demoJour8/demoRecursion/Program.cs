using System;
namespace demoRecursion{
    class Program{
        static void Main(string[] args) {
            // PremierExemple(4);
            // Console.WriteLine(Factoriel(6));
            TestBoucle(3);
        }
        public static void PremierExemple(int nb) {
            Console.WriteLine("Avant " + nb);
            if (nb > 1) {
                PremierExemple(nb - 1);
            }
            Console.WriteLine("Apres " + nb);
        }
        public static void RecusionInfinie() {
            RecusionInfinie();
        }
        public static int Factoriel(int nb) {
            if (nb == 0) {
                return 1;
            }
            return nb * Factoriel(nb - 1);
        }
        public static void TestBoucle(int nbBoucle) {
            if (nbBoucle > 0)
                for (int i = 0; i < 4; i++) {
                    Console.WriteLine("Boucle no : " + nbBoucle + " value i: " + i);
                    TestBoucle(nbBoucle - 1);
                }
        }
    }
}