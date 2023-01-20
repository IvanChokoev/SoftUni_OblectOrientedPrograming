namespace Restaurant
{

    public class Product
    {
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

        }
    }
}