using System.Reflection;

namespace AttributeValue
{
    public class AttributeValue
    {
        public static void Main(string[] args)
        {
            foreach(PropertyInfo propertyInfo in typeof(Book).GetProperties())
            {
                foreach (AuthorAttribute customeAttributes in propertyInfo.GetCustomAttributes(true))
                {
                    Console.WriteLine(customeAttributes.AuthorId);
                    Console.WriteLine(customeAttributes.AuthorName);
                }
            }
        }
    }
}
