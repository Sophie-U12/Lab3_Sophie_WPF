using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sophie_WPF
{
    public class Dachshund : Dog
    {
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Dachshund() : base()
        {
            Length = 0;
            Weight = 0;
        }

        public Dachshund(string breed, double length, double weight) : base(breed)
        {
            Length = length;
            Weight = weight;
        }

        public override double GetAmountFoodPerDay()
        {
            return Length * 1d / Weight;
        }

        public override string ToString()
        {
            return base.ToString() + $". Довжина: {Length}. Маса: {Weight}. Кількість їжі на день: {GetAmountFoodPerDay()}";
        }
    }
}
