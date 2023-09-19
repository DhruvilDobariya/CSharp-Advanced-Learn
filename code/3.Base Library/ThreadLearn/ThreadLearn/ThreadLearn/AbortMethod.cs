namespace ThreadLearn
{
    public class AbortMethod
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
            try
            {
                Thread thread = (Thread)t;
                for (int i = 0; i < 40; i++)
                {
                    Console.WriteLine($"Fun1: {i}");
                    if (i == 21)
                    {
                        thread.Abort();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Thread one aborted");
            }
        }
        public static void Fun2(object t)
        {
            try
            {
                Thread thread = (Thread)t;
                for (int i = 0; i < 70; i++)
                {
                    Console.WriteLine($"Fun2: {i}");
                    if (i == 21)
                    {
                        thread.Abort();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thread two aborted");
            }
        }
    }
}
