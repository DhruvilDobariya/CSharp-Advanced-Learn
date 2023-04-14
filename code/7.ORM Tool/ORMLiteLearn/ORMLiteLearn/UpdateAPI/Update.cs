using DisplayCollection;
using ORMLiteLearn.Models;
using ServiceStack.OrmLite;

namespace ORMLiteLearn.UpdateAPI
{
    public class Update
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);
        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                db.Update(new Student() { StudentId = 28, FirstName = "BhargavUpdate", LastName = "Vachhani", Email = "bhargav@gmail.com", Gender = "Male", CollageId = 1, CityId = 2 });

                // OR

                db.Update(new Student() { FirstName = "BhargavUpdate", LastName = "Vachhani", Email = "bhargav@gmail.com", Gender = "Male", CollageId = 1, CityId = 2 }, student => student.StudentId == 28);

                Display.Table(db.Select<Student>());

                db.UpdateOnly(() => new Student() { FirstName = "JenilUpdate", LastName = "VasoyaUpdate" }, student => student.StudentId == 29);

                // OR

                db.UpdateOnlyFields(new Student() { FirstName = "JenilUpdate", LastName = "VasoyaUpdate" }, student => new { student.FirstName, student.LastName }, student => student.StudentId == 29);

                Display.Table(db.Select<Student>());
            }
        }
    }
}
