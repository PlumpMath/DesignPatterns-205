using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class UserInterface : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"hey user, look at {sender.Data.ToUpper()}");
        }
    }
}