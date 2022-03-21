using System;
namespace Design_Patterns_Implementation.Observer
{
    public class AppChannel : ISubscriber
    {
        public void Updade(string post)
        {
            Console.WriteLine("App get " + post);
        }
    }
}