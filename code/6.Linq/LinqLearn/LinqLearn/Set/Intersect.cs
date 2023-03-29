﻿using DisplayCollection;
using LinqLearn.Interfaces;
using LinqLearn.Models;
using System.Diagnostics.CodeAnalysis;

namespace LinqLearn.Set
{
    public class Intersect
    {
        // It's return all elements which is exist in both dataset

        private static List<string> _lanhuages1 = new List<string>() { "C#", "Java", "Python" };
        private static List<string> _lanhuages2 = new List<string>() { "Java", "C#", "C++" };

        private static List<Student> _students1 = new List<Student>()
        {
            new Student() {Id = 1, Name = "Dhruvil Dobariya", Age = 21 },
            new Student() {Id = 2, Name = "Dhruvil Dobariya", Age = 13  },
            new Student() {Id = 3, Name = "Bhargav Vachhani", Age = 18  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        private static List<Student> _students2 = new List<Student>()
        {
            new Student() {Id = 2, Name = "Dhruvil Dobariya", Age = 13  },
            new Student() {Id = 4, Name = "Jenil Vasoya", Age = 20  },
            new Student() {Id = 5, Name = "Dhruv Rathod", Age = 20  }
        };
        public static void Main(string[] args)
        {
            //var list = _students.Select(student => student.Name).Distinct().ToList();
            var list = _lanhuages1.Intersect(_lanhuages2).ToList();
            Display.DisplayList(list);

            // On one row

            // Without Column name
            //var list2 =  _students1.Select(student => student.Name).Except(_students2.Select(student => student.Name)).ToList();
            // With Column name
            var list2 = _students1.Select(student => new { student.Name }).Intersect(_students2.Select(student => new { student.Name })).ToList();
            Display.Table(list2);


            // Whole Object

            // Using anonymous type
            var list3 = _students1.Select(student => new { student.Id, student.Name }).Intersect(_students2.Select(student => new { student.Id, student.Name })).ToList();
            Display.Table(list3);
            // here problem is we get list of anonymous type object

            // Using Equality Comparer
            StudentComparer comparer = new StudentComparer();
            var list4 = _students1.Intersect(_students2, comparer).ToList();
            Display.Table(list4);

        }
    }
}
