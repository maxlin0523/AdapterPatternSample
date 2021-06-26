using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.HDMI
{
    /// <summary>
    /// 新的螢幕
    /// </summary>
    public class NewScreen : IHDMI
    {
        public void Connect()
        {
            Console.WriteLine("HDMI螢幕連接成功");
        }
    }
}
