using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Kata
{
    public class Calculator
    {
        private List<string> SEPARATORS = new List<string>{",", "\n"}; 
        
        public int Add(string number= "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;
   
            var sumNumbers = number.Split(SEPARATORS.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            if (sumNumbers.Length == 1)
                return int.Parse(sumNumbers[0]);
            
            var numberArr = new List<int>();
            
            foreach (var num in sumNumbers)
            {
                numberArr.Add(int.Parse(num));
            }

            var sum = numberArr.Sum();
            return sum;
        }
    }
}