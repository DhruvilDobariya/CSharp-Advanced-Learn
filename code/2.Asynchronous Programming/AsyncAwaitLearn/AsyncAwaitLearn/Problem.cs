namespace AsyncAwaitLearn;

public class Problem
{
    public static void Main(string[] args)
    {
        int ansSum = Addition(10, 20);
        int ansSub = Subtraction(10, 20);
        int ansMul = Multiplication(10, 20);
        int ansDiv = Division(10, 20);
        Console.WriteLine($"Addition: {ansSum}");
        Console.WriteLine($"Subtraction: {ansSub}");
        Console.WriteLine($"Multiplication: {ansMul}");
        Console.WriteLine($"Division: {ansDiv}");
    }

    public static int Addition(int a, int b)
    {
        Console.WriteLine("Addition started...");
        Thread.Sleep(4000);
        Console.WriteLine("Addition completed");
        return a + b;
    }
    public static int Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction started...");
        Thread.Sleep(3000);
        Console.WriteLine("Subtraction completed");
        return a - b;
    }
    public static int Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication started...");
        Thread.Sleep(8000);
        Console.WriteLine("Multiplication completed");
        return a * b;
    }
    public static int Division(int a, int b)
    {
        Console.WriteLine("Division started...");
        Thread.Sleep(7000);
        Console.WriteLine("Division completed");
        return a / b;
    }
}