using DisplayCollection;
using SelectAPI.Models;
using ServiceStack.OrmLite;

namespace SelectAPI
{
    public class Select
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                // Select
                List<Student> students1 = db.Select<Student>();
                Display.Table(students1);

                // Condition
                var students2 = db.Select<Student>(student => student.StudentId > 10 && student.StudentId < 21);
                Display.Table(students2);

                // In
                var students3 = db.Select<Student>(student => Sql.In(student.StudentId, 4, 7, 10, 20));
                Display.Table(students3);

                // StartWith
                var students4 = db.Select<Student>(student => student.FirstName.StartsWith("s"));
                Display.Table(students4);

                // EndWith
                var students5 = db.Select<Student>(student => student.FirstName.EndsWith("w"));
                Display.Table(students5);

                // Contains
                var students6 = db.Select<Student>(student => student.FirstName.Contains("ie"));
                Display.Table(students6);
            }
        }
    }
}
