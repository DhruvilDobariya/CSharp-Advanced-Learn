namespace MultiThreading
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            Thread threadOne = new Thread(MethodOne);
            Thread threadTwo = new Thread(MethodTwo);
            Thread threadThree = new Thread(MethodThree);

            // now we have 4 thread
            // One main thread which is parent thread and three child thread of main thread.

            threadOne.Start();
            threadTwo.Start();
            threadThree.Start();

        }
        public static void MethodOne()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"Method One: {i}");
            }
        }
        public static void MethodTwo()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"Method Two: {i}");
                if (i == 25)
                {
                    Console.WriteLine("Method two is going to the sleep mode for 7 second...");
                    Thread.Sleep(7000);
                }
            }
        }
        public static void MethodThree()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"Method Three: {i}");
            }
        }
    }
}
