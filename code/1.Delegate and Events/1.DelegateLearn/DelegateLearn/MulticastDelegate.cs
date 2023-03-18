namespace DelegateLearn
{
    public class MulticastDelegate
    {
        delegate void Calculation(int x, int y);
        public static void Main(string[] args)
        {
            // delegate contain more then one reference of method

            Calculation calculation = Addition;
            calculation += Subtraction;
            calculation += Multiplication;
            calculation += Division;
            // += Subscribe or append 
            calculation(20, 10);

            // remove subscription 
            calculation -= Subtraction;
            calculation(20, 10);


        }
        public static void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Subtraction(int a, int b)
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
