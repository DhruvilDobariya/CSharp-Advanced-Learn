using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Quantifier
{
    public class Contains
    {
        // It check member contains particular things in value or not

        private static List<string> _names = new List<string>() { "Dhruvil", "Dobariya" };

        private static List<StudentWithLanguage> _students = new List<StudentWithLanguage>()
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
            bool isContainsDhruvil = _names.Contains("Dhruvil");
            Console.WriteLine(isContainsDhruvil);

            bool isContainsDhaval = _names.Contains("Dhaval");
            Console.WriteLine(isContainsDhaval);

            //bool IsContainsDhruv = _students.Contains(new StudentWithLanguage()
            //{
            //    Id = 5,
            //    Name = "Dhruv Rathod",
            //    Age = 20,
            //    Languages = new List<string>() { "C++", "C", "Java" }
            //});
            //Console.WriteLine(IsContainsDhruv);

            var list = _students.Where(student => student.Languages.Contains("C#")).ToList();

            Display.Table(list);
        }
    }
}
