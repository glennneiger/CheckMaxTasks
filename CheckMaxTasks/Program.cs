using System;
using System.Threading;

// Created by Glenn Neiger
// Date Created: 06/06/2018

namespace CheckMaxTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent mainEvent = new AutoResetEvent(false);
            int workerThreads;
            int portThreads;

            ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
            Console.WriteLine("\nMaximum worker threads: \t{0}" +
                "\nMaximum completion port threads: {1}",
                workerThreads, portThreads);

            ThreadPool.GetAvailableThreads(out workerThreads,
                out portThreads);
            Console.WriteLine("\nAvailable worker threads: \t{0}" +
                "\nAvailable completion port threads: {1}\n",
                workerThreads, portThreads);

            Console.WriteLine("Press any key to exit");
            Console.Read();
        }
    }
}
