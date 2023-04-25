using LinqLearn.Models;

namespace LinqLearn.Aggregate
{
    public class ToLookup
    {
        // ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate.

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  },
            new Student() {Id = 8, Name = "Shivam Nanda", Age = 22  },
            new Student() {Id = 9, Name = "Yash Makwana", Age = 25  },
            new Student() {Id = 10, Name = "Sanjay Vadhiya", Age = 20  },
            new Student() {Id = 6, Name = "Jash Makwana", Age = 13  },
            new Student() {Id = 7, Name = "Monik Rupareliya", Age = 20  }
        };
        public static void Main(string[] args)
        {
            var dictionary2 = _students.ToLookup(student => student.Age);
            
            foreach (var element in dictionary2)
            {
                Console.WriteLine($"Age: {element.Key}");
                foreach (Student value in element)
                {
                    Console.WriteLine($"Name: {value.Name}");
                }
            }
        }
    }
}
