using ObserverPatternTut.Observer;
using ObserverPatternTut.Subject;
using System;

namespace ObserverPatternTut
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new YoutueChannel();
            var michel = new User();
            var moderator = new Moderator();

            channel.Subscriber(michel);
            channel.Subscriber(moderator);

            channel.NotifyAll();

            Console.Read();
        }
    }
}
