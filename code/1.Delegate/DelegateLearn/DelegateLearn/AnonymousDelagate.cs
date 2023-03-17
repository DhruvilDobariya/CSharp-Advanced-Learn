namespace DelegateLearn
{
    public class AnonymousDelagate
    {
        delegate void Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Calculation calculation = ((int a, int b) => Console.WriteLine(a + b));
            calculation(10, 20);
        }
    }
}
