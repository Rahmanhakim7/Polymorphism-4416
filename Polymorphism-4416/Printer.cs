using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_4416
{
    internal class PrinterWindows 
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer Display Dimension");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer Printing ");
        }
    }

    internal class Epson : PrinterWindows
    {
        public override void Show ()
        {
            Console.WriteLine("Epson Display Dimension : 10 * 11");
        }

        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing ");
        }
    }

    internal class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display Dimension : 9.5 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing");
        }
    }

    internal class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display Dimension : 12 * 12");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet Printer Printing");
        }
    }
}
