using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.DVI
{
    /// <summary>
    /// 我的螢幕
    /// </summary>
    public class MyScreen : IDVI
    {
        public void Connect()
        {
            Console.WriteLine("螢幕故障連接失敗");
        }
    }
}
