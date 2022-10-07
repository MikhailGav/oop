using System;
using System.Threading;

namespace oopLab1._1._2
{
    internal class Class1
    {
        private static void Main()
        {
            Console.WriteLine($"Id потока метода Main - {Thread.CurrentThread.ManagedThreadId}");

            Console.WriteLine("Для запуска нажмите любую клавишу");
            Console.ReadKey();

            ThreadPool.QueueUserWorkItem(new WaitCallback(Example));


            for (int i = 0; i < 80; i++)
            {
                Console.Write("task2");
                Thread.Sleep(50);
            }
        }

        private static void Example(object state)
        {
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("\ttask1");
                Thread.Sleep(50);
            }

        }
    }
}
