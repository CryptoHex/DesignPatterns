using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();
            log.Write("This is the Singleton pattern and it can only have one instance");
        }
    }
}
