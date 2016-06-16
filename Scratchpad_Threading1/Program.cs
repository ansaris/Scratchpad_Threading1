using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scratchpad_Threading1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            for (int i = 1; i <= Environment.ProcessorCount; i++)
            {
                Thread thread = new Thread(DifferentMethod);
                thread.IsBackground = true;
                thread.Start(i);
            }
            //Thread thread = new Thread(DifferentMethod);
            //thread.Start();
            //while (true)
            //    Console.WriteLine("Hello from Main()");
            Console.WriteLine("Leaving Main()");
        }
        
        static void DifferentMethod(object threadID)
        {
            while(true)
                Console.WriteLine($"Hello from DifferentMethod -- {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
