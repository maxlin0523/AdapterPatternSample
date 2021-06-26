using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternSample.HDMI
{
    /// <summary>
    /// HDMI規格
    /// </summary>
    public interface IHDMI
    {
        void Connect();
    }
}
