namespace FunctionArgumentLearn
{
    public class Delagate
    {
        public delegate int Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Calculation calculation = new Calculation(Sum);
            Console.WriteLine(AddNInCalculation(calculation, 10, 20, 40));
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int AddNInCalculation(Calculation del, int n, int a, int b)
        {
            return n + del(a, b);
        }
    }
}
