namespace DelegateLearn
{
    public delegate void Calculation(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create Instance
            // Method 1
            //Calculation calculation = new Calculation(Addition);

            // Method 2
            Calculation calculation = Addition;

            // Invoke Delegates

            // Method 1
            //calculation.Invoke(10, 20);

            // Method 2
            calculation(10, 20);

            calculation = Substraction;
            calculation(10, 20);

            calculation = Multiplication;
            calculation(10, 20);

            calculation = Division;
            calculation(10, 20);
        }
        public static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Substraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
