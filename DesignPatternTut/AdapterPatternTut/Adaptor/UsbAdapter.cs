using AdapterPatternTut.Client;

namespace AdapterPatternTut.Adaptor
{
    internal class UsbAdapter
    {
        Mouse mouse = new Mouse();

        public void ConnectUsbPort()
        {
            mouse.ConnectPS2Port();
            System.Console.WriteLine("Converting signal to USB");
            System.Console.WriteLine("Sending new converted signals to Computer");
        }
    }
}
