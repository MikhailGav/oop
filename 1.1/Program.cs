using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace oopLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите для старта...");
            Console.ReadKey();
            Thread thread = new Thread(Write);

            thread.Start("Hello word");

            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine("task2");
            }

            Console.ReadKey();
        }

        private static void Write(object arg)
        {
            for (int i = 0; i < 80; i++)
            {
                Console.WriteLine($"\t{arg}");
            }

        }
    }


}
