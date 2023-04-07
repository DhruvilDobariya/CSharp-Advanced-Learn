using DisplayCollection;
using SelectAPI.Models;
using ServiceStack.OrmLite;

namespace SelectAPI
{
    public class Single
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = StudentDB; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                Student student1 = db.SingleById<Student>(10);
                Display.DisplayObject(student1);

                Student student2 = db.Single<Student>(student => student.RollNo == 20);
                Display.DisplayObject(student2);

                Student student3 = db.SingleWhere<Student>("RollNo", 10);
                Display.DisplayObject(student3);
            }
        }
    }
}
