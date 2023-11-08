using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Sophie_WPF
{
    public class Alabai : Dog
    {
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public Alabai() : base()
        {
            Height = 0;
            Weight = 0;
        }

        public Alabai(string breed, double height, double weight) : base(breed)
        {
            Height = height;
            Weight = weight;
        }

        public override double GetAmountFoodPerDay()
        {
            return 0.8 * Weight * Height;
        }

        public override string ToString()
        {
            return base.ToString() + $". Висота: {Height}. Маса: {Weight}. Кількість їжі на день: {GetAmountFoodPerDay()}";
        }
    }
}
