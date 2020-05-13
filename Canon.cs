using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }
        public void Print()
        {
            Console.WriteLine("Canon Printer Printing....  ");
        }
    }
}
