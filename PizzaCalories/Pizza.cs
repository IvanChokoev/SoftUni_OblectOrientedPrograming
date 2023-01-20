using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int maxLength = 15;

        private const int maxToppingCount = 10;


        private string name;
        private Dough dough;
        //private readonly List<Topping> Toppings;

        public string Name 
        {
            get => this.name;
                private set
            {
                if (value.Length > maxLength || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            } 
        }

        public Dough Dough
        {
            get => this.dough;
            private set
            {
                this.dough = value;
            }
        }

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Toppings = new List<Topping>();
        }
        public List<Topping> Toppings { get; }
        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Count == maxToppingCount)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.Toppings.Add(topping);
        }

        public override string ToString()
        {
            double toppingSum = this.Toppings.Select(t => t.ToppingCalories()).Sum();
            double calories = this.Dough.DoughCalories() + toppingSum;
            return $"{this.Name} - {calories:f2} Calories.";
        }

    }
}

