namespace AsyncAwaitLearn;

public class Solution
{
    public static void Main(string[] args)
    {
        Task<int> ansSum = Addition(10,20);
        Task<int> ansSub = Subtraction(10, 20);
        Task<int> ansMul = Multiplication(10, 20);
        Task<int> ansDiv = Division(10, 20);

        Console.WriteLine($"Multiplication: {ansMul.Result}");
        Console.WriteLine($"Subtraction: {ansSub.Result}");
        Console.WriteLine($"Addition: {ansSum.Result}");
        Console.WriteLine($"Division: {ansDiv.Result}");
    }

    public async static Task<int> Addition(int a, int b)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("Addition started...");
            Thread.Sleep(4000);
            Console.WriteLine("Addition completed");
            return a + b;
        });
    }
    public async static Task<int> Subtraction(int a, int b)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("Subtraction started...");
            Thread.Sleep(3000);
            Console.WriteLine("Subtraction completed");
            return a - b;
        });
    }
    public async static Task<int> Multiplication(int a, int b)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("Multiplication started...");
            Thread.Sleep(8000);
            Console.WriteLine("Multiplication completed");
            return a * b;
        });
    }
    public async static Task<int> Division(int a, int b)
    {
        return await Task.Run(() =>
        {
            Console.WriteLine("Division started...");
            Thread.Sleep(7000);
            Console.WriteLine("Division completed");
            return a / b;
        });
    }
}