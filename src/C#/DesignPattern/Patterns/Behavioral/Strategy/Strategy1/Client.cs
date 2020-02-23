using System;

namespace DesignPattern.Behavioral.Strategy.Strategy1
{
    /// <summary>
    /// This client class can use two different Strategys / Algorithms to get a string.
    /// </summary>
    public class Client
    {
        private IStrategy _strategy;

        public IStrategy Strategy
        {
            set { _strategy = value; }
        }

        public Client(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string CallAlgorithm()
        {
            return _strategy.Algorithm();
        }
    }
}