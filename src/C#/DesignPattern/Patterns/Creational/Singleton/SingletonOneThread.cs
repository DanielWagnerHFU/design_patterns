using System;

namespace DesignPattern.Creational.Singleton
{
    public sealed class SingletonOneThread
    {
        private static SingletonOneThread instance = null;

        private SingletonOneThread()
        {
        }

        public static SingletonOneThread Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonOneThread();
                }
                return instance;
            }
        }
    }
}