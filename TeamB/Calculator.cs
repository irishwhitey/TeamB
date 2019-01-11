using System;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            try
            {
                var split = problem.Split(" ");
                if (problem.Contains("+"))
                {
                    return decimal.Parse(split[0]) + decimal.Parse(split[2]);
                }

            }
            catch (Exception e)
            {
                return 3;
            }

            return 0;

        }
    }
}