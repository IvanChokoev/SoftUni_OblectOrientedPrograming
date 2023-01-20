using System;


namespace PizzaCalories
{
    public class Topping
    {
        private const double maxWeight = 51;
        private const double minWeight = 0;

        private string name;
        private double weight;

        public Topping(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    var valueName = value[0].ToString().ToUpper() + value.Substring(1);
                    throw new Exception($"Cannot place {valueName} on top of your pizza.");
                }

                this.name = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                if (value <= minWeight || value >= maxWeight)
                {
                    throw new ArgumentException($"{Name} weight should be in the range [1..50].");
                }

                this.weight = value;

            }
        }
        public double ToppingCalories()
        {
            return (2 * this.Weight) * ToppingTypeModifier();
        }

        private double ToppingTypeModifier()
        {
            if (this.Name == "meat")
            {
                return 1.2;
            }
            else if (this.Name == "veggies")
            {
                return 0.8;
            }
            else if (this.Name == "cheese")
            {
                return 1.1;
            }
            else
            {
                return 0.9;
            }
        }
    }
}
