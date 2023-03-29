using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Sorting
{
    public class ThenBy
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhruvil Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        public static void Main(string[] args)
        {

            // Method Syntax
            var list1 = _students.OrderBy(student => student.Name).ThenBy(student => student.Age).ToList();
            Display.Table(list1);

            var list2 = _students.OrderByDescending(student => student.Name).ThenBy(student => student.Age).ToList();
            Display.Table(list2);

            // it first sort with orderby property then if it have same value of property then it's sorting with thenby property.
        }
    }
}
