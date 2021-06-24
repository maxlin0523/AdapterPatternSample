using AdapterPatternSample.Adapter;
using AdapterPatternSample.DVI;
using AdapterPatternSample.HDMI;
using AdapterPatternSample.Host;
using System;

namespace AdapterPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // var oldScreen = new OldScreen();

            var newScreen = new NewScreen();

            var DVIadapter = new DVIAdapter(newScreen);

            var myHost = new MyHost(DVIadapter);

            myHost.Open();

            Console.ReadKey();
        }
    }
}
