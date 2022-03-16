namespace Design_Patterns_Implementation.Builder
{
    public class CommonEngine : IEngine
    {

        public int enginePower { get; set; }
        public float enginePrice { get; set; }

        public CommonEngine()
        {
            enginePower = 1200; 
            enginePrice = 5500f;
        }
        
    }
}