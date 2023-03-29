using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Projection
{
    public class Select
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
                                         select student;
            Display.Table(list1.ToList());

            var list2 = from student in _students
                        select new
                        {
                            student.Name
                        };

            //var list2 = from student in _students
            //            select student.Id;

            //var list2 = from student in _students
            //            select new Student
            //            {
            //                Name = student.Name
            //            };

            Display.Table(list2.ToList());

            // Method Syntax
            IEnumerable<Student> list3 = _students.Select(student => student);
            Display.Table(list3.ToList());

            var list4 = _students.Select(student => new { student.Name }).ToList();

            //var list4 = _students.Select(student => student.Id).ToList();
            //var list4 = _students.Select(student => new Student { Name = student.Name }).ToList();

            Display.Table(list4);

            var list5 = _students.Select((student, index) => new { Index = index, student.Id, student.Name }).ToList();

            Display.Table(list5);
        }
    }
}
