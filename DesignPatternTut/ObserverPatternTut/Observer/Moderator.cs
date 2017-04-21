using System;

namespace ObserverPatternTut.Observer
{
    public class Moderator : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("Moderator needs to  review video.");
        }
    }
}
