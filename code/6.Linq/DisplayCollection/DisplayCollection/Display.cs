using Spectre.Console;
using System.Collections;
using System.Reflection;

namespace DisplayCollection
{
    public static class Display
    {
        public static void DisplayList(ICollection list)
        {
            if (list.Count != 0)
            {
                bool flag = false;
                Console.Write("[ ");
                foreach (var item in list)
                {
                    if (!flag)
                    {
                        Console.Write(item);
                        flag = true;
                    }
                    else
                    {
                        Console.Write($", {item}");
                    }

                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
        public static void DisplayDictionary(ICollection dictionary)
        {
            if (dictionary.Count != 0)
            {
                bool flag = false;
                Console.Write("[ ");
                foreach (DictionaryEntry item in dictionary)
                {
                    if (!flag)
                    {
                        Console.Write("{ " + item.Key + " : " + item.Value + " }");
                        flag = true;
                    }
                    else
                    {
                        Console.Write(", { " + item.Key + " : " + item.Value + " }");
                    }

                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("dictionary is empty");
            }
        }
        public static void DisplayDictionary<TKey, TValue>(ICollection dictionary) where TKey : class where TValue : class
        {
            if (dictionary.Count != 0)
            {
                bool flag = false;
                Console.Write("[ ");
                foreach (KeyValuePair<TKey, TValue> item in dictionary)
                {
                    if (!flag)
                    {
                        Console.Write("{ " + item.Key + " : " + item.Value + " }");
                        flag = true;
                    }
                    else
                    {
                        Console.Write(", { " + item.Key + " : " + item.Value + " }");
                    }

                }
                Console.Write(" ]");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("dictionary is empty");
            }
        }
        public static void Table(ICollection list)
        {
            var table = new Table();

            foreach (PropertyInfo propertyInfo in list.GetType().GetGenericArguments().Single().GetProperties())
            {
                table.AddColumn(propertyInfo.Name);
            }


            foreach (var element in list)
            {
                PropertyInfo[] propertyInfo = element.GetType().GetProperties();
                string[] arr = new string[propertyInfo.Length];
                for (int i = 0; i < propertyInfo.Length; i++)
                {
                    arr[i] = propertyInfo[i].GetValue(element).ToString();
                }
                table.AddRow(arr);
            }
            AnsiConsole.Write(table);
        }
    }
}
