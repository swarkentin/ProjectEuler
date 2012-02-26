using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    class Problem3 : IProblem
    {
        private const long Number = 600851475143;        

        public string Name
        {
            get { return "Problem 3"; }
        }

        public string Description
        {
            get
            {
                return
                    "What is the largest prime factor of the number 600851475143.";
            }
        }

        public string Execute()
        {            
            return MaxPrime2(Number).ToString();            
        }
     
        private long MaxPrime2(long number)
        {      
            var maxCheck = (long) Math.Ceiling(Math.Sqrt(number));
            for (var i = 2L; i < maxCheck; i++)
            {
                if (number % i == 0)
                {
                    return Math.Max(MaxPrime2(i), MaxPrime2(number / i));
                }
            }
            return number;
        }  
    }
}
