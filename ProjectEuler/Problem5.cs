using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    class Problem5 : IProblem
    {
        private const long Number = 600851475143;        

        public string Name
        {
            get { return "Problem 5"; }
        }

        public string Description
        {
            get
            {
                return
@"2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ? ";
            }
        }

        public string Execute()
        {            
            return SmallestDivisible().ToString();            
        }

        private long SmallestDivisible()
        {            
            var start = 2520;
            
            for(var cur = start; cur  < int.MaxValue; cur+=5)
            {
                if (check(cur))
                {
                    return cur;
                }
            }
            return -1L;
        }

        private bool check(int val)
        {
            for (int i = 20; i > 0; i--)
            {
                if ((val % i) != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
