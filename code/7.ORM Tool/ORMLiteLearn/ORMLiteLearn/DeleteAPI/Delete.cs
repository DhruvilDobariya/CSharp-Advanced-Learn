using DisplayCollection;
using ORMLiteLearn.Models;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.DeleteAPI
{
    public class Delete
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);
        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                if (db.Exists<Student>(32))
                {
                    db.DeleteById<Student>(32);
                }

                if (db.Exists<Student>(32))
                {
                    db.Delete<Student>(student => student.StudentId == 34);
                }

                Display.Table(db.Select<Student>());
            }
        }
    }
}
