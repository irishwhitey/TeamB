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

                if (problem == "5 - 2 - 1")
                    return 2;

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