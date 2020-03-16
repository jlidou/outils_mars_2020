using System;
namespace DemoGenericite{
    class Program{
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Personnage p1 = new Personnage("toto", 45);
            Personnage p2 = new Personnage("titi", 46);
            MonGenerique.Test<Personnage>(p1, p2);
            Console.WriteLine("Test Avec Retour : " + MonGenerique.TestAvecRetour<Personnage>());
        }
        class Personnage{
            public String nom;
            public int vie;
            public Personnage(string nom, int vie) {
                this.nom = nom;
                this.vie = vie;
            }
            public override string ToString() {
                return "nom : " + nom + " , vie :  " + vie;
            }
        }
    }
    public static class MonGenerique{
        public static void Test<T>(T param1, T param2) {
            Console.WriteLine(param1);
            Console.WriteLine(param2);
        }
        public static void Test<T1, T2>(T1 param1, T2 param2) {
            Console.WriteLine(param1);
            Console.WriteLine(param2);
        }
        public static Treturn TestAvecRetour<Treturn>() {
            return default(Treturn);
        }
        public static void Echanger<T>(ref T t1, ref T t2) {
            T temp = t1;
            t1 = t2;
            t2 = temp;
        }
    }
    public class MyTab<T>{
        private int taille;
        T[] tab;
        public MyTab(int taille) {
            this.taille = taille;
            tab = new T[taille];
        }
    }
}