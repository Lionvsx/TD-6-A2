using System;
using System.Runtime.CompilerServices;

namespace TD_6_A2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] schema = new string[4] {"*******", "*d----*", "**---a*", "*******"};
            Labyrinthe testLab = new Labyrinthe(schema, 4, 7);


            Personnage joueur = new Personnage(testLab);
            Console.Clear();
            Console.WriteLine(testLab.ToString());
            while (true)
            {
                joueur.DeplacementSuivant();
                if (joueur.EstArrive()) break;
            }
        }
    }
}