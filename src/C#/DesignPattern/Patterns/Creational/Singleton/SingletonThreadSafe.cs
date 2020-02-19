using System;

namespace DesignPattern.Creational.Singleton
{
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object padlock = new object();

        SingletonThreadSafe()
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