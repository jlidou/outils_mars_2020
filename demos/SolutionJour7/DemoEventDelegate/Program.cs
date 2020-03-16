using System;
using System.Collections.Generic;
namespace DemoEventDelegate{
    class Program{
        static void Main(string[] args) {
            List<Enemy> enemies = new List<Enemy>();
            Personnage hero = new Personnage("toto", 45, 4);
            for (int i = 0; i < 10; i++) {
                if (i < 3) {
                    Enemy e = new Enemy(EnemyType.Barbare, "le mal " + i, 20);
                    hero.methodeCible += e.ActionDuPersonnage;
                    enemies.Add(e);
                }
                if (i > 3) {
                    Enemy e = new Enemy(EnemyType.Goblin, "le mal " + i, 20);
                    hero.methodeCible += e.ActionDuPersonnage;
                    enemies.Add(e);
                }
            }
            hero.TirerPartout(EnemyType.Barbare);
            Console.WriteLine("/**********/");
            hero.TirerPartout(EnemyType.Goblin);
        }
    }
    public class Personnage{
        public String Nom { get; set; }
        public int Vie { get; set; }
        public int Force { get; set; }
        public delegate void PersonnageEvent(PersonnageEventArg eventArg);
        public PersonnageEvent methodeCible;
        public void TirerPartout(EnemyType type) {
            if (methodeCible != null) {
                methodeCible(new PersonnageEventArg(this, type));
            }
        }
        public Personnage(string nom, int vie, int force) {
            Nom = nom;
            Vie = vie;
            Force = force;
        }
    }
    public class Enemy{
        public String Nom { get; set; }
        public int Vie { get; set; }
        public EnemyType Type { get; set; }
        public Enemy(EnemyType type, string nom, int vie) {
            Type = type;
            Nom = nom;
            Vie = vie;
        }
        public void ActionDuPersonnage(PersonnageEventArg eventArg) {
            if (eventArg.enemyType == Type) {
                Vie -= eventArg.source.Force;
            }
            Console.WriteLine(Vie);
        }
    }
    public enum EnemyType{
        Goblin,
        Martien,
        Barbare
    }

    public class PersonnageEventArg{
        public Personnage source;
        public EnemyType enemyType;
        public PersonnageEventArg(Personnage source, EnemyType enemyType) {
            this.source = source;
            this.enemyType = enemyType;
        }
    }
}