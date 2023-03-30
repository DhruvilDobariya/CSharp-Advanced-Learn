using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Partitioning
{
    public class SkipWhile
    {
        // It skip n recored until condition become false and give after skips recored

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  },
            new Student() {Id = 8, Name = "Shivam Nanda", Age = 22  },
            new Student() {Id = 9, Name = "Yash Makwana", Age = 25  },
            new Student() {Id = 10, Name = "Sanjay Vadhiya", Age = 17  },
            new Student() {Id = 6, Name = "Jash Makwana", Age = 13  },
            new Student() {Id = 7, Name = "Monik Rupareliya", Age = 14  }
        };
        public static void Main(string[] args)
        {
            var list1 = _students.SkipWhile(student => student.Id < 4).ToList();
            Display.Table(list1);

            var list2 = _students.SkipWhile((student, index) => student.Id > index).ToList();
            Display.Table(list2);
        }
    }
}
