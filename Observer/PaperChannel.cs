namespace Design_Patterns_Implementation.Observer
{
    public class PaperChannel : ISubscriber
    {
        public void Updade(string post)
        {
            System.Console.WriteLine("Paper get " + post);
        }
    }
}