using SelectAPI.Models;
using ServiceStack.OrmLite;

namespace SelectAPI
{
    public class GroupBy
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                var query1 = db.From<Student>().GroupBy(student => student.CollageId).Select(student => new { CollageId = student.CollageId, Count = Sql.Count(student.StudentId) });
                var result1 = db.KeyValuePairs<string, int>(query1);

                foreach (var row in result1)
                {
                    Console.WriteLine($"CollageId: {row.Key}, Count: {row.Value}");
                }

                var query2 = db.From<Student>().GroupBy(student => student.CollageId).Select(student => new { CollageId = student.CollageId, Count = Sql.Min(student.StudentId) });
                var result2 = db.KeyValuePairs<string, int>(query2);

                foreach (var row in result2)
                {
                    Console.WriteLine($"CollageId: {row.Key}, Count: {row.Value}");
                }

                var query3 = db.From<Student>().GroupBy(student => student.CollageId).Select(student => new { CollageId = student.CollageId, Count = Sql.Max(student.StudentId) });
                var result3 = db.KeyValuePairs<string, int>(query3);

                foreach (var row in result3)
                {
                    Console.WriteLine($"CollageId: {row.Key}, Count: {row.Value}");
                }

                var query4 = db.From<Student>().GroupBy(student => student.CollageId).Select(student => new { CollageId = student.CollageId, Count = Sql.Sum(student.StudentId) });
                var result4 = db.KeyValuePairs<string, int>(query4);

                foreach (var row in result4)
                {
                    Console.WriteLine($"CollageId: {row.Key}, Count: {row.Value}");
                }

                var query5 = db.From<Student>().GroupBy(student => student.CollageId).Select(student => new { CollageId = student.CollageId, Count = Sql.Avg(student.StudentId) });
                var result5 = db.KeyValuePairs<string, int>(query5);

                foreach (var row in result5)
                {
                    Console.WriteLine($"CollageId: {row.Key}, Count: {row.Value}");
                }
            }
        }
    }
}
