using System.Threading;
using System;
using Design_Patterns_Implementation.Builder;
using Design_Patterns_Implementation.Observer;
using Design_Patterns_Implementation.Strategy;
using Design_Patterns_Implementation.Decorator;

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
            //ObserverClient();
            DecoratorClient();
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

        public static void DecoratorClient()
        {
            System.Console.WriteLine("Type a text: Decorator text");
            //string input = Console.ReadLine();
            string input  = "Decorator Text";
            IDataSource data = new FileDataSource("Decorator exemple");
            data.WriteData(input);
            System.Console.WriteLine();
            System.Console.WriteLine(data.ReadData());
            System.Console.WriteLine("---- Putting compression ----");
            CompressionDecorator dataCompress = new CompressionDecorator(data);
            dataCompress.WriteData(data.ReadData());
            System.Console.WriteLine();
            System.Console.WriteLine(dataCompress.ReadData());


        }
    }
}
