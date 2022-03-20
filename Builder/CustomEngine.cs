namespace Design_Patterns_Implementation.Builder
{
    public class CustomEngine : IEngine
    {
        public int enginePower { get; set; }
        public float enginePrice { get; set; }

        public CustomEngine(int enginePower)
        {
            if(enginePower >= 10000)
                this.enginePower = 10000;
            else
                this.enginePower = enginePower;
                
            enginePrice = enginePower * 3;
        }

        public override string ToString()
        {
            return "Custom engine";
        }
    }
}