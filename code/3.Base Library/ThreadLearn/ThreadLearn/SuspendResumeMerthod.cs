namespace ThreadLearn
{
    public class SuspendResumeMerthod
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Fun1));
            Thread t2 = new Thread(new ParameterizedThreadStart(Fun2));
            t1.Start(t1);
            t2.Start(t2);
        }
        public static void Fun1(object t)
        {
            Thread thread = (Thread)t;
            try
            {

                for (int i = 0; i < 40; i++)
                {
                    Console.WriteLine($"Fun1: {i}");
                    if (i == 21)
                    {
                        thread.Suspend();

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Thread one is going to suspend state for 10 second...");
                Thread.Sleep(10000);
                thread.Resume();
                Console.WriteLine("Thread one resumed");
            }
        }
        public static void Fun2(object t)
        {
            Thread thread = (Thread)t;
            try
            {

                for (int i = 0; i < 70; i++)
                {
                    Console.WriteLine($"Fun2: {i}");
                    if (i == 21)
                    {
                        thread.Suspend();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thread one is going to suspend state for 8 second...");
                Thread.Sleep(8000);
                thread.Resume();
                Console.WriteLine("Thread one resumed");
            }
        }
    }
}
