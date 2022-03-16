namespace Design_Patterns_Implementation.Builder
{
    public class CustomEngine : IEngine
    {
        public int enginePower { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float enginePrice { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public CustomEngine(int enginePower)
        {
            if(enginePower >= 10000)
                this.enginePower = 10000;
            else
                this.enginePower = enginePower;
                
            enginePrice = enginePower * 3;
        }
    }
}