using AdapterPatternSample.DVI;
using AdapterPatternSample.HDMI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.Adapter
{
    /// <summary>
    /// HDMI to DVI 轉接器。繼承要轉換的DVI接口
    /// </summary>
    public class DVIAdapter : IDVI
    {
        private IHDMI _hdmi;

        /// <summary>
        /// 注入被轉換的HDMI
        /// </summary>
        public DVIAdapter(IHDMI hdmi)
        {
            _hdmi = hdmi;       
        }

        /// <summary>
        /// 由DVI實作連接，但實際上是HDMI連接
        /// </summary>
        public void Connect()
        {
            Console.WriteLine("HDMI轉接成DVI");
            _hdmi.Connect();
        }
    }
}
