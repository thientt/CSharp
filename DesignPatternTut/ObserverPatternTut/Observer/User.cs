using System;

namespace ObserverPatternTut.Observer
{
    public class User : ISubscriber
    {
        public void Notify() {

            Console.WriteLine("User has been updated about new video!");
        }
    }
}
