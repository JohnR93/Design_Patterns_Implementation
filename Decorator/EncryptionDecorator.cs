namespace Design_Patterns_Implementation.Decorator
{
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource wrappee) : base(wrappee)
        {

        }

        public override void WriteData(string data)
        {
            base.WriteData(data);
        }

        public override string ReadData()
        {
            return base.ReadData();
        }
    }
}