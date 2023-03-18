namespace DelegateLearn
{
    public class MutlicastWithReturnType
    {
        public delegate int Calculation(int a);
        public static void Main(string[] args)
        {
            Calculation calculation = AddFive;
            calculation += AddSeven;

            // It will return only last method's return value.
            Console.WriteLine(calculation(3));

        }
        public static int AddFive(int a)
        {
            return a + 5;
        }
        public static int AddSeven(int a)
        {
            return a + 7;
        }
    }
}
