namespace AsyncDelegate
{
    public class Problem
    {
        // Here the issue is Program hang to 10 seconds.
        delegate int Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Console.WriteLine("Program start");

            Calculation calculation = Sum;
            Console.WriteLine("Control going to the Sum method");
            int result = calculation.Invoke(10, 20);
            Console.WriteLine("Control back to the Main method");

            Console.WriteLine(result);

            Console.WriteLine("Program end");
        }
        public static int Sum(int a, int b)
        {
            Console.WriteLine("Sum method running...");
            Thread.Sleep(10000);
            int x = a + b;
            Console.WriteLine("Sum method end");
            return x;
        }
    }
}
