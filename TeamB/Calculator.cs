using System;
using System.Linq;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            decimal result = 0;
            var numbers = problem.Split("+");
            foreach (var num in numbers)
            {
                result += Convert.ToDecimal(num);
            }

            return result;
        }
    }
}
