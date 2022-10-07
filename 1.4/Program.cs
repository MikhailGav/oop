using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    internal class Program
    {
        private static void Main()
        {
            Action threadOutput = new Action(ThreadOutput);

            Task task = new Task(threadOutput);
            task.Start();
            MainOutput();
        }

        private static void ThreadOutput()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("_");
                Thread.Sleep(75);
            }
        }

        private static void MainOutput()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("^");
                Thread.Sleep(75);
            }
        }
    }
}
