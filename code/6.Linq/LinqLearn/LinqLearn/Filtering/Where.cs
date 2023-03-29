using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Filtering
{
    public class Where
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };

        public static void Main(string[] args)
        {
            // Query Syntax
            IEnumerable<Student> list1 = from student in _students
                                         where student.Id == 1
                                         select student;

            Display.Table(list1.ToList());

            IEnumerable<Student> list2 = from student in _students
                                         where student.Id == 1 || student.Id == 2
                                         select student;

            Display.Table(list2.ToList());

            // Method Syntax

            var list3 = _students.Where(student => student.Id == 1).ToList();

            Display.Table(list3);

            var list4 = _students.Where(student => student.Id == 1 || student.Id == 2).ToList();

            Display.Table(list4);
        }
    }
}
