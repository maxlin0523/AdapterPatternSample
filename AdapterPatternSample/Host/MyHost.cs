using AdapterPatternSample.DVI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.Host
{
    public class MyHost
    {
        private IDVI _dvi;
        public MyHost(IDVI dvi)
        {
            _dvi = dvi;
        }

        public void Open()
        {
            Console.WriteLine("電腦源DVI已被接上");
            _dvi.Connect();      
        }
    }
}
