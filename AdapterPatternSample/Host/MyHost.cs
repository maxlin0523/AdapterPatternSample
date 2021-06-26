using AdapterPatternSample.DVI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.Host
{
    /// <summary>
    /// 主機
    /// </summary>
    public class MyHost
    {
        private IDVI _dvi;

        /// <summary>
        /// 使用DVI接口
        /// </summary>
        public MyHost(IDVI dvi)
        {
            _dvi = dvi;
            Console.WriteLine("PC端DVI接口連接成功");
        }

        /// <summary>
        /// 開機
        /// </summary>
        public void Open()
        {
            _dvi.Connect();      
        }
    }
}
