namespace TaskLearn
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            Task t = new Task(() =>
            {
                Console.WriteLine("Task start");
                Thread.Sleep(4000);
                Console.WriteLine("Task finish");
            });

            Console.WriteLine(t.IsCompleted); // it check task is competed or not.
            Console.WriteLine(t.IsCompletedSuccessfully); // it check task is successfully completed or not
            Console.WriteLine(t.IsCanceled);
            Console.WriteLine(t.IsFaulted);
            Console.WriteLine(t.Status);

            Console.ReadLine();
        }
    }
}
