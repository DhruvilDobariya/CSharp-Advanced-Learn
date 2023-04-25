namespace ReflectionLearn
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine(t);
            Console.WriteLine(t.Name); // String
            Console.WriteLine(t.FullName); // System.String
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.Namespace); // System
            Console.WriteLine(t.Assembly.FullName); // System.Private.CoreLib
            Console.WriteLine(t.Module); // System.Private.CoreLib.dll
            Console.WriteLine(t.Attributes);

            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsInterface);
            Console.WriteLine(t.IsAbstract);
            Console.WriteLine(t.IsSealed);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsPublic);
            Console.WriteLine(t.IsNotPublic);
            Console.WriteLine(t.IsArray);
            Console.WriteLine(t.IsPointer);

        }
    }
}
