using LinqLearn.Models;

namespace LinqLearn.Element
{
    public class Last
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
            Student student1 = _students.Last();
            Console.WriteLine($"Id: {student1.Id}, Name: {student1.Name}, Age: {student1.Age}");
            // If element not exist on last index then it will throws an exception.

            Student student2 = _students.LastOrDefault();
            Console.WriteLine($"Id: {student2.Id}, Name: {student2.Name}, Age: {student2.Age}");
            // If element not exist on last index then it will return null.
        }
    }
}
