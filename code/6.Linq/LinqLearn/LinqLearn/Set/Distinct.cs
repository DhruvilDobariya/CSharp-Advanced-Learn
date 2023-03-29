using DisplayCollection;
using LinqLearn.Interfaces;
using LinqLearn.Models;

namespace LinqLearn.Set
{
    public class Distinct
    {
        // It's return unique element of dataset

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        public static void Main(string[] args)
        {
            // Single column
            // Without column name
            //var list1 = _students.Select(student => student.Name).Distinct().ToList();

            // with column name
            var list1 = _students.Select(student => new { student.Name }).Distinct().ToList();
            Display.Table(list1);


            // Whole Object
            StudentComparer studentComparer = new StudentComparer();
            var list2 = _students.Distinct(studentComparer).ToList();
            Display.Table(list2);

        }
    }
}
