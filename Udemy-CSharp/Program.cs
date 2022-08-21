namespace Udemy_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var motor1 = new Motor1();
            var motor2 = new Motor2();
            var chosenCarID = -1;
            int newSpeed = 0;
            var car = new Car("BMW", "Chevete", motor2);
            var car2 = new Car("Mercedes Benz", "Fusca", motor1);

            Console.WriteLine("Escolha o carro que você quer dar uma voltinha por aí: \n" +
                "-----------------------------------------------------------------\n" +
                "Digite 1 para:\n" +
                "Marca: {0}, Nome: {1} - Velocidade máxima: {2}km/h", car.Brand, car.Name, car.MotorType.MaxSpeed);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Escolha o carro que você quer dar uma voltinha por aí: \n" +
                "Digite 2 para:\n" +
                "Marca: {0}, Nome: {1} - Velocidade máxima: {2}km/h", car2.Brand, car2.Name, car2.MotorType.MaxSpeed);

            chosenCarID = int.Parse(Console.ReadLine());


            switch (chosenCarID)
            {
                case 1:
                    newSpeed = car.Accelerate();
                    break;
                case 2:
                    newSpeed = car2.Accelerate();
                    break;
                default:
                    Console.WriteLine("A opção digitada é inválida\n" +
                        "************************************************************");
                    Main(args);
                    return;
            }

            Console.WriteLine("Você está a {0}km/h, cuidado com a fiscalização!", newSpeed);
        }
    }
}
