using System;

namespace TD_6_A2
{
    public class Position
    {
        private int ligne;
        private int colonne;

        public Position(int ligne, int colonne)
        {
            if (ligne < 0) throw new ArgumentOutOfRangeException(nameof(ligne));
            if (colonne < 0) throw new ArgumentOutOfRangeException(nameof(colonne));
            this.ligne = ligne;
            this.colonne = colonne;
        }

        public int Ligne
        {
            get => ligne;
            set => ligne = value;
        }

        public int Colonne
        {
            get => colonne;
            set => colonne = value;
        }

        public string toString()
        {
            return $"X:{this.Ligne},Y:{this.Colonne}";
        }

        public bool EstEgale(Position other)
        {
            return (other.Ligne == this.Ligne && other.Colonne == this.Colonne);
        }
        
    }
}