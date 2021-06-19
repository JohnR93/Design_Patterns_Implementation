using System.Reflection;
namespace Design_Patterns_Implementation.Strategy
{
    public class Transport
    {
        private ITransport transportMode;

        public void SetTransport(ITransport transportMode)
        {
            this.transportMode = transportMode;
        }

        public void FindRoute()
        {
            transportMode.MakeRouteMap();
        }
    }
}