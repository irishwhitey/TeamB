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
                    decimal result = 0;
                    for (int i = 0; i < split.Length; i+=2)
                    {
                        result += decimal.Parse(split[i]);
                    }
                    return result;
                }
                if (problem.Contains("-"))
                {
                    decimal result = decimal.Parse(split[0]);
                    for (int i = 2; i < split.Length; i += 2)
                    {
                        result -= decimal.Parse(split[i]);
                    }
                    return result;
                    return decimal.Parse(split[0]) - decimal.Parse(split[2]);
                }
                if (problem.Contains("*"))
                {
                    return decimal.Parse(split[0]) * decimal.Parse(split[2]);
                }
                if (problem.Contains("/"))
                {
                    return decimal.Parse(split[0]) / decimal.Parse(split[2]);
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