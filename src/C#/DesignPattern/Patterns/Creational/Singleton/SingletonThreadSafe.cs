using System;

namespace DesignPattern.Creational.Singleton
{
    /// <summary>
    /// This class is a template for a threadsafe singleton in C# using a lock. This is not optimal as the version using C#s lazy class is even better.
    /// </summary>
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object padlock = new object();

        private SingletonThreadSafe()
        {
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonThreadSafe();
                    }
                    return instance;
                }
            }
        }
    }
}