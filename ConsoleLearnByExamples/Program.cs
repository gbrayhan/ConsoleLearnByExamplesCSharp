using ConsoleLearnByExamples.LINQ;

namespace ConsoleLearnByExamples
{
    internal class LINQQueryExpressions
    {
        private static void Main(string[] args)
        {
            var odd = new Odd();
            odd.LinqOdd();

            var higher = new HigherThan();
            higher.LinqHigherThan();
        }
    }
}