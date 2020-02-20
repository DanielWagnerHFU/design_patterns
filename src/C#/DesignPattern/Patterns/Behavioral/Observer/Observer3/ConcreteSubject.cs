using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPattern.Behavioral.Observer.Observer3
{
    /// <summary>
    /// This class represents a simple subject
    /// </summary>
    public class ConcreteSubject : Observable<ConcreteSubject>
    {
    }
}