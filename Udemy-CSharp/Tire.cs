namespace Udemy_CSharp
{
    public class Tyre
    {
        public string Name { get; set; }
        public int Friction { get; set; }
        public int Durability { get; set; }
        public double Price { get; set; }

        public Tyre(string Name, int friction, int durability, double price)
        {
            this.Name = Name;
            this.Friction = friction;
            this.Durability = durability;
            this.Price = price;
        }
    }
}
