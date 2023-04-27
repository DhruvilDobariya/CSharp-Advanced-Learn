namespace FunctionArgumentLearn
{
    public class Predicate
    {
        // it is predefine delegate
        // it only use to predict value n boolean
        // it take only one parameter
        public static void Main(string[] args)
        {
            Console.WriteLine($"Is odd: {Check(21, IsOdd)}");
            Console.WriteLine($"Is even: {Check(21, IsEven)}");
        }
        public static bool Check(int a, Predicate<int> predicatemethod)
        {
            return predicatemethod(a);
        }
        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsOdd(int a)
        {
            if (a % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
