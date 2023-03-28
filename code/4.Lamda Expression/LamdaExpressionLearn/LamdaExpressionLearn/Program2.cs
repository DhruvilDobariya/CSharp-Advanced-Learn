using System;

namespace LamdaExpressionLearn
{
    public class Program2
    {

        public static void Main(string[] args)
        {
            // Single line
            Func<string, int, bool> isLengthGreaterThenN = (x, y) => x.Length > y;

            Console.WriteLine(isLengthGreaterThenN("Dhruvil Dobariya", 10));

            // Multi line
            Action<int, int> sum = (x, y) =>
            {
                int ans = x + y;
                Console.WriteLine($"Ans: {ans}");
            };

            sum(10, 20);
        }
    }
}
