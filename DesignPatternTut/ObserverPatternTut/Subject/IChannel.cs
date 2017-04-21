using ObserverPatternTut.Observer;

namespace ObserverPatternTut.Subject
{
    interface IChannel
    {
        void Subscriber(ISubscriber s);
        void Unsubscriber(ISubscriber s);
        void NotifyAll();
    }
}
