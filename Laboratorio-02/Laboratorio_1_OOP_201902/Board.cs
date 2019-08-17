using Laboratorio_1_OOP_201902.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902
{
    public class Board
    {
        //Constantes
        private const int DEFAULT_NUMBER_OF_PLAYERS = 2;

        //Atributos
        private List<CombatCard>[] meleeCards;
        private List<CombatCard>[] rangeCards;
        private List<CombatCard>[] longRangeCards;

        private SpecialCard[] specialMeleeCards;
        private SpecialCard[] specialRangeCards;
        private SpecialCard[] specialLongRangeCards;

        private SpecialCard[] captainCards;
        private List<SpecialCard> weatherCards;

        //Propiedades
        public List<CombatCard>[] MeleeCards
        {
            get
            {
                return this.meleeCards;
            }
        }
        public List<CombatCard>[] RangeCards
        {
            get
            {
                return this.rangeCards;
            }
        }
        public List<CombatCard>[] LongRangeCards
        {
            get
            {
                return this.longRangeCards;
            }
        }
        public SpecialCard[] SpecialMeleeCards
        {
            get
            {
                return this.specialMeleeCards;
            }
            set
            {
                this.specialMeleeCards = value;
            }
        }
        public SpecialCard[] SpecialRangeCards
        {
            get
            {
                return this.specialRangeCards;
            }
            set
            {
                this.specialRangeCards = value;
            }
        }
        public SpecialCard[] SpecialLongRangeCards
        {
            get
            {
                return this.specialLongRangeCards;
            }
            set
            {
                this.specialLongRangeCards = value;
            }
        }
        public SpecialCard[] CaptainCards
        {
            get
            {
                return this.captainCards;
            }
        }
        public List<SpecialCard> WeatherCards
        {
            get
            {
                return this.weatherCards;
            }
        }


        //Constructor
        public Board()
        {
            this.meleeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.rangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.longRangeCards = new List<CombatCard>[DEFAULT_NUMBER_OF_PLAYERS];
            this.weatherCards = new List<SpecialCard>();
            this.captainCards = new SpecialCard[DEFAULT_NUMBER_OF_PLAYERS];
        }



		//Metodos

		public void AddCombatCard(int playerId, CombatCard combatCard)
		{

			if (combatCard.Type == "Melee")
			{
				AddMeleeCard(playerId, combatCard);
			}
			if (combatCard.Type == "Range")
			{
				AddRangeCard(playerId, combatCard);
			}
			if (combatCard.Type == "LongRange")
			{
				AddLongRangeCard(playerId, combatCard);
			}
		}

		public void AddSpecialCard(int playerId, SpecialCard specialCard, string buffType)
		{
			if (specialCard.Type == "SpecialMelee")
			{
				SpecialMeleeCards[playerId] = specialCard;
			}
			if (specialCard.Type == "SpecialRange")
			{
				SpecialRangeCards[playerId] = specialCard;
			}
			if (specialCard.Type == "SpecialLongRange")
			{
				SpecialLongRangeCards[playerId] = specialCard;
			}
			if (specialCard.Type == "Captain")
			{
				AddCaptainCard(playerId, specialCard);
			}
			if (specialCard.Type == "Weather")
			{
				AddWeatherCard(playerId, specialCard);
			}
			
		}


		public void DestroyCombatCard(int playerId)
		{
			DestroyMeleeCard(playerId);
			DestroyRangeCard(playerId);
			DestroyLongRangeCard(playerId);

		}

		public void DestroySpecialCards()
		{
			DestroySpecialMeleeCard();
			DestroySpecialRangeCard();
			DestroySpecialLongRangeCard();
			DestroyWeatherCard();


		}

		public int[] GetMeleeAttackPoints()
		{
			List<int> cont = new List<int>();
			foreach (var cards in meleeCards)
			{
				foreach (var card in cards)
				{
					cont.Add(card.AttackPoints);
				}
			}
			int[] Cont = cont.ToArray();
			return Cont;
		}

		public int[] GetRangeAttackPoints()
		{
			List<int> cont = new List<int>();
			foreach (var cards in rangeCards)
			{
				foreach (var card in cards)
				{
					cont.Add(card.AttackPoints);
				}
			}
			int[] Cont = cont.ToArray();
			return Cont;
		}

		public int[] GetLongRangeAttackPoints()
		{
			List<int> cont = new List<int>();
			foreach (var cards in longRangeCards)
			{
				foreach (var card in cards)
				{
					cont.Add(card.AttackPoints);
				}
			}
			int[] Cont = cont.ToArray();
			return Cont;
		}


		public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
			meleeCards[PlayerId].Add(combatCard);
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
			rangeCards[PlayerId].Add(combatCard);
		}
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
			longRangeCards[PlayerId].Add(combatCard);
		}
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
			captainCards[PlayerId] =specialCard;
		}
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
			weatherCards.Add(specialCard);
		}
        public void DestroyMeleeCard(int PlayerId)
        {
			meleeCards[PlayerId].Clear();
        }
        public void DestroyRangeCard(int PlayerId)
        {
			rangeCards[PlayerId].Clear();
        }
        public void DestroyLongRangeCard(int PlayerId)
        {
			longRangeCards[PlayerId].Clear();
		}
        public void DestroySpecialMeleeCard()
        {
			Array.Clear(specialMeleeCards, 0, specialMeleeCards.Length);
        }
        public void DestroySpecialRangeCard()
        {
			Array.Clear(specialRangeCards, 0, specialRangeCards.Length);
		}
        public void DestroySpecialLongRangeCard()
        {
			Array.Clear(specialLongRangeCards, 0, specialLongRangeCards.Length);
		}
        public void DestroyWeatherCard()
        {
			weatherCards.Clear();
        }
        
    }
}
