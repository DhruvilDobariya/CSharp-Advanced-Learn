using System.ComponentModel;

namespace BackgroundWorkerLearn
{
    // Now we use background worker for execute in background, these tasks which is time taken, so main method just invoke time taken task and get back control and start next tasks.
    public class Solution
    {
        public static void Main(string[] args)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            Console.WriteLine("Control go outside of main method");
            worker.RunWorkerAsync();
            Console.WriteLine("Control back to the main method");
            Console.ReadKey();
        }
        public static void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Task in process");

            Thread.Sleep(5000);

        }
        public static void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine("Task completed successfully");
        }
    }
}
