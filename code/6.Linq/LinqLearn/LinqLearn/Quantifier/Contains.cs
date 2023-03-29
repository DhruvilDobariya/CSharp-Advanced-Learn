using DisplayCollection;
using LinqLearn.Interfaces;
using LinqLearn.Models;

namespace LinqLearn.Quantifier
{
    public class Contains
    {
        // It check member contains particular things in value or not

        private static List<string> _names = new List<string>() { "Dhruvil", "Dobariya" };

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };

        private static List<StudentWithLanguage> _studentsWithLanguage = new List<StudentWithLanguage>()
        {
            new StudentWithLanguage()
            {
                Id = 1, Name = "Dhruvil Dobariya", Age = 21,
                Languages = new List<string>(){ "C#", "Java", "TS" }
            },
            new StudentWithLanguage()
            {
                Id = 2, Name = "Dhaval Dobariya", Age = 13,
                Languages = new List<string>(){ "Dart", "JavaScript", "C#" }
            },
            new StudentWithLanguage()
            {
                Id = 3, Name = "Bhargav Vachhani", Age = 18,
                Languages = new List < string >() { "C#", "Python", "JavaScript" }
            },
            new StudentWithLanguage()
            {
                Id = 4, Name = "Jenil Vasoya", Age = 20,
                Languages = new List<string>(){ "Objective - C", "Java", "Swift" }
            },
            new StudentWithLanguage()
            {
                Id = 5, Name = "Dhruv Rathod", Age = 20,
                Languages = new List<string>(){ "C++", "C", "Java" }
            }
        };

        public static void Main(string[] args)
        {
            // Simple type
            bool isContainsDhruvil = _names.Contains("Dhruvil");
            Console.WriteLine(isContainsDhruvil);

            bool isContainsDhaval = _names.Contains("Dhaval");
            Console.WriteLine(isContainsDhaval);

            // Complex type

            // Condition
            var list = _studentsWithLanguage.Where(student => student.Languages.Contains("C#")).ToList();

            Display.Table(list);

            // Compare Whole object
            StudentComparer comparer = new StudentComparer();
            var isContains = _students.Contains(new Student()
            {
                Id = 5,
                Name = "Dhruv Rathod",
                Age = 20
            }, comparer);
            Console.WriteLine(isContains);
        }
    }
}
