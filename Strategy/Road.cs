namespace Design_Patterns_Implementation.Strategy
{
    public class Road : ITransport
    {
        public void MakeRouteMap()
        {
            System.Console.WriteLine("RoadRoute");
        }
    }
}