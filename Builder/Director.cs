namespace Design_Patterns_Implementation.Builder
{
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            SetBuilder(builder);
        }

        public Director()
        {
            return;
        }

        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public void MakeCommonCar()
        {
            if(builder == null)
                return;
            builder.Reset();
            builder.SetEngine(new CommonEngine());
            builder.SetSeats(5);
            builder.SetGPS(false);
            builder.SetTripComputer(false);

        } 

        public void MakeSportCar()
        {
            if(builder == null)
                return;
            builder.Reset();
            builder.SetEngine(new SportEngine());
            builder.SetSeats(2);
            builder.SetGPS(true);
            builder.SetTripComputer(true);
        }

        public void MakeCustomCar(IEngine engine, int seats, bool gps, bool tripComputer)
        {
            if(builder == null)
                return;
            builder.Reset();
            builder.SetEngine(engine);
            builder.SetSeats(seats);
            builder.SetGPS(gps);
            builder.SetTripComputer(tripComputer);
        }
    }
}