using System;

namespace DesignPattern.Behavioral.Strategy.Strategy1
{
    /// <summary>
    /// This interface gives the Client the possibility to call Algorithm() on the Strategys.
    /// </summary>
    public interface IStrategy
    {
        string Algorithm();
    }

}