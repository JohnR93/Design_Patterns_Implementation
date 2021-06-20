using System;
using Design_Patterns_Implementation.Strategy;

namespace Design_Patterns_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyClient(new Road());
            StrategyClient(new Walking());
            StrategyClient(new PublicTransport());
        }

        public static void StrategyClient(ITransport transportMode)
        {
            Transport transport = new Transport();
            transport.SetTransport(transportMode);
            transport.FindRoute();

        }
    }
}
