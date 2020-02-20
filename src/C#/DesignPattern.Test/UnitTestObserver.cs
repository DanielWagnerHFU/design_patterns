using System;
using Xunit;

namespace DesignPattern.Test.ObserverTest1
{
    using DesignPattern.Behavioral.Observer.Observer1;
    public class UnitTestObserver1
    {
        [Fact]
        public void ObserverTest1()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            subject.Attach(observer1);
            Assert.True(observer1.Notified == 0);
        }

        [Fact]
        public void ObserverTest2()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify();
            Assert.True(observer1.Notified == 1);
        }

        [Fact]
        public void ObserverTest3()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify();
            subject.Attach(observer2);
            subject.Notify();
            Assert.True((observer1.Notified == 2) && (observer2.Notified == 1));
        }
    }
}

namespace DesignPattern.Test.ObserverTest2
{
    using DesignPattern.Behavioral.Observer.Observer2;
    public class UnitTestObserver1
    {
        [Fact]
        public void ObserverTest1()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer = new ConcreteObserver();
            subject.Attach(observer);
            Assert.True(observer.Value == 0);
            subject.ChangeNumber(5);
            Assert.True(observer.Value == 5);
        }

        [Fact]
        public void ObserverTest2()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.ChangeNumber(5);
            Assert.True(observer1.Value == 5);
            Assert.False(observer2.Value == 5);
            subject.Attach(observer2);
            subject.ChangeNumber(2);
            Assert.True(observer1.Value == 2);
            Assert.True(observer2.Value == 2);
        }

        [Fact]
        public void ObserverTest3()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.ChangeNumber(5);
            Assert.True(observer1.Value == 5);
            Assert.False(observer2.Value == 5);
            subject.Attach(observer2);
            subject.Detach(observer1);
            subject.ChangeNumber(2);
            Assert.False(observer1.Value == 2);
            Assert.True(observer2.Value == 2);
        }
    }
}

namespace DesignPattern.Test.ObserverTest3
{
    using DesignPattern.Behavioral.Observer.Observer3;
    public class UnitTestObserver1
    {
        [Fact]
        public void ObserverTest1()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer = new ConcreteObserver();
            subject.Attach(observer);
            Assert.True(observer.Value == 0);
            subject.ChangeNumber(5);
            Assert.True(observer.Value == 5);
        }

        [Fact]
        public void ObserverTest2()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.ChangeNumber(5);
            Assert.True(observer1.Value == 5);
            Assert.False(observer2.Value == 5);
            subject.Attach(observer2);
            subject.ChangeNumber(2);
            Assert.True(observer1.Value == 2);
            Assert.True(observer2.Value == 2);
        }

        [Fact]
        public void ObserverTest3()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.ChangeNumber(5);
            Assert.True(observer1.Value == 5);
            Assert.False(observer2.Value == 5);
            subject.Attach(observer2);
            subject.Detach(observer1);
            subject.ChangeNumber(2);
            Assert.False(observer1.Value == 2);
            Assert.True(observer2.Value == 2);
        }
    }
}