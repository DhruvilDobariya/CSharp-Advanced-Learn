using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Sorting
{
    public class OrderByDescending
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
            // Query Syntax
            var list1 = from student in _students
                        orderby student.Name descending
                        select student;
            Display.Table(list1.ToList());

            var list2 = from student in _students
                        orderby student.Name descending, student.Id descending
                        select student;
            Display.Table(list2.ToList());

            // Method Syntax
            var list3 = _students.OrderByDescending(keySelector: student => student.Name).ToList();
            Display.Table(list3);

            var list4 = _students.OrderByDescending(student => student.Id).OrderByDescending(student => student.Name).ToList();
            Display.Table(list4);

        }
    }
}
