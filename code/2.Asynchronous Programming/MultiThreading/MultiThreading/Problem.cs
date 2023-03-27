namespace MultiThreading
{
    public class Problem
    {
        public static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread; // It gives Main Thread
            //By default process have one thread which we know as Main thread

            thread.Name = "Main"; // We can rename main thread using name property

            MethodOne();
            MethodTwo();
            MethodThree();

            // here the problem is method two take time for execution so, our whole Main thread hanged.
        }
        public static void MethodOne()
        {
            for(int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"Method One: {i}");
            }
        }
        public static void MethodTwo()
        {
            for (int i = 0; i <= 40; i++)
            {
                Console.WriteLine($"Method Two: {i}");
                if(i == 25)
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
