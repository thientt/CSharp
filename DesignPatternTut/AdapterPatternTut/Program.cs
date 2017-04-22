using AdapterPatternTut.Adaptor;
using System;

namespace AdapterPatternTut
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UsbAdapter usb = new UsbAdapter();
            usb.ConnectUsbPort();
            Console.WriteLine("Got the signal!");

            Console.Read();
        }
    }
}
