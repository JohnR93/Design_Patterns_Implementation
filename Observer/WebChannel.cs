using System;

namespace Design_Patterns_Implementation.Observer
{
    public class WebChannel : ISubscriber
    {
        public void Updade(string post)
        {
            Console.WriteLine("Web get " + post);
        }
    }
}