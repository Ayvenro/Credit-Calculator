using System.Globalization;

namespace Credit_Calculator
{
    internal class InputValidator
    {
        public bool IsValidLoanAmountInput(string input)
        {
            decimal result;
            return decimal.TryParse(input, out result) || char.IsControl(input, 0);
        }

        public bool IsValidInterestRateInput(string input)
        {
            return input.All(c => char.IsDigit(c) || c == ',' || char.IsControl(c));
        }
    }
}
