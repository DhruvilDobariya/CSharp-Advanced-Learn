namespace FunctionArgumentLearn
{
    public class Fun
    {
        // it is predefine delegate
        public static void Main(string[] args)
        {
            Console.WriteLine(AddNInCalculation(Sum, 10, 20, 40));
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int AddNInCalculation(Func<int, int, int> function, int n, int a, int b)
        {
            // Func<typeofarg1, typeofarg2, ..., returntype>
            return n + function(a, b);
        }
    }
}
