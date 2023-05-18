using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credit_Calculator_Tests
{
    public class LoanTermCalculatorTests
    {
        private LoanTermCalculator _loanTermCalculator;

        [SetUp]
        public void SetUp()
        {
            _loanTermCalculator = new LoanTermCalculator();
        }

        [Test]
        public void GetLoanTerm_ReturnCorrectValue_ForMonths()
        {
            string selectedItem = "6 месяцев";
            decimal loanTerm = _loanTermCalculator.GetLoanTerm(selectedItem);
            decimal expectedLoanTerm = 0.5m; // 6 months / 12 months per year
            Assert.That(loanTerm, Is.EqualTo(expectedLoanTerm));
        }

        [Test]
        public void GetLoanTerm_ReturnCorrectValue_ForYears()
        {
            string selectedItem = "2 года";
            decimal loanTerm = _loanTermCalculator.GetLoanTerm(selectedItem);
            decimal expectedLoanTerm = 2; // 6 months / 12 months per year
            Assert.That(loanTerm, Is.EqualTo(expectedLoanTerm));
        }

        [Test]
        public void GetLoanTerm_ReturnCorrectValue_ForYearsWithFloatingPointNumber()
        {
            string selectedItem = "1,5 года";
            decimal loanTerm = _loanTermCalculator.GetLoanTerm(selectedItem);
            decimal expectedLoanTerm = 1.5m; // 6 months / 12 months per year
            Assert.That(loanTerm, Is.EqualTo(expectedLoanTerm));
        }
    }
}
