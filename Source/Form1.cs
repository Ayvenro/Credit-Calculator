using System.Globalization;

namespace Credit_Calculator
{
    public partial class CreditCalculatorForm : Form
    {
        private readonly LoanCalculator _loanCalculator;
        private readonly LoanTermCalculator _loanTermCalculator;
        private readonly InputValidator _inputValidator;

        public CreditCalculatorForm()
        {
            InitializeComponent();
            loanTermcomboBox.SelectedIndex = 0;
            _loanCalculator = new LoanCalculator();
            _loanTermCalculator = new LoanTermCalculator();
            _inputValidator = new InputValidator();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            if (_inputValidator.IsValidLoanAmountInput(loanAmountTextBox.Text) && _inputValidator.IsValidInterestRateInput(interestRateTextBox.Text))
            {
                decimal loanAmount = decimal.Parse(loanAmountTextBox.Text);
                decimal interestRate = decimal.Parse(interestRateTextBox.Text);
                decimal loanTerm = _loanTermCalculator.GetLoanTerm(loanTermcomboBox.SelectedItem as string);
                decimal monthlyInterestRate = interestRate / 100 / 12;
                decimal monthlyPayment = _loanCalculator.CalculateMonthlyPayment(loanAmount, loanTerm, monthlyInterestRate);
                decimal totalInterest = _loanCalculator.CalculateTotalInterest(loanAmount, loanTerm, monthlyPayment);
                montlyPaymentTextBox.Text = monthlyPayment.ToString("C");
                totalInterestTextBox.Text = totalInterest.ToString("C");
            }
            else
            {
                MessageBox.Show("¬ведите верные значени€.");
            }
        }
        private void loanAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_inputValidator.IsValidLoanAmountInput(e.KeyChar.ToString());
        }

        private void interestRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !_inputValidator.IsValidInterestRateInput(e.KeyChar.ToString());
        }
    }
}