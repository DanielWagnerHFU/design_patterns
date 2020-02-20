using System;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This class represents a Observer who remembers how often he got notified by the subject
    /// </summary>
    public class ConcreteObserver : IObserver<ConcreteSubject>
    {
        public int Notified{ get; set; } = 0;

        public void Update(ConcreteSubject subjtec)
        {
            Notified++;
        }
    }
}