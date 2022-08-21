namespace Udemy_CSharp
{
    public class Motor
    {
        public int HorsePower { get; set; }
        public int MaxSpeed { get; set; }
    

        public Motor(int horsePower, int maxSpeed)
        {
            this.HorsePower = horsePower;
            this.MaxSpeed = maxSpeed;
        }
    }
}
