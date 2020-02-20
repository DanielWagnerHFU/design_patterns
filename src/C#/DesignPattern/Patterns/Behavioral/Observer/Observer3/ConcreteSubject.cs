using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This class represents a simple subject which can change its number
    /// </summary>
    public class ConcreteSubject : Observable<int>
    {
        private int _number = 0;

        public void ChangeNumber(int newNumber)
        {
            _number = newNumber;
            Notify(_number);
        }
    }
}