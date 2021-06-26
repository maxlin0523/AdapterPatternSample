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
            var newScreen = new NewScreen();

            // DVI轉接器
            // 建構式參數:HDMI規格的新螢幕
            var adapter = new DVIAdapter(newScreen);

            // 接上轉接器
            var myHost = new MyHost(adapter);

            myHost.Open();
            // Output:
            // PC端DVI接口連接成功
            // 轉接: HDMI to DVI
            // HDMI螢幕連接成功

            Console.ReadKey();
        }
    }
}
