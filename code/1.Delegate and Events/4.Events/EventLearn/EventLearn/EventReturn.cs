namespace EventLearn
{
    public class EventReturn
    {
        delegate int Calculation(int x, int y);
        // event don't have return type because event may have more then one subscriber, so it become ambiguous to derive return value.
        // But event handler may return value.
        event Calculation OnCalculation;
        public static void Main(string[] args)
        {
            EventReturn eventReturn = new EventReturn();
            eventReturn.OnCalculation += Addition;
            int ans = eventReturn.OnCalculation(10, 20);
            Console.WriteLine(ans);
        }

        public static int Addition(int a, int b)
        {
            return a + b;
        }
    }

}
