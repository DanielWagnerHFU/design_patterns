using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Behavioral.Observer.Observer2
{
    /// <summary>
    /// This class represents a simple subject which can change its number
    /// </summary>
    public class ConcreteSubject : IObservable<int>
    {
        private int _number = 0;
        private List<IObserver<int>> _observers = new List<IObserver<int>>();

        public void Attach(IObserver<int> observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver<int> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver<int> observer in _observers)
            {
                observer.Update(_number);
            }
        }

        public void ChangeNumber(int newNumber)
        {
            _number = newNumber;
            Notify();
        }
    }
}