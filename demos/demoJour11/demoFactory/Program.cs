using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;


namespace demoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Enemmi> enemmis = new List<Enemmi>();


            enemmis.Add(EnemmiFactory.generate(EnemiType.BlazardBlue, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.BlazardBlue, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.BlazardBlue, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.BlazardBlue, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.StolderBlack, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.StolderBlack, "blazar"));

            enemmis.Add(EnemmiFactory.generate(EnemiType.ExistePas, "blazar"));
            



            enemmis.Add(EnemmiFactory.generate(EnemiType.TorkesienCruel, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.TorkesienCruel, "blazar"));
            enemmis.Add(EnemmiFactory.generate(EnemiType.TorkesienCruel, "blazar"));


            foreach (var e in enemmis)
            {
                e.Shout();
                Thread.Sleep(500);
            }
        }
    }

    public enum EnemiType
    {
        BlazardBlue, TorkesienCruel, StolderBlack, ExistePas
    }

    public abstract class Enemmi
    {
        public string nom;
        public abstract void Shout();
    }


    public class BlazardBlue : Enemmi
    {
        public BlazardBlue(string nom)
        {
            this.nom = nom;
        }

        public override void Shout()
        {
            Console.WriteLine("AHHHHHHHHHHHHHHHHHHHHHHHHHHH");
        }
    }
    public class TorkesienCruel : Enemmi
    {
        public TorkesienCruel(string nom)
        {
            this.nom = nom;
        }

        public override void Shout()
        {
            Console.WriteLine("OHHHHHHHHHHHHHHHHHHHHHHHHHHH");
        }
    }
    public class StolderBlack : Enemmi
    {
        public StolderBlack(string nom)
        {
            this.nom = nom;
        }

        public override void Shout()
        {
            Console.WriteLine("Hiiiiiiiiiiiiiiiii");
        }
    }

    public static class EnemmiFactory
    {

        public static Enemmi generate(EnemiType type, string enemmiNom) 
        {
            Enemmi retour = null;

            switch (type)
            {
                case EnemiType.BlazardBlue:
                    retour = new BlazardBlue(enemmiNom);
                    break;
                case EnemiType.StolderBlack:
                    retour = new StolderBlack(enemmiNom);
                    break;
                case EnemiType.TorkesienCruel:
                    retour = new TorkesienCruel(enemmiNom);
                    break;
                default:
                    throw new EnemmiExecption();
    }

            if (retour == null)
            {
                throw new EnemmiExecption();
}

            return retour;
        }


        class EnemmiExecption : Exception
{

    public EnemmiExecption(string msg) : base(msg) { }
    public EnemmiExecption() : base("Cet ennemi n existe pas !!!! Execption") { }
}

    }

}
