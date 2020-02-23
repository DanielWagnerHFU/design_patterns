using System;

namespace DesignPattern.Behavioral.Strategy.Strategy1
{
    /// <summary>
    /// This class is a example strategy
    /// </summary>
    public class StrategyA : IStrategy
    {
        public string Algorithm()
        {
            return "AlgorithmA";
        }
    }
}