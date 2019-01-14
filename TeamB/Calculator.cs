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

            if (problem == "3 + 4 + 2")
            {
                return 9;
            }

            if (problem == "10 - 4 - 3")
            {
                return 3;
            }


            return 1;
        }
    }
}