using DisplayCollection;
using ORMLiteLearn.Models;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.InsertAPI
{
    public class Insert
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);
        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                db.Insert(new Student() { FirstName = "Bhargav", LastName = "Vachhani", Email = "bhargav@gmail.com", Gender = "Male", CollageId = 1, CityId = 2 });

                Display.Table(db.Select<Student>());

                db.InsertOnly<Student>(() => new Student() { FirstName = "Jenil", LastName = "Vasoya", Email = "jenil@gmail.com", Gender = "Male" });

                Display.Table(db.Select<Student>());

                db.InsertAll(new List<Student>() {
                    new Student() { FirstName = "Dhruv", LastName = "Rathod", Email = "dhruv@gmail.com", Gender = "Male", CollageId = 1, CityId = 2 },
                    new Student() { FirstName = "Dhaval", LastName = "Dobariya", Email = "dhavals@gmail.com", Gender = "Male" }
                });

                Display.Table(db.Select<Student>());
            }
        }
    }
}
