namespace FunctionArgumentLearn
{
    public class Action
    {
        public static void Main(string[] args)
        {
            WarpSum(Sum, 10, 20);
        }
        public static void Sum(int a, int b)
        {
             Console.WriteLine(a + b);
        }
        public static void WarpSum(Action<int, int> function, int a, int b)
        {
            // Action<typeofarg1, typeofarg2, ...>
            // Action only used for these which don't return anything.
            function(a, b);
            Console.WriteLine("Function Run");
        }
    }
}
