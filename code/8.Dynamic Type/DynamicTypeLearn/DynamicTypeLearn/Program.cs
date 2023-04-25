namespace DynamicTypeLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            dynamic x = 10;
            Console.WriteLine(x.GetType());

            x = "Dhruvil Dobariya";
            Console.WriteLine(x.GetType());

            x = Array.Empty<int>();
            Console.WriteLine(x.GetType());
        }
    }
}
