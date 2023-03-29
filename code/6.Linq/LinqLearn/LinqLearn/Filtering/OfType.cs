using DisplayCollection;
using System.Collections;

namespace LinqLearn.Filtering
{
    public class OfType
    {
        private static ArrayList _arrayList = new ArrayList()
        {
            1,
            true,
            "Dhruvil",
            false,
            21,
            30,
            //new Student() {Id = 3, Name = "Bhargav Vachhani" }
        };

        public static void Main(string[] args)
        {
            // It filter collection based in datatype.

            // Query Syntax
            var list1 = from element in _arrayList.OfType<int>()
                        select element;

            Display.DisplayList(list1.ToList());

            // Method Syntax
            var list2 = _arrayList.OfType<int>().ToList();

            Display.DisplayList(list2);
        }
    }
}
