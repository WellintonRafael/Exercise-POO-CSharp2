namespace Udemy_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancialização de novos objetos
            var motor1 = new Motor1();
            var motor2 = new Motor2();

            var brakeNormal = new BrakeTypeNormal();
            var brakeABS = new BrakeTypeABS();

            var softTyre = new SoftTyre();
            var mediumTyre = new MediumTyre();
            var hardTyre = new HardTyre();

            var car = new Car("BMW", "Chevete", motor2, brakeNormal, hardTyre, 1780000.00);
            var car2 = new Car("Mercedes Benz", "Fusca", motor1, brakeABS, softTyre, 204000.00);

            // Declaração de variáveis globais
            var chosenCarID = -1;
            int newSpeed = 0;
            string chosenIfBrake = "";

            //new ConnectionDB();


            Console.WriteLine("Escolha o carro que você quer dar uma voltinha por aí: \n" +
                "----------------------------------------------------------------- \n" +
                "Digite 1 para:\n\n" +
                "Marca: {0}\n" +
                "Nome: {1}\n" +
                "Velocidade máxima: {2} km/h \n" +
                "Tipo do freio: {3} \n" +
                "Maciez do pneu: {4} \n" +
                "Preço: U${5}", car.CarBrand, car.Name, car.MotorType.MaxSpeed, car.BrakeType.Name,car.TyreType.Name, car.Price);

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Digite 2 para: \n\n" +
                "Marca: {0}\n" +
                "Nome: {1}\n" +
                "Velocidade máxima: {2} km/h \n" +
                "Tipo do freio: {3} \n" +
                "Maciez do pneu: {4} \n" +
                "Preço: U${5}", car2.CarBrand, car2.Name, car2.MotorType.MaxSpeed, car2.BrakeType.Name,car2.TyreType.Name, car2.Price);
            Console.Write("\nDigite aqui -> ");

            chosenCarID = int.Parse(Console.ReadLine());


            Car carSelected;
            switch (chosenCarID)
            {
                case 1:
                    carSelected = car;
                    newSpeed = car.Accelerate();
                    break;
                case 2:
                    carSelected = car2;
                    newSpeed = car2.Accelerate();
                    break;
                default:
                    Console.WriteLine("A opção digitada é inválida \n" +
                        "*******************************************************************");
                    Main(args);
                    return;
            }

            if (newSpeed > 110)
            {
                Console.WriteLine("Você está a {0} km/h, cuidado com a fiscalização!", newSpeed);
                Console.WriteLine("Deseja frear um pouco? \n" +
                    "[1] - Sim \n" +
                    "[2] - Não");
                chosenIfBrake = Console.ReadLine().ToLower();
                switch (chosenIfBrake)
                {
                    case "1":
                    case "sim":
                        newSpeed = carSelected.Braking();
                        Console.WriteLine("Você está a {0} km/h. Boa viagem!", newSpeed);

                        break;
                    case "2":
                    case "não":
                        break;
                    default:
                        Main(args);
                        return;
                }
            }
            else
            {
                Console.WriteLine("Você está a {0} km/h. Boa viagem!", newSpeed);
            }
        }
    }
}