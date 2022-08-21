namespace Udemy_CSharp
{
    public class Brake
    {
        public string Name { get; set; }
        public int BrakeFriction { get; set; }
        public int BrakeDurability { get; set; }
        public double Price { get; set; }

        public Brake(string Name, int brakeFriction, int brakeDurability, double price)
        {
            this.Name = Name;
            this.BrakeFriction = brakeFriction;
            this.BrakeDurability = brakeDurability;
            this.Price = price;
        }
    }
}
