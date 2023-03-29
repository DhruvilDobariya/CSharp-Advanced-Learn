using LinqLearn.Models;

namespace LinqLearn.Quantifier
{
    public class All
    {
        // All of the member is satisfy condition then return true

        private static List<Student> _students = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhaval Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        public static void Main(string[] args)
        {
            bool isAgeGraterThen10 = _students.All(student => student.Age > 10);

            Console.WriteLine(isAgeGraterThen10);

            bool IsGraterThen10AgeAndAge = _students.All(student => student.Age > 10 && student.Id > 10);

            Console.WriteLine(IsGraterThen10AgeAndAge);
        }
    }
}
