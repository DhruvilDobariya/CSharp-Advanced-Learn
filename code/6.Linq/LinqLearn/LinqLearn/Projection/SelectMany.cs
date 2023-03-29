using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Projection
{
    public class SelectMany
    {
        private static List<string> names = new List<string>() { "Dhruvil", "Dobariya" };

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
            var list1 = from name in names
                        from character in name
                        select character;

            Display.DisplayList(list1.ToList());

            var list2 = names.SelectMany(name => name).ToList();
            Display.DisplayList(list2);

            // Output: [ D, h, r, u, v, i, l, D, o, b, a, r, i, y, a ]

            var list3 = from student in _students
                        from language in student.Languages
                        select language;
            Display.DisplayList(list3.ToList());

            var list4 = _students.SelectMany(student => student.Languages).ToList();
            Display.DisplayList(list4);
        }
    }
}
