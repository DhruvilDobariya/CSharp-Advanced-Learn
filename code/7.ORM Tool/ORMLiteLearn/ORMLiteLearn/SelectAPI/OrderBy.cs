using DisplayCollection;
using ORMLiteLearn.Models;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.SelectAPI
{
    public class OrderBy
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                var query1 = db.From<Student>().Select().OrderBy("FirstName");
                Display.Table(db.Select(query1));

                var query2 = db.From<Student>().Select().OrderByDescending("FirstName");
                Display.Table(db.Select(query2));
            }
        }
    }
}
