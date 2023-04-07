namespace EventLearn
{
    public class Problem
    {
        public delegate void Calculation(int x, int y);
        public static void Main(string[] args)
        {
            Calculation calculation = Addition;
            calculation += Subtraction;
            calculation = Multiplication; // I want to subscribe multiplication also, but some how i miss to put + before =, so now it over write the above subscription and only we get multiplication and after subscriptions.
            calculation += Division;

            calculation(10, 20);  
        }
        public static void Addition(int a, int b)
        {
            Console.WriteLine($"Addition of {a} and {b} is : {a + b}");
        }
        public static void Subtraction(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} and {b} is : {a - b}");
        }
        public static void Multiplication(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} and {b} is : {a * b}");
        }
        public static void Division(int a, int b)
        {
            Console.WriteLine($"Division of {a} and {b} is : {a / b}");
        }
    }

}
