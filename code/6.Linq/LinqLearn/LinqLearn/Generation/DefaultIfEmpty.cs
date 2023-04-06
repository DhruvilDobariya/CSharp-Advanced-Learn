using LinqLearn.Models;

namespace LinqLearn.Generation
{
    public class DefaultIfEmpty
    {
        private static List<Student> _students = new List<Student>();
        public static void Main(string[] args)
        {
            var list1 = _students.ToList();
            var list2 = _students.DefaultIfEmpty();
            var list3 = _students.DefaultIfEmpty(new Student() { Id = 0, Name = "NA", Age = 0 });

            // It throws exception "Index was out of range. Must be non-negative and less than the size of the collection".
            //Console.WriteLine(list1.ElementAt(0).Name);

            // It throws exception "Object reference not set to an instance of an object".
            //Console.WriteLine(list2.ElementAt(0).Name);

            // It don't give exception.
            Console.WriteLine(list3.ElementAt(0).Name);

            // Count
            Console.WriteLine(list1.Count()); // It don't have any element
            Console.WriteLine(list2.Count()); // It have one default element which is undefined 
            Console.WriteLine(list3.Count()); // // It have one default element which is "new Student() { Id = 0, Name = null, Age = 0 }"
        }
    }
}
