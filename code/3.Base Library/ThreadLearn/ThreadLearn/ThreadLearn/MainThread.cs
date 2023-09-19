namespace ThreadLearn
{
    public class MainThread
    {
        public static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
        }
    }
}
