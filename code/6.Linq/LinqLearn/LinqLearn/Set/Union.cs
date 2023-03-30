using DisplayCollection;
using LinqLearn.Interfaces;
using LinqLearn.Models;

namespace LinqLearn.Set
{
    public class Union
    {
        // It combine two dataset vertically
        // Both dataset have same sequence of datatype of tuples  

        private static List<string> _lanhuages1 = new List<string>() { "C#", "Java", "Python" };
        private static List<string> _lanhuages2 = new List<string>() { "Java", "TS", "C++" };

        private static List<Student> _students1 = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhruvil Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        private static List<Student> _students2 = new List<Student>()
        {
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 6, Name = "Jash Makwana", Age = 13  },
            new Student() {Id = 7, Name = "Monik Rupareliya", Age = 20  }
        };
        public static void Main(string[] args)
        {
            // Simple Type
            //var list = _students.Select(student => student.Name).Distinct().ToList();
            var list = _lanhuages1.Union(_lanhuages2).ToList();
            Display.DisplayList(list);


            // Complex type 

            // Single column
            // Without column name
            //var list2 = _students1.Select(student => student.Name).Union(_students2.Select(student => student.Name)).ToList();

            // With column name
            var list2 = _students1.Select(student => new { student.Name }).Union(_students2.Select(student => new { student.Name })).ToList();
            Display.Table(list2);

            // With Whole Object

            // Using anonymous object
            var list3 = _students1.Select(student => new { student.Id, student.Name, student.Age }).Union(_students2.Select(student => new { student.Id, student.Name, student.Age })).ToList();
            Display.Table(list3);

            // Using Equality Comparer
            StudentComparer comparer = new StudentComparer();
            var list4 = _students1.Union(_students2, comparer).ToList();
            Display.Table(list4);

            // Union All
            // Just union without anonymous object or equality comparer
            // It just union both dataset not remove duplicate element
            var list5 = _students1.Union(_students2).ToList();
            Display.Table(list5);
        }
    }
}
