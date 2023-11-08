using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sophie_WPF
{
    public abstract class Dog
    {
		private string breed;

		public string Breed
		{
			get { return breed; }
			set { breed = value; }
		}

		public Dog()
		{
			Breed = "";
		}

		public Dog(string breed)
		{
			Breed = breed;
		}

		public abstract double GetAmountFoodPerDay();

		public override string ToString()
		{
			return Breed;
		}
	}
}
