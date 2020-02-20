using System;

namespace DesignPattern.Creational.Singleton
{
    /// <summary>
    /// This class is a template for a lazy and threadsafe singleton. This is the best possible implementation of a singleton in C#
    /// </summary>
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance
        {
            get { return lazy.Value; }
        }

        private Singleton()
        {
        }
    }
}