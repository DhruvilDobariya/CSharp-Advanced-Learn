namespace DelegateLearn
{
    public class MulticastWithOutputParameter
    {
        public delegate void Calculation(out int a);

        public static void Main(string[] args)
        {
            Calculation calculation = GetTan;
            calculation += GetTwentyOne;

            // It will give only last method's out parameter value.
            int x;
            calculation(out x);
            Console.WriteLine(x);

        }
        public static void GetTan(out int a)
        {
            a = 10;
        }
        public static void GetTwentyOne(out int a)
        {
            a = 21;
        }
    }
}
