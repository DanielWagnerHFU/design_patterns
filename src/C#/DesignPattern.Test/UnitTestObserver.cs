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

        [Fact]
        public void ObserverTest4()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify();
            subject.Attach(observer2);
            subject.Notify();
            subject.Detach(observer1);
            subject.Notify();
            Assert.True(observer1.Notified == observer2.Notified);
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

        [Fact]
        public void ObserverTest4()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify();
            subject.Attach(observer2);
            subject.Notify();
            subject.Detach(observer1);
            subject.Notify();
            Assert.True(observer1.Notified == observer2.Notified);
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
            subject.Notify(subject);
            Assert.True(observer1.Notified == 1);
        }

        [Fact]
        public void ObserverTest3()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify(subject);
            subject.Attach(observer2);
            subject.Notify(subject);
            Assert.True((observer1.Notified == 2) && (observer2.Notified == 1));
        }

        [Fact]
        public void ObserverTest4()
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver();
            ConcreteObserver observer2 = new ConcreteObserver();
            subject.Attach(observer1);
            subject.Notify(subject);
            subject.Attach(observer2);
            subject.Notify(subject);
            subject.Detach(observer1);
            subject.Notify(subject);
            Assert.True(observer1.Notified == observer2.Notified);
        }
    }
}