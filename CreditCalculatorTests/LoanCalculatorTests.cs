namespace Credit_Calculator_Tests
{
    public class LoanCalculatorTests
    {
        private LoanCalculator _loanCalculator;

        [SetUp]
        public void SetUp()
        {
            _loanCalculator = new LoanCalculator();
        }

        [Test]
        public void CalculateMonthlyPayment_ReturnsCorrectValue()
        {
            decimal loanAmount = 100000;
            decimal loanTerm = 1;
            decimal interestRate = 10;
            decimal monthlyInterestRate = interestRate / 100 / 12;
            decimal expectedResult = 8792;
            decimal actualResult = _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTerm, monthlyInterestRate);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateTotalInterest_ReturnsCorrectValue()
        {
            decimal loanAmount = 100000;
            decimal loanTerm = 1;
            decimal monthlyPayment = 8792;
            decimal expectedResult = 5504;
            decimal actualResult = _loanCalculator.CalculateTotalInterest(loanAmount, loanTerm, monthlyPayment);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CalculateTotalInterest_ReturnsInCorrectValue()
        {
            decimal loanAmount = 100000;
            decimal loanTerm = 1;
            decimal monthlyPayment = 8792;
            decimal expectedResult = 5404;
            decimal actualResult = _loanCalculator.CalculateTotalInterest(loanAmount, loanTerm, monthlyPayment);
            Assert.AreNotEqual(expectedResult, actualResult);
        }
    }
}
