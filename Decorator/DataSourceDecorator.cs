namespace Design_Patterns_Implementation.Decorator
{
    public abstract class DataSourceDecorator : IDataSource
    {
        private IDataSource wrappee;
        
        public DataSourceDecorator(IDataSource wrappee)
        {
            this.wrappee = wrappee;
        }

        public string ReadData()
        {
            throw new System.NotImplementedException();
        }

        public void WriteData(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}