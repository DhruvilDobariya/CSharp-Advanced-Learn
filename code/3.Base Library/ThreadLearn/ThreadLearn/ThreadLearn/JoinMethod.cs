namespace ThreadLearn
{
    public class JoinMethod
    {
        // If we use threading then both method run asynchronously, But if we want that one method complete after another method will be executed then we use Join() method.
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(Fun2);
            t1.Start();
            // t1.Join();
            t1.Join(10000);
            // If we use just Join() method then method 2 should wait from completing method 1 and then method 2 will execute.
            // But If we pass parameter in Join(10000) method then method 2 should wait form maximum 10 second and if 10 second is complete and execution of method 1 is not complete then method 2 start their execution asynchronously.
            t2.Start();
        }
        public static void Fun1()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine($"Fun1: {i}");
                if (i == 21)
                {
                    Thread.Sleep(21000);
                }
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
