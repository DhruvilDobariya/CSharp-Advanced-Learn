namespace ThreadLearn
{
    public class Priority
    {
        // The high priority thread can be executed first.
        // But it is not guaranteed because thread is highly system dependent.
        // It increases the chance of the high priority thread to execute before low priority thread.
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            t1.Priority = ThreadPriority.Normal;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
        }
        public static void Fun1()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Fun1: {i}");
            }
        }
        public static void Fun2()
        {
            for (int i = 0; i < 70; i++)
            {
                Console.WriteLine($"Fun2: {i}");
            }
        }
    }
}
