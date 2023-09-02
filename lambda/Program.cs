using System;
using System.Diagnostics;
using System.Linq;
namespace lambda
{
    

    class Program
    {
        const int _max = 10000000;
        static void Main()
        {
            int[] array = { 1 };
            Func<int, bool> delegateVersion = delegate (int argument)
            {
                return argument == 1;
            };

            // Version 1: use lambda expression for Count.
            var s1 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                if (array.Count(element => element == 1) == 0)
                {
                    return;
                }
            }
            s1.Stop();
            // Version 2: use delegate for Count.
            var s2 = Stopwatch.StartNew();
            for (int i = 0; i < _max; i++)
            {
                if (array.Count(delegateVersion) == 0)
                {
                    return;
                }
            }
            s2.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            Console.ReadKey();
        }
    }
}
