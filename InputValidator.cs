namespace Credit_Calculator
{
    internal class InputValidator
    {
        public bool IsValidLoanAmountInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            decimal result;
            return decimal.TryParse(input, out result) || char.IsControl(input, 0);
        }

        public bool IsValidInterestRateInput(string input)
        {
            if (string.IsNullOrEmpty(input)) 
            {
                return false;
            }
            return input.All(c => char.IsDigit(c) || c == ',' || char.IsControl(c));
        }
    }
}
