using System.Globalization;

namespace Credit_Calculator
{
    public partial class CreditCalculatorForm : Form
    {
        public CreditCalculatorForm()
        {
            InitializeComponent();
            loanTermcomboBox.SelectedIndex = 0;
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double loanAmount = Convert.ToDouble(loanAmountTextBox.Text);
            double interestRate = Convert.ToDouble(interestRateTextBox.Text);
            double loanTerm = GetLoanTerm();
            double monthlyInterestRate = interestRate / 100 / 12;
            double monthlyPayment = CalculateMonthlyPayment(loanAmount, loanTerm, monthlyInterestRate);
            double totalInterest = CalculateTotalInterest(loanAmount, loanTerm, monthlyPayment);
            montlyPaymentTextBox.Text = monthlyPayment.ToString("C");
            totalInterestTextBox.Text = totalInterest.ToString("C");
        }

        public double CalculateMonthlyPayment(double loanAmount, double loanTerm, double monthlyInterestRate)
        {
            double monthlyPayment;
            double denominator = Math.Pow(1 + monthlyInterestRate, loanTerm * 12) - 1;
            monthlyPayment = (loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, loanTerm * 12)) / denominator;
            return Math.Round(monthlyPayment);
        }

        public double CalculateTotalInterest(double loanAmount, double loanTerm, double monthlyPayment)
        {
            double totalInterest;
            totalInterest = (monthlyPayment * loanTerm * 12) - loanAmount;
            return Math.Round(totalInterest);
        }

        private double GetLoanTerm()
        {
            double loanTerm = 0;
            string? selectedItem = loanTermcomboBox.SelectedItem as string;
            if (selectedItem.Contains("мес€ц"))
            {
                double months = double.Parse(selectedItem.Split()[0]);
                loanTerm = months / 12;
            }
            else if (selectedItem.Contains("год") || selectedItem.Contains("лет"))
            {
                double years = double.Parse(selectedItem.Split()[0]);
                loanTerm = years;
            }
            return loanTerm;
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}