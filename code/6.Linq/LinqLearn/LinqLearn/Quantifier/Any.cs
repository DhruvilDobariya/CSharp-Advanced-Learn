using LinqLearn.Models;

namespace LinqLearn.Quantifier
{
    public class Any
    {
        // Any of the member is satisfy condition then return true

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
            bool isAgeGraterThen20 = _students.Any(student => student.Age > 20);

            Console.WriteLine(isAgeGraterThen20);

            bool IsGraterThen20AgeAndAge = _students.All(student => student.Age > 20 && student.Id > 20);

            Console.WriteLine(IsGraterThen20AgeAndAge);
        }
    }
}
