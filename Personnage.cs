using System;

namespace TD_6_A2
{
    public class Personnage
    {
        private Position pos;
        private Labyrinthe _labyrinthe;

        public Personnage(Labyrinthe labyrinthe)
        {
            this._labyrinthe = labyrinthe;
            this.pos = labyrinthe.Depart;
            this._labyrinthe.Matrice[pos.Ligne, pos.Colonne] = 4;
        }

        public bool EstArrive()
        {
            return this.pos.EstEgale(this._labyrinthe.Arrivee);
        }

        public void DeplacementSuivant()
        {
            ConsoleKey key = Functions.PromptDirection();
            Position nextPos = key == ConsoleKey.DownArrow ? new Position(this.pos.Ligne + 1, this.pos.Colonne) :
                key == ConsoleKey.UpArrow ? new Position(this.pos.Ligne - 1, this.pos.Colonne) :
                key == ConsoleKey.RightArrow ? new Position(this.pos.Ligne, this.pos.Colonne + 1) :
                key == ConsoleKey.LeftArrow ? new Position(this.pos.Ligne, this.pos.Colonne - 1) : null;

            if (nextPos == null)
            {
                Console.Clear();
                Console.WriteLine(this._labyrinthe.ToString());
                Console.WriteLine("❌ Vous avez utilisé une touche invalide !!");
                return;
            }
            if (this._labyrinthe.MarquerPassage(nextPos))
            {
                
                this.pos = nextPos;
                Console.Clear();
                Console.WriteLine(this._labyrinthe.ToString());
            }
            else
            {
                Console.Clear();
                Console.WriteLine(this._labyrinthe.ToString());
                Console.WriteLine("⚠️ Vous ne pouvez pas vous déplacer sur cette case !");
                
            }
        }
    }
}