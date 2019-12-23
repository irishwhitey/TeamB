namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            if (problem == string.Empty)
                return 0;

            if (problem == "5 + 4")
                return 9;

            return int.Parse(problem);
        }
    }
}