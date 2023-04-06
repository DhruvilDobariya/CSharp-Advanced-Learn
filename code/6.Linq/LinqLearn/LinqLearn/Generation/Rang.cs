using DisplayCollection;

namespace LinqLearn.Generation
{
    public class Rang
    {
        public static void Main(string[] args)
        {
            var list = Enumerable.Range(10, 10);
            Display.DisplayList(list.ToList());
        }
    }
}
