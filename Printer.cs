using System;
namespace Lab5
{
    class Printer
    {
        public void iAmPrinting(Iusing obj)
        {
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
}
