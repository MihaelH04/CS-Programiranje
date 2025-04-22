namespace VubCaffe
{
    public class Drink : Consumable, IProduct
    {
        public Drink(string name, double volume, double price) : base(name)
        {
            Volume = volume;
            Price = price;
        }




        public virtual double TotalPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2:0.00}€", Name, Volume, Price);

        }
        public double Volume { get; set; }
        public double Price { get; set; }

    }
}