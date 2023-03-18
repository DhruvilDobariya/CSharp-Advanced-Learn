namespace AsyncDelegate
{
    public class Solution2
    {
        // using async await
        delegate Task<int> Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Console.WriteLine("Program start");

            Calculation calculation = Sum;
            Console.WriteLine("Control going to the Sum method");
            Task<int> result = calculation.Invoke(10, 20);
            Console.WriteLine("Control back to the Main method");

            Console.WriteLine(result.Result);

            Console.WriteLine("Program end");
        }
        public async static Task<int> Sum(int a, int b)
        {
            return await Task.Run(() =>
            {
                Console.WriteLine("Sum method running in background...");
                Thread.Sleep(10000);
                int x = a + b;
                Console.WriteLine("Sum method running end");
                return x;
            });
        }
    }
}
