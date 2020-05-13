using System;
using System.Collections.Generic;
using System.Text;

namespace Latihanpoly
{
    class Epson : IPrinterWindows
    {
        public void Show ()
        {
            Console.WriteLine("Epson Display dimension : 10*11");
        }
        public void Print()
        {
            Console.WriteLine("Epson Printer Printing....  ");
        }
    }
}
