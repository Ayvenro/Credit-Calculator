namespace Credit_Calculator
{
    public partial class CreditCalculatorForm : Form
    {
        public CreditCalculatorForm()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double loanAmount = Convert.ToDouble(loanAmountTextBox.Text);
            double interestRate = Convert.ToDouble(interestRateTextBox.Text);
            double loanTerm = Convert.ToDouble(loanTermTextBox.Text);
            double monthlyPayment = 0;
            double monthlyInterestRate = interestRate / 100 / 12;
            monthlyPayment = CalculateMonthlyPayment(loanAmount, loanTerm, monthlyInterestRate);
            montlyPaymentTextBox.Text = monthlyPayment.ToString("C");
        }

        private double CalculateMonthlyPayment(double loanAmount, double loanTerm, double monthlyInterestRate)
        {
            double monthlyPayment;
            double denominator = Math.Pow(1 + monthlyInterestRate, loanTerm * 12) - 1;
            monthlyPayment = (loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTerm * 12)) / denominator;
            return monthlyPayment;
        }

        private void loanAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void interestRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void loanTermTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}