namespace Design_Patterns_Implementation.Builder
{
    public interface IBuilder
    {
 
        void Reset();
        void SetSeats(int amount);
        void SetEngine(IEngine engine);
        void SetTripComputer(bool tripComputer);
        void SetGPS(bool gps);
    }
}