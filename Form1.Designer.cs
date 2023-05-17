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
            loanTermTextBox = new TextBox();
            loanTermLabel = new Label();
            label1 = new Label();
            montlyPaymentTextBox = new TextBox();
            totalInterestTextBox = new TextBox();
            montlyPaymentLabel = new Label();
            totalInterestLabel = new Label();
            resultButton = new Button();
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
            // loanTermTextBox
            // 
            loanTermTextBox.Location = new Point(12, 70);
            loanTermTextBox.Name = "loanTermTextBox";
            loanTermTextBox.Size = new Size(100, 23);
            loanTermTextBox.TabIndex = 4;
            loanTermTextBox.KeyPress += loanTermTextBox_KeyPress;
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
            montlyPaymentTextBox.Size = new Size(100, 23);
            montlyPaymentTextBox.TabIndex = 7;
            // 
            // totalInterestTextBox
            // 
            totalInterestTextBox.Location = new Point(12, 154);
            totalInterestTextBox.Name = "totalInterestTextBox";
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
            totalInterestLabel.Size = new Size(95, 15);
            totalInterestLabel.TabIndex = 10;
            totalInterestLabel.Text = "Общая выплата";
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
            // CreditCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultButton);
            Controls.Add(totalInterestLabel);
            Controls.Add(montlyPaymentLabel);
            Controls.Add(totalInterestTextBox);
            Controls.Add(montlyPaymentTextBox);
            Controls.Add(label1);
            Controls.Add(loanTermLabel);
            Controls.Add(loanTermTextBox);
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
        private TextBox loanTermTextBox;
        private Label loanTermLabel;
        private Label label1;
        private TextBox montlyPaymentTextBox;
        private TextBox totalInterestTextBox;
        private Label montlyPaymentLabel;
        private Label totalInterestLabel;
        private Button resultButton;
    }
}