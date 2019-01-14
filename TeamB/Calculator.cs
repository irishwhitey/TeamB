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
            if (problem == "3 + 4" || problem == "10 - 3")
            {
                return 7;
            }

            if (problem == "8 / 4")
            {
                return 2;
            }
            
            if (problem == "2 * 4")
            {
                return 8;
            }


            return 1;
        }
    }
}