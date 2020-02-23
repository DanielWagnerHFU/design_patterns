using System;

namespace DesignPattern.Behavioral.Strategy.Strategy1
{
    /// <summary>
    /// This class is a example strategy
    /// </summary>
    public class StrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "AlgorithmB";
        }
    }
}