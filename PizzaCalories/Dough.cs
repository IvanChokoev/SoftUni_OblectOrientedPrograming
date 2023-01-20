using System;


namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private const double minWeight = 1;
        private const double maxWeight = 200;

        private const double white = 1.5;
        private const double wholegrain = 1.0;
        private const double crispy = 0.9;
        private const double chewy = 1.1;
        private const double homemade = 1.0;

        public Dough(string aFlourType, string aBakingTechnique, double aWeight)
        {
            this.FlourType = aFlourType;
            this.BakingTechnique = aBakingTechnique;
            this.Weight = aWeight;
        }

        public string FlourType { 
            get =>  this.flourType;
           private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new InvalidOperationException(Exeption.invalidDoughTypeException);
                }
                this.flourType = value;
            } 
        }

        public string BakingTechnique {
            get => this.bakingTechnique;
            private set 
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new InvalidOperationException(Exeption.invalidDoughTypeException);
                }
                this.bakingTechnique = value;
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
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException(Exeption.invalidDoughWeightException);
                }

                this.weight = value;
            }
        }

        public double DoughCalories()
        {
            return (2 * this.Weight) * FlourModifier() * BakingTechniqueModifier();
        }

        private double BakingTechniqueModifier()
        {
            if (this.FlourType == "white")
            {
                return 1.5;
            };

            return 1.0;
        }

        private double FlourModifier()
        {
            if (this.BakingTechnique == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique == "chewy")
            {
                return 1.1;
            }
            else
            {
                return 1.0;
            }
        }
    }
}
