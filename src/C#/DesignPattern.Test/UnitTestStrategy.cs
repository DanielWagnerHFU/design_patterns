using System;
using Xunit;
using DesignPattern.Behavioral.Strategy.Strategy1;

namespace DesignPattern.Test
{
    public class UnitTestStrategy
    {
        [Fact]
        public void StrategyTest1()
        {
            Client client = new Client(new StrategyA());
            Assert.Equal("AlgorithmA", client.CallAlgorithm());
        }

        [Fact]
        public void StrategyTest2()
        {
            Client client = new Client(new StrategyB());
            Assert.Equal("AlgorithmB", client.CallAlgorithm());
        }

        [Fact]
        public void StrategyTest3()
        {
            Client client = new Client(new StrategyB());
            Assert.Equal("AlgorithmB", client.CallAlgorithm());
            client.Strategy = new StrategyA();
            Assert.Equal("AlgorithmA", client.CallAlgorithm());
        }
    }
}