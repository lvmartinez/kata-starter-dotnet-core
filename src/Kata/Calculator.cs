using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Kata
{
    public class Calculator
    {
        public int Add(string number= "")
        {
            if(string.IsNullOrEmpty(number))
                return 0;
   
            var sumNumbers = number.Split(",");

            if (sumNumbers.Length == 1)
                return int.Parse(sumNumbers[0]);
            
            var numberArr = new List<int>();
            
            foreach (var num in sumNumbers)
            {
                numberArr.Add(int.Parse(num));
            }

            var sum = numberArr[0]+numberArr[1];
            return sum;
        }
    }
}