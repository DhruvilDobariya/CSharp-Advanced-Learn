namespace LamdaExpressionLearn
{
    public class Program1
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            int sumOfSqrt = list.Select(element => element * element).Sum();
            Console.WriteLine(sumOfSqrt);

            // it's like:
            // int sumOfSqrt = 0;
            // foreach (int element in list)
            // {
            //    sumOfSqrt += element * element;
            // }
        }
    }
}
