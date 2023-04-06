using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Generation
{
    public class Repeat
    {
        public static void Main(string[] args)
        {
            var list = Enumerable.Repeat<Student>(new Student() { Id = 1, Name = "Dhruvil Dobariya", Age = 21 }, 10);

            Display.Table(list.ToList());
        }
    }
}
