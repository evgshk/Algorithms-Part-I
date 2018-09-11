using System;

namespace QuickFindUf
{
    class Program
    {
        static void Main(string[] args)
        {
            var qf = new QuickFindUf(10);
            Console.WriteLine($"Connecting 4 and 3");
            qf.Union(4, 3);
            Console.WriteLine($"Connecting 3 and 8");
            qf.Union(3, 8);
            Console.WriteLine($"Connecting 6 and 5");
            qf.Union(6, 5);
            Console.WriteLine($"Connecting 9 and 4");
            qf.Union(9, 4);
            Console.WriteLine($"Are 8 and 9 connected: {qf.Connected(8, 9)}");
            Console.WriteLine($"Connecting 2 and 1");
            qf.Union(2, 1);
            Console.WriteLine($"Are 5 and 0 connected: {qf.Connected(5, 0)}");
            Console.WriteLine($"Connecting 5 and 0");
            qf.Union(5, 0);

            Console.Read();
        }
    }
}
