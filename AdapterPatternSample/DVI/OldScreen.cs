using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.DVI
{
    public class OldScreen : IDVI
    {
        public void Connect()
        {
            Console.WriteLine("接上DVI螢幕");
        }
    }
}
