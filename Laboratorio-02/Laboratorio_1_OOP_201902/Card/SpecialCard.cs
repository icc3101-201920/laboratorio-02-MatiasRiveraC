using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
    public class SpecialCard :Card
    {
        //Atributos
        private string buffType;
        private string effect;

        //Constructor
        public SpecialCard(string name, string type, string effect):base(name,type)
        {
            Effect = effect;
            BuffType = null;
        }



        //Propiedades
        public string BuffType
        {
            get
            {
                return this.buffType;
            }
            set
            {
                this.buffType = value;
            }
        }
        public string Effect
        {
            get
            {
                return this.effect;
            }
            set
            {
                this.effect = value;
            }
        }


    }
}
