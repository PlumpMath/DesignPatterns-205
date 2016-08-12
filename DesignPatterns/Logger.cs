using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Logger : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Writing down {sender.Data.ToUpper()}");
        }
    }
}