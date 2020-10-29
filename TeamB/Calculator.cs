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

            if (numbers.Length > 1)
            {
                foreach (var num in numbers)
                {
                    try
                    {
                        result += Convert.ToDecimal(num);
                    }
                    catch (Exception)
                    {

                    }
                }

                return result;
            }

            numbers = problem.Split("-");
            if (numbers.Length > 1)
            {
                bool firstNumber = true;
                foreach (var num in numbers)
                {
                    try
                    {
                        if (firstNumber)
                        {
                            result = Convert.ToDecimal(num);
                            firstNumber = false;
                        }
                        else
                        {
                            result -= Convert.ToDecimal(num);
                        }
                        
                    }
                    catch (Exception)
                    {

                    }
                }

                return result;
            }

            return result;
        }
    }
}
