using System;
using System.Linq;

namespace ConsoleLearnByExamples.LINQ
{
    public class Odd
    {
        public void LinqOdd()
        {
            var numbers = new int[7] {0, 1, 2, 3, 4, 5, 6};
            var numQuery =
                from num in numbers
                where num % 2 == 0
                select num;

            foreach (var num in numQuery) Console.Write("{0,1} ", num);
        }
    }
}