using System;
using System.Runtime.InteropServices;
using CustomExtension;
using demoMethodeExtension;
namespace demoMethodeExtension{
    class Program{
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            Vector2 vector2 = new Vector2(4,5.5f);
            Console.WriteLine(vector2.ToString());
            vector2.SetRandom();
            Console.WriteLine(vector2.ToString());
            
            Vector2 vToCompare = new Vector2(4,8);
            Console.WriteLine(vToCompare.Biger(new Vector2(10, 4)));

        }
    }
    public class Vector2{
        public float x;
        public float y;
        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return x + " , " + y;
        }
    }
}
namespace CustomExtension{
    public static class Extension{
        public static void SetRandom(this Vector2 vector2) {
            var rand = new Random();
            vector2.x = rand.Next(10, 45);
            vector2.y = rand.Next(10, 45);
        }

        public static bool Biger(this Vector2 target, Vector2 toCompare) {
            return target.x > toCompare.x && target.y > toCompare.y;
        }

    }
}