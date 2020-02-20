using System;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This interface provides methods for a observer
    /// </summary>
    public interface IObserver<T>
    {
        void Update(T data);
    }
}