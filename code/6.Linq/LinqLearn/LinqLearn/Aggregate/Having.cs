using LinqLearn.Models;

namespace LinqLearn.Aggregate
{
    public class Having
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
            new Student() {Id = 10, Name = "Sanjay Vadhiya", Age = 20  },
            new Student() {Id = 6, Name = "Jash Makwana", Age = 13  },
            new Student() {Id = 7, Name = "Monik Rupareliya", Age = 20  }
        };
        public static void Main(string[] args)
        {
            var dictionary1 = from student in _students
                              group student by student.Age into ageGroup
                              where ageGroup.Count() > 1
                              select ageGroup;

            foreach (var element in dictionary1)
            {
                Console.WriteLine($"Age: {element.Key}");
                foreach (Student value in element)
                {
                    Console.WriteLine($"Name: {value.Name}");
                }
            }

            Console.WriteLine();

            var dictionary2 = _students.GroupBy(student => student.Age).Where(ageGroup => ageGroup.Count() > 1);

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
