using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismInterface
{
    class PrinterWindows : IPrinterWindows
    {
        public void Show()
    
        {
            Console.WriteLine("Display dimension :");
        }
            public void Print()
        {
            Console.WriteLine("Printer Printing....");
        }
      }
}
