using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class LaserJet Print : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer LaserJet dimension:14 *17");
        }
        public void Print()
        {
            Console.WriteLine("printer LaserJet proses printing.....");
        }
    }
}
