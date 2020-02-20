using System;

namespace DesignPattern.Behavioral.Observer.Observer1
{
    /// <summary>
    /// This interface provides methods for a observer
    /// </summary>
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}