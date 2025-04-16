using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Text;

namespace prac4
{
    public partial class MainWindow : Window
    {
        private bool isNewCalculation = true;
        private bool isResultDisplayed = false;

        public MainWindow()
        {
            InitializeComponent();
            TextBox.Text = "0";
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (isNewCalculation || isResultDisplayed)
            {
                TextBox.Text = "";
                isNewCalculation = false;
                isResultDisplayed = false;
            }

            Button button = (Button)sender;
            string number = button.Content.ToString();

            if (TextBox.Text == "0" && number != "0")
                TextBox.Text = number;
            else if (TextBox.Text != "0")
                TextBox.Text += number;
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Content.ToString();

            if (isResultDisplayed)
                isResultDisplayed = false;

            if (isNewCalculation && operation != "-")
            {
                TextBox.Text = "0";
                isNewCalculation = false;
                return;
            }

            if (TextBox.Text.Length > 0 && IsOperator(TextBox.Text[TextBox.Text.Length - 1]))
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1) + operation;
            }
            else
            {
                TextBox.Text += operation;
            }
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        }

        private void FunctionButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string function = button.Content.ToString();

            try
            {
                double result = 0;
                string expression = TextBox.Text;

                switch (function)
                {
                    case "sin":
                        result = Math.Sin(ConvertToRadians(GetLastNumber(expression)));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "COS":
                        result = Math.Cos(ConvertToRadians(GetLastNumber(expression)));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "tg":
                        result = Math.Tan(ConvertToRadians(GetLastNumber(expression)));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "x²":
                        result = Math.Pow(GetLastNumber(expression), 2);
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "1/x":
                        double num = GetLastNumber(expression);
                        if (num == 0) throw new DivideByZeroException();
                        result = 1 / num;
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "|x|":
                        result = Math.Abs(GetLastNumber(expression));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "2√x":
                        num = GetLastNumber(expression);
                        if (num < 0) throw new ArgumentException();
                        result = Math.Sqrt(num);
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "n!":
                        result = Factorial(GetLastNumber(expression));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "10^x":
                        result = Math.Pow(10, GetLastNumber(expression));
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "log":
                        num = GetLastNumber(expression);
                        if (num <= 0) throw new ArgumentException();
                        result = Math.Log10(num);
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                    case "ln":
                        num = GetLastNumber(expression);
                        if (num <= 0) throw new ArgumentException();
                        result = Math.Log(num);
                        ReplaceLastNumber(expression, result.ToString());
                        break;
                }

                isResultDisplayed = true;
            }
            catch (Exception ex)
            {
                TextBox.Text = "Ошибка";
                isNewCalculation = true;
            }
        }

        private double GetLastNumber(string expression)
        {
            int i = expression.Length - 1;
            while (i >= 0 && (char.IsDigit(expression[i]) || expression[i] == '.' || expression[i] == ',' || expression[i] == '-'))
            {
                i--;
            }

            string lastNumber = expression.Substring(i + 1).Replace(',', '.');
            return double.Parse(lastNumber);
        }

        private void ReplaceLastNumber(string expression, string newNumber)
        {
            int i = expression.Length - 1;
            while (i >= 0 && (char.IsDigit(expression[i]) || expression[i] == '.' || expression[i] == ',' || expression[i] == '-'))
            {
                i--;
            }

            TextBox.Text = expression.Substring(0, i + 1) + newNumber.Replace('.', ',');
        }

        private double ConvertToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private double Factorial(double n)
        {
            if (n < 0 || n != Math.Floor(n))
                throw new ArgumentException();

            double result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        private void ConstantButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string constant = button.Content.ToString();

            if (isNewCalculation || isResultDisplayed)
            {
                TextBox.Text = "";
                isNewCalculation = false;
                isResultDisplayed = false;
            }

            switch (constant)
            {
                case "π":
                    TextBox.Text += Math.PI.ToString().Replace('.', ',');
                    break;
                case "e":
                    TextBox.Text += Math.E.ToString().Replace('.', ',');
                    break;
            }
        }

        private void BracketButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string bracket = button.Content.ToString();

            if (isNewCalculation || isResultDisplayed)
            {
                TextBox.Text = "";
                isNewCalculation = false;
                isResultDisplayed = false;
            }

            TextBox.Text += bracket;
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (isNewCalculation || isResultDisplayed)
            {
                TextBox.Text = "0";
                isNewCalculation = false;
                isResultDisplayed = false;
            }

            string currentText = TextBox.Text;
            int lastOperatorIndex = Math.Max(
                currentText.LastIndexOf('+'),
                Math.Max(
                    currentText.LastIndexOf('-'),
                    Math.Max(
                        currentText.LastIndexOf('*'),
                        Math.Max(
                            currentText.LastIndexOf('/'),
                            currentText.LastIndexOf('^')
                        )
                    )
                )
            );

            string lastNumber = lastOperatorIndex == -1 ?
                currentText :
                currentText.Substring(lastOperatorIndex + 1);

            if (!lastNumber.Contains(","))
            {
                TextBox.Text += ",";
            }
        }

        private void SignButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = TextBox.Text;
            if (expression == "0") return;

            int i = expression.Length - 1;
            while (i >= 0 && (char.IsDigit(expression[i]) || expression[i] == '.' || expression[i] == ','))
            {
                i--;
            }

            if (i >= 0 && expression[i] == '-')
            {
                TextBox.Text = expression.Remove(i, 1);
            }
            else
            {
                TextBox.Text = expression.Insert(i + 1, "-");
            }
        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "0";
            isNewCalculation = true;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0 && !isNewCalculation)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1);
                if (TextBox.Text.Length == 0)
                {
                    TextBox.Text = "0";
                    isNewCalculation = true;
                }
            }
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = TextBox.Text.Replace(',', '.');

                expression = System.Text.RegularExpressions.Regex.Replace(
                    expression,
                    @"(\d+)!",
                    m => Factorial(double.Parse(m.Groups[1].Value)).ToString()
                );

                expression = expression.Replace("π", Math.PI.ToString());
                expression = expression.Replace("e", Math.E.ToString());

                expression = expression.Replace("^", "**");

                var result = new DataTable().Compute(expression, null);
                TextBox.Text = result.ToString().Replace('.', ',');
                isResultDisplayed = true;
                isNewCalculation = false;
            }
            catch (Exception ex)
            {
                TextBox.Text = "Ошибка";
                isNewCalculation = true;
            }
        }
    }
}