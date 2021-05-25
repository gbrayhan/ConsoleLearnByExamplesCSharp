using System;
using System.Linq;

namespace ConsoleLearnByExamples.LINQ
{
    public class HigherThan
    {
        public void LinqHigherThan()
        {
            int[] scores = {97, 92, 81, 60};

            foreach (var i in scores)
                Console.Write(i + " ");
            
            Console.Write("\n");

            var scoreQuery =
                from score in scores
                where score > 85
                select score;

            foreach (var i in scoreQuery)
                Console.Write(i + " ");
        }
    }
}