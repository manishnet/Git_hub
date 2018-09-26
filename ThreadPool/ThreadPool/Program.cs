using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;

namespace ThreadPool1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc));
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadProc1));
            ReadOnly.Class1.print();

           // Console.WriteLine(ReadOnly.Class1.a);
        Console.WriteLine("Main thread does some work, then sleeps.");
        // If you comment out the Sleep, the main thread exits before 
        // the thread pool task runs.  The thread pool uses background 
        // threads, which do not keep the application running.  (This 
        // is a simple example of a race condition.)
        for (int i = 1; i <= 10;i++ )
        {
            Console.WriteLine("Main thread exits.");
        }
            
        Console.ReadLine();
    }

    // This thread procedure performs the task. 
    static void ThreadProc(Object stateInfo) {
        // No state object was passed to QueueUserWorkItem, so  
        // stateInfo is null.
        Console.WriteLine("Hello from the thread pool.");
        Console.ReadLine();
        }

    static void ThreadProc1(Object stateInfo)
    {
        // No state object was passed to QueueUserWorkItem, so  
        // stateInfo is null.
        Console.WriteLine("Hello from the thread pool. aa");
        Console.ReadLine();
    }
    
    }
}
