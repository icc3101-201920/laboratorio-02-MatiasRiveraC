using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Hand : Deck
    {
        private List<CombatCard> combatCards;
        private List<SpecialCard> specialCards;

        public Hand(List<CombatCard> combatCards, List<SpecialCard> specialCards)
        {
            this.combatCards = combatCards;
            this.specialCards = specialCards;
        }

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => SpecialCards = value; }




    }
}
