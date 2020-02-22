using System;

namespace DesignPattern.Creational.Builder.Builder1
{
    /// <summary>
    /// TODO
    /// </summary>
    public interface IBuilder
    {
        void Reset();
        void BuildPartA();
        void BuildPartB();

        //Add more
    }
}