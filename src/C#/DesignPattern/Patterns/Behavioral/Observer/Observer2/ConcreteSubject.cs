using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Behavioral.Observer.Observer2
{
    /// <summary>
    /// This class represents a simple subject which can change its number
    /// </summary>
    public class ConcreteSubject : IObservable<ConcreteSubject>
    {
        private List<IObserver<ConcreteSubject>> _observers = new List<IObserver<ConcreteSubject>>();

        public void Attach(IObserver<ConcreteSubject> observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver<ConcreteSubject> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver<ConcreteSubject> observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}