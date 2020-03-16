using System;
namespace DemoStruct{
    class Program{
        static void Main(string[] args) {
            Vector2 vector2 = new Vector2(1,5);
            Console.WriteLine("out: " +vector2.ToString());

            Console.WriteLine("test: " +TestStruct(in vector2));
            
            Console.WriteLine("out: " + vector2.ToString());
        }

        public static Vector2 TestStruct(in Vector2 vector2) {
            Vector2 vRetour = vector2;
            vRetour.x++;
            Console.WriteLine("in: "+vector2.ToString());
            return vector2;
        }
    }

    public struct Vector2{
        public float x;
        public float y;
        public Vector2(float x, float y) {
            this.x = x;
            this.y = y;
        }
        public override string ToString() {
            return x + " , " +y;
        }
    }
}