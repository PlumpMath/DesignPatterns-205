using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Doer : ISubject
    {
        public string Data { get; set; }
        private IList<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void DoSomethingWith(string data)
        {
            Data = data;
            Console.WriteLine($"Do something with {data}");
            Notify();
        }

        public void Notify()
        {
            foreach (var obs in _observers)
            {
                obs.Update(this);
            }
        }
    }
}