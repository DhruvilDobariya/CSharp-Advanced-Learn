namespace BackgroundWorkerLearn
{
    // The problem is when we execute time taken task at the movement our main method stuck.
    public class Problem
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Control go outside of main method");
            RunTask();
            Console.WriteLine("Control back to the main method");
            Console.ReadKey();
        }
        public static void RunTask()
        {
            Console.WriteLine("Task in process");
            Thread.Sleep(4000);
            Console.WriteLine("Task completed successfully");
        }
    }
}
