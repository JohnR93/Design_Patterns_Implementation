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
            string description = Engine.ToString() + ", Seats: " + Seats.ToString();
            float costPrice = 1000;
            costPrice += Engine.enginePrice;
            costPrice += Seats * 120f;
            if(GPS)
            {
                description += ", contains GPS";
                costPrice += 1800f;
            }
            if(TripComputer)
            {
                description += ", contains Trip Computer";
                costPrice += 1800f;
            }
            description += ". Cost price: " + costPrice.ToString();
            return description;

        }
    }
}