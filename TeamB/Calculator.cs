using System;
using System.Linq;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            try
            {
                if (problem == string.Empty)
                    return 0;

                var splitProblem = problem.Split('+');

                return splitProblem.Sum(int.Parse);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}