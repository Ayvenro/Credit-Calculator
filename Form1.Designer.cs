namespace Credit_Calculator
{
    partial class CreditCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loanAmountTextBox = new TextBox();
            loanAmountLabel = new Label();
            interestRateTextBox = new TextBox();
            interestRateLabel = new Label();
            loanTermLabel = new Label();
            label1 = new Label();
            montlyPaymentTextBox = new TextBox();
            totalInterestTextBox = new TextBox();
            montlyPaymentLabel = new Label();
            totalInterestLabel = new Label();
            resultButton = new Button();
            loanTermcomboBox = new ComboBox();
            SuspendLayout();
            // 
            // loanAmountTextBox
            // 
            loanAmountTextBox.Location = new Point(12, 12);
            loanAmountTextBox.Name = "loanAmountTextBox";
            loanAmountTextBox.Size = new Size(100, 23);
            loanAmountTextBox.TabIndex = 0;
            loanAmountTextBox.KeyPress += loanAmountTextBox_KeyPress;
            // 
            // loanAmountLabel
            // 
            loanAmountLabel.AutoSize = true;
            loanAmountLabel.Location = new Point(118, 15);
            loanAmountLabel.Name = "loanAmountLabel";
            loanAmountLabel.Size = new Size(107, 15);
            loanAmountLabel.TabIndex = 1;
            loanAmountLabel.Text = "Величина кредита";
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(12, 41);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(100, 23);
            interestRateTextBox.TabIndex = 2;
            interestRateTextBox.KeyPress += interestRateTextBox_KeyPress;
            // 
            // interestRateLabel
            // 
            interestRateLabel.AutoSize = true;
            interestRateLabel.Location = new Point(118, 44);
            interestRateLabel.Name = "interestRateLabel";
            interestRateLabel.Size = new Size(112, 15);
            interestRateLabel.TabIndex = 3;
            interestRateLabel.Text = "Процентная ставка";
            // 
            // loanTermLabel
            // 
            loanTermLabel.AutoSize = true;
            loanTermLabel.Location = new Point(118, 73);
            loanTermLabel.Name = "loanTermLabel";
            loanTermLabel.Size = new Size(81, 15);
            loanTermLabel.TabIndex = 5;
            loanTermLabel.Text = "Срок кредита";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Результат:";
            // 
            // montlyPaymentTextBox
            // 
            montlyPaymentTextBox.Location = new Point(12, 125);
            montlyPaymentTextBox.Name = "montlyPaymentTextBox";
            montlyPaymentTextBox.ReadOnly = true;
            montlyPaymentTextBox.Size = new Size(100, 23);
            montlyPaymentTextBox.TabIndex = 7;
            // 
            // totalInterestTextBox
            // 
            totalInterestTextBox.Location = new Point(12, 154);
            totalInterestTextBox.Name = "totalInterestTextBox";
            totalInterestTextBox.ReadOnly = true;
            totalInterestTextBox.Size = new Size(100, 23);
            totalInterestTextBox.TabIndex = 8;
            // 
            // montlyPaymentLabel
            // 
            montlyPaymentLabel.AutoSize = true;
            montlyPaymentLabel.Location = new Point(118, 128);
            montlyPaymentLabel.Name = "montlyPaymentLabel";
            montlyPaymentLabel.Size = new Size(128, 15);
            montlyPaymentLabel.TabIndex = 9;
            montlyPaymentLabel.Text = "Ежемесячный платеж";
            // 
            // totalInterestLabel
            // 
            totalInterestLabel.AutoSize = true;
            totalInterestLabel.Location = new Point(118, 157);
            totalInterestLabel.Name = "totalInterestLabel";
            totalInterestLabel.Size = new Size(106, 15);
            totalInterestLabel.TabIndex = 10;
            totalInterestLabel.Text = "Общая переплата";
            // 
            // resultButton
            // 
            resultButton.Location = new Point(12, 183);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(75, 23);
            resultButton.TabIndex = 11;
            resultButton.Text = "Расчитать";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // loanTermcomboBox
            // 
            loanTermcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            loanTermcomboBox.FormattingEnabled = true;
            loanTermcomboBox.Items.AddRange(new object[] { "1 месяц", "3 месяца", "6 месяцев", "9 месяцев", "1 год", "1,5 года", "2 года", "3 года", "4 года", "5 лет", "6 лет", "7 лет", "10 лет", "15 лет", "20 лет", "25 лет", "30 лет" });
            loanTermcomboBox.Location = new Point(12, 70);
            loanTermcomboBox.Name = "loanTermcomboBox";
            loanTermcomboBox.Size = new Size(100, 23);
            loanTermcomboBox.TabIndex = 12;
            // 
            // CreditCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 222);
            Controls.Add(loanTermcomboBox);
            Controls.Add(resultButton);
            Controls.Add(totalInterestLabel);
            Controls.Add(montlyPaymentLabel);
            Controls.Add(totalInterestTextBox);
            Controls.Add(montlyPaymentTextBox);
            Controls.Add(label1);
            Controls.Add(loanTermLabel);
            Controls.Add(interestRateLabel);
            Controls.Add(interestRateTextBox);
            Controls.Add(loanAmountLabel);
            Controls.Add(loanAmountTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CreditCalculatorForm";
            Text = "Кредитный калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loanAmountTextBox;
        private Label loanAmountLabel;
        private TextBox interestRateTextBox;
        private Label interestRateLabel;
        private Label loanTermLabel;
        private Label label1;
        private TextBox montlyPaymentTextBox;
        private TextBox totalInterestTextBox;
        private Label montlyPaymentLabel;
        private Label totalInterestLabel;
        private Button resultButton;
        private ComboBox loanTermcomboBox;
    }
}