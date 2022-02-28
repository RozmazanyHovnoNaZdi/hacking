using System;
using System.Threading;

namespace hacking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("!hacking = žielenskýOnlyFans...");
            for (int i = 0; i <= 100; i = i + 5)
            {
                Console.WriteLine($"progress: {i}%");
                Thread.Sleep(3700);
            }
            Console.WriteLine("password hack successful >> putting backdoor (for later informational purposes)");
            for (int i = 0; i <= 100; i = i + 25)
            {
                Console.WriteLine($"backdoor implantation: {i}%");
                Thread.Sleep(1400);
            }
            Console.WriteLine("hack finished! password = (gimpmamina123)and backdoor planted");

        }
    }
}
