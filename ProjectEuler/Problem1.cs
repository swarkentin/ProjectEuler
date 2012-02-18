using System.Globalization;
using System.Linq;

namespace ProjectEuler
{
    internal class Problem1 : IProblem
    {
        private const int Max = 1000;
        private static readonly int[] Multiples = new int[] {3, 5};

        public string Name
        {
            get { return "Problem 1"; }
        }

        public string Description
        {
            get { return "Find the sum of all the multiples of 3 or 5 below 1000."; }
        }

        public string Execute()
        {
            return Enumerable.Range(1, Max - 1)
                .Where(num => Multiples.Any(mul => num%mul == 0))
                .Sum()
                .ToString();
        }
    }
}