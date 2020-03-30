using System.Collections.Generic;
using System;

namespace CantStop.Core.Plateau
{
    public class Colonne
    {
        public int Valeur { get; private set; }
        public bool EstOuverte { get; set; }
        public List<CaseJeu> Cases { get; private set; }

        public Colonne(int val)
        {
            if (val < 2  || val > 12)
            {
                throw new ArgumentOutOfRangeException("colonne", "La valeur de la colonne n'est pas valide");
            }
            Valeur = val;
            EstOuverte = true;
            Cases = new List<CaseJeu>();
            if (val == 2 || val == 12)
            {
                AjouterCases(3);
            }
            else if (val == 3 || val == 11)
            {
                AjouterCases(5);
            }
            else if (val == 4 || val == 10)
            {
                AjouterCases(7);
            }
            else if (val == 5 || val == 9)
            {
                AjouterCases(9);
            }
            else if (val == 6 || val == 8)
            {
                AjouterCases(11);
            }
            else if (val == 7)
            {
                AjouterCases(11);
            }
        }

        private void AjouterCases(int nombreCases)
        {
            for (int i = 0; i < nombreCases; i++)
            {
                Cases.Add(new CaseJeu(i));
            }
        }

    }
}