using System;

namespace DesignPattern.Behavioral.Observer.Observer1
{
    /// <summary>
    /// This class represents a Observer who remembers how often he got notified by the subject
    /// </summary>
    class ConcreteObserver1 : IObserver
    {
        public int Notified{ get; set; } = 0;

        public void Update(ISubject subject)
        {
            Notified++;
        }
    }
}