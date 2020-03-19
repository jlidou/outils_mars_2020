using System;

namespace demoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MonPlayerSingleton mps = MonPlayerSingleton.getInstance();
            //interdit car constructeur private
            // MonPlayerSingleton mps2 = new MonPlayerSingleton();


        }
    }

    class MonPlayerSingleton {
        private static MonPlayerSingleton instance;

        private MonPlayerSingleton(){}

        public static MonPlayerSingleton getInstance(){
            if(instance == null){
                instance = new MonPlayerSingleton();
            }
            return instance;
        }
    }
}
