using LinqLearn.Models;
using System.Diagnostics.CodeAnalysis;

namespace LinqLearn.Interfaces
{
    public class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student? x, Student? y)
        {
            if (object.ReferenceEquals(x, y))
            {
                // if both object have save reference then it mean's it is same instance of class so we return true
                return true;
            }

            if (x.Id == y.Id && x.Name == y.Name && x.Age == y.Age)
            {
                return true;
            }

            return false;

        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            if (obj == null)
            {
                return 0;
            }
            int idHashCode = obj.Id.GetHashCode();
            int nameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();
            int ageHashCode = obj.Age == null ? 0 : obj.Age.GetHashCode();

            return idHashCode ^ nameHashCode ^ ageHashCode;
        }
    }
}
