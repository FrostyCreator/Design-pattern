using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            comp.Launch("Windows XP");
            Console.WriteLine(comp.OS.Name);        //  Windows XP

            comp.Launch("Windows 10");
            Console.WriteLine(comp.OS.Name);        //  Windows XP

            Computer comp2 = new Computer();
            comp2.Launch("Kali Linux");
            Console.WriteLine(comp2.OS.Name);       //  Windows XP
        }
    }
}
