using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Behavioral.Observer.Observer1
{
    /// <summary>
    /// This class represents a simple subject without any other purpose.
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}