namespace ThreadLearn
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.IsBackground);
            Console.WriteLine(thread.IsThreadPoolThread);
            Console.WriteLine(thread.ManagedThreadId);
            Console.WriteLine(thread.Name);
            Console.WriteLine(thread.Priority);
            Console.WriteLine(thread.ThreadState);
        }
    }
}
