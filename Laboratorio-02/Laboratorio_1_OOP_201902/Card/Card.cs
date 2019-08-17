using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_1_OOP_201902.Card
{
	public class Card
	{
		private string name;
		private string type;

		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		public string Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		public Card(string name, string type)
		{
			this.name = name;
			this.type = type;
		}
	}
}
