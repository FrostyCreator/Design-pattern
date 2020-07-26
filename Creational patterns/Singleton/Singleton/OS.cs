using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class OS
    {
        private static OS instance;
        public string Name { get; private set; }
        private OS(string name)
        {
            Name = name;
        }
        public static OS GetInstance(string name)
        {
            if (instance == null)
                instance = new OS(name);
            return instance;
        }
    }
}
