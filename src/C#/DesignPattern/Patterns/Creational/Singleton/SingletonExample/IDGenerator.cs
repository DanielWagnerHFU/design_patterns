using System;

namespace DesignPattern.Creational.Singleton

{
    /// <summary>
    /// This class is a example usage of the Lazy and Threadsafe Singleton Pattern in C#. 
    /// </summary>
    public sealed class IDGenerator

    {
        private static readonly Lazy<IDGenerator> _lazy = new Lazy<IDGenerator>(() => new IDGenerator());

        public static IDGenerator Instance
        {
            get { return _lazy.Value; }
        }

        private IDGenerator()
        {
            lastID = 1;
        }

        private int lastID;

        public int GetID()
        {
            return lastID++;
        }
    }
}