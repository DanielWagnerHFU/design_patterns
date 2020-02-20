using System;

namespace DesignPattern.Behavioral.Observer.Observer1
{
    /// <summary>
    /// This interface provides methods for a subject
    /// </summary>
    public interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}