namespace AsyncDelegate
{
    public class Solution1
    {
        // using callback function
        delegate int Calculation(int a, int b);
        public static void Main(string[] args)
        {
            Console.WriteLine("Program start");

            Calculation calculation = Sum;
            Console.WriteLine("Control going to the Sum method");

            IAsyncResult x = calculation.BeginInvoke(10, 20, new AsyncCallback(CallbackMethod), calculation);

            Console.WriteLine("Control back to the Main method");

            Console.WriteLine("Program end");
        }

        private static void CallbackMethod(IAsyncResult ar)
        {
            Console.WriteLine("Callback call");

            Calculation del = (Calculation)ar.AsyncState;

            int result = del.EndInvoke(ar);
            Console.WriteLine(result);

            Console.WriteLine("Callback end");
        }

        public static int Sum(int a, int b)
        {
            Thread.Sleep(10000);
            return a + b;
        }
    }
}
