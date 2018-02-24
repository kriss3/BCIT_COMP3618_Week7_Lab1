using System.Threading;
using static System.Console;

namespace ConAppMultithreading
{
    /// <summary>
    /// Krzysztof Szczurowski
    /// Week 7 Lab 1
    /// Repo: https://github.com/kriss3/BCIT_COMP3618_Week7_Lab1.git
    /// </summary>
    class MyApp
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
            Read();
        }

        private static void Counting()
        {
            for (int i = 1; i <= 10; i++)
            {
                WriteLine($"Count: {i} - Thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
        }
    }
}
