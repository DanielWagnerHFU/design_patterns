using System;
using System.Collections.Generic;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This abstract class provides methods and a list of observers for observable classes.
    /// </summary>
    public abstract class Observable<T> : IObservable<T>
    {
        private List<IObserver<T>> _observers = new List<IObserver<T>>();
        public void Attach(IObserver<T> observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver<T> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(T changedObject)
        {
            foreach (IObserver<T> observer in _observers)
            {
                observer.Update(changedObject);
            }
        }
    }
}