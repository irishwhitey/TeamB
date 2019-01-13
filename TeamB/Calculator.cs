using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            try
            {
                var splitted = new Regex(" ").Split(problem +" + 0") ;
                var splitted2 = new Regex("()(?<=\\().+?(?=\\)) | ").Split(problem);
                var expressions = new List<Expression>();
                var expressions1 = new List<Expression>();
                foreach (var s in splitted)
                {
                    expressions.Add(new Expression(s,null));
                }

                var initialValue = new Expression(splitted.ElementAt(0));
                for (int i = 1; i < splitted.Length-1; i+=2)
                {
                    expressions1.Add(new Expression(splitted.ElementAt(i+1),splitted.ElementAt(i)));
                }

                var toReturn1 = initialValue.Value();
                foreach (var exp1 in expressions1)
                {
                    switch (exp1._operator1)
                    {
                        case "+": toReturn1 += exp1.Value();
                            break;
                        case "-": toReturn1 -= exp1.Value();
                            break;
                        case "*":
                            toReturn1 *= exp1.Value();
                            break;
                        case "/":
                            toReturn1 /= exp1.Value();
                            break;
                    }
                }

                return toReturn1;
                
            }
            catch (Exception e)
            {
                return -100;
            }
        }

      
    }
    public class Expression
    {
        private readonly string _ex;
        public readonly string _operator1;
        public List<Expression> innerExpressions;
        

        public Expression(string ex, string operator1=null)
        {
            if (ex.Contains("("))
            {
                var splitted = new Regex(" ").Split(ex + " + 0");
                for (int i = 1; i < splitted.Length - 1; i += 2)
                {
                    innerExpressions.Add(new Expression(splitted.ElementAt(i + 1), splitted.ElementAt(i)));
                }
            }
            else
            {
                _ex = ex;
            }
            _operator1 = operator1;
        }

        public decimal Value()
        {
            if (innerExpressions!=null && innerExpressions.Count >0)
            {
                var toReturn = innerExpressions.ElementAt(0).Value();
                
                for (int i = 1; i < innerExpressions.Count; i++)
                {
                    
                }
                
            }
            return decimal.Parse(_ex);
        }

        public decimal JoinWith(Expression exp)
        {
            decimal toReturn = 0;
                switch (this._operator1)
                {
                    case "+":
                        toReturn += exp.Value();
                        break;
                    case "-":
                        toReturn -= exp.Value();
                        break;
                    case "*":
                        toReturn *= exp.Value();
                        break;
                    case "/":
                        toReturn /= exp.Value();
                        break;
                }

            return toReturn;
        
        }

    }
}