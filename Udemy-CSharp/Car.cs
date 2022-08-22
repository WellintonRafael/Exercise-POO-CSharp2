namespace Udemy_CSharp 
{ 
    public class Car
    {
        public int speed = 0;

        public string CarBrand { get; set; }
        public string Name { get; set; }
        public Motor MotorType { get; set; }
        public Brake BrakeType { get; set; }
        public Tyre TyreType { get; set; }
        public double Price { get; set; }

        public Car(string brand, string name, Motor motortype, Brake brakeType, Tyre tyreType, double price)
        {
            this.CarBrand = brand;
            this.Name = name;
            this.MotorType = motortype;
            this.BrakeType = brakeType;
            this.TyreType = tyreType;
            this.Price = price;
        }

        public int Accelerate()
        {
            Console.WriteLine("Quantos por cento deseja acelerar: ");
            double percent = double.Parse(Console.ReadLine());

            speed = (int)(MotorType.MaxSpeed * (percent / 100) - (TyreType.Friction / 10));
            return speed;
        }

        public int Braking()
        {
            Console.WriteLine("Quantos por cento deseja frear: ");
            double percentBrake = double.Parse(Console.ReadLine());
            percentBrake = percentBrake / 100;
            speed = (int)(speed - (speed * percentBrake));
            return speed;
        }
    }

    




}
