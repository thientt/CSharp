using ObserverPatternTut.Observer;
using System.Collections.Generic;
using System;

namespace ObserverPatternTut.Subject
{
    public class YoutueChannel : IChannel
    {
        private ICollection<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscriber(ISubscriber s)
        {
            if (!subscribers.Contains(s))
                subscribers.Add(s);
        }

        public void Unsubscriber(ISubscriber s)
        {
            if (subscribers.Contains(s))
                subscribers.Remove(s);
        }

        public void NotifyAll()
        {
            foreach (var item in subscribers)
            {
                item.Notify();
            }
        }
    }
}
