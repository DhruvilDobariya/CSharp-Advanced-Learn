using DisplayCollection;
using LinqLearn.Interfaces;
using LinqLearn.Models;
using System.Xml.Linq;

namespace LinqLearn.Element
{
    public class Index
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
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
            int index1 = _students.IndexOf(new Student() { Id = 1, Name = "Dhruvil Dobariya", Age = 21 });
            Console.WriteLine(index1);
            // It return index of first occurrence.
            // If element not exist then it will return -1.

            int index2 = _students.LastIndexOf(new Student() { Id = 1, Name = "Dhruvil Dobariya", Age = 21 });
            Console.WriteLine(index2);
            // It return index of last occurrence.
            // If element not exist then it will return -1.
        }
    }
}
