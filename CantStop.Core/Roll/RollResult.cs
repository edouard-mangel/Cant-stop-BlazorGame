using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CantStop.Core.Dices
{
    public class RollResult
    {
        private List<ushort> lancers { get; set; }
        
        public List<DicesCombination> Combinaisons { get; private set; }

        public RollResult()
        {
            lancers = DiceRoll.Lancer();

            AssocierPaires();
        }

        private void AssocierPaires()
        {
            Combinaisons = new List<DicesCombination>();
            Combinaisons.Add(new DicesCombination(lancers[0], lancers[1], lancers[2], lancers[3]));
            Combinaisons.Add(new DicesCombination(lancers[0], lancers[2], lancers[1], lancers[3]));
            Combinaisons.Add(new DicesCombination(lancers[1], lancers[2], lancers[0], lancers[3]));
        }
        protected int SommeLancers { get { return lancers.Sum(d => d); } }
    }
}
