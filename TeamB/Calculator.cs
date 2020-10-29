using System;
using System.Linq;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            if (problem.Contains("*"))
            {
                var split = problem.Split("*");
                return decimal.Parse(split[0]) * decimal.Parse(split[1]);
            }
            return -2;
        }
    }
}