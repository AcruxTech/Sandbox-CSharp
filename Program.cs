using System;
using System.Diagnostics;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int x = 123456789;
            int y = ~x;
            y += 1;
            stopwatch.Stop();
            Console.WriteLine($"Инвертирование бит\nTicks: {stopwatch.ElapsedTicks}\nValue: {y}\n-------------");

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            int x2 = 123456789;
            int y2 = x2 * -1;
            stopwatch2.Stop();
            Console.WriteLine($"Умножение\nTicks: {stopwatch2.ElapsedTicks}\nValue: {y2}\n-------------");
        }
    }
}
