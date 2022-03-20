namespace Design_Patterns_Implementation.Builder
{
    public class SportEngine : IEngine
    {
        public int enginePower { get; set; }
        public float enginePrice { get; set; }

        public SportEngine()
        {
            enginePower = 4800;
            enginePrice = 12000f;
        }

        public override string ToString()
        {
            return "Common engine";
        }
    }
}