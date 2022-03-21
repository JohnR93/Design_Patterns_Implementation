using System;
using System.Collections.Generic;

namespace Design_Patterns_Implementation.Observer
{
    public class Publisher
    {
        private List<ISubscriber> subscribers;
        private string lastPost;

        public Publisher()
        {
            subscribers = new List<ISubscriber>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach(var subscriber in subscribers)
            {
                subscriber.Updade(lastPost);
            }
        }

        public void Publish(string post)
        {
            lastPost = post + "| Updated in "  + DateTime.Now.ToString();
            NotifySubscribers();
        }
    }
}