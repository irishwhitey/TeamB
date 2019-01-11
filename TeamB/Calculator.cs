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
                    return Calculate(0, "+", split);
                }
                if (problem.Contains("-"))
                {
                    return Calculate(decimal.Parse(split[0]), "-", split);
                }
                if (problem.Contains("*"))
                {
                    return Calculate(decimal.Parse(split[0]), "*", split);
                }
                if (problem.Contains("/"))
                {
                    return Calculate(decimal.Parse(split[0]), "/", split);
                    
                }

            }
            catch (Exception e)
            {
                return 3;
            }
            return 0;
        }

        private decimal Calculate(decimal startingValue, string operator1, string[] split)
        {
            decimal result;
            switch (operator1)
            {
                case "+":
                     result = startingValue;
                    for (int i = 0; i < split.Length; i += 2)
                    {

                        result += decimal.Parse(split[i]);
                    }
                    return result;

                case "-":
                     result = startingValue;
                    for (int i = 2; i < split.Length; i += 2)
                    {
                        result -= decimal.Parse(split[i]);
                    }
                    return result;
                

                case "*":
                    result = startingValue;
                    for (int x = 2; x <= split.Length; x += 2)
                    {

                        result *= decimal.Parse(split[x]);
                    }
                    return result;
                case "/":
                    result = startingValue;
                    for (int x = 2; x <= split.Length; x += 2)
                    {

                        result /= decimal.Parse(split[x]);
                    }
                    return result;
                default:
                    return 0;



            }


        }


    }
}