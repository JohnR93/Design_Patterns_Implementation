namespace Design_Patterns_Implementation.Decorator
{
    public class FileDataSource : IDataSource
    {
        private string fileName;
        private string data;

        public FileDataSource(string fileName)
        {
            this.fileName = fileName;
        }

        public string ReadData()
        {
            return "Output -> " + data;
        }

        public void WriteData(string data)
        {
            System.Console.Write("Input -> " + data);
            this.data = data;
        }
    }
}