using DisplayCollection;
using SelectAPI.Models;
using ServiceStack.OrmLite;

namespace SelectAPI
{
    public class Select
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = StudentDB; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                // Select
                List<Student> students1 = db.Select<Student>();
                Display.Table(students1);

                // Condition
                var students2 = db.Select<Student>(student => student.Id > 10 && student.Id < 21);
                Display.Table(students2);

                // In
                var students3 = db.Select<Student>(student => Sql.In(student.RollNo, 4, 7, 10, 20));
                Display.Table(students3);

                // StartWith
                var students4 = db.Select<Student>(student => student.Name.StartsWith("s"));
                Display.Table(students4);

                // EndWith
                var students5 = db.Select<Student>(student => student.Name.EndsWith("w"));
                Display.Table(students5);

                // Contains
                var students6 = db.Select<Student>(student => student.Name.Contains("ie"));
                Display.Table(students6);
            }
        }
    }
}
