namespace Udemy_CSharp 
{ 
    
    public class Car
    {

        public int speed = 0;

        
        public string Brand { get; set; }
        public string Name { get; set; }
        public Motor MotorType { get; set; }

        
        public Car(string brand, string name, Motor motortype)
        {
            this.Brand = brand;
            this.Name = name;
            this.MotorType = motortype;
        }

        public int Accelerate()
        {
            
            Console.WriteLine("Acelere uma quantia em porcentagem: ");
            double percent = double.Parse(Console.ReadLine());

            speed = (int)(MotorType.MaxSpeed * (percent / 100));
            return speed;
        }

    }

    




}
