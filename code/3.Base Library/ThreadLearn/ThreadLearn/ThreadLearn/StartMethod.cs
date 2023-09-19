namespace ThreadLearn
{
    public class StartMethod
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            // When we create new thread, it's become sibling of main thread
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
