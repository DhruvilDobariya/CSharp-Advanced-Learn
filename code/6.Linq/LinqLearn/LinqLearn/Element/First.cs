using LinqLearn.Models;

namespace LinqLearn.Element
{
    public class First
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 1, Name = "Bhargav Vachhani", Age = 18  },
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
            Student student1 = _students.First();
            Console.WriteLine($"Id: {student1.Id}, Name: {student1.Name}, Age: {student1.Age}");
            // If element not exist on first index then it will throws an exception.

            Student student2 = _students.FirstOrDefault();
            Console.WriteLine($"Id: {student2.Id}, Name: {student2.Name}, Age: {student2.Age}");
            // If element not exist on first index then it will return null.

            // First with delegate vs First with Where

            Student student3 = _students.Where(student => student.Id == 3).First();
            Student student4 = _students.First(student => student.Id == 3);

            // both give same output, but First with delegate if faster then First with Where.
            // Because in Where case we traverse whole dataset and find student.Id equals to 3 and then we apply First.
            // In case if First with delegate we just traverse dataset until we find first student which have student.Id equals to 3 and when we find first student we stop traversing.
            // It apply same thing on FirstOrDefault with delegate.
        }
    }
}
