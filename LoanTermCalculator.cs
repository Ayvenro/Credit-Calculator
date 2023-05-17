namespace Credit_Calculator
{
    internal class LoanTermCalculator
    {
        public decimal GetLoanTerm(string selectedItem)
        {
            decimal loanTerm = 0;
            switch (selectedItem)
            {
                case string s when s.Contains("месяц"):
                    decimal months = decimal.Parse(s.Split()[0]);
                    loanTerm = months / 12;
                    break;
                case string s when s.Contains("год") || s.Contains("лет"):
                    decimal years = decimal.Parse(s.Split()[0]);
                    loanTerm = years;
                    break;
            }
            return loanTerm;
        }
    }
}
