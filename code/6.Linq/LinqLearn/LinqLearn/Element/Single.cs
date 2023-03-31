using LinqLearn.Models;
using System.Data;

namespace LinqLearn.Element
{
    public class Single
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  },
            new Student() {Id = 8, Name = "Shivam Nanda", Age = 22  },
            new Student() {Id = 5, Name = "Yash Makwana", Age = 25  },
            new Student() {Id = 10, Name = "Sanjay Vadhiya", Age = 17  },
            new Student() {Id = 6, Name = "Jash Makwana", Age = 13  },
            new Student() {Id = 7, Name = "Monik Rupareliya", Age = 14  }
        };

        public static void Main(string[] args)
        {
            Student student1 = _students.Where(student => student.Id == 1).Single();
            Console.WriteLine($"Id: {student1.Id}, Name: {student1.Name}, Age: {student1.Age}");
            // If element not exist in dataset or dataset contains more then one element in dataset then it will throws an exception.
            // Sequence contains more than one element
            // Sequence contains no elements

            Student student2 = _students.Where(student => student.Id == 1).SingleOrDefault();
            Console.WriteLine($"Id: {student2.Id}, Name: {student2.Name}, Age: {student2.Age}");
            // If element not exist in dataset or dataset contains more then one element in dataset then it will throws an exception.
            // Sequence contains more than one element
            // Object reference not set to an instance of an object.

            // Student student3 = _students.Single(student => student.Id == 5);
            // It will throws an exception Sequence contains more than one matching element
            // Student student3 = _students.Single(student => student.Id == 11);
            // It will throws an exception Sequence contains no matching element

            // Student student3 = _students.SingleOrDefault(student => student.Id == 5);
            // It will throws an exception Sequence contains more than one matching element
            //Student student3 = _students.SingleOrDefault(student => student.Id == 11);
            // It will return null



        }
    }
}
