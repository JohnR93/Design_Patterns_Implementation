namespace Design_Patterns_Implementation.Builder
{
    public class CarBuilder : IBuilder
    {
        public Car car;

        public CarBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            this.car = new Car();
        }

        public void SetEngine(IEngine engine)
        {
            this.car.Engine = engine;
        }

        public void SetGPS(bool gps)
        {
            this.car.GPS = gps;
        }

        public void SetSeats(int amount)
        {
            if(amount < 2 || amount > 8)
                car.Seats = 0;
            else
                car.Seats = amount;
        }

        public void SetTripComputer(bool tripComputer)
        {
            this.car.TripComputer = tripComputer;
        }
    }
}