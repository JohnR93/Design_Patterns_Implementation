namespace Design_Patterns_Implementation.Builder
{
    public  class Car
    {
        public IEngine Engine { get; set; }
        public int Seats { get; set; }
        public bool GPS { get; set; }
        public bool TripComputer { get; set; }

        public string Description()
        {
            return null;
        }
    }
}