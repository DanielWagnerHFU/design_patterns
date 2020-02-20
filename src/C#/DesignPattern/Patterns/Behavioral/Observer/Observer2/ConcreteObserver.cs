using System;

namespace DesignPattern.Behavioral.Observer.Observer2
{
    /// <summary>
    /// This class represents a Observer who remembers how often he got notified by the subject
    /// </summary>
    public class ConcreteObserver : IObserver<int>
    {
        public int Value{ get; set; } = 0;

        public void Update(int number)
        {
            Value = number;
        }
    }
}