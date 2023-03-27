namespace ReflectionLearn
{
    public class Properties
    {
        public static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine(t);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.Namespace);
            Console.WriteLine(t.Assembly.FullName);
            Console.WriteLine(t.Module);
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
