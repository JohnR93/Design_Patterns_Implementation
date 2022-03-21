using System.Threading;
using System;
using Design_Patterns_Implementation.Builder;
using Design_Patterns_Implementation.Observer;
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
            //BuilderClient();
            ObserverClient();
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

        public static void ObserverClient()
        {
             Publisher publisher = new Publisher();
             AppChannel app = new AppChannel();
             publisher.Subscribe(app);
             WebChannel web = new WebChannel();
             publisher.Subscribe(web);
             PaperChannel paper = new PaperChannel();
             publisher.Subscribe(paper);

             publisher.Publish("Post one ");
             Thread.Sleep(5000);
             publisher.Publish("Post two ");
             Thread.Sleep(5000);
             publisher.Publish("Post three ");
        }
    }
}
