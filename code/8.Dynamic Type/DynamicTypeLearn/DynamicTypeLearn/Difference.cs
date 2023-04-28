namespace DynamicTypeLearn
{
    public class Difference
    {
        public static void Main(string[] args)
        {
            string a1 = "dhdhdh";
            var a2 = "ssasasass";
            dynamic a3 = "ashshshh";
            object a4 = "jdjdjd";

            Console.WriteLine(a1.ToUpper()); // give suggestion, compile time identification
            Console.WriteLine(a2.ToUpper()); // give suggestion, compile time identification
            Console.WriteLine(a2.ToUpper()); // don't give suggestion, but we can use, runtime identification
                                             //Console.WriteLine(a4.ToUpper()); // there is no such a method.

            // type
            Console.WriteLine(a1.GetType()); // String
            Console.WriteLine(a2.GetType()); // String
            Console.WriteLine(a3.GetType()); // String
            Console.WriteLine(a4.GetType()); // String

            // modification
            //a1 = 10; // can't implicitly convert int to string error
            //a2 = 10; // can't implicitly convert int to string error
            a3 = 10; // can assign different type
            a4 = 10; // can assign different type

            // operation
            int b1 = 10;
            var b2 = 10;
            dynamic b3 = 10;
            object b4 = 10;

            Console.WriteLine(b1 + b1); // can do
            Console.WriteLine(b2 + b2); // can do
            Console.WriteLine(b3 + b3); // can do
            //Console.WriteLine(b4 + b4); // error: can't applied + operation on object, if we want to do then we should unbox it.
        }
    }

}
