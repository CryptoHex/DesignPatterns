namespace MyObserver
{
    public class Stock
    {
        private string name;
        private double price;

        public Stock(string name)
        {
            this.name = name;
        }

        public Stock(string name, double price) : this(name)
        {
            this.price = price;
        }

        public double Price { get => price; set => price = value; }
        public string Name { get => name; }
    }
}