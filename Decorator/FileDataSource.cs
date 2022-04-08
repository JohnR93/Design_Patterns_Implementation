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
            throw new System.NotImplementedException();
        }

        public void WriteData(string data)
        {
            this.data = data;
        }
    }
}