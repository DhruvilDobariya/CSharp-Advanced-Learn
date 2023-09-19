namespace ThreadLearn
{
    public class LockThread
    {
        private static int counter = 0;
        private static object lockObject = new object();

        public static void Main()
        {
            //Thread thread1 = new Thread(IncrementCounter);
            //Thread thread2 = new Thread(IncrementCounter);

            Thread thread1 = new Thread(IncrementCounterLock);
            Thread thread2 = new Thread(IncrementCounterLock);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Counter: {counter}");
        }

        static void IncrementCounter()
        {
            for (int i = 0; i < 1000000; i++)
            {
                // This is not thread-safe without lock
                counter++;
            }

        }

        static void IncrementCounterLock()
        {
            lock (lockObject) // It will lock the block to ensure that at a time only one thread access the block.
            {
                for (int i = 0; i < 1000000; i++)
                {
                    // This is thread-safe with lock
                    counter++;
                }
            }

        }
    }
}
