namespace Design_Patterns_Implementation.Decorator
{
    public abstract class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;
        
        public DataSourceDecorator(IDataSource wrappee)
        {
            this.wrappee = wrappee;
        }

        public virtual string ReadData()
        {
            return wrappee.ReadData();
        }

        public virtual void WriteData(string data)
        {
            wrappee.WriteData(data);
        }
    }
}