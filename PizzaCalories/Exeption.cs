namespace PizzaCalories
{
    public class Exeption
    {
        public static string invalidDoughTypeException = "Invalid type of dough.";

        public static string invalidDoughWeightException = "Dough weight should be in the range [1..200].";

        public static string invalidPizzaNameException = "Pizza name should be between 1 and 15 symbols.";

        public static string invalidToppingNumberException = "Number of toppings should be in range [0..10].";

        public static string invalidToppingWeightException = $"{0} weight should be in the range [1..50].";

        public static string invalidToppingNameException = $"Cannot place {0} on top of your pizza.";

    }
}