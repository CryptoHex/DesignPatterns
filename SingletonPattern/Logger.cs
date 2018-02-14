using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger logger;

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            return logger ?? (logger = new Logger());
        }

        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
