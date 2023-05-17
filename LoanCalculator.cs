namespace Credit_Calculator
{
    internal class LoanCalculator
    {
        public decimal CalculateMonthlyPayment(decimal loanAmount, decimal loanTerm, decimal monthlyInterestRate)
        {
            decimal monthlyPayment;
            decimal denominator = (decimal)Math.Pow(1 + (double)monthlyInterestRate, (double)loanTerm * 12) - 1;
            monthlyPayment = (loanAmount * monthlyInterestRate * (decimal)Math.Pow(1 + (double)monthlyInterestRate, (double)loanTerm * 12)) / denominator;
            return Math.Round(monthlyPayment);
        }

        public decimal CalculateTotalInterest(decimal loanAmount, decimal loanTerm, decimal monthlyPayment)
        {
            decimal totalInterest;
            totalInterest = (monthlyPayment * loanTerm * 12) - loanAmount;
            return Math.Round(totalInterest);
        }
    }
}
