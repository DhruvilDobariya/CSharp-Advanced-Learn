using DisplayCollection;
using ORMLiteLearn.Models;
using ServiceStack;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.SelectAPI
{
    public class SqlExpression
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                var query1 = db.From<Student>().Where(student => student.StudentId == 1).Select(student => student.FirstName);
                Display.DisplayList(db.Column<string>(query1));
                Console.WriteLine();

                var query2 = db.From<Student>().Select(student => student.FirstName);
                Display.DisplayList(db.ColumnDistinct<string>(query2).AsEnumerable().ToList());
                Console.WriteLine();

                var query3 = db.From<Student>().Select(student => new { student.StudentId, student.FirstName });
                Display.DisplayDictionary<string, string>(db.Dictionary<string, string>(query3));
                Console.WriteLine();

                var query4 = db.From<Student>().Select(student => new { student.StudentId, student.FirstName });
                Dictionary<int, List<string>> result4 = db.Lookup<int, string>(query4);
                Console.WriteLine();

                var query5 = db.From<Student>().Where(student => student.StudentId == 1).Select(student => new { student.StudentId, student.FirstName });
                Display.Table(db.Select(query5));

            }
        }
    }
}
