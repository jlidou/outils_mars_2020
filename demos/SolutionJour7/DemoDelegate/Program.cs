using System;
using System.Net;
using System.Numerics;
using System.Threading;
namespace DemoDelegate{
    class Program{
        internal delegate void MonDelegate(String s1);
        
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            MonDelegate monDelegate;
            monDelegate = PremiereMethode;
            monDelegate += DeuxiemMethode;
            monDelegate("toto");
            ActionSurMonString("toto", s1 => {
                Console.WriteLine("redefinit " + s1);
            });
            ActionSurMonString("titi", s1 => {
                int index = s1.IndexOf("t");
                string s = s1.Insert(index, "uu");
                Console.WriteLine(s);
            });
        }
        public static void PremiereMethode(String p1) {
            Console.WriteLine(p1);
        }
        public static void DeuxiemMethode(String p1) {
            Console.WriteLine("deuxieme " + p1);
        }
        // public static void ActionSurMonString(String s1, MonDelegate action) {
        //     action(s1);
        // }
        public static void ActionSurMonString(String s1, Action<String> action) {
            action(s1);
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
            return x + " , " + y;
        }
    }
}