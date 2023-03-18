namespace EventLearn
{
    public class Solution
    {
        // event should solve this problem.
        // it encapsulate delegate and it only use publish and subscribe.
        // We can only use += or -= not only =.
        // Event Handlers can't return a value. They are always void.
        public delegate void Calculation(int x, int y);
        public event Calculation OnCalculation = null;

        public static void Main(string[] args)
        {
            // Event only use subscribe unsubscribe method.
            // We cant use = operator for new instance.

            Solution solution = new Solution();
            solution.OnCalculation += Addition;
            solution.OnCalculation += Subtraction;
            //solution.OnCalculation = null; // throw an error.
            solution.OnCalculation -= Subtraction;
            solution.OnCalculation += Division;
            solution.OnCalculation(10, 20);
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
