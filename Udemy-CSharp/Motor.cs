namespace Udemy_CSharp
{
    public class Motor
    {
        public int HorsePower { get; set; }
        public int MaxSpeed { get; set; }
        public double Price { get; set; }
    

        public Motor(int horsePower, int maxSpeed, double price)
        {
            this.HorsePower = horsePower;
            this.MaxSpeed = maxSpeed;
            this.Price = price;
        }
    }
}
