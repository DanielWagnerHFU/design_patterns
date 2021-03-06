using System;

namespace DesignPattern.Creational.Singleton
{
    /// <summary>
    /// This class is a template for a Singleton. 
    /// It is not threadsafe and shouldnt be used if there is the possibility you will have more then one thread.
    /// </summary>
    public sealed class SingletonOneThread
    {
        private static SingletonOneThread _instance = null;

        private SingletonOneThread()
        {
        }

        public static SingletonOneThread Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SingletonOneThread();
                }
                return _instance;
            }
        }
    }
}