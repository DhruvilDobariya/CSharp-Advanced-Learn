namespace ThreadLearn
{
    public class SleepMethod
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            t1.Start();
            t2.Start();
        }
        public static void Fun1()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Fun1: {i}");
                if (i == 21)
                {
                    Console.WriteLine("Thread one is going to sleep for 10 second...");
                    Thread.Sleep(10000);
                    Console.WriteLine("Thread one is back to the runnable state");
                }
            }
        }
        public static void Fun2()
        {
            for (int i = 0; i < 70; i++)
            {
                Console.WriteLine($"Fun2: {i}");
                if (i == 21)
                {
                    Console.WriteLine("Thread two is going to sleep for 8 second...");
                    Thread.Sleep(8000);
                    Console.WriteLine("Thread two is back to the runnable state");
                }
            }
        }
    }
}
