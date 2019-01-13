using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            try
            {
                var splitted = new Regex(" ").Split(problem);
                var expressions = new List<Expression>();
                foreach (var s in splitted)
                {
                    expressions.Add(new Expression(s));
                }
                //var toReturn = 
                foreach (var expression in expressions)
                {
                  //  return expression +=
                }

            }
            catch (Exception e)
            {
                return 3;
            }
            return 7;
        }

        private void CreateExpression(string s)
        {
            
        }
    }
    public class Expression
    {
        private readonly string _ex;
        
        public Expression(string ex)
        {
            _ex = ex;
        }

        public decimal Value()
        {
            return decimal.Parse(_ex);
        }
    }
}