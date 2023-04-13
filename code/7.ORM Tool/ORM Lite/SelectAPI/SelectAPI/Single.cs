﻿using DisplayCollection;
using SelectAPI.Models;
using ServiceStack.OrmLite;

namespace SelectAPI
{
    public class Single
    {
        private readonly static OrmLiteConnectionFactory _dbFactory = new OrmLiteConnectionFactory("Server = localhost; Database = JoinLearn; User = root; Password = Admin;", MySqlDialect.Provider);

        public static void Main(string[] args)
        {
            using (var db = _dbFactory.Open())
            {
                Student student1 = db.SingleById<Student>(10);
                Display.DisplayObject(student1);

                Student student2 = db.Single<Student>(student => student.StudentId == 20);
                Display.DisplayObject(student2);

                Student student3 = db.SingleWhere<Student>("FirstName", "Sadye");
                Display.DisplayObject(student3);
            }
        }
    }
}
