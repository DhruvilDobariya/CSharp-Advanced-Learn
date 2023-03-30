using DisplayCollection;
using LinqLearn.Models;

namespace LinqLearn.Partitioning
{
    public class Pagging
    {
        public static void Main(string[] args)
        {
            StudentDBContext db = new StudentDBContext();
            int page, size;

            Console.Write("Enter size of page: ");
            if (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("size is not valid");
                Environment.Exit(0);
            }
            Console.Write("Enter page no : ");
            if (!int.TryParse(Console.ReadLine(), out page))
            {
                Console.WriteLine("page is not valid");
                Environment.Exit(0);
            }

            var list = db.GetStudents().Skip((page - 1) * size).Take(size).ToList();

            Display.Table(list);
        }
    }
}
