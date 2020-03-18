using System;
using System.Threading;
namespace demoThread{
    class Program{
        public static int nb = 0;
        static void Main(string[] args) {
            object monLock = new object();
            //demarer un thread avec une methode simple
            // for (int i = 0; i < 10; i++) {
            //     Thread premierThread = new Thread(MesActions.PremiereAction);
            //     premierThread.Start();
            // }

            // Thread t1 = new Thread(MesActions.ActionSurObj);
            // Thread t2 = new Thread(MesActions.ActionSurObj);

            // Thread t1 = new Thread((() => { MesActions.ActionSurObjAvecParametre(100); }));
            // Thread t2 = new Thread(() => { MesActions.ActionSurObjAvecParametre(50); });
            // Thread t1 = new Thread((() => { MesActions.ActionSurObjAvecParametreEtLock(100, monLock); }));
            // Thread t2 = new Thread(() => { MesActions.ActionSurObjAvecParametreEtLock(50, monLock); });
            // t1.Name = "T1";
            // t2.Name = "   T2";
            // t1.Start();
            // t2.Start();

            // for (int i = 0; i < 50; i++) {
            //     Thread test = new Thread(() => MesActions.TestBetise());
            //     test.Start();
            // }
            // UneRessource ressource = new UneRessource();
            // long start = DateTime.Now.Ticks;
            // for (int i = 0; i < 10; i++) {
            //     Thread t = new Thread((() => { MesActions.ActionAvecMutex(ressource); }));
            //     t.Name = "T" + i;
            //     t.Start();
            // }
            // long end = DateTime.Now.Ticks;
            // Console.WriteLine("temps : " + ((end - start)/1000) );
            for (int i = 0; i < 10; i++) {
                int iCopie = i;
                Thread t = new Thread((() => { MesActions.ActionAvecParamBizarre(iCopie); }));
                t.Start();
            }
        }
    }
    public static class MesActions{
        public static Mutex mutex = new Mutex();
        public static void PremiereAction() {
            Console.WriteLine("Hello Thread");
        }
        public static void ActionSurObj() {
            for (int i = 0; i < 100; i++) {
                Program.nb++;
                Console.WriteLine(Thread.CurrentThread.Name + " nb: " + Program.nb);
            }
        }
        public static void ActionSurObjAvecParametre(int nbBoucle) {
            for (int i = 0; i < nbBoucle; i++) {
                Program.nb++;
                Console.WriteLine(Thread.CurrentThread.Name + " nb: " + Program.nb);
            }
        }
        public static void ActionSurObjAvecParametreEtLock(int nbBoucle, object monLock) {
            for (int i = 0; i < nbBoucle; i++) {
                lock (monLock) {
                    Program.nb++;
                    Console.WriteLine(Thread.CurrentThread.Name + " nb: " + Program.nb);
                }
            }
        }
        public static void TestBetise() {
            while (true) {
            }
        }
        public static void ActionAvecMutex(UneRessource ressource) {
            Console.WriteLine(Thread.CurrentThread.Name + " essaie d acceder a la ressource");
            if (mutex.WaitOne(1000)) {
                ressource.nb++;
                Console.WriteLine(Thread.CurrentThread.Name + " travaille sur la ressource");
                Console.WriteLine(ressource.nb);
                Thread.Sleep(500);
                Console.WriteLine(Thread.CurrentThread.Name + " a fini son travaille");
                mutex.ReleaseMutex();
            }
            else {
                Console.WriteLine(Thread.CurrentThread.Name + " trop tard je pars");
            }
        }
        public static void ActionAvecParamBizarre(int nb) {
            Console.WriteLine(nb);
        }
    }
    public class UneRessource{
        public int nb;
    }
}