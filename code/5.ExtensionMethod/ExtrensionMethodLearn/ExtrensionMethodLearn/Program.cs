namespace ExtrensionMethodLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculation calculation = new Calculation();

            Console.WriteLine(calculation.Addition(10, 20));
            Console.WriteLine(calculation.Sqrt(100));
        }
    }
    public class Calculation
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }
        public int Subtraction(int x, int y)
        {
            return x - y;
        }
        public int Multiplication(int x, int y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y;
        }
    }
    public static class CalculationExtention
    {
        public static double Sqrt(this Calculation calculation, int x)
        {
            return Math.Sqrt(x);
        }

        public static double Percentage(this Calculation calculation, int x, int total)
        {
            return (x * 100) / total;
        }
    }
}
