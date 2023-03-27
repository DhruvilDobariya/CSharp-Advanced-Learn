namespace TaskLearn
{
    public class SubTask
    {
        public static void Main(string[] args)
        {
            Task parentTask = new Task(() =>
            {
                Console.WriteLine("Outer Task Start");
                Task childTask = new Task(() =>
                {
                    Console.WriteLine("Inner Task Start");
                    Thread.Sleep(4000);
                    Console.WriteLine("Inner Task Finish");
                }, TaskCreationOptions.AttachedToParent);

                childTask.Start();

                Thread.Sleep(3000);
                Console.WriteLine("Outer Task Finish");
            });

            parentTask.Start();
            parentTask.Wait();
            Console.WriteLine("Complete");
            Console.ReadLine();
        }
    }
}
