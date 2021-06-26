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
    /// HDMI to DVI 轉接器。
    /// 繼承的介面＝要轉換的物件(DVI)
    /// </summary>
    public class DVIAdapter : IDVI
    {
        private IHDMI _hdmi;

        /// <summary>
        /// 建構式參數＝要被轉換的物件(HDMI)
        /// </summary>
        public DVIAdapter(IHDMI hdmi)
        {
            _hdmi = hdmi;       
        }

        /// <summary>
        /// 實作IDVI Connect
        /// 實際上是HDMI連接，藉此達到轉接效果
        /// </summary>
        public void Connect()
        {
            Console.WriteLine("轉接: HDMI to DVI");
            _hdmi.Connect();
        }
    }
}
