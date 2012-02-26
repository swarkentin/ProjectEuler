using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem2 : IProblem
    {
        private const int Max = 4000000;        

        public string Name
        {
            get { return "Problem 2"; }
        }

        public string Description
        {
            get
            {
                return
                    "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            }
        }

        public string Execute()
        {
            return NextFib()
                .Where(val => val%2 == 0)
                .Sum()
                .ToString();
        }

        private IEnumerable<int> NextFib()
        {
            var last = 0;
            var val = 1;
            var next = last + val;
            while (next < Max)
            {
                last = val;
                val = next;
                yield return val;

                next = last + val;
            }
                
        }
    }
}
