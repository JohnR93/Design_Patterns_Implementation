using System;
using Design_Patterns_Implementation.Builder;
using Design_Patterns_Implementation.Strategy;

namespace Design_Patterns_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrategyClient(new Road());
            //StrategyClient(new Walking());
            //StrategyClient(new PublicTransport());
            BuilderClient();
        }
        
        public static void StrategyClient(ITransport transportMode)
        {
            Transport transport = new Transport();
            transport.SetTransport(transportMode);
            transport.FindRoute();

        }
        

        public static void BuilderClient()
        {
            Director director = new Director();
            CarBuilder carBuilder = new CarBuilder();
            director.SetBuilder(carBuilder);

            director.MakeCommonCar();
            Console.WriteLine("Common Car: " + carBuilder.car.Description());
            director.MakeSportCar();
            Console.WriteLine("Sport Car: " + carBuilder.car.Description());
            director.MakeCustomCar(new CustomEngine(6000), 2, true, true);
            Console.WriteLine("Custom Car: " + carBuilder.car.Description());
        }
    }
}
