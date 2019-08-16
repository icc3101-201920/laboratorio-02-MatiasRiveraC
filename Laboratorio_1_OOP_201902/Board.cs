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
			if (specialCard.Type == "Captain")
			{
				AddCaptainCard(playerId, specialCard);
			}
			if (specialCard.Type == "Weather")
			{
				AddWeatherCard(playerId, specialCard);
			}
			
		}


		public void DestroyCombatCard()
		{
			DestroyMeleeCard();
			DestroyRangeCard();
			DestroyLongRangeCard();

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
			throw new NotImplementedException();
		}

		public int[] GetRangeAttackPoints()
		{
			throw new NotImplementedException();
		}

		public int[] GetLongRangeAttackPoints()
		{
			throw new NotImplementedException();
		}


		public void AddMeleeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddLongRangeCard(int PlayerId, CombatCard combatCard)
        {
            throw new NotImplementedException();
        }
        public void AddCaptainCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void AddWeatherCard(int PlayerId, SpecialCard specialCard)
        {
            throw new NotImplementedException();
        }
        public void DestroyMeleeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroyRangeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroyLongRangeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialMeleeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialRangeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroySpecialLongRangeCard()
        {
            throw new NotImplementedException();
        }
        public void DestroyWeatherCard()
        {
            throw new NotImplementedException();
        }
        
    }
}
