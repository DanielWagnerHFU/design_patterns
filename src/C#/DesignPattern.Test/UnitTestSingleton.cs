using System;
using Xunit;
using DesignPattern.Creational.Singleton;

namespace DesignPattern.Test
{
    public class UnitTestSingleton
    {
        [Fact]
        public void SingletonTest1()
        {
            IDGenerator idGenerator = IDGenerator.Instance;
            int id = idGenerator.GetID();
            Assert.Equal(1, id);
            id = idGenerator.GetID();
            Assert.Equal(2, id);
        }

        [Fact]
        public void SingletonTest2()
        {
            IDGenerator idGenerator = IDGenerator.Instance;
            IDGenerator idGenerator2 = IDGenerator.Instance;
            Assert.Equal(idGenerator2, idGenerator);
        }
    }
}
