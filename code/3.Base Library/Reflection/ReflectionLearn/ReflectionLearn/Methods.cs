using System.Reflection;

namespace ReflectionLearn
{
    public class Methods
    {
        public static void Main(string[] args)
        {
            Type t = typeof(string);

            Console.WriteLine("Dhruvil".GetType());

            Console.WriteLine();
            Console.WriteLine("Constructor");
            foreach (var element in t.GetConstructors())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Constructor with binding flag");
            foreach (var element in t.GetConstructors(BindingFlags.Public))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Fields");
            foreach (var element in t.GetFields())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Fields with binding flag");
            foreach (var element in t.GetFields(BindingFlags.Public))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Methods");
            foreach (var element in t.GetMethods())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Methods with binding flag");
            foreach (var element in t.GetMethods(BindingFlags.Public))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Properties");
            foreach (var element in t.GetProperties())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Properties with binding flag");
            foreach (var element in t.GetProperties(BindingFlags.Public))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();
            Console.WriteLine("Members");
            foreach (var element in t.GetMembers())
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Members with binding flag");
            foreach (var element in t.GetMembers(BindingFlags.Public))
            {
                Console.WriteLine(element);
            }
        }
    }
}
