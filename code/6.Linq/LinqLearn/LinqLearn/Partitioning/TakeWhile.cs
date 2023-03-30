using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Partitioning
{
    public class TakeWhile
    {
        // It returns n number of recored until condition is false

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhruvil Dobariya", Age = 13  },
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
            var list1 = _students.TakeWhile(student => student.Id < 4).ToList();
            Display.Table(list1);

            // index
            var list2 = _students.TakeWhile((student, index) => student.Id > index).ToList();
            Display.Table(list2);

            // Difference between where and takewhile
            var list3 = _students.TakeWhile(student => student.Id < 8).ToList();
            Display.Table(list3);
            // it just check condition in sequence and when condition become false it just stop

            var list4 = _students.Where(student => student.Id < 8).ToList();
            Display.Table(list4);
            // it just check condition on all the element of dataset
        }
    }
}
