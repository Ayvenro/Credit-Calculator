namespace Credit_Calculator_Tests
{
    [TestFixture]
    public class InputValidatorTests
    {
        private InputValidator _inputValidator;

        [SetUp]
        public void SetUp()
        {
            _inputValidator = new InputValidator();
        }

        [Test]
        public void IsValidLoanAmountInput_InputIsValid_ReturnsTrue()
        {
            string input = "1000";
            bool result = _inputValidator.IsValidLoanAmountInput(input);
            Assert.IsTrue(result);
        }

        [Test]
        public void IsValidLoanAmountInput_InputIsNull_ReturnsFalse()
        {
            string? input = null;
            bool result = _inputValidator.IsValidLoanAmountInput(input);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsValidLoanAmountInput_InputIsEmpty_ReturnsFalse()
        {
            string input = string.Empty;
            bool result = _inputValidator.IsValidLoanAmountInput(input);
            Assert.IsFalse(result);
        }
    }
}
