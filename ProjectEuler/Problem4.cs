using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
    class Problem4 : IProblem
    {        

        public string Name
        {
            get { return "Problem 4"; }
        }

        public string Description
        {
            get
            {
                return
                    "Find the largest palindrome made from the product of two 3-digit numbers.";
            }
        }

        public string Execute()
        {
            return AllPalindromes.Max().ToString();
        }

        public IEnumerable<int> AllPalindromes
        {
            get
            {
                var numbers1 = Numbers;
                var numbers2 = Numbers.ToList();
                foreach (var n1 in numbers1)
                {
                    foreach (var n2 in numbers2)
                    {
                        var result = n1 * n2;
                        if (IsPalindrome(result))
                            yield return result;
                    }
                }
            }
        }

        private IEnumerable<int> Numbers
        {
            get { 
                return Enumerable.Range(100, 900).Reverse();                
            }
        }

        private bool IsPalindrome(int value)
        {
            var str = value.ToString();            
            var length = str.Length;
            var halfWay =  (int) Math.Ceiling(length/2d);
            for (var i= 0; i<= halfWay; i++)
            {
                if (str[i] != str[length - i-1])
                    return false;
            }
            return true;
        }      
          
    }
}
