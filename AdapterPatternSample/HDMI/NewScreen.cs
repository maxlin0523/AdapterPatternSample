using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.HDMI
{
    public class NewScreen : IHDMI
    {
        public void Connect()
        {
            Console.WriteLine("接上HDMI螢幕");
        }
    }
}
