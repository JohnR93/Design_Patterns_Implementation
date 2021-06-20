namespace Design_Patterns_Implementation.Strategy
{
    public class PublicTransport : ITransport
    {
        public void MakeRouteMap()
        {
            System.Console.WriteLine("PublicTransportRoute");
        }
    }
}