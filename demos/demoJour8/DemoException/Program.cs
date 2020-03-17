using System;
namespace DemoException{
    class Program{
        static void Main(string[] args) {
            String chaine1 = "coucou comment ca va";
            String chaine2 = "coucou comment toto caché ca va";
            try {
                chaine1.TestSiTotoDansString();
                chaine2.TestSiTotoDansString();
            }
            catch (TotoStringException e) {
                Console.WriteLine(e);
                Console.WriteLine(e.StackTrace);
            }
            finally {
                Console.WriteLine("Message dans tous les cas");
            }
            Console.WriteLine("Test");
        }
    }
    public static class TestString{
        public static void TestSiTotoDansString(this String toTest) {
            if (toTest.Contains("toto")) {
                throw new TotoStringException("Arrete d utiliser toto dans les demos");
            }
        }
    }
    public class TotoStringException : Exception{
        public TotoStringException(string message) : base(message) {
        }
    }
}