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
            
            Enumerable
                .Range(10,25)
                .ForEach(v=>Debug.WriteLine(v + ":" + MaxPrime(v)));
            return MaxPrime(Number).ToString();            
        }

        private long MaxPrime(long number)
        {
            return PrimesDescending(number).First();
        }

        private IEnumerable<long> PrimesDescending(long number)
        {
            var maxCheck = MaxCheck(number);

            while (maxCheck > 0)
            {
                var nextValue = maxCheck--;
                if (nextValue == 1)
                    yield return number;

                if (number % nextValue == 0 && PrimesDescending(nextValue).First() == nextValue)
                    yield return nextValue;
            }
        }

        private long MaxCheck(long number)
        {
            return (long)Math.Ceiling(number/2d);
        }        
    }
}
