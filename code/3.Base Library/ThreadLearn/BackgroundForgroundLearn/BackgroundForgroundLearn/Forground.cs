namespace BackgroundForgroundLearn
{
    public class Foreground
    {
        //In the this code snippet, the threads created are foreground threads as they are set to IsBackground = false. A foreground thread will keep the application running until it completes its execution.This means that even if the Main method completes, the application will not terminate until all foreground threads have completed their execution.
        public static void Main(string[] args)
        {
            Console.WriteLine("Main method start");
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            // When we create new thread, it's become sibling of main thread
            t1.IsBackground = false;
            t2.IsBackground = false;
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
