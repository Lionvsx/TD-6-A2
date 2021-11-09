using System;

namespace TD_6_A2
{
    public class Labyrinthe
    {
        private int[,] matrice;
        private int nbLignes;
        private int nbColonnes;
        private Position depart;
        private Position arrivee;

        public Labyrinthe(string[] schema, int nbLignes, int nbColonnes)
        {
            this.matrice = new int[nbLignes, nbColonnes];
            if (schema.Length != nbLignes) throw new ArgumentOutOfRangeException(nameof(nbLignes));
            for (int l = 0; l < schema.Length; l++)
            {
                if (schema[l].Length != nbColonnes) throw new ArgumentOutOfRangeException(nameof(nbColonnes));
                for (int col = 0; col < schema[l].Length; col++)
                {
                    if (schema[l][col].ToString() == "d") this.depart = new Position(l, col);
                    if (schema[l][col].ToString() == "a") this.arrivee = new Position(l, col);
                    this.matrice[l, col] = schema[l][col].ToString() == "*" ? 1 :
                        schema[l][col].ToString() == "-" ? 0 :
                        schema[l][col].ToString() == "d" ? 2 :
                        schema[l][col].ToString() == "a" ? 3 : -1;
                }
                
            }
            this.nbLignes = nbLignes;
            this.nbColonnes = nbColonnes;
        }

        public bool EstUnMur(Position pos)
        {
            return this.matrice[pos.Ligne, pos.Colonne] == 1;
        }

        public bool EstOccupee(Position pos)
        {
            return this.matrice[pos.Ligne, pos.Colonne] == 4;
        }

        public bool MarquerPassage(Position pos)
        {
            if (this.EstOccupee(pos) || this.EstUnMur(pos)) return false;
            this.matrice[pos.Ligne, pos.Colonne] = 4;
            return true;
        }

        public override string ToString()
        {
            string finalString = "";
            for (int ligne = 0; ligne < this.matrice.GetLength(0); ligne++)
            {
                for (int col = 0; col < this.matrice.GetLength(1); col++)
                {
                    finalString += this.matrice[ligne, col] == 1 ? "*" :
                        this.matrice[ligne, col] == 0 ? "-" :
                        this.matrice[ligne, col] == 2 ? "." :
                        this.matrice[ligne, col] == 3 ? "-" : ".";
                }

                finalString += "\n";
            }

            return finalString;
        }

        public int[,] Matrice
        {
            get => matrice;
            set => matrice = value;
        }

        public int NbLignes
        {
            get => nbLignes;
            set => nbLignes = value;
        }

        public int NbColonnes
        {
            get => nbColonnes;
            set => nbColonnes = value;
        }

        public Position Depart
        {
            get => depart;
            set => depart = value;
        }

        public Position Arrivee
        {
            get => arrivee;
            set => arrivee = value;
        }
    }
}