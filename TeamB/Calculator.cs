namespace TeamB
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            if (problem == string.Empty)
                return 0;

            return int.Parse(problem);
        }
    }
}