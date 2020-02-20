using System;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This interface provides methods for a subject
    /// </summary>
    public interface IObservable<T>
    {
        void Attach(IObserver<T> observer);

        void Detach(IObserver<T> observer);

        void Notify(T changedObject);
    }
}