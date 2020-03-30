using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantStop.Core.Lancer
{
    public class ResultatLancer
    {
        private List<ushort> lancers { get; set; }
        
        
        public List<Combinaison> Combinaisons { get; private set; }

        public ResultatLancer()
        {
            lancers = LancerDes.Lancer();

            AssocierPaires();
        }

        private void AssocierPaires()
        {
            Combinaisons = new List<Combinaison>();
            Combinaisons.Add(new Combinaison(lancers[0], lancers[1], lancers[2], lancers[3]));
            Combinaisons.Add(new Combinaison(lancers[0], lancers[2], lancers[1], lancers[3]));
            Combinaisons.Add(new Combinaison(lancers[1], lancers[2], lancers[0], lancers[3]));
        }
        protected int SommeLancers { get { return lancers.Sum(d => d); } }
    }
}
