using System;

namespace demoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage.Builder builderperos = new Personnage.Builder();
            builderperos.SetNomPersonnage("toto");
            builderperos.SetPosition(4,5);
            

            Personnage p = builderperos.create();
        }
    }



    class Personnage{
        public string Nom{get; protected set;}
        public Vect2 Postion {get; protected set;}

        private Personnage(){}


        public class Builder{
            private Personnage instance;
            public Builder (){
                instance = new Personnage();
            }

            public void SetNomPersonnage(string nom){
                instance.Nom = nom;
            }

            public void SetPosition(float x,float y){
                instance.Postion=new Vect2(x,y);
            }

            public Personnage create(){
                return instance;
            }
        }


    }


    class Vect2{
        public float X{get;set;}
        public float Y{get;set;}
        public Vect2(float x, float y){
            this.X = x; this.Y = y;
        }
    }
}
