using LinqLearn.Models;

namespace LinqLearn.Aggregate
{
    public class Aggregate
    {
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
            int sum = _students.Sum(student => student.Age);
            Console.WriteLine(sum);

            double avg = _students.Average(student => student.Age);
            Console.WriteLine(avg);

            int count = _students.Count();
            Console.WriteLine(count);

            int min = _students.Min(student => student.Age);
            Console.WriteLine(min);

            int max = _students.Max(student => student.Age);
            Console.WriteLine(max);
        }
    }
}
