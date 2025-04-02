using System;
using System.Windows;
using System.Windows.Controls;

namespace prac4
{
    public partial class MainWindow : Window
    {
        private double firstValue = 0;
        private string operation = "";
        private bool operationPerformed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (operationPerformed)
            {
                TextBox.Text = "0";
                operationPerformed = false;
            }

            Button button = (Button)sender;
            if (TextBox.Text == "0")
            {
                TextBox.Text = button.Content.ToString();
            }
            else
            {
                TextBox.Text += button.Content.ToString();
            }
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Content.ToString();
            firstValue = double.Parse(TextBox.Text);
            operationPerformed = true;
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            double secondValue = double.Parse(TextBox.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                    {
                        result = firstValue / secondValue;
                    }
                    else
                    {
                        TextBox.Text = "Ошибка";
                        return;
                    }
                    break;
            }

            TextBox.Text = result.ToString();
            operation = "";
        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "0";
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
                if (TextBox.Text.Length == 0)
                {
                    TextBox.Text = "0";
                }
            }
        }
    }
}