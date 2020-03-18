using System;
namespace DemoSurchargeOperateur{
    class Program{
        static void Main(string[] args) {
            Point p1 = new Point(4, 5);
            Point p2 = new Point(2, 8);
            Point add = p1 + p2;
            add.Afficher();
            bool isSup = p1 > p2;
            Console.WriteLine(isSup);
            add = -add;
            add.Afficher();
        }
    }
    class Point{
        public int x;
        public int y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public static Point operator -(Point p) {
            Console.WriteLine("je prend le signe negatif");
            return new Point(-p.x, -p.y);
        }
        public static Point operator +(Point pA, Point pB) {
            return new Point(pA.x + pB.x, pA.y + pB.y);
        }
        public static bool operator >(Point pA, Point pB) {
            return pA.x > pB.x && pA.y > pB.y;
        }
        public static bool operator <(Point pA, Point pB) {
            return pA.x < pB.x && pA.y < pB.y;
        }
        public void Afficher() {
            Console.WriteLine(x + ", " + y);
        }
    }
}