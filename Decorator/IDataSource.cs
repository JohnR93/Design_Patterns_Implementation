namespace Design_Patterns_Implementation.Decorator
{
    public interface IDataSource
    {
         void WriteData(string data);
         string ReadData();
    }
}