namespace TaskLearn
{
    public class TaskLearn
    {
        public static void Main(string[] args)
        {
            Task t = new Task(() =>
            {
                Console.WriteLine("Task start");
                Thread.Sleep(4000);
                Console.WriteLine("Task finish");
            });

            t.Start(); // start task
            t.Wait(4000); // after execution wait task
            Console.WriteLine("Complete");
            Console.ReadLine();
        }
    }
}
