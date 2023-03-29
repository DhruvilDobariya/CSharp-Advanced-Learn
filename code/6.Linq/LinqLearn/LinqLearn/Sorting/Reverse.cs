using DisplayCollection;

namespace LinqLearn.Sorting
{
    public class Reverse
    {
        private static List<int> _arr = new List<int>() { 10, 1, 0, -10, 10, 20, 17, 27 };
        public static void Main(string[] args)
        {
            // Query Syntax
            var list1 = (from x in _arr
                         select x).Reverse();
            Display.DisplayList(list1.ToList());

            // Method Syntax
            var list2 = _arr.Select(x => x).Reverse();

            Display.DisplayList(list2.ToList());
        }
    }
}
