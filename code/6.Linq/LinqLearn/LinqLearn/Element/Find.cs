using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Element
{
    public class Find
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 1, Name = "Dhaval Dobariya", Age = 13  },
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
            Student student1 = _students.Find(student => student.Id == 1);
            Console.WriteLine($"Id: {student1.Id}, Name: {student1.Name}, Age: {student1.Age}");
            // It returns only one element which find first.
            // If element not exist then it will throws an exception.

            Student student2 = _students.FindLast(student => student.Id == 1);
            Console.WriteLine($"Id: {student2.Id}, Name: {student2.Name}, Age: {student2.Age}");
            // It returns only one element which find last.
            // If element not exist then it will throws an exception.

            List<Student> student3 = _students.FindAll(student => student.Id == 1);
            Display.Table(student3);
            // If element not exist then it will return null.

            int index1 = _students.FindIndex(student => student.Id == 1);
            Console.WriteLine(index1);
            // It return index of first occurrence.
            // If element not exist then it will return -1.

            int index2 = _students.FindLastIndex(student => student.Id == 1);
            Console.WriteLine(index2);
            // It return index of last occurrence.
            // If element not exist then it will return -1.
        }
    }
}
