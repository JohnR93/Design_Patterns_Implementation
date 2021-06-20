namespace Design_Patterns_Implementation.Strategy
{
    public class Walking : ITransport
    {
        public void MakeRouteMap()
        {
            System.Console.WriteLine("WalkingRoute");
        }
    }
}