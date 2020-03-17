using System;
using System.Numerics;
using System.Reflection;
namespace DemoReflection{
    class Program{
        static void Main(string[] args) {
            ToToGameObject gameObject = new ToToGameObject();
            ToToGameObject gameObject2 = new ToToGameObject("toto",12,new Vector3(4));
            int test = 4;
            
            Type typeTotoGameObject = typeof(ToToGameObject);
            Type typeTotoGameObject2 = gameObject.GetType();
            
            Console.WriteLine(typeTotoGameObject.IsClass);
            Console.WriteLine(test.GetType().IsClass);
            Console.WriteLine("/******************/");

            PropertyInfo[] propertyInfos = typeTotoGameObject.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Public);
            foreach (var prop in propertyInfos) {
                Console.WriteLine(prop.Name);
            }

            FieldInfo[] fields = typeTotoGameObject.GetFields(
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            foreach (var field in fields) {
                Console.WriteLine(field.Name);
            }

            typeTotoGameObject.GetMethod("Afficher").Invoke(gameObject, new object?[] {"un super jkadkajsdh"});
            typeTotoGameObject.GetMethod("Afficher").Invoke(gameObject2, new object?[] {"un super jkadkajsdh"});

            Console.WriteLine("/******************/");
            Type monType = typeof(ToToGameObject);
            ToToGameObject gameObject3 = (ToToGameObject) Activator.CreateInstance(monType);
            gameObject3.Afficher("hello");

            typeof(ToToGameObject).GetMethod("MeThodeStatic").Invoke(null, null);


            var myAssembly = Assembly.GetExecutingAssembly();
            var types = myAssembly.GetTypes();
            foreach (var type in types) {
                Console.WriteLine(type.Name);
            }



        }
    }

    public class ToToGameObject{
        [MyProp]
        public String Nom { get; set; }
        public int Age { get; set; }
        [MyProp]
        public Vector3 Position { get; set; }
        private String priveNom;
        private string PriveNom2 { get; set; }
        public ToToGameObject() {
            Nom = "sans parametre";
        }
        public ToToGameObject(string nom, int age, Vector3 position) {
            Nom = nom;
            Age = age;
            Position = position;
        }
        public void DoSonthinh() {
        }
        public void Afficher(String msg) {
            Console.WriteLine(Nom + " " + msg);
        }
        public int UneMethodeTresUtile() {
            return 0;
        }
        private void methodePrive() {
        }
        public static void MeThodeStatic() {
            Console.WriteLine("je suis statique");
        }

    }




    public class MyPropAttribute : Attribute{
    }
}