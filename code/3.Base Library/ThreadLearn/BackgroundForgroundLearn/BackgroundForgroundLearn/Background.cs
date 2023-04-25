using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Threading;
using System;
namespace BackgroundForgroundLearn
{
    public class Background
    {
        //In the this code snippet, the threads created are background threads as they are set to IsBackground = true.A background thread will not prevent the application from terminating even if it has not completed its execution.This means that if the Main method completes before the background threads have completed their execution, the application will terminate regardless of whether the background threads have finished or not.
        public static void Main(string[] args)
        {
            Console.WriteLine("Main method start");
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            // When we create new thread, it's become sibling of main thread
            t1.IsBackground = true;
            t2.IsBackground = true;
            Console.WriteLine("Control go to the method 1");
            t1.Start();
            Console.WriteLine("Control back to main method from the method 1");
            Console.WriteLine("Control go to the method 2");
            t2.Start();
            Console.WriteLine("Control back to main method from the method 2");
            Console.WriteLine("Main method end");
        }
        public static void Fun1()
        {
            Console.WriteLine("Method 1 start");
            Thread.Sleep(7000);
            Console.WriteLine("Method 1 end");
        }
        public static void Fun2()
        {
            Console.WriteLine("Method 2 start");
            Thread.Sleep(4000);
            Console.WriteLine("Method 2 end");
        }
    }
}
