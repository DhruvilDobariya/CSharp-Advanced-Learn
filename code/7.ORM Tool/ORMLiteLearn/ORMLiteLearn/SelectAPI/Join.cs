using ORMLiteLearn.Models;
using ServiceStack;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.Legacy;

namespace ORMLiteLearn.SelectAPI
{
    public class Join
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                //var query = db.From<Student>()
                //    .Join<Student, Collage>((student, collage) => student.CollageId == collage.CollageId)
                //    .Join<City>((studentWithCollage, city) => studentWithCollage.CityId == city.CityId)
                //    .Select<Student, Collage, City>((student, collage, city) => new
                //    {
                //        StudentId = student.StudentId,
                //        FirstName = student.FirstName,
                //        LastName = student.LastName,
                //        Email = student.Email,
                //        Gender = student.Gender,
                //        Collage = collage.Name,
                //        City = city.CityName
                //    });

                //var query = db.From<Student>()
                //    .Join<Student, Collage>((student, collage) => student.CollageId == collage.CollageId)
                //    .Select<Student, Collage, City>((student, collage, city) => new
                //    {
                //        StudentId = student.StudentId,
                //        FirstName = student.FirstName,
                //        LastName = student.LastName,
                //        Email = student.Email,
                //        Gender = student.Gender,
                //        Collage = collage.Name,
                //        //City = city.CityName
                //    });

                var query = db.From<Student>()
                    .Join<Student, Collage>();

                //db.Select(query).PrintDump();
                db.Select(query).PrintDumpTable();

            }
        }
    }
}
